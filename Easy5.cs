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
    public partial class Easy5: UserControl, IAnswerCheck
    {

        public event Action AnswerCorrect;
        public Easy5()
        {
            InitializeComponent();
            
        }


        public bool IsAnswerCorrect()
        {
            errorProvider1.SetError(textBox1, string.Empty);


            string userInput = textBox1.Text.ToUpper();


            if (textBox1.Text == null || userInput != "LETERSI")
            {
                errorProvider1.SetError(textBox1, "Përgjigja mungon ose është e pasaktë!");
                return false;
            }

            return true;
        }




        private void Easy5_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {

            if (IsAnswerCorrect())
            {
                MessageBox.Show(
                    "Ju e perfunduat lojen me sukses!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Easy easyForm = this.ParentForm as Easy;
                if (easyForm != null)
                {
                    easyForm.SetSessionLastCompletedLevel(5);
                }

                AnswerCorrect?.Invoke();
            }
            else
            {
                MessageBox.Show("Përgjigje e gabuar. Ju lutem provoni përsëri.");
            }
        }
    }
}
