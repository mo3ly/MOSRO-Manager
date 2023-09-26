using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class Loading : Form
    {
        private static string[] requiredFiles = { "log.txt", "Item_name.txt", "queries.json", "packet-scripts.json", "clients.json" }; // if not found generate it
        private static string[] loadFiles = { "Item_name.txt" }; // to be loaded
        private static bool isReady;

        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            try
            {
                // start loading timer
                loadingTimer.Start();

                // create config
                Common.ConfigController.LoadConfig();

                //Check files
                string path = Directory.GetCurrentDirectory() + "/Required/";
                foreach (string file in requiredFiles)
                {
                    sLabel.Text = $"{file} has been found";
                    if (File.Exists(path + file))
                    {
                        sLabel.Text = $"{file} has been found";
                    }
                    else
                    {
                        new message($"{file} was not found, the system is generating it now!").Show();
                        try
                        {
                            File.Create(path + file);
                            sLabel.Text = $"{file} has been created";
                        }
                        catch { }
                    }
                }

                // load names files
                using (var reader = new StreamReader(path + "Item_name.txt"))
                {
                    // make it async later
                    sLabel.Text = "Loading Item_name.txt";
                    while (!reader.EndOfStream)
                    {
                        try
                        {
                            string[] line = reader.ReadLine().Split(new char[] { '\t' });
                            Common.ItemNameDictionary.Add(line[0], line[1]);
                            //Console.WriteLine(line[0] +  " " +line[1]);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }

                // ready state
                sLabel.Text = "Preparing the application to be ready for use.";
                isReady = true;
            }
            catch
            {
                // show error
                NextProcess();
            }
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                loadingBar.Width += 4;
                Percentage.Text = $"{Math.Round(((double)loadingBar.Width / (pLoadingBar.Width - 50) * 100))}%";
                if (loadingBar.Width >= pLoadingBar.Width - 50 && isReady)
                {
                    NextProcess();
                }
            }
            catch 
            {
                // show error
                NextProcess();
            }
        }

        private void NextProcess()
        {

            loadingTimer.Stop();
            new DashboardForm().Show();
            Hide();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void basePanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                WindowAPI.ReleaseCapture();
                WindowAPI.SendMessage(Handle, WindowAPI.WM_NCLBUTTONDOWN, WindowAPI.HT_CAPTION, 0);
            }
        }
    }
}
