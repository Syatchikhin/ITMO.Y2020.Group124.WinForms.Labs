using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms2020.Syatc00M.Lab03.Exersice2
{
    public partial class CustomControlTimer2 : Control
    {
        public CustomControlTimer2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.FillRectangle(Brushes.LightBlue, 0, 0, this.Width, this.Height);

            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(),this.Font, new SolidBrush(this.ForeColor),0,0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
