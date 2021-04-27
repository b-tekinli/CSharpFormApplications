
namespace NumberComparison
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
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxNum3 = new System.Windows.Forms.TextBox();
            this.btnBigNum = new System.Windows.Forms.Button();
            this.btnSmallNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(166, 42);
            this.txtBoxNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(65, 30);
            this.txtBoxNum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "3 sayı giriniz: ";
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(293, 42);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(65, 30);
            this.txtBoxNum2.TabIndex = 2;
            // 
            // txtBoxNum3
            // 
            this.txtBoxNum3.Location = new System.Drawing.Point(413, 42);
            this.txtBoxNum3.Name = "txtBoxNum3";
            this.txtBoxNum3.Size = new System.Drawing.Size(65, 30);
            this.txtBoxNum3.TabIndex = 3;
            // 
            // btnBigNum
            // 
            this.btnBigNum.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBigNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBigNum.ForeColor = System.Drawing.Color.White;
            this.btnBigNum.Location = new System.Drawing.Point(80, 107);
            this.btnBigNum.Name = "btnBigNum";
            this.btnBigNum.Size = new System.Drawing.Size(151, 64);
            this.btnBigNum.TabIndex = 4;
            this.btnBigNum.Text = "EN BÜYÜK SAYI";
            this.btnBigNum.UseVisualStyleBackColor = false;
            this.btnBigNum.Click += new System.EventHandler(this.btnBigNum_Click);
            // 
            // btnSmallNum
            // 
            this.btnSmallNum.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSmallNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSmallNum.ForeColor = System.Drawing.Color.Transparent;
            this.btnSmallNum.Location = new System.Drawing.Point(282, 107);
            this.btnSmallNum.Name = "btnSmallNum";
            this.btnSmallNum.Size = new System.Drawing.Size(146, 64);
            this.btnSmallNum.TabIndex = 6;
            this.btnSmallNum.Text = "EN KÜÇÜK SAYI";
            this.btnSmallNum.UseVisualStyleBackColor = false;
            this.btnSmallNum.Click += new System.EventHandler(this.btnSmallNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(490, 183);
            this.Controls.Add(this.btnSmallNum);
            this.Controls.Add(this.btnBigNum);
            this.Controls.Add(this.txtBoxNum3);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNum1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Sayı Karşılaştırması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.TextBox txtBoxNum3;
        private System.Windows.Forms.Button btnBigNum;
        private System.Windows.Forms.Button btnSmallNum;
    }
}

