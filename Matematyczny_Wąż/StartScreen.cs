﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematyczny_Wąż
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Loadgame(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void helpsrc(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
            this.Close();

        }
    }
}
