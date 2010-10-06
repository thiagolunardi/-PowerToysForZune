using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BallonZ
{
    public class MyTooltip : ToolTip
    {
        public MyTooltip()
        {
            this.OwnerDraw = true;
            this.Draw += new DrawToolTipEventHandler(OnDraw);
        }
        public MyTooltip(System.ComponentModel.IContainer Cont)
        {
            this.OwnerDraw = true;
            this.Draw += new DrawToolTipEventHandler(OnDraw);
        }
        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            DrawToolTipEventArgs newArgs = new DrawToolTipEventArgs(e.Graphics,
                e.AssociatedWindow, e.AssociatedControl, e.Bounds, e.ToolTipText,
                this.BackColor, this.ForeColor, new Font(e.Font, FontStyle.Bold));
            newArgs.DrawBackground();
            newArgs.DrawBorder();
            newArgs.DrawText(TextFormatFlags.TextBoxControl);
        }
    }
}