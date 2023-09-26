using MOSRO_Manager.Logic.Libs.SRClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SilkroadSecurity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSyntaxHighlighter;

namespace MOSROManager
{
    public partial class PacketSniffer : Form
    {
        /**
         * TODO:
         *      Add Client and save it load it when the page loads
         *      Add packet injection page
         *      Add file log
         *      Complete the adjust packet section
         *      Complete packet details page represent the packets correctly with its type -> Check the pxBook (xBot Owner) -> add his credits and phAnalyzer -> add his credits
         *      Allow Cancelling the injection process
         *      Use edx loader dll to read all the client side packet which is not avaliable for the proxy
         */

        #region Members
        FolderBrowserDialog newClientDialog = new FolderBrowserDialog();
        SRClientHelper SRClientHelper = null;
        string clientPath = null;
        string[] ParamsKeywords = new string[] { "int8", "int16", "int32", "int64", "uint8", "uint16", "uint32", "uint64", "float", "bool", "ascii", "unicode" };
        string[] MainKeywords = new string[] { "Packet", "Param", "Delay", "Send", "Hexbytes" };
        Dictionary<int, Packet> PacketsDictionary = new Dictionary<int, Packet>();
        Dictionary<string, string> Scripts = new Dictionary<string, string>();
        Dictionary<string, string> Clients = new Dictionary<string, string>();
        bool isShowServerPackets = true;
        bool isShowClientPackets = true;
        bool isAllowPacketLogging = true;
        bool isShowOnlyOpcode = false;
        bool isHideOpcode = true;
        bool isActiceGridScroll = true;
        #endregion

        #region Constructor
        public PacketSniffer()
        {
            InitializeComponent();
        }
        #endregion

