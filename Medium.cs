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
        private static int sessionLastCompletedLevel = 0;

        private UserControl currentGameControl;
        private int lastCompletedLevel;
        public Medium()
        {
            InitializeComponent();

            lastCompletedLevel = sessionLastCompletedLevel;


            switch (lastCompletedLevel)
            {
                case 1:
                    LoadGameControl(new Med2());
                    break;
                case 2:
                    LoadGameControl(new Med3());
                    break;
                case 3:
                    LoadGameControl(new Med4());
                    break;
                case 4:
                    LoadGameControl(new Med5());
                    break;
                case 5:
                    LoadGameControl(new End());
                    nextBtn.Visible = false;
                    break;
                default:
                    LoadGameControl(new Med1());
                    break;
            }



        }


        public void LoadGameControl(UserControl gameControl)
        {

            if (currentGameControl != null)
            {
                panelGame.Controls.Remove(currentGameControl);
                lastCompletedLevel = Properties.Settings.Default.LastCompletedMediumLevel;
                currentGameControl.Dispose();
            }


            currentGameControl = gameControl;
            currentGameControl.Dock = DockStyle.Fill;
            panelGame.Controls.Add(currentGameControl);


            if (currentGameControl is Med5 med5)
            {
                med5.AnswerCorrect += () =>
                {
                    LoadGameControl(new End());
                    nextBtn.Visible = false;
                };
            }
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

        public void SetSessionLastCompletedLevel(int level)
        {
            sessionLastCompletedLevel = level;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentGameControl is IAnswerCheck answerCheck)
            {
                if (answerCheck.IsAnswerCorrect())
                {
                    if (currentGameControl is Med1)
                    {
                        sessionLastCompletedLevel = 1;
                    }
                    else if (currentGameControl is Med2)
                    {
                        sessionLastCompletedLevel = 2;
                    }
                    else if (currentGameControl is Med3)
                    {
                        sessionLastCompletedLevel = 3;
                    }
                    else if (currentGameControl is Med4)
                    {
                        sessionLastCompletedLevel = 4;
                    }
                    else if (currentGameControl is Med5)
                    {
                        sessionLastCompletedLevel = 5;
                    }


                    if (sessionLastCompletedLevel == 1)
                    {
                        LoadGameControl(new Med2());
                    }
                    else if (sessionLastCompletedLevel == 2)
                    {
                        LoadGameControl(new Med3());
                    }
                    else if (sessionLastCompletedLevel == 3)
                    {
                        LoadGameControl(new Med4());
                    }
                    else if (sessionLastCompletedLevel == 4)
                    {
                        LoadGameControl(new Med5());
                    }
                    else if (sessionLastCompletedLevel == 5)
                    {
                        LoadGameControl(new End());
                    }

                }
                else
                {
                    MessageBox.Show("Përgjigje e gabuar. Ju lutem provoni përsëri.");
                }
            }

        }
    }
}
