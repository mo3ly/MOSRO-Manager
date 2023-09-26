using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOSROManager
{
    class SlotToolTip
    {
        ToolTip ToolTip = new ToolTip();

        public SlotToolTip(object sender) {
            PictureBox CurrentSlot = (PictureBox)sender;
            ApendTooltip(CurrentSlot);
        }

        public async void ApendTooltip(PictureBox Slot)
        {
            ItemInfo ItemDetails = new ItemInfo(Convert.ToInt32(Slot.Tag.ToString().Split('-')[0]));
            StringBuilder Details = await ItemDetails.ItemData();
            ToolTip.OwnerDraw = true;
            ToolTip.InitialDelay = 0;
            ToolTip.SetToolTip(Slot, Details.ToString());
            ToolTip.Draw += Draw_Tooltip;
        }

        private void Draw_Tooltip(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            ToolTip.ForeColor = Color.White;
            ToolTip.BackColor = Color.FromArgb(31, 31, 31);
            e.DrawBackground();
            e.DrawBorder();
            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Regular), Brushes.White, new PointF(e.Bounds.X, e.Bounds.Y));
        }
    }
}
