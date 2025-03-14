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
    public partial class Med4: UserControl, IAnswerCheck
    {

        private int failedAttempts = 0;
        public Med4()
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

        public bool IsAnswerCorrect()
        {
            errorProvider1.SetError(textBox1, string.Empty);

            string userInput = textBox1.Text.ToUpper();

            if (string.IsNullOrEmpty(userInput) ||
              (userInput != "TOSKE E GEGE PEME NGA NJE DEGE"))
            {
                errorProvider1.SetError(textBox1, "Përgjigja mungon ose është e pasaktë!");
                return false;
            }

            return true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToUpper();

            if (userInput == "TOSKE E GEGE PEME NGA NJE DEGE")
            {
                MessageBox.Show(
                     "Fjala eshte gjetur sakte, kaloni ne nivelin tjeter!",
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

        private void Med4_Load(object sender, EventArgs e)
        {

        }
    }
}
