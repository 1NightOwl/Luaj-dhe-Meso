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
            pieces = new PictureBox[,]
            {
        { pictureBox1, pictureBox2, pictureBox3 },
        { pictureBox4, pictureBox5, pictureBox6 },
        { pictureBox7, pictureBox8, pictureBox9 }
            };

            // Ngarko fotot e ndara manualisht
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
            images = images.OrderBy(x => rnd.Next()).ToList();

            int index = 0;
            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (r == emptySlot.row && c == emptySlot.col)
                    {
                        pieces[r, c].Image = null; 
                        pieces[r, c].Tag = "empty"; 
                    }
                    else
                    {
                        pieces[r, c].Image = images[index];
                        pieces[r, c].Tag = (index + 1).ToString();
                        index++;
                    }
                }
            }
        }

        private void Piece_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            (int r, int c) = GetPiecePosition(clicked);
            if (CanMove(r, c))
            {
                // Ndërro pjesët
                pieces[emptySlot.row, emptySlot.col].Image = clicked.Image;
                pieces[emptySlot.row, emptySlot.col].Tag = clicked.Tag; // Ndërro edhe Tag
                clicked.Image = null;
                clicked.Tag = null;
                emptySlot = (r, c);

                // Kontrollo nëse puzzle është zgjidhur
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



        private void CheckIfSolved()
        {
            int correctPieces = 0;
            PictureBox emptyBox = null;

            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (pieces[r, c].Tag != null && pieces[r, c].Tag.ToString() == "empty")
                    {
                        emptyBox = pieces[r, c]; // Store empty slot for later
                        continue;
                    }

                    // Ensure Tag is not null before checking its value
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

            // If 8 pieces are correct, auto-fill the last empty slot
            if (correctPieces == 8 && emptyBox != null)
            {
                emptyBox.Image = images[8]; // Set last image
                emptyBox.Tag = "9"; // Assign last tag


                MessageBox.Show("Urime! E zgjidhe puzzle-in!");
            }

        }
    }
}
