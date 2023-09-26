using MOSROManager.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    class ConfigController
    {

        string configPath = $"{Directory.GetCurrentDirectory()}\\required\\config.json";

        /// <summary>
        /// SaveConfig
        /// </summary>
        public void SaveConfig()
        {
            try
            {
                if (Common.Config != null)
                {
                    string JSONConfig = JsonConvert.SerializeObject(Common.Config);

                    File.Delete(configPath);

                    using (var writer = new StreamWriter(configPath, true))
                    {
                        writer.WriteLine(JSONConfig.ToString());
                        writer.Close();
                    }
                    LoadConfig();
                }
            }
            catch
            {
                MessageBox.Show("Error while saving config.json");
            }
        }

        /// <summary>
        /// Update Config
        /// </summary>
        /// <param name="host"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="accountDB"></param>
        /// <param name="shardDB"></param>
        /// <param name="logDB"></param>
        public void UpdateDBConfig(string host, string user, string password, string accountDB, string shardDB, string logDB)
        {
            try
            {
                Config config = new Config()
                {
                    Host = host,
                    User = user,
                    Password = password,
                    SR_Account = accountDB,
                    SR_Shard = shardDB,
                    SR_ShardLog = logDB
                };
                Common.Config = config;
            } 
            catch
            {
                MessageBox.Show("Error while Updating config.json");
            }
        }

        /// <summary>
        /// Loads Config
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                if (!File.Exists(configPath))
                {
                    CreateConfig();
                }
                else
                {
                    try
                    {
                        string ConfigFile = File.ReadAllText(configPath);
                        Common.Config = JsonConvert.DeserializeObject<Config>(ConfigFile);
                    }
                    catch
                    {
                        CreateConfig();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error while loading config.json");
            }
        }

        /// <summary>
        /// Creates a new config
        /// </summary>
        public void CreateConfig()
        {
            try
            {
                Config config = new Config()
                {
                    Host = "127.0.0.1",
                    User = "sa",
                    Password = "123456789",
                    SR_Account = "SRO_VT_ACCOUNT",
                    SR_Shard = "SRO_VT_SHARD",
                    SR_ShardLog = "SRO_VT_SHARDLOG"
                };
                string JSONConfig = JsonConvert.SerializeObject(config);

                File.Delete(configPath);

                using (var writer = new StreamWriter(configPath, true))
                {
                    writer.WriteLine(JSONConfig.ToString());
                    writer.Close();
                }
                LoadConfig();
            }
            catch
            {
                MessageBox.Show("Error while creating config.json");
            }
        }
    }
}
