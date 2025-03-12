using System;
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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadPnl.Width += 6;

            if (loadPnl.Width >= 550)
            {
                timer1.Stop();


                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }
    }
}
