using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 30 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Blue;
        public Form1()
        {
            InitializeComponent();
        }
        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
            {
                return;
            }

            var x1 = x0 + leng * Math.Cos(th);
            var y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            if ((int)x0 == (int)x1 && (int)y0 == (int)y1)
            {
                return;
            }

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            per1 = double.Parse(rbranch.Text);
            per2 = double.Parse(lbranch.Text);
            th1 = double.Parse(rangle.Text);
            th2 = double.Parse(langle.Text);
            if (graphics == null) graphics = panel1.CreateGraphics();
            graphics.Clear(BackColor);
            drawCayleyTree(int.Parse(length.Text), panel1.Width / 2, panel1.Height,double.Parse(depth.Text), -Math.PI / 2);
        }
    }
}
