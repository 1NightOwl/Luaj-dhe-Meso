using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loaj_dhe_Meso
{
    public partial class Med5: UserControl, IAnswerCheck
    {

        private int failedAttempts = 0;
        public event Action AnswerCorrect;

        public Med5()
        {
            InitializeComponent();
           
        }


        public bool IsAnswerCorrect()
        {
            errorProvider1.SetError(textBox1, string.Empty);

            string userInput = textBox1.Text.ToUpper();

            if (string.IsNullOrEmpty(userInput) ||
              (userInput != "BASHKIMI BEN FUQINE" &&
              userInput != "TRIMI I MIRE ME SHOKE SHUME"))
            {
                errorProvider1.SetError(textBox1, "Përgjigja mungon ose është e pasaktë!");
                return false;
            }

            return true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (IsAnswerCorrect())
            {
                MessageBox.Show(
                    "Ju e perfunduat lojen me sukses!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Medium medForm = this.ParentForm as Medium;
                if (medForm != null)
                {
                    medForm.SetSessionLastCompletedLevel(5);
                }


                AnswerCorrect?.Invoke(); 
            }
            else
            {
                failedAttempts++;

                MessageBox.Show($"Përgjigje e pasaktë. Ju lutem provoni përsëri. \nNumri i përpjekjeve të dështuara : {failedAttempts}", "Deshtim", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (failedAttempts >= 3)
                {
                    answerBtn.Enabled = true;
                    MessageBox.Show(
                    "Ju mund te aksesoni butonin e pergjigjes!",
                    "Deshtim",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }

            }
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            answerLbl.Visible = true;
        }

        private void Med5_Load(object sender, EventArgs e)
        {

        }
    }
}
