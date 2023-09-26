using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MOSROManager
{

    class SQL
    {
        private static string sConnectionString;
        private static SqlConnection sConnection;

        // Constructor
        public SQL(string Host, string User, string Password, string ACC_Database)
        {
            sConnectionString = $"Server={Host};Database={ACC_Database};User ID={User};Password={Password};MultipleActiveResultSets=True;";
        }

        /// <summary>
        /// Check whether sql is connected or not
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            if (sConnection == null)
                return false;

            if (sConnection.State == ConnectionState.Connecting ||
                sConnection.State == ConnectionState.Executing ||
                sConnection.State == ConnectionState.Fetching ||
                sConnection.State == ConnectionState.Open)
                return true;

            return false;
        }

        /// <summary>
        /// establish the sql connection
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Connect()
        {
            if (IsConnected())
            {
                Common.Dashboard.writeLog("SQL connectin is already opened!");
                return true;
            }

            // open new connection
            sConnection = new SqlConnection(sConnectionString);
            try
            {
                await sConnection.OpenAsync();
            }
            catch (SqlException error)
            {
                Common.Dashboard.writeLog("SQL connection failed due to: " + error.Message, 0);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executes query, returns amount of updated rows.
        /// </summary>
        /// <param name="str">Query string (can be formatted).</param>
        /// <param name="args">Arguments as in any other formatted string.</param>
        /// <returns>Updated row count. Can be -1 if no rows were updated (fetch operation).</returns>
        public async Task<int?> ExecuteNonQuery(string str, params object[] args)
        {
            var cmd = QueryCommand(str, args);
            if (cmd == null)
            {
                Common.Dashboard.writeLog($"SQL connection failed due to: {StringExtensions.DumpFormat(str, args)}", 0);
                return null;
            }

            return await ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Executes query for given SqlCommand, returns amount of updated rows.
        /// </summary>
        /// <param name="cmd">The sql command.</param>
        /// <returns>null on command failure, -1 if no rows updated, otherwise updated row count.</returns>
        public async Task<int?> ExecuteNonQuery(SqlCommand cmd)
        {
            Task<int?> result = null;
            try
            {
                using (cmd)
                    result = Task.FromResult<int?>(await cmd.ExecuteNonQueryAsync());
            }
            catch (SqlException error)
            {
                // i will get this catch if connection dropped, right? yeah, because sql command will fail :) actually
                // i think that u will get exception at CreateSqlCommand
                Common.Dashboard.writeLog($"Could not execute SQL command (format: {cmd.CommandText}) Error: {error.Message}", 0);
                return null;
            }

            return result.Result;
        }



        /// <summary>
        /// Creates sql command from classic TSQL query / args.
        /// </summary>
        /// <param name="str">The query string (format).</param>
        /// <param name="args"></param>
        /// <returns></returns>
        private SqlCommand QueryCommand(string str, params object[] args)
        {
            SqlCommand result = null;
            str = StringExtensions.TryFormat(str, args);
            if (str == null)
            {
                Common.Dashboard.writeLog($"Failed to format query str {str}.", 0);
                return result; //null
            }

            result = new SqlCommand(str, sConnection);
            return result;
        }

        /// <summary>
        /// Gets data from database (from classic TSQL query).
        /// </summary>
        /// <param name="str">The query string (format).</param>
        /// <param name="args">The string format arguments.</param>
        /// <returns>null on failure, Task SqlDataReader on success.</returns>
        public async Task<SqlDataReader> GetReaderResult(string str, params object[] args)
        {
            var cmd = QueryCommand(str, args);
            if (cmd == null)
            {
                Common.Dashboard.writeLog($"SQL query failed: {StringExtensions.DumpFormat(str, args)}", 0);
                return null;
            }
            return await GetReaderResult(cmd);
        }

        /// <summary>
        /// Gets data from database (using user-supplied SqlCommand).
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <returns>null on failure, Task SqlDataReader on success.</returns>
        public async Task<SqlDataReader> GetReaderResult(SqlCommand cmd)
        {
            Task<SqlDataReader> result = null;
            try
            {
                using (cmd)
                    result = Task.FromResult(await cmd.ExecuteReaderAsync());
            }
            catch (SqlException error)
            {
                Common.Dashboard.writeLog("SQL query failed due to: " + error.Message, 0);
                return null; 
            }
            return result.Result;
        }

        public async Task<T> Read<T>(string query)
        {
            try
            {
                if (sConnection != null)
                    using (var command = new SqlCommand(query, sConnection))
                        return (T)(object)await command.ExecuteReaderAsync();
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog($"SQL read error: {error.Message}", 0);
                return default(T);
            }
            return default(T);
        }

        public async Task<int> RowCount(string query)
        {
            var table = new DataTable();
            table.Load(await Read<IDataReader>(query));
            return table.Rows.Count;
        }

        public Task<T> QueryFetchCell<T>(string sQuery, string Column)//params SqlParameter[] parameters
        {
            return Task.Run(() =>
            {
                //string sData = string.Empty;
                try
                {
                    using (SqlCommand command = new SqlCommand(sQuery, sConnection))
                    {
                        SqlDataReader reader = command.ExecuteReader();//reader.FieldCount
                        reader.Read();
                        if (reader.IsDBNull(0))
                            return default;
                        else
                            return (T)reader[Column];
                    }
                }
                catch (Exception error)
                {
                    Common.Dashboard.writeLog("SQL Error "+ error, 0);
                }
                return default;
            });
        }

        public Task<int> ExecuteAsync(string sQuery, params SqlParameter[] parameters)
        {
            return Task.Run(() =>
            {
                try
                {
                    using (var newCommand = new SqlCommand(sQuery, sConnection))
                    {
                        newCommand.CommandType = CommandType.Text;
                        if (parameters != null) newCommand.Parameters.AddRange(parameters);
                        return newCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception error)
                {
                     Common.Dashboard.writeLog("Query Error: " + error.Message, 0);
                }
                return 0;
            });
        }

        public Task<DataTable> GetDataSet(string sQuery)
        {
            return Task.Run(async () =>
            {
                using (SqlCommand command = new SqlCommand(sQuery, sConnection))
                using (SqlDataReader read = await command.ExecuteReaderAsync())
                {
                    DataTable myDataSet = new DataTable();
                    try
                    {
                        myDataSet.Load(read);
                    }
                    catch (Exception error)
                    {
                        Common.Dashboard.writeLog("Query Error: " + error.Message, 0);
                    }
                    return myDataSet;
                }
                
            });
        }


        public async Task<object> ExecuteProcedure(string str, params object[] args)
        {
            var cmd = QueryCommand(str);
            if (cmd == null)
            {
                Common.Dashboard.writeLog($"SQL connection failed due to: {StringExtensions.DumpFormat(str, args)}", 0);
                return null;
            }
            //TESTME men
            if (args.Length > 0 && args.Length % 2 == 0)
            {
                for (int argindex = 0; argindex < args.Length; argindex += 2)
                {
                    cmd.Parameters.AddWithValue(args[argindex].ToString(), args[argindex + 1]);
                }
            }
            else
            {
                Common.Dashboard.writeLog($"Could not execute procedure. Incorrect args.", 0);
                return -1;
            }
            return await ExecuteProcedure(cmd);
        }

        public async Task<object> ExecuteProcedure(SqlCommand cmd)
        {
            Task<object> result = null;
            try
            {
                using (cmd)
                    result = Task.FromResult<object>(await cmd.ExecuteNonQueryAsync());
            }
            catch { return null; }
            return result;
        }

        public void Disconnect()
        {
            if (!IsConnected())
                return;

            try
            {
                sConnection.Close();
            } catch (Exception e)
            {
                Common.Dashboard.writeLog("Failed to close the sql connection due to: " + e.Message, 0);
            }
        }
       
    }
}
