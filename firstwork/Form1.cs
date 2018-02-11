using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        Color GetRandomColor()
        {
            return Color.FromArgb(
            random.Next(256),
            random.Next(256),
            random.Next(256));
        }
        int deltX = 10;
        int deltY = 10;


        private void btnbegin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

 

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //屏保图片
            pic_show.Left += deltX;
            pic_show.Top += deltY;
            if (pic_show.Top < 0 ||
            pic_show.Top + pic_show.Height > this.Height)
                deltY = -deltY;
            if (pic_show.Left < 0 ||
            pic_show.Left +pic_show.Width > this.Width)
                deltX = -deltX;

            //画圆
            //Graphics g = this.CreateGraphics();

            //int x0 = this.Width / 2;
            //int y0 = this.Height / 2;

            //for (int r = 0; r < this.Height / 2; r++)
            //{
            //    g.DrawEllipse(
            //    new Pen(GetRandomColor(), 1),
            //    x0 - r, y0 - r, r * 2, r * 2
            //    );

            //}

            //g.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}
