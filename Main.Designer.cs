namespace Loaj_dhe_Meso
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.easyBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(518, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luaj Dhe Mëso";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Loaj_dhe_Meso.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(574, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 115);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // easyBtn
            // 
            this.easyBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.easyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBtn.Location = new System.Drawing.Point(208, 391);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(160, 42);
            this.easyBtn.TabIndex = 2;
            this.easyBtn.Text = "I Thjeshte";
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // mediumBtn
            // 
            this.mediumBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.mediumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.Location = new System.Drawing.Point(560, 391);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(160, 42);
            this.mediumBtn.TabIndex = 3;
            this.mediumBtn.Text = "Mesatar";
            this.mediumBtn.UseVisualStyleBackColor = false;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.hardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.Location = new System.Drawing.Point(905, 391);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(160, 42);
            this.hardBtn.TabIndex = 4;
            this.hardBtn.Text = "I veshtire";
            this.hardBtn.UseVisualStyleBackColor = false;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Faqja Kryesore";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.Red;
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext.Location = new System.Drawing.Point(1173, 0);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(85, 36);
            this.ext.TabIndex = 6;
            this.ext.Text = "X";
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Loaj_dhe_Meso.Properties.Resources.mainft;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 660);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hardBtn);
            this.Controls.Add(this.mediumBtn);
            this.Controls.Add(this.easyBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ext;
    }
}