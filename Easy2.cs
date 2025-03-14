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
    public partial class Easy2: UserControl, IAnswerCheck
    {
        public Easy2()
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
                MessageBox.Show("Përgjigje e gabuar. Ju lutem provoni përsëri.");
            }
        }


        public bool IsAnswerCorrect()
        {
            errorProvider1.SetError(textBox1, string.Empty);

            string userInput = textBox1.Text.ToUpper();

            if (textBox1.Text == null || userInput != "DIALEKT")
            {
                errorProvider1.SetError(textBox1, "Përgjigja mungon ose është e pasaktë!");
                return false;
            }

            return true;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToUpper();

            if (userInput == "DIALEKT")
            {
                MessageBox.Show(
                     "Fjala eshte gjetur sakte, kaloni ne nivelin tjeter!",
                     "Sukses",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
            }
        }

        private void Easy2_Load(object sender, EventArgs e)
        {

        }
    }
}
