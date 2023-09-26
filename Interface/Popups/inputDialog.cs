using System;
using System.Drawing;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class inputDialog : Form
    {
        /// <summary>
        /// dragging the window ith drap button
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public inputDialog(string title, string content)
        {
            InitializeComponent();
            this.Text = title;
            pTitle.Text = title;
            labelContent.Text = content;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Common.dialogInputResult = null;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            Common.dialogResult = DialogResult.Yes;
            Common.dialogInputResult = inputBox.Text;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Close();
            Common.dialogInputResult = null;
        }
    }
}
