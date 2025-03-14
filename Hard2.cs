using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loaj_dhe_Meso
{
    public partial class Hard2 : UserControl
    {

        private Panel[,] panels;
        private int gridSize = 3;
        private Label messageLabel;
        private string secretMessage = "Urime, e gjete!";

        public Hard2()
        {
            InitializeComponent();

            panels = new Panel[3, 3] 
            {
                    { panel1, panel2, panel3 },
                    { panel4, panel5, panel6 },
                    { panel7, panel8, panel9 }
            };

            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    panels[r, c].Click += Panel_Click;
                }
            }

            messageLabel = new Label { Text = "", Dock = DockStyle.Bottom, ForeColor = Color.Black, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 14, FontStyle.Bold) };
            this.Controls.Add(messageLabel);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void p1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb1);
            }
        }

        private void p2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb2); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb3); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb4); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb5); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb6); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb7); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb8); // Pass the specific TextBox to CheckAnswer
            }
        }
        private void p9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer(tb9); // Pass the specific TextBox to CheckAnswer
            }
        }


        private void CheckAnswer(System.Windows.Forms.TextBox textBox)
        {
            errorProvider1.Clear();

            // Dictionary to map TextBoxes to their correct answers
            var answerMap = new Dictionary<System.Windows.Forms.TextBox, string>
    {
        { tb1, "FORMULA E PAGEZIMIT" },
        { tb2, "22 NENTOR 1908" },
        { tb3, "LUMI SHKUMBIN" },
        { tb4, "7 MARS 1887" },
        { tb5, "NAUM VEQILHARXHI" },
        { tb6, "1972" },
        { tb7, "GJON BUZUKU" },
        { tb8, "FAMILJEN E GJUHEVE INDOEVROPIANE" },
        { tb9, "UNIFIKIMIN E ALFABETIT" }
    };

            // Check only the specific TextBox that was passed to the method
            if (answerMap.ContainsKey(textBox))
            {
                if (textBox == tb8 || textBox == tb9)
                {
                    // For tb8 and tb9, use Contains to check if the answer includes the target text
                    string target = textBox == tb8 ? "FAMILJEN E GJUHEVE INDOEVROPIANE" : "UNIFIKIMIN E ALFABETIT";
                    if (!textBox.Text.ToUpper().Contains(target.ToUpper()))
                    {
                        errorProvider1.SetError(textBox, "Answer is missing or incorrect!");
                    }
                    else
                    {
                        // If the answer is correct, update the corresponding panel
                        UpdatePanel(textBox);
                    }
                }
                else
                {
                    // For other TextBoxes, check for exact match
                    if (textBox.Text.ToUpper() != answerMap[textBox].ToUpper())
                    {
                        errorProvider1.SetError(textBox, "Answer is missing or incorrect!");
                    }
                    else
                    {
                        // If the answer is correct, update the corresponding panel
                        UpdatePanel(textBox);
                    }
                }
            }

            // Check if all answers are correct
            if (answerMap.All(entry =>
                (entry.Key == tb8 || entry.Key == tb9)
                    ? entry.Key.Text.ToUpper().Contains(entry.Value.ToUpper())
                    : entry.Key.Text.ToUpper() == entry.Value.ToUpper()))
            {
                messageLabel.Text = secretMessage;
            }
        }



        private void UpdatePanel(System.Windows.Forms.TextBox textBox)
        {
            // Map TextBoxes to their corresponding panels and images
            var panelMap = new Dictionary<System.Windows.Forms.TextBox, Action>
    {
        { tb1, () => { panel1.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m1.jpg"); p1.Visible = false; p2.Visible = true; tb1.Visible = false; tb2.Visible = true; } },
        { tb2, () => { panel2.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m2.jpg"); p2.Visible = false; p3.Visible = true; tb2.Visible = false; tb3.Visible = true; } },
        { tb3, () => { panel3.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m3.jpg"); tb3.Visible = false; fsh1.Visible = true; } },
        { tb4, () => { panel4.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m4.jpg"); p4.Visible = false; p5.Visible = true; tb4.Visible = false; tb5.Visible = true; } },
        { tb5, () => { panel5.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m5.jpg"); p5.Visible = false; p6.Visible = true; tb5.Visible = false; tb6.Visible = true; } },
        { tb6, () => { panel6.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m6.jpg"); tb6.Visible = false; fsh2.Visible = true; } },
        { tb7, () => { panel7.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m7.jpg"); p7.Visible = false; p8.Visible = true; tb7.Visible = false; tb8.Visible = true; } },
        { tb8, () => { panel8.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m8.jpg"); p8.Visible = false; p9.Visible = true; tb8.Visible = false; tb9.Visible = true; } },
        { tb9, () => { panel9.BackgroundImage = Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\m9.jpg"); tb9.Visible = false; fsh3.Visible = true; } }
    };

            // Execute the corresponding action for the TextBox
            if (panelMap.ContainsKey(textBox))
            {
                panelMap[textBox].Invoke();
            }
        }











        private void Panel_Click(object sender, EventArgs e)
        {
           
        }

        private void Hard2_Load(object sender, EventArgs e)
        {

        }

        private void p5_Click(object sender, EventArgs e)
        {

        }

        private void p6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
