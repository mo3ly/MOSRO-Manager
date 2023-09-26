using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pManagement : UserControl
    {
        public pManagement()
        {
            InitializeComponent();
        }
        
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            /*
            string data = await Common.SqlConnection.QueryFetchCell<string>($"SELECT Charname16 FROM {Common.Config.SR_Shard}.._Char", "CharName16");
            byte data2 = await Common.SqlConnection.QueryFetchCell<byte>($"SELECT CurLevel FROM {Common.Config.SR_Shard}.._Char Where CharName16 = 'Exoria'", "CurLevel");
            Common.Dashboard.writeLog($"QueryFetchCell Result {data} \t {data2}", 1);
            try
            {
                object[] QueryParams = { "Exoria" };
                SqlDataReader QueryReader = await Common.SqlConnection.GetReaderResult("SELECT Charname16 FROM SRO_VT_SHARD.._Char Where CharName16 = '{0}'", QueryParams);//"Exoria" insted of objrct[]
                await QueryReader.ReadAsync();
                Common.Dashboard.writeLog("Query Result " + QueryReader[0], 1);

                SqlDataReader SqlDataReader = await Common.SqlConnection.GetReaderResult("SELECT * FROM SRO_VT_SHARD.._Char");
                while (await SqlDataReader.ReadAsync())
                {
                    Console.WriteLine($"{ SqlDataReader["CharName16"]} \t  { SqlDataReader["CurLevel"]}");
                }
            }
            catch { }
            */
        }
    }
}
