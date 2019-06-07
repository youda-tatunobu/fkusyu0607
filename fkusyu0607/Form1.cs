using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fkusyu0607
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();

        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10, 11);

        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);

        int vx3 = rand.Next(-10, 11);
        int vy3= rand.Next(-10, 11);
        int taim = 1000;

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Width - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label1.Width);
            label2.Top = rand.Next(ClientSize.Width - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label1.Width);
            label2.Top = rand.Next(ClientSize.Width - label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = PointToClient(MousePosition);

            textBox1.Left = p.X;
            textBox1.Top = p.Y ;

            if ((p.X > label1.Left) && (p.X <= label1.Right) && (p.Y > label1.Top) && (p.Y < label1.Bottom) )
                
            {
                vx = 0;
                vy= 0;
            }


            if ((p.X > label2.Left) && (p.X <= label2.Right) && (p.Y > label2.Top) && (p.Y < label2.Bottom))
            {
                vx2 = 0;
                vy2 = 0;
            }

            if((p.X > label3.Left) && (p.X <= label3.Right) && (p.Y > label3.Top) && (p.Y < label3.Bottom))
            {
                vx3 = 0;
                vy3 = 0;
            }

            label1.Left += vx;
            label1.Top += vy;
            label2.Left += vx2;
            label2.Top += vy2;
            label3.Left += vx3;
            label3.Top += vy3;

            if (label1.Right >= ClientSize.Width) 
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom >= ClientSize.Width)
            {
                vy = -Math.Abs(vy);
            }
            if (label1.Left <= 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top <= 0)
            {
                vy = Math.Abs(vy);
            }


             if(label2.Right >= ClientSize.Width) 
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label2.Bottom >= ClientSize.Width)
            {
                vy2 = -Math.Abs(vy2);
            }
            if (label2.Left <= 0)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label2.Top <= 0)
            {
                vy2 = Math.Abs(vy2);
            }


             if  (label3.Right >= ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label3.Bottom >= ClientSize.Width)
            {
                vy3 = -Math.Abs(vy3);
            }
            if (label3.Left <= 0)
            {
                vx3 = Math.Abs(vx3);
            }
            if (label3.Top <= 0)
            {
                vy3 = Math.Abs(vy3);
            }

           taim--;
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
