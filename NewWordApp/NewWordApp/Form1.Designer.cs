
namespace NewWordApp
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblWords = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBoxWords = new System.Windows.Forms.ListBox();
            this.lbel2 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(256, 85);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 33);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Dur";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(177, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 33);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(364, 463);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 31);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.BackColor = System.Drawing.Color.Yellow;
            this.lblWords.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWords.ForeColor = System.Drawing.Color.Black;
            this.lblWords.Location = new System.Drawing.Point(198, 39);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(91, 25);
            this.lblWords.TabIndex = 21;
            this.lblWords.Text = "Kelimeler";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 31);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBoxWords
            // 
            this.lstBoxWords.FormattingEnabled = true;
            this.lstBoxWords.ItemHeight = 20;
            this.lstBoxWords.Location = new System.Drawing.Point(91, 153);
            this.lstBoxWords.Name = "lstBoxWords";
            this.lstBoxWords.Size = new System.Drawing.Size(300, 204);
            this.lstBoxWords.TabIndex = 15;
            // 
            // lbel2
            // 
            this.lbel2.AutoSize = true;
            this.lbel2.Location = new System.Drawing.Point(22, 468);
            this.lbel2.Name = "lbel2";
            this.lbel2.Size = new System.Drawing.Size(336, 20);
            this.lbel2.TabIndex = 18;
            this.lbel2.Text = "Silinecek kelimeyi listeden seçip butona tıklayınız.";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(22, 424);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(143, 20);
            this.lblAdd.TabIndex = 16;
            this.lblAdd.Text = "Yeni kelimeyi giriniz:";
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(171, 421);
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(187, 27);
            this.txtBoxAdd.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 532);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBoxWords);
            this.Controls.Add(this.lbel2);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtBoxAdd);
            this.Name = "Form1";
            this.Text = "Yeni Kelime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBoxWords;
        private System.Windows.Forms.Label lbel2;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtBoxAdd;
    }
}

