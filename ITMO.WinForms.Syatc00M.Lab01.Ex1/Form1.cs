using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourses2020.Syatc00M.Lab01.Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