        #region Header
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowAPI.ReleaseCapture();
                WindowAPI.SendMessage(Handle, WindowAPI.WM_NCLBUTTONDOWN, WindowAPI.HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Load
        private void PacketSniffer_Load(object sender, EventArgs e)
        {
            PacketsGrid.ColumnCount = 8;
            PacketsGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            PacketsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PacketsGrid.Columns[0].Name = "Packet";
            PacketsGrid.Columns[1].Name = "Name";
            PacketsGrid.Columns[2].Name = "Module";
            PacketsGrid.Columns[3].Name = "Sender";
            PacketsGrid.Columns[4].Name = "Encrypt";
            PacketsGrid.Columns[5].Name = "Massive";
            PacketsGrid.Columns[6].Name = "Size";
            PacketsGrid.Columns[7].Name = "Time";

            // fix some grid columns width
            PacketsGrid.Columns[6].Width -= 5;
            PacketsGrid.Columns[7].Width += 5;

            // set syntax
            var syntaxHighlighter = new SyntaxHighlighter(tPacketScript);
            // singlie-line comments
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"//.*?$", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.Green, false, true));
            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"--.*?$", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.Green, false, true));
            // double quote strings
            syntaxHighlighter.AddPattern(new PatternDefinition(@"\""([^""]|\""\"")+\"""), new SyntaxStyle(Color.DarkSeaGreen));
            // Params
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition(ParamsKeywords), new SyntaxStyle(Color.DarkSeaGreen));//DarkSeaGreen
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition(new string[] { "server", "client", "encrypted", "massive" }), new SyntaxStyle(Color.DarkSeaGreen));
            // numbers
            //syntaxHighlighter.AddPattern(new PatternDefinition(@"\d+\.\d+|\d+"), new SyntaxStyle(Color.DarkSeaGreen));
            // keywords2
            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition(MainKeywords), new SyntaxStyle(Color.DarkKhaki, true, false));//DarkGoldenrod//Color.Firebrick
            // brackets
            syntaxHighlighter.AddPattern(new PatternDefinition("(", ")"), new SyntaxStyle(Color.WhiteSmoke, true, false));

            syntaxHighlighter.ReHighlight();

            loadScripts();
            loadClients();
        }
        #endregion

        #region Server & Connection Settigns
        private void bAddNewServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (newClientDialog.ShowDialog() == DialogResult.OK)
                {
                    clientPath = newClientDialog.SelectedPath;
                    string clientDir = clientPath.Split(Path.DirectorySeparatorChar).Last();
                    clientSetup();

                    string filePath = Directory.GetCurrentDirectory() + "/Required/clients.json";
                    var fileData = File.ReadAllText(filePath);
                    var JsonData = JsonConvert.DeserializeObject<dynamic>(fileData);
                    JsonData.Add(new JProperty(clientDir, clientPath));
                    JsonData = JsonConvert.SerializeObject(JsonData);
                    File.WriteAllText(filePath, JsonData);
                    loadClients();
                    comboServersList.Text = clientDir;
                }
                else
                {
                    Common.Dashboard.writeLog("You didn't select a client folder.");
                }
            } catch
            {

            }
        }

        private void clientSetup()
        {
            try
            {
                tServerPath.Text = clientPath;
                SRClientHelper = new SRClientHelper(clientPath, tClientBlowfish.Text);
                tServerIP.Text = SRClientHelper.GetMediaIP();
                tServerPort.Text = SRClientHelper.GetMediaPort().ToString();
                StartClientButton.Enabled = true;
            } catch { Common.Dashboard.writeLog("An error occurred while loading client data."); }
        }

        private void comboServersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clientPath = Clients[comboServersList.SelectedItem.ToString()];
                clientSetup();
            }
            catch { }
        }

        private void loadClients()
        {
            try
            {
                string Data = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Required/clients.json"));
                dynamic Json = JsonConvert.DeserializeObject<dynamic>(Data);
                foreach (var parent in Json)
                {
                    if (!Clients.ContainsKey(parent.Name))
                    {
                        Clients.Add((string)parent.Name, (string)parent.Value);
                        comboServersList.Items.Add((string)parent.Name);
                    }
                }
                lAvaliableServers.Text = "Avaliable servers: "+ Clients.Count +" server(s)";
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading clients: " + error.Message, 0);
            }
        }

        private void StartClientButton_Click(object sender, EventArgs e)
        {
            Common.SRClient = new SRClient(clientPath, tRedirectIP.Text, tServerIP.Text,  ushort.Parse(tServerPort.Text));
            Common.SRClient.StartClient();

        }
        #endregion

        #region Packet Grid
        public void AddPacket(Packet packet, string module, string direction)
        {
            try
            {
                // disable log
                if (!isAllowPacketLogging)
                    return;

                string opcode = packet.Opcode.ToString("X");

                // show only
                if (isShowOnlyOpcode && !OpcodesList.Contains(opcode))
                    return;

                // hide opcode 
                if (isHideOpcode && OpcodesList.Contains(opcode))
                    return;


                if (PacketsGrid.InvokeRequired)
                {
                    PacketsGrid.Invoke(new MethodInvoker(delegate
                    {
                        AddPacket(packet, module, direction);

                    }));

                }
                else
                {
                    bool append;
                    if (direction == "Client")
                        append = isShowClientPackets ? true : false;
                    else
                        append = isShowServerPackets ? true : false;

                    if (append)
                    {
                        int index = PacketsGrid.Rows.Add(
                                opcode,
                                "Unkown",
                                module.Replace("Server", ""),
                                direction,
                                packet.Encrypted ? "Encrypted" : "-",
                                packet.Massive ? "Massive" : "-",
                                packet.GetBytes().Length.ToString(),
                                DateTime.Now.ToLongTimeString()
                            );
                        PacketsDictionary.Add(index, packet);
                        lPacketsCount.Text = $"Count: {PacketsGrid.Rows.Count} packet(s)";

                        if (cAllowScrollDown.Checked)
                            PacketsGrid.FirstDisplayedScrollingRowIndex = PacketsGrid.RowCount - 1;
                    }
                }
            }
            catch
            {
                Common.Dashboard.writeLog("Error while adding a new row the packets grid.", 0);
            }
        }

        private void bClearPacketsGrid_Click(object sender, EventArgs e)
        {
            new dialog("Clear packets grid?", $"Are you sure you want to clear the packets grid?").ShowDialog();
            if (Common.dialogResult == DialogResult.Yes)
            {
                PacketsGrid.Rows.Clear();
                PacketsDictionary.Clear();
                lPacketsCount.Text = "Count: 0 packet(s)";
                Common.Dashboard.writeLog("Packets grid has been cleared successfully.");
            }
        }

        private void cAllowScrollDown_CheckedChanged(object sender, EventArgs e)
        {
            isActiceGridScroll = cAllowScrollDown.Checked ? true : false;
        }

        private void bPacketsGridSearch_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (PacketsGrid.Rows.Count > 0)
            {
                PacketsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                PacketsGrid.CurrentCell = null;
                try
                {
                    foreach (DataGridViewRow row in PacketsGrid.Rows)
                    {
                        if(!string.IsNullOrWhiteSpace(tPacketsGridSearch.Text))
                        {
                            string Cell = row.Cells[0].Value.ToString();
                            if (Cell != null && Cell.ToLower().Equals(tPacketsGridSearch.Text.ToLower()))
                            {
                                PacketsGrid.ClearSelection();
                                row.Selected = true;
                                row.Visible = true;
                                counter++;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        } 
                        else
                        {
                            row.Visible = true;
                        }
                    }
                    new alert($"Search result: {counter} rows(s)");
                }
                catch (Exception error)
                {
                    Common.Dashboard.writeLog("Error: " + error.Message, 0);
                }
            }
        }

        private void tPacketsGridSearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (tPacketsGridSearch.Text == "Opcode")
                tPacketsGridSearch.Text = "";
        }
        #endregion

        #region Packet Details
        private void pDeatailsPacketHide_Click(object sender, EventArgs e)
        {
            mDropDetailsPackets.Visible = false;
        }

        private void PacketsGrid_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int index = PacketsGrid.SelectedRows[0].Index;
                if (index > -1)
                {
                    Packet packet = PacketsDictionary[index];
                    lDeatailsPacketOpcode.Text = packet.Opcode.ToString("X4");
                    lDeatailsPacketDirection.Text = PacketsGrid.SelectedRows[0].Cells[3].Value.ToString();
                    tPacketDump.Text = Utility.HexDump(packet.GetBytes());
                    mDropDetailsPackets.Visible = true;
                }

            }
            catch
            {

            }
        }

        private void pPacketDetailsCopy_Click(object sender, EventArgs e)
        {
            try
            {
                int index = PacketsGrid.SelectedRows[0].Index;
                if (index > -1)
                {
                    Packet p = PacketsDictionary[index];
                    Clipboard.SetText(string.Join(" ", p.GetBytes().Select(x => x.ToString("X2"))));
                    new alert("Packet data row has been copied");
                }
            }
            catch { }
        }

        private void pPacketDetailsInject_Click(object sender, EventArgs e)
        {
            try
            {
                int index = PacketsGrid.SelectedRows[0].Index;
                if (index > -1)
                {
                    Packet p = PacketsDictionary[index];

                    if (lDeatailsPacketDirection.Text == "Server")
                        Common.SRClient.SendToClient(p);
                    else if (lDeatailsPacketDirection.Text == "Client")
                        Common.SRClient.SendToServer(p);

                    Common.SRClient.SendNotice($"Packet {lDeatailsPacketOpcode.Text} has been injected successfully.");
                    Common.Dashboard.writeLog($"Packet {lDeatailsPacketOpcode.Text} has been injected successfully.", 1);
                }
            }
            catch { }
        }

        private void bPacketDetailsScript_Click(object sender, EventArgs e)
        {
            try
            {
                int index = PacketsGrid.SelectedRows[0].Index;
                if (index > -1)
                {
                    Packet p = PacketsDictionary[index];

                    StringBuilder packetScript = new StringBuilder();
                    // packet
                    packetScript.AppendLine($"//Packet {p.Opcode.ToString("X4")}");
                    packetScript.AppendLine($"Packet({p.Opcode.ToString("X4")}, {p.Encrypted}, {p.Massive})");

                    // bytes
                    packetScript.AppendLine($"Hexbytes({string.Join(" ", p.GetBytes().Select(x => x.ToString("X2")))})");

                    // direction
                    if (lDeatailsPacketDirection.Text == "Server")
                        packetScript.AppendLine("Send(client)");
                    else if (lDeatailsPacketDirection.Text == "Client")
                        packetScript.AppendLine("Send(server)");

                    Clipboard.SetText(packetScript.ToString());
                    new alert("Packet injection script has been created & copied to the clipboard.");

                    new dialog("Append to injection tab?", "Do you want to append the injection script to the injection tab?").ShowDialog();
                    if (Common.dialogResult == DialogResult.Yes)
                    {
                        tPacketScript.AppendText(Environment.NewLine);
                        tPacketScript.AppendText(packetScript.ToString());
                        bInjectPacket.PerformClick();
                    }
                }
            }
            catch { }

        }
        #endregion

        #region Adjust packets
        private void bAdjustPacketToggle_Click(object sender, EventArgs e)
        {
            mDropAdjustPackets.Visible = mDropAdjustPackets.Visible ? false : true;
        }

        private void bShowServer_CheckedChanged(object sender, EventArgs e)
        {
            isShowServerPackets = bShowServer.Checked ? true : false;
        }

        private void bShowClient_CheckedChanged(object sender, EventArgs e)
        {
            isShowClientPackets = bShowClient.Checked ? true : false;
        }
        private void bHideAdjustPackets_Click(object sender, EventArgs e)
        {
            mDropAdjustPackets.Visible = false;
        }
        #endregion

        #region Reset pacekt sniffer
        public void ResetPacketSniffer()
        {
            // close proxy connection clear everything
            PacketsGrid.Rows.Clear();
            PacketsDictionary.Clear();
            lPacketsCount.Text = "Count: 0 packet(s)";
        }
        #endregion

        #region Packets Logging Settings
        private void bPacketLogging_CheckedChanged(object sender, EventArgs e)
        {
            isAllowPacketLogging = bPacketLogging.Checked ? true : false;
        }

        private void pFileLogging_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Custom Opcode Settings
        List<string> OpcodesList = new List<string>();
        private void bAddOpcodeList_Click(object sender, EventArgs e)
        {
            try
            {
                if (tAddOpcodeList.Text.Length == 4)
                {
                    OpcodesList.Add(tAddOpcodeList.Text);
                    pCustomOpcodeList.Items.Add(tAddOpcodeList.Text);
                }
                else
                {
                    Common.Dashboard.writeLog("Packet length must be 4 hex digits.");
                }
                //UpdateOpcodeList();
            }
            catch { }
        }

        private void UpdateOpcodeList()
        {
            try
            {
                pCustomOpcodeList.Items.Clear();
                foreach (var Opcode in OpcodesList)
                {
                    pCustomOpcodeList.Items.Add(Opcode);
                }
            }
            catch { }
        }

        private void bClearOpcodetList_Click(object sender, EventArgs e)
        {
            try
            {
                OpcodesList.Clear();
                pCustomOpcodeList.Items.Clear();
            }
            catch { }
        }

        private void bRemoveOpcodeList_Click(object sender, EventArgs e)
        {
            try
            {
                if (pCustomOpcodeList.SelectedItem != null)
                {
                    OpcodesList.Remove(pCustomOpcodeList.SelectedItem.ToString());
                    pCustomOpcodeList.Items.Remove(pCustomOpcodeList.SelectedItem);
                }
            }
            catch { }
        }

        private void rShowOnlyOpcode_CheckedChanged(object sender, EventArgs e)
        {
            isShowOnlyOpcode = true;
            isHideOpcode = false;
        }

        private void rHideOpcode_CheckedChanged(object sender, EventArgs e)
        {
            isShowOnlyOpcode = false;
            isHideOpcode = true;
        }
        #endregion

        #region Packet Injection
        private void bInjectPacket_Click(object sender, EventArgs e)
        {
            pPacketInjection.Visible = pPacketInjection.Visible ? false : true;
        }

        /// <summary>
        /// Packet param button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PacketParamClick(object sender, EventArgs e)
        {
            try
            {
                Button button = (sender as Button);
                if (ParamsKeywords.Any((button.Tag as string).Contains) || MainKeywords.Any((button.Tag as string).Contains))
                {
                    if (string.IsNullOrEmpty(tPacketScript.Text))
                        tPacketScript.AppendText(button.Tag.ToString().Replace("\\n", Environment.NewLine));
                    else
                        tPacketScript.AppendText(Environment.NewLine + button.Tag.ToString().Replace("\\n", Environment.NewLine));
                }
                else
                {
                    Common.Dashboard.writeLog("The pressed button dosen't contain an recognised tag.", 0);
                }
            }
            catch { Common.Dashboard.writeLog("The pressed button dosen't contain an recognised tag", 0); }
        }
        private void bClearScriptBox_Click(object sender, EventArgs e)
        {
            tPacketScript.Clear();
        }
        private void bHidePacketInjector_Click(object sender, EventArgs e)
        {
            pPacketInjection.Visible = false;
        }
        private void bToggleSaveScript_Click(object sender, EventArgs e)
        {
            pDropSaveScript.Visible = pDropSaveScript.Visible ? false : true;
        }

        private async void bInjectScript_Click(object sender, EventArgs e)
        {
            try
            {
                if (tPacketScript.Text.Length > -1)
                {
                    string[] scriptLines = tPacketScript.Lines;
                    for (int x = 0; x < PacketRepeatSpinner.Value; x++)
                    {
                        await PScriptParser.Parse(scriptLines);
                        await Task.Delay((int)PacketDelaySpinner.Value);
                    }
                }
                else
                {
                    new message("Couldn't inject the script, something is invalid.");
                }
            }
            catch { }
        }

        private void bSaveScript_Click(object sender, EventArgs e)
        {
            try
            {
                if (tSaveScriptName.Text.Length <= 2 || tPacketScript.Text.Length <= 2)
                {
                    Common.Dashboard.writeLog("Script box, Script name or section can't be empty or less than 2 character.", 0);
                    return;
                }

                string filePath = Directory.GetCurrentDirectory() + "/Required/packet-scripts.json";
                var fileData = File.ReadAllText(filePath);
                var JsonData = JsonConvert.DeserializeObject<dynamic>(fileData);
                // check if same query name is found update it
                JsonData.Add(new JProperty(tSaveScriptName.Text, tPacketScript.Text.Replace(Environment.NewLine, "\\n")));
                JsonData = JsonConvert.SerializeObject(JsonData);
                File.WriteAllText(filePath, JsonData);

                Common.Dashboard.writeLog($"{tSaveScriptName.Text} Script has been added successfully.", 1);
                loadScripts();
            }
            catch (Exception ex)
            {
                Common.Dashboard.writeLog("Couldn't save the new script, ERROR: " + ex.Message, 0);
            }
        }

        private void loadScripts()
        {
            try
            {
                // add file handeling
                string Data = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Required/packet-scripts.json"));
                dynamic Json = JsonConvert.DeserializeObject<dynamic>(Data);
                foreach (var parent in Json)
                {
                    if (!Scripts.ContainsKey(parent.Name))
                    {
                        Scripts.Add((string)parent.Name, (string)parent.Value);
                        savedScriptsList.Items.Add((string)parent.Name);
                    }
                }
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while loading scripts: " + error.Message, 0);
            }
        }

        private void savedScriptsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tPacketScript.Text = Scripts[savedScriptsList.SelectedItem.ToString()];
            }
            catch { }
        }

        private void bDeleteScript_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Directory.GetCurrentDirectory() + "/Required/packet-scripts.json";
                var fileData = File.ReadAllText(filePath);
                var JsonData = JsonConvert.DeserializeObject<dynamic>(fileData);

                foreach (var item in JsonData)
                {
                    if (item.Name == savedScriptsList.SelectedItem.ToString())
                    {
                        JsonData.Remove(savedScriptsList.SelectedItem.ToString());
                        break;
                    }
                }

                Scripts.Remove(savedScriptsList.SelectedItem.ToString());
                savedScriptsList.Items.Remove(savedScriptsList.SelectedItem.ToString());
                JsonData = JsonConvert.SerializeObject(JsonData);
                File.WriteAllText(filePath, JsonData);
                Common.Dashboard.writeLog($"{tSaveScriptName.Text} Script has been deleted successfully.", 1);
                loadScripts();
            }
            catch (Exception error)
            {
                Common.Dashboard.writeLog("Error while deleting scripts: " + error.Message, 0);
            }
        }
        #endregion

        // Add this to the main window so grid works each client 
        private void bNewSniffer_Click(object sender, EventArgs e)
        {
            PacketSniffer PacketSniffer = new PacketSniffer();
            Common.Dashboard.AddOwnedForm(PacketSniffer);
            PacketSniffer.Show();
        }

    }
}
