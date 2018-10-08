﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richTextBox1.AppendText("sin(100) =" + sin(180) + "\n");
            richTextBox1.AppendText("sin-1(1) =" + asin(1) + "\n");
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));

        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
