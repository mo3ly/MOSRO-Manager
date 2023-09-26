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
    public partial class dialog : Form
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

        public dialog(string title, string content, Image image = null)
        {
            InitializeComponent();
            this.Text = title;
            pTitle.Text = title;
            pContent.Text = content;
            // show slot
            if (image != null)
            {
                slotPanel.Visible = true;
                itemSlot.Image = image;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Common.dialogResult = DialogResult.None;
            Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Common.dialogResult = DialogResult.Yes;
            Close();
        }
    }
}
