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
    public partial class Medium: Form
    {

        private UserControl currentGameControl;
        public Medium()
        {
            InitializeComponent();
            LoadGameControl(new Med1());
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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Medium_Load(object sender, EventArgs e)
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

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentGameControl is IAnswerCheck answerCheck)
            {
                // Check if the answer is correct
                if (answerCheck.IsAnswerCorrect())
                {
                    // Load the next game
                    if (currentGameControl is Med1)
                    {

                        LoadGameControl(new Med2());
                    }
                    else if (currentGameControl is Med2)
                    {

                        LoadGameControl(new Med3());
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect answer. Please try again.");
                }
            }

        }
    }
}
