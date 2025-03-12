﻿using System;
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
    public partial class Easy3: UserControl, IAnswerCheck
    {
        public Easy3()
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


            if (textBox1.Text == null || userInput != "SHQIPTAR")
            {
                errorProvider1.SetError(textBox1, "Answer is missing or incorrect!");
                return false;
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToUpper();

            if (userInput == "SHQIPTAR")
            {
                MessageBox.Show(
                     "Ju e perfunduat lojen me sukses!",
                     "Sukses",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
            }
        }
    }
}
