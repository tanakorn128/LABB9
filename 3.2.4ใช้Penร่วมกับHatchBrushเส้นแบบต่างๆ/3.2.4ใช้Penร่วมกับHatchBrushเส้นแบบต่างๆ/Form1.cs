﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _3._2._4ใช้Penร่วมกับHatchBrushเส้นแบบต่างๆ
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
            HatchBrush mybrush = new HatchBrush(HatchStyle.DarkVertical, Color.White,Color.Violet);
            Pen mypen = new Pen(mybrush, 5);
            g.DrawEllipse(mypen, 10, 10, 200, 200);
            mypen.Dispose();
            mybrush.Dispose();
        }
    }
}
