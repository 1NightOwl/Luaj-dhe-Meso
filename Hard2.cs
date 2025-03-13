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
    public partial class Hard2 : UserControl
    {

        private Panel[,] panels;
        private int gridSize = 3;
        private Label messageLabel;
        private int revealedCount = 0;
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

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clicked = sender as Panel;

            if (clicked.BackgroundImage != null) 
            {
                clicked.BackgroundImage = null; 
                clicked.BackColor = Color.Gray; 
                revealedCount++;
            }

            if (revealedCount == gridSize * gridSize)
            {
                messageLabel.Text = secretMessage;
            }
        }

        private void Hard2_Load(object sender, EventArgs e)
        {

        }
    }
}
