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

namespace _3._7._1__การโหลดภาพชนิดต่างๆ_มาแสดงบนฟอร์ม
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap Bmp = new Bitmap("D:\\Capture.PNG");
            Rectangle destrect = new Rectangle(10, 10, Bmp.Width / 2, Bmp.Height / 2);
            Rectangle srcrect = new Rectangle(0,0,Bmp.Width,Bmp.Height);
            this.SetClientSizeCore(destrect.Width + 20, destrect.Height + 20);
            g.DrawImage(Bmp, destrect, srcrect, GraphicsUnit.Pixel);
            g.Dispose();
        }
    }
}
