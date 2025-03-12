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
    public partial class Med1: UserControl, IAnswerCheck
    {
        public Med1()
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
                MessageBox.Show("Incorrect answer. Please try again.");
            }
        }


        public bool IsAnswerCorrect()
        {
            errorProvider1.SetError(textBox1, string.Empty);

            string userInput = textBox1.Text.ToUpper();

            if (string.IsNullOrEmpty(userInput) ||
              (userInput != "GUR GUR BEHET KALAJA" &&
              userInput != "GUR GUR BEHET MUR" &&
               userInput != "GURI I RENDE NE VEND TE VET"))
            {
                errorProvider1.SetError(textBox1, "Answer is missing or incorrect!");
                return false;
            }

            return true;
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToUpper();

            if (userInput == "GUR GUR BEHET KALAJA" || userInput == "GUR GUR BEHET MUR" || userInput == "GURI I RENDE NE VEND TE VET")
            {
                MessageBox.Show(
                     "Fjala eshte gjetur sakte, kaloni ne nivelin tjeter!",
                     "Sukses",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
            }
        }
    }
}
