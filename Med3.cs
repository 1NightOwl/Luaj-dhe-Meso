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
    public partial class Med3: UserControl, IAnswerCheck
    {

        private int failedAttempts = 0;
        public Med3()
        {
            InitializeComponent();
            submitBtn.Click += (sender, e) => CheckAnswer(textBox1.Text);
        }


        private void CheckAnswer(string userAnswer)
        {
            if (IsAnswerCorrect())
            {

            }
            else
            {

                failedAttempts++;

                MessageBox.Show($"Incorrect answer. Please try again. \nNr of failed Attempts : {failedAttempts}", "Deshtim", MessageBoxButtons.OK,
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


        public bool IsAnswerCorrect()
        {
            errorProvider1.SetError(textBox1, string.Empty);

            string userInput = textBox1.Text.ToUpper();

            if (textBox1.Text == null || userInput != "SHQIPONJA NUK GJUAN MIZA")
            {
                errorProvider1.SetError(textBox1, "Answer is missing or incorrect!");
                return false;
            }

            return true;
        }





        private void Med3_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToUpper();

            if (userInput == "SHQIPONJA NUK GJUAN MIZA")
            {
                MessageBox.Show(
                     "Ju e perfunduat lojen me sukses!",
                     "Sukses",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
            }
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            answerLbl.Visible = true;
        }
    }
}
