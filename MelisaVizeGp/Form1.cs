﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelisaVizeGp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            uyeekleme uyeekleme = new uyeekleme();
            uyeekleme.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            kitapekleme kitapekleme = new kitapekleme();
            kitapekleme.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            emanetislemleri emanetislemleri = new emanetislemleri();
            emanetislemleri.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
