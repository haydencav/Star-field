using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }

        private void StarField(int y)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int w = 0;
            int xcoord, ycoord, size, rcolor, gcolor, bcolor;
            Random randNum = new Random();

            while (w <= y)
            {
//ssdkufhsddfjj
                rcolor = randNum.Next(1, 225);
                gcolor = randNum.Next(1, 225);
                bcolor = randNum.Next(1, 225);

                drawBrush.Color = Color.FromArgb(rcolor, gcolor, bcolor);

                xcoord = randNum.Next(1, 300);
                ycoord = randNum.Next(1, 300);
                size = randNum.Next(1, 10);

                g.FillEllipse(drawBrush, xcoord, ycoord, size, size);

                w++;
            }
        }
    }
}
