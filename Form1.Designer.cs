namespace Loaj_dhe_Meso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loadBar = new System.Windows.Forms.Panel();
            this.loadPnl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadBar
            // 
            this.loadBar.BackgroundImage = global::Loaj_dhe_Meso.Properties.Resources.Screenshot_2025_03_12_191146;
            this.loadBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadBar.Controls.Add(this.loadPnl);
            this.loadBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadBar.Location = new System.Drawing.Point(0, 822);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(600, 35);
            this.loadBar.TabIndex = 0;
            // 
            // loadPnl
            // 
            this.loadPnl.BackColor = System.Drawing.Color.LightSlateGray;
            this.loadPnl.Location = new System.Drawing.Point(0, 0);
            this.loadPnl.Name = "loadPnl";
            this.loadPnl.Size = new System.Drawing.Size(53, 35);
            this.loadPnl.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Loaj_dhe_Meso.Properties.Resources.photload;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 857);
            this.Controls.Add(this.loadBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.loadBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loadBar;
        private System.Windows.Forms.Panel loadPnl;
        private System.Windows.Forms.Timer timer1;
    }
}

