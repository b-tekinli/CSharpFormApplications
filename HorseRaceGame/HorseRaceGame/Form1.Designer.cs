
namespace HorseRaceGame
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
            this.lblFinishLine = new System.Windows.Forms.Label();
            this.lblBlackLine1 = new System.Windows.Forms.Label();
            this.lblBlackLine2 = new System.Windows.Forms.Label();
            this.lblBlackLine3 = new System.Windows.Forms.Label();
            this.lblBlackLine0 = new System.Windows.Forms.Label();
            this.pcbHorse1 = new System.Windows.Forms.PictureBox();
            this.pcbHorse3 = new System.Windows.Forms.PictureBox();
            this.pcbHorse2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRaceStatus = new System.Windows.Forms.Label();
            this.lblMetre = new System.Windows.Forms.Label();
            this.lblRaceResult = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorse2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFinishLine
            // 
            this.lblFinishLine.BackColor = System.Drawing.Color.Black;
            this.lblFinishLine.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinishLine.ForeColor = System.Drawing.Color.White;
            this.lblFinishLine.Location = new System.Drawing.Point(1236, -3);
            this.lblFinishLine.Name = "lblFinishLine";
            this.lblFinishLine.Size = new System.Drawing.Size(25, 521);
            this.lblFinishLine.TabIndex = 0;
            this.lblFinishLine.Text = "FINISH";
            this.lblFinishLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackLine1
            // 
            this.lblBlackLine1.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine1.Location = new System.Drawing.Point(1, 149);
            this.lblBlackLine1.Name = "lblBlackLine1";
            this.lblBlackLine1.Size = new System.Drawing.Size(1238, 16);
            this.lblBlackLine1.TabIndex = 1;
            this.lblBlackLine1.Text = "label1";
            // 
            // lblBlackLine2
            // 
            this.lblBlackLine2.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine2.Location = new System.Drawing.Point(1, 303);
            this.lblBlackLine2.Name = "lblBlackLine2";
            this.lblBlackLine2.Size = new System.Drawing.Size(1238, 18);
            this.lblBlackLine2.TabIndex = 2;
            this.lblBlackLine2.Text = "label1";
            // 
            // lblBlackLine3
            // 
            this.lblBlackLine3.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine3.Location = new System.Drawing.Point(1, 453);
            this.lblBlackLine3.Name = "lblBlackLine3";
            this.lblBlackLine3.Size = new System.Drawing.Size(1238, 65);
            this.lblBlackLine3.TabIndex = 4;
            this.lblBlackLine3.Text = "label1";
            // 
            // lblBlackLine0
            // 
            this.lblBlackLine0.BackColor = System.Drawing.Color.Black;
            this.lblBlackLine0.Location = new System.Drawing.Point(1, -3);
            this.lblBlackLine0.Name = "lblBlackLine0";
            this.lblBlackLine0.Size = new System.Drawing.Size(1238, 19);
            this.lblBlackLine0.TabIndex = 5;
            this.lblBlackLine0.Text = "label1";
            // 
            // pcbHorse1
            // 
            this.pcbHorse1.Image = ((System.Drawing.Image)(resources.GetObject("pcbHorse1.Image")));
            this.pcbHorse1.Location = new System.Drawing.Point(1, 19);
            this.pcbHorse1.Name = "pcbHorse1";
            this.pcbHorse1.Size = new System.Drawing.Size(186, 127);
            this.pcbHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHorse1.TabIndex = 6;
            this.pcbHorse1.TabStop = false;
            // 
            // pcbHorse3
            // 
            this.pcbHorse3.Image = ((System.Drawing.Image)(resources.GetObject("pcbHorse3.Image")));
            this.pcbHorse3.Location = new System.Drawing.Point(1, 324);
            this.pcbHorse3.Name = "pcbHorse3";
            this.pcbHorse3.Size = new System.Drawing.Size(186, 126);
            this.pcbHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHorse3.TabIndex = 7;
            this.pcbHorse3.TabStop = false;
            // 
            // pcbHorse2
            // 
            this.pcbHorse2.Image = ((System.Drawing.Image)(resources.GetObject("pcbHorse2.Image")));
            this.pcbHorse2.Location = new System.Drawing.Point(1, 168);
            this.pcbHorse2.Name = "pcbHorse2";
            this.pcbHorse2.Size = new System.Drawing.Size(186, 126);
            this.pcbHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHorse2.TabIndex = 8;
            this.pcbHorse2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 527);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 60);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRaceStatus
            // 
            this.lblRaceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRaceStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaceStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRaceStatus.ForeColor = System.Drawing.Color.Cyan;
            this.lblRaceStatus.Location = new System.Drawing.Point(239, 588);
            this.lblRaceStatus.Name = "lblRaceStatus";
            this.lblRaceStatus.Size = new System.Drawing.Size(703, 75);
            this.lblRaceStatus.TabIndex = 10;
            this.lblRaceStatus.Text = "Yarış Başlıyor!";
            this.lblRaceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetre
            // 
            this.lblMetre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetre.ForeColor = System.Drawing.Color.Cyan;
            this.lblMetre.Location = new System.Drawing.Point(551, 518);
            this.lblMetre.Name = "lblMetre";
            this.lblMetre.Size = new System.Drawing.Size(141, 70);
            this.lblMetre.TabIndex = 11;
            this.lblMetre.Text = "METRE";
            this.lblMetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRaceResult
            // 
            this.lblRaceResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRaceResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaceResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRaceResult.ForeColor = System.Drawing.Color.Cyan;
            this.lblRaceResult.Location = new System.Drawing.Point(973, 518);
            this.lblRaceResult.Name = "lblRaceResult";
            this.lblRaceResult.Size = new System.Drawing.Size(288, 145);
            this.lblRaceResult.TabIndex = 12;
            this.lblRaceResult.Text = "Yarışma Sonucu";
            this.lblRaceResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(12, 593);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(146, 60);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "RESET";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCounter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.ForeColor = System.Drawing.Color.Cyan;
            this.lblCounter.Location = new System.Drawing.Point(488, 518);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(66, 70);
            this.lblCounter.TabIndex = 14;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1263, 667);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblRaceResult);
            this.Controls.Add(this.lblMetre);
            this.Controls.Add(this.lblRaceStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcbHorse2);
            this.Controls.Add(this.pcbHorse3);
            this.Controls.Add(this.pcbHorse1);
            this.Controls.Add(this.lblBlackLine0);
            this.Controls.Add(this.lblBlackLine3);
            this.Controls.Add(this.lblBlackLine2);
            this.Controls.Add(this.lblBlackLine1);
            this.Controls.Add(this.lblFinishLine);
            this.Name = "Form1";
            this.Text = "Horse Race Game";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHorse2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFinishLine;
        private System.Windows.Forms.Label lblBlackLine1;
        private System.Windows.Forms.Label lblBlackLine2;
        private System.Windows.Forms.Label lblBlackLine3;
        private System.Windows.Forms.Label lblBlackLine0;
        private System.Windows.Forms.PictureBox pcbHorse1;
        private System.Windows.Forms.PictureBox pcbHorse3;
        private System.Windows.Forms.PictureBox pcbHorse2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRaceStatus;
        private System.Windows.Forms.Label lblMetre;
        private System.Windows.Forms.Label lblRaceResult;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCounter;
    }
}

