using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loaj_dhe_Meso
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            SetCircularRegion(panel1);
            panel1.Invalidate();
            panel1.BackgroundImageLayout = ImageLayout.Stretch;

        }


        private void SetCircularRegion(Panel panel)
        {
            int diameter = Math.Min(panel.Width, panel.Height);
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);

            panel.Region = new Region(path);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = Math.Min(panel.Width, panel.Height);
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                panel.Region = new Region(path); // Apply circular clipping region
            }

            // Fill with background color
            using (SolidBrush brush = new SolidBrush(panel.BackColor))
            {
                e.Graphics.FillEllipse(brush, rect);
            }

            // Draw the image manually
            if (panel.BackgroundImage != null)
            {
                // Scale the image to fit inside the circle
                e.Graphics.DrawImage(panel.BackgroundImage, rect);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetCircularRegion(panel1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            Easy easy = new Easy();
            easy.Show();
            this.Hide();
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            Medium medium = new Medium();
            medium.Show();
            this.Hide();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            Hard hard = new Hard();
            hard.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);  
            Application.Exit();  
        }

    }
}
