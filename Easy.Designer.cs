namespace Loaj_dhe_Meso
{
    partial class Easy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy));
            this.ext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.Olive;
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext.Location = new System.Drawing.Point(0, 0);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(83, 37);
            this.ext.TabIndex = 7;
            this.ext.Text = "Home";
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1175, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.LightSalmon;
            this.panelTitle.Controls.Add(this.nextBtn);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.button1);
            this.panelTitle.Controls.Add(this.ext);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1258, 107);
            this.panelTitle.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loja e shkronjave te ngaterruara";
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Bisque;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGame.Location = new System.Drawing.Point(0, 106);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1258, 554);
            this.panelGame.TabIndex = 10;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(920, 69);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(144, 35);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next Game";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1258, 660);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Easy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextBtn;
    }
}