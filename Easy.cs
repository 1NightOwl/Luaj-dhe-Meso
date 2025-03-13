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
    public partial class Easy: Form
    {
        private UserControl currentGameControl;


        public Easy()
        {
            InitializeComponent();
            LoadGameControl(new Easy1());
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

        private void ext_Click(object sender, EventArgs e)
        {
            Main main = new Main(); 
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }




        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentGameControl is IAnswerCheck answerCheck)
            {
                
                if (answerCheck.IsAnswerCorrect())
                {
                    
                    if (currentGameControl is Easy1)
                    {
                        
                        LoadGameControl(new Easy2());
                    }
                    else if (currentGameControl is Easy2)
                    {
                        
                        LoadGameControl(new Easy3());
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect answer. Please try again.");
                }
            }

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
