﻿using System;
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
        int vx = -10;
        int vy = -10;

        Point cpos = MousePosition;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpos = PointToClient(cpos);

            textBox1.Left = cpos.X; //+ textBox1.Right / 2;
            textBox1.Top = cpos.Y; //+ textBox1.Bottom / 2;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left >= 255)
            {
                vx = -vx;
            }
            if (label1.Top >= 255)
            {
                vy =-vy;
            }
            if (label1.Left <= 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top <= 0)
            {
                vy = Math.Abs(vy);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
