using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class alert : Form
    {
        public alert(string message, int type = 2, int interval = 5000)
        {
            InitializeComponent();
            timer1.Interval = interval;
            alertLabel.Text = message;
            pStatus.BackColor = type == 1 ? Color.DarkOliveGreen : type == 0 ? Color.DarkRed : Color.DarkKhaki;
            Show();
        }

        private void alert_Load(object sender, EventArgs e)
        {
            Common.alertTop += 65;
            if (Common.Dashboard.Visible)
            {
                
                this.Left = (Common.Dashboard.Right - this.Width - 10);
                this.Top = (Common.Dashboard.Top + Common.alertTop);
            } else
            {
                this.Top = Common.alertTop;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 60;
            }
            timer1.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Common.alertTop -= 65;
            timer1.Stop();
            base.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Common.alertTop -= 65;
            timer1.Stop();
            base.Close();
        }
    }
}
