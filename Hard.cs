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
    public partial class Hard: Form
    {
        private UserControl currentGameControl;


        public Hard()
        {
            InitializeComponent();
            LoadGameControl(new Hard1());
        }



        public void LoadGameControl(UserControl gameControl)
        {

            if (currentGameControl != null)
            {
                panelGame.Controls.Remove(currentGameControl);
                currentGameControl.Dispose();
            }


            currentGameControl = gameControl;
            currentGameControl.Dock = DockStyle.Fill;
            panelGame.Controls.Add(currentGameControl);
        }


        //private void nextBtn_Click(object sender, EventArgs e)
        //{
            
        //}


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

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            LoadGameControl(new Hard2());
            nextBtn.Visible = false;
            prevBtn.Visible = true;
        }

        //private void prevBtn_Click(object sender, EventArgs e)
        //{
           
        //}

        private void prevBtn_Click_1(object sender, EventArgs e)
        {
            LoadGameControl(new Hard1());
            nextBtn.Visible = true;
            prevBtn.Visible = false;
        }
    }
}
