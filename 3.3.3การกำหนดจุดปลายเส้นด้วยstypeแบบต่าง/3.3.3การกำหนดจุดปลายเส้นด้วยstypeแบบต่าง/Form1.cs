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

namespace _3._3._3การกำหนดจุดปลายเส้นด้วยstypeแบบต่าง
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
            Pen pen = new Pen(Color.Green, 2);
            pen.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawLine(pen, 10, 80, 220, 120);
            pen.Dispose();
        } 
    }
}
