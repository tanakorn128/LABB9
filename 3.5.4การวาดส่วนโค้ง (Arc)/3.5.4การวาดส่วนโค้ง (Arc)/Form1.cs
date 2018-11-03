using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _3._5._4การวาดส่วนโค้ง__Arc_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //
            Pen penElipse = new Pen(Color.Brown);
            penElipse.DashStyle = DashStyle.Dash;
            g.DrawEllipse(penElipse, 20, 20, 200, 150);

            //
            Pen penPie = new Pen(Color.Magenta, 2);
            g.DrawPie(penPie, 20, 20, 200, 150, 45, 90);
            Pen penpie1 = new Pen(Color.BlueViolet, 2);
            g.DrawPie(penpie1, 20, 20, 200, 150, 150, 45);

            g.Dispose();

            
        }
    }
}
