﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loaj_dhe_Meso
{
    public partial class Hard: Form
    {
        public Hard()
        {
            InitializeComponent();
        }

        private void ext_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Hard_Load(object sender, EventArgs e)
        {

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
