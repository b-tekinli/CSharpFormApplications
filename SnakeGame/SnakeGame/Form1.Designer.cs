
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.cboChangeColor = new System.Windows.Forms.ComboBox();
            this.lblChangeColor = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.pcbWall1 = new System.Windows.Forms.PictureBox();
            this.pcbWall2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbWall2);
            this.panel1.Controls.Add(this.pcbWall1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 463);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(829, 341);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 21);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Skor:";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Firebrick;
            this.btnRestart.Enabled = false;
            this.btnRestart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(829, 209);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(214, 58);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "YENİDEN BAŞLAT";
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
            this.cboChangeColor.Location = new System.Drawing.Point(804, 476);
            this.cboChangeColor.Name = "cboChangeColor";
            this.cboChangeColor.Size = new System.Drawing.Size(250, 31);
            this.cboChangeColor.TabIndex = 6;
            // 
            // lblChangeColor
            // 
            this.lblChangeColor.AutoSize = true;
            this.lblChangeColor.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeColor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChangeColor.ForeColor = System.Drawing.Color.Black;
            this.lblChangeColor.Location = new System.Drawing.Point(804, 438);
            this.lblChangeColor.Name = "lblChangeColor";
            this.lblChangeColor.Size = new System.Drawing.Size(250, 23);
            this.lblChangeColor.TabIndex = 7;
            this.lblChangeColor.Text = "Yılan rengi seçiniz:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Firebrick;
            this.btnStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(829, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(214, 52);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameTitle.ForeColor = System.Drawing.Color.Red;
            this.lblGameTitle.Location = new System.Drawing.Point(365, 9);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(318, 67);
            this.lblGameTitle.TabIndex = 9;
            this.lblGameTitle.Text = "SNAKE GAME";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbWall1
            // 
            this.pcbWall1.BackColor = System.Drawing.Color.Snow;
            this.pcbWall1.Location = new System.Drawing.Point(390, 303);
            this.pcbWall1.Name = "pcbWall1";
            this.pcbWall1.Size = new System.Drawing.Size(319, 20);
            this.pcbWall1.TabIndex = 0;
            this.pcbWall1.TabStop = false;
            // 
            // pcbWall2
            // 
            this.pcbWall2.BackColor = System.Drawing.Color.Snow;
            this.pcbWall2.Location = new System.Drawing.Point(62, 129);
            this.pcbWall2.Name = "pcbWall2";
            this.pcbWall2.Size = new System.Drawing.Size(189, 18);
            this.pcbWall2.TabIndex = 1;
            this.pcbWall2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1071, 550);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblChangeColor);
            this.Controls.Add(this.cboChangeColor);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ComboBox cboChangeColor;
        private System.Windows.Forms.Label lblChangeColor;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.PictureBox pcbWall2;
        private System.Windows.Forms.PictureBox pcbWall1;
    }
}

