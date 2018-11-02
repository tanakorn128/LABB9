using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3._2กำหนดจุด_style
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
            Pen[] objPen = new Pen[11];
            for(int i = 0; i < 11; i++)
            {
                objPen[i] = new Pen(Color.Blue, 9);
            }
            //Set pen styles
            objPen[0].EndCap = LineCap
        }
    }
}
