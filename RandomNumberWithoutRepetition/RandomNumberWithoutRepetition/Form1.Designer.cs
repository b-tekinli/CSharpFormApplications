
namespace RandomNumberWithoutRepetition
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
            this.lstBoxRandomSmall = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtBoxFinish = new System.Windows.Forms.TextBox();
            this.txtBoxStart = new System.Windows.Forms.TextBox();
            this.txtBoxNumberOfProduction = new System.Windows.Forms.TextBox();
            this.lstBoxRandomBig = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxRandomSmall
            // 
            this.lstBoxRandomSmall.FormattingEnabled = true;
            this.lstBoxRandomSmall.ItemHeight = 20;
            this.lstBoxRandomSmall.Location = new System.Drawing.Point(365, 17);
            this.lstBoxRandomSmall.Name = "lstBoxRandomSmall";
            this.lstBoxRandomSmall.Size = new System.Drawing.Size(150, 284);
            this.lstBoxRandomSmall.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bitiş değerini giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Başlangıç değerini giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kaç sayı üretileceğini giriniz:";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.White;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRandom.ForeColor = System.Drawing.Color.Red;
            this.btnRandom.Location = new System.Drawing.Point(82, 224);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(216, 62);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "RASTGELE SAYI ÜRET";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtBoxFinish
            // 
            this.txtBoxFinish.Location = new System.Drawing.Point(262, 90);
            this.txtBoxFinish.Name = "txtBoxFinish";
            this.txtBoxFinish.Size = new System.Drawing.Size(67, 27);
            this.txtBoxFinish.TabIndex = 10;
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Location = new System.Drawing.Point(262, 27);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.Size = new System.Drawing.Size(67, 27);
            this.txtBoxStart.TabIndex = 9;
            // 
            // txtBoxNumberOfProduction
            // 
            this.txtBoxNumberOfProduction.Location = new System.Drawing.Point(262, 157);
            this.txtBoxNumberOfProduction.Name = "txtBoxNumberOfProduction";
            this.txtBoxNumberOfProduction.Size = new System.Drawing.Size(67, 27);
            this.txtBoxNumberOfProduction.TabIndex = 8;
            // 
            // lstBoxRandomBig
            // 
            this.lstBoxRandomBig.FormattingEnabled = true;
            this.lstBoxRandomBig.ItemHeight = 20;
            this.lstBoxRandomBig.Location = new System.Drawing.Point(555, 17);
            this.lstBoxRandomBig.Name = "lstBoxRandomBig";
            this.lstBoxRandomBig.Size = new System.Drawing.Size(150, 284);
            this.lstBoxRandomBig.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(715, 314);
            this.Controls.Add(this.lstBoxRandomBig);
            this.Controls.Add(this.lstBoxRandomSmall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtBoxFinish);
            this.Controls.Add(this.txtBoxStart);
            this.Controls.Add(this.txtBoxNumberOfProduction);
            this.Name = "Form1";
            this.Text = "Tekrarsız Sayı Üretme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxRandomSmall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtBoxFinish;
        private System.Windows.Forms.TextBox txtBoxStart;
        private System.Windows.Forms.TextBox txtBoxNumberOfProduction;
        private System.Windows.Forms.ListBox lstBoxRandomBig;
    }
}

