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

namespace _3._6._3การระบายสีด้วยTextureBrush
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
            Image image = Image.FromFile("d:\\Capture.PNG");
            //
            TextureBrush brush = new TextureBrush(image);
            Rectangle rect = new Rectangle(10, 10, 180, 150);
            g.FillEllipse(brush, rect);
            g.Dispose();

        }
    }
}
