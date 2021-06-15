
namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.cboChangeColor = new System.Windows.Forms.ComboBox();
            this.lblChangeColor = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 703);
            this.panel1.TabIndex = 0;
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameTitle.ForeColor = System.Drawing.Color.Red;
            this.lblGameTitle.Location = new System.Drawing.Point(1003, 46);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(217, 37);
            this.lblGameTitle.TabIndex = 3;
            this.lblGameTitle.Text = "SNAKE GAME";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(1006, 371);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 21);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Skor:";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Enabled = false;
            this.btnRestart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Location = new System.Drawing.Point(1006, 239);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(214, 58);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Yeniden Başlat";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // cboChangeColor
            // 
            this.cboChangeColor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboChangeColor.FormattingEnabled = true;
            this.cboChangeColor.Items.AddRange(new object[] {
            "Kırmızı",
            "Sarı",
            "AçıkYeşil",
            "Turuncu",
            "Beyaz",
            "Mor",
            "AçıkMavi",
            "KoyuYeşil",
            "KoyuMavi",
            "Pembe"});
            this.cboChangeColor.Location = new System.Drawing.Point(1004, 506);
            this.cboChangeColor.Name = "cboChangeColor";
            this.cboChangeColor.Size = new System.Drawing.Size(196, 31);
            this.cboChangeColor.TabIndex = 6;
            // 
            // lblChangeColor
            // 
            this.lblChangeColor.AutoSize = true;
            this.lblChangeColor.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeColor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChangeColor.ForeColor = System.Drawing.Color.DimGray;
            this.lblChangeColor.Location = new System.Drawing.Point(981, 468);
            this.lblChangeColor.Name = "lblChangeColor";
            this.lblChangeColor.Size = new System.Drawing.Size(250, 23);
            this.lblChangeColor.TabIndex = 7;
            this.lblChangeColor.Text = "Yılan rengi seçiniz:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(1006, 149);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(214, 52);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 711);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblChangeColor);
            this.Controls.Add(this.cboChangeColor);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ComboBox cboChangeColor;
        private System.Windows.Forms.Label lblChangeColor;
        private System.Windows.Forms.Button btnStart;
    }
}

