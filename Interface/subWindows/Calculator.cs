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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // add To and From conversion and fix the binary issue
            int BaseValue = 16;
            if (radioHex.Checked)
                BaseValue = 16;
            else if (radioDecimal.Checked)
                BaseValue = 10;
            else if (radioOctal.Checked)
                BaseValue = 8;
            else if (radioBinary.Checked)
                BaseValue = 2;

            if (inputBox.Text.Length > 0)
            {
                try
                {
                    outputBox.Text = Convert.ToInt64(inputBox.Text, BaseValue).ToString();
                } catch (Exception error)
                {
                    Common.Dashboard.writeLog("Error while converting - "+ error, 0);
                }
            } else
            {
                MessageBox.Show("Enter a value to convert it!");
            }
        }
    }
}
