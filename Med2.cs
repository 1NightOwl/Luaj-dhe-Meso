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
    public partial class Med2: UserControl, IAnswerCheck
    {
        public Med2()
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

            if (textBox1.Text == null || userInput != "DUAJE ATDHENE SI SHQIPONJA FOLENE")
            {
                errorProvider1.SetError(textBox1, "Answer is missing or incorrect!");
                return false;
            }

            return true;
        }





        private void Med2_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToUpper();

            if (userInput == "DUAJE ATDHENE SI SHQIPONJA FOLENE")
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
