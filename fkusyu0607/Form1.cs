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

        int[] vx = new int[3];
        int[] vy = new int[3];
        


        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);
            }

         /*vx[0] = rand.Next(-10, 11);
             vy[0] = rand.Next(-10, 11);

             vx[1] = rand.Next(-10, 11);
             vy[1] = rand.Next(-10, 11);

             vx[2] = rand.Next(-10, 11);
             vy[2] = rand.Next(-10, 11);*/
             

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

            textBox1.Left = p.X - textBox1.Height / 2;
            textBox1.Top = p.Y - textBox1.Width / 2;

            if ((p.X > label1.Left) && (p.X <= label1.Right) && (p.Y > label1.Top) && (p.Y < label1.Bottom) )
                
            {
                vx[0] = 0;
                vy[0]= 0;
            }


            if ((p.X > label2.Left) && (p.X <= label2.Right) && (p.Y > label2.Top) && (p.Y < label2.Bottom))
            {
                vx[1] = 0;
                vy[1] = 0;
            }

            if((p.X > label3.Left) && (p.X <= label3.Right) && (p.Y > label3.Top) && (p.Y < label3.Bottom))
            {
                vx[2] = 0;
                vy[2] = 0;
            }

            label1.Left += vx[0];
            label1.Top += vy[0];
            label2.Left += vx[1];
            label2.Top += vy[1];
            label3.Left += vx[2];
            label3.Top += vy[2];

            if (label1.Right >= ClientSize.Width) 
            {

                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Bottom >= ClientSize.Width)
            {
                vy[0] = -Math.Abs(vy[0]);
            }
            if (label1.Left <= 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top <= 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }


             if(label2.Right >= ClientSize.Width) 
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Bottom >= ClientSize.Width)
            {
                vy[1] = -Math.Abs(vy[1]);
            }
            if (label2.Left <= 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label2.Top <= 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }


             if  (label3.Right >= ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Bottom >= ClientSize.Width)
            {
                vx[2] = -Math.Abs(vy[2]);
            }
            if (label3.Left <= 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label3.Top <= 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }

          
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
