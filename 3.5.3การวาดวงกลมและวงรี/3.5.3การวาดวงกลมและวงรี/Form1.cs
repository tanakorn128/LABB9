using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._5._3การวาดวงกลมและวงรี
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
            // draw circle
            Rectangle rect = new Rectangle(10, 10, 100, 100);
            g.DrawEllipse(Pens.Purple, rect);

            //Fill circle
            Rectangle rect1 = new Rectangle(10, 120, 100, 100);
            g.FillEllipse(Brushes.DeepPink, rect1);

            //Draw ellipse
            Rectangle rect2 = new Rectangle(150, 10, 120, 100);
            g.DrawEllipse(Pens.DarkSlateBlue, rect2);

            //fill ellipse
            Rectangle rect3 = new Rectangle(150, 120, 120, 100);
            g.FillEllipse(Brushes.Firebrick, rect3);

            g.Dispose();
        }
    }
}
