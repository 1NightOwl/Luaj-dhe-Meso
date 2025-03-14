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

        private static int sessionLastCompletedLevel = 0;
        private int lastCompletedLevel;
        public Easy()
        {
            InitializeComponent();
            lastCompletedLevel = sessionLastCompletedLevel;

            switch (lastCompletedLevel)
            {
                case 1:
                    LoadGameControl(new Easy2());
                    break;
                case 2:
                    LoadGameControl(new Easy3());
                    break;
                case 3:
                    LoadGameControl(new Easy4());
                    break;
                case 4:
                    LoadGameControl(new Easy5());
                    break;
                case 5:
                    LoadGameControl(new End()); 
                    nextBtn.Visible = false;
                    break;
                default:
                    LoadGameControl(new Easy1());
                    break;
            }
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


            if (currentGameControl is Easy5 easy5)
            {
                easy5.AnswerCorrect += () =>
                {
                    LoadGameControl(new End());
                    nextBtn.Visible = false;
                };
            }
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
                        sessionLastCompletedLevel = 1;
                    }
                    else if (currentGameControl is Easy2)
                    {
                        sessionLastCompletedLevel = 2;
                    }
                    else if (currentGameControl is Easy3)
                    {
                        sessionLastCompletedLevel = 3;
                    }
                    else if (currentGameControl is Easy4)
                    {
                        sessionLastCompletedLevel = 4;
                    }

                    if (sessionLastCompletedLevel == 1)
                    {
                        LoadGameControl(new Easy2());
                    }
                    else if (sessionLastCompletedLevel == 2)
                    {
                        LoadGameControl(new Easy3());
                    }
                    else if (sessionLastCompletedLevel == 3)
                    {
                        LoadGameControl(new Easy4());
                    }
                    else if (sessionLastCompletedLevel == 4)
                    {
                        LoadGameControl(new Easy5());
                    }
                    else if (sessionLastCompletedLevel == 5)
                    {
                        LoadGameControl(new End()); 
                        nextBtn.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Përgjigje e gabuar. Ju lutem provoni përsëri.");
                }
            }

        }

        public void SetSessionLastCompletedLevel(int level)
        {
            sessionLastCompletedLevel = level;
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
