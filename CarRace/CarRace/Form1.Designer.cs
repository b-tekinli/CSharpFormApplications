
namespace CarRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbBoom = new System.Windows.Forms.PictureBox();
            this.pcbCar2 = new System.Windows.Forms.PictureBox();
            this.pcbMyCar = new System.Windows.Forms.PictureBox();
            this.pcbCar1 = new System.Windows.Forms.PictureBox();
            this.pcbRoad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pcbBoom);
            this.panel1.Controls.Add(this.pcbCar2);
            this.panel1.Controls.Add(this.pcbMyCar);
            this.panel1.Controls.Add(this.pcbCar1);
            this.panel1.Controls.Add(this.pcbRoad);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // pcbBoom
            // 
            this.pcbBoom.Image = ((System.Drawing.Image)(resources.GetObject("pcbBoom.Image")));
            this.pcbBoom.Location = new System.Drawing.Point(275, 261);
            this.pcbBoom.Name = "pcbBoom";
            this.pcbBoom.Size = new System.Drawing.Size(53, 53);
            this.pcbBoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBoom.TabIndex = 2;
            this.pcbBoom.TabStop = false;
            // 
            // pcbCar2
            // 
            this.pcbCar2.Image = ((System.Drawing.Image)(resources.GetObject("pcbCar2.Image")));
            this.pcbCar2.Location = new System.Drawing.Point(405, 38);
            this.pcbCar2.Name = "pcbCar2";
            this.pcbCar2.Size = new System.Drawing.Size(69, 134);
            this.pcbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar2.TabIndex = 1;
            this.pcbCar2.TabStop = false;
            // 
            // pcbMyCar
            // 
            this.pcbMyCar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMyCar.Image")));
            this.pcbMyCar.Location = new System.Drawing.Point(210, 306);
            this.pcbMyCar.Name = "pcbMyCar";
            this.pcbMyCar.Size = new System.Drawing.Size(69, 134);
            this.pcbMyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMyCar.TabIndex = 1;
            this.pcbMyCar.TabStop = false;
            // 
            // pcbCar1
            // 
            this.pcbCar1.Image = ((System.Drawing.Image)(resources.GetObject("pcbCar1.Image")));
            this.pcbCar1.Location = new System.Drawing.Point(54, 38);
            this.pcbCar1.Name = "pcbCar1";
            this.pcbCar1.Size = new System.Drawing.Size(69, 134);
            this.pcbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar1.TabIndex = 1;
            this.pcbCar1.TabStop = false;
            // 
            // pcbRoad
            // 
            this.pcbRoad.Image = ((System.Drawing.Image)(resources.GetObject("pcbRoad.Image")));
            this.pcbRoad.Location = new System.Drawing.Point(0, 0);
            this.pcbRoad.Name = "pcbRoad";
            this.pcbRoad.Size = new System.Drawing.Size(513, 775);
            this.pcbRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRoad.TabIndex = 0;
            this.pcbRoad.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(420, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(497, 541);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 27);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStart.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(2, 617);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(526, 50);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Oyunu Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yüksek Skor: ";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScore.Location = new System.Drawing.Point(176, 541);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(25, 27);
            this.lblHighScore.TabIndex = 1;
            this.lblHighScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 677);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbRoad;
        private System.Windows.Forms.PictureBox pcbCar2;
        private System.Windows.Forms.PictureBox pcbMyCar;
        private System.Windows.Forms.PictureBox pcbCar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pcbBoom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHighScore;
    }
}

