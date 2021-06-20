
namespace SnakeGame
{
    partial class SnakeGame
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
            this.panel = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.cboChangeColor = new System.Windows.Forms.ComboBox();
            this.lblChangeColor = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Location = new System.Drawing.Point(12, 79);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(790, 500);
            this.panel.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(844, 340);
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
            this.btnRestart.Location = new System.Drawing.Point(844, 208);
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
            "Mor",
            "AçıkMavi",
            "KoyuYeşil",
            "KoyuMavi",
            "Pembe"});
            this.cboChangeColor.Location = new System.Drawing.Point(819, 475);
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
            this.lblChangeColor.Location = new System.Drawing.Point(819, 437);
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
            this.btnStart.Location = new System.Drawing.Point(844, 118);
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
            this.lblGameTitle.Location = new System.Drawing.Point(287, 9);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(383, 67);
            this.lblGameTitle.TabIndex = 9;
            this.lblGameTitle.Text = "SNAKE GAME";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1094, 592);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblChangeColor);
            this.Controls.Add(this.cboChangeColor);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel);
            this.Name = "SnakeGame";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ComboBox cboChangeColor;
        private System.Windows.Forms.Label lblChangeColor;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Timer timer;
    }
}

