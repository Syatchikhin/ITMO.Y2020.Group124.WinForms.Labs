using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ITMO.WinForms2020.Syatc00m.Lab03.Exersise3.WinButNum
{
    public class ClickButton : Button
    {
        int mClicks;
        public int Clicks 
        {
        get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);
            g.DrawString(Clicks.ToString(), this.Font,
            SystemBrushes.ControlText, 
            this.Width - stringsize.Width - 3, this.Height - stringsize.Height - 3);
            
            
        }



    }
}
