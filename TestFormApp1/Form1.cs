﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        private string cadenaEscrita="";
        private void Button1_Click(object sender, EventArgs e)
        {
            cadenaEscrita = textBox1.Text;
            textBox2.Text += cadenaEscrita;
        }
    }
}
