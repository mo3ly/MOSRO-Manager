using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSROManager
{
    public partial class pAbout : UserControl
    {
        public pAbout()
        {
            InitializeComponent();
        }

        private void discordImage_Click(object sender, EventArgs e)
        {
            new message("Discord account: mo3ly#2319").Show();
        }

        private void facebookPicture_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/mohamed.exoria");
        }
    }
}
