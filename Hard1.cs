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
    public partial class Hard1: UserControl
    {
        //private TableLayoutPanel table;
        private PictureBox[,] pieces;
        public int gridSize = 3;
        private (int row, int col) emptySlot;
        private List<Image> images;


        public Hard1()
        {
            InitializeComponent();


            toolTip1.SetToolTip(panel1, "Kliko për të lëvizur pjesën");


            pieces = new PictureBox[,]
            {
        { pictureBox1, pictureBox2, pictureBox3 },
        { pictureBox4, pictureBox5, pictureBox6 },
        { pictureBox7, pictureBox8, pictureBox9 }
            };

           
            images = new List<Image>
{
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s1.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s2.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s3.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s4.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s5.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s6.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s7.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s8.png"),
    Image.FromFile("C:\\Users\\User\\source\\repos\\Loaj dhe Meso\\Resources\\s9.png")
};

            // Shto indeksin real të fotos si tag
            for (int i = 0; i < images.Count; i++)
            {
                images[i].Tag = (i + 1).ToString();
            }


            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    pieces[r, c].Image = images[r * gridSize + c];
                    pieces[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                    pieces[r, c].Click += Piece_Click;
                }
            }

            emptySlot = (gridSize - 1, gridSize - 1);
            Shuffle();
        }


        private void Shuffle()
        {
            Random rnd = new Random();
            images = images.OrderBy(x => rnd.Next()).ToList(); // Shuflo listën e fotove

            int index = 0;
            StringBuilder initialPositions = new StringBuilder();

            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (r == emptySlot.row && c == emptySlot.col)
                    {
                        pieces[r, c].Image = null;
                        pieces[r, c].Tag = "X";
                        initialPositions.Append("X ");
                    }
                    else
                    {
                        pieces[r, c].Image = images[index];

                      
                        int imageIndex = int.Parse(images[index].Tag.ToString());

                        pieces[r, c].Tag = imageIndex.ToString(); 
                        initialPositions.Append(imageIndex + " "); 

                        index++;
                    }
                }
                initialPositions.AppendLine(); // Shto rresht të ri
            }

            txtInitialState.Text = initialPositions.ToString();

            if (!IsSolvable())
            {
                //MessageBox.Show("Puzzle nuk është i zgjidhshëm. Do të përpiqemi përsëri.");
                Shuffle();
            }
        }

        private void Piece_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            (int r, int c) = GetPiecePosition(clicked);
            if (CanMove(r, c))
            {
               
                pieces[emptySlot.row, emptySlot.col].Image = clicked.Image;
                pieces[emptySlot.row, emptySlot.col].Tag = clicked.Tag; 
                clicked.Image = null;
                clicked.Tag = null;
                emptySlot = (r, c);

                
                CheckIfSolved();
            }
        }

        private (int, int) GetPiecePosition(PictureBox piece)
        {
            for (int r = 0; r < gridSize; r++)
                for (int c = 0; c < gridSize; c++)
                    if (pieces[r, c] == piece) return (r, c);
            return (-1, -1);
        }

        private bool CanMove(int r, int c)
        {
            return (Math.Abs(emptySlot.row - r) + Math.Abs(emptySlot.col - c)) == 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Hard1_Load(object sender, EventArgs e)
        {
            
        }

        private bool IsSolvable()
        {
            // Krijo një listë të gjithë pjesëve (përjashto boshllëkun)
            List<int> puzzle = new List<int>();

            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (pieces[r, c].Tag != null && pieces[r, c].Tag.ToString() != "X")
                    {
                        puzzle.Add(int.Parse(pieces[r, c].Tag.ToString()));
                    }
                }
            }

            int inversions = 0;

            // Numëro inversimet
            for (int i = 0; i < puzzle.Count - 1; i++)
            {
                for (int j = i + 1; j < puzzle.Count; j++)
                {
                    if (puzzle[i] > puzzle[j])
                    {
                        inversions++;
                    }
                }
            }

            // Puzzle është i zgjidhshëm nëse numri i inversimeve është çift
            return inversions % 2 == 0;
        }



        private void CheckIfSolved()
        {
            int correctPieces = 0;

            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (r == emptySlot.row && c == emptySlot.col)
                    {
                        continue;
                    }

                    if (pieces[r, c].Tag != null)
                    {
                        int expectedTag = (r * gridSize + c) + 1;
                        if (pieces[r, c].Tag.ToString() == expectedTag.ToString())
                        {
                            correctPieces++;
                        }
                    }
                }
            }

           
            if (correctPieces == 8)
            {
                pieces[emptySlot.row, emptySlot.col].Image = images[8]; 
                pieces[emptySlot.row, emptySlot.col].Tag = "9";

                MessageBox.Show("Urime! E zgjidhe puzzle-in!");
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infoMessage = "Ky është një puzzle 3x3. Klikoni në pjesët për t'i lëvizur dhe për të zgjidhur puzzle-in! \n\nKy eshte nje website qe mund te ju ndihmoje per zgjidhjen e ketij puzzle! \n\nanalogbit.com/software/puzzletools/";
            MessageBox.Show(infoMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
