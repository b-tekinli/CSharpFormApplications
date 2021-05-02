
namespace PrintNumbersSideBySide
{
    partial class Form
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
            this.txtBoxNumStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNumFinish = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxShow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNumIncreaseValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxNumStart
            // 
            this.txtBoxNumStart.Location = new System.Drawing.Point(256, 40);
            this.txtBoxNumStart.Name = "txtBoxNumStart";
            this.txtBoxNumStart.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNumStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç değerini giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş değerini giriniz: ";
            // 
            // txtBoxNumFinish
            // 
            this.txtBoxNumFinish.Location = new System.Drawing.Point(256, 89);
            this.txtBoxNumFinish.Name = "txtBoxNumFinish";
            this.txtBoxNumFinish.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNumFinish.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.Lime;
            this.btnPrint.Location = new System.Drawing.Point(456, 54);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 59);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "YAZDIR";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayılar:";
            // 
            // txtBoxShow
            // 
            this.txtBoxShow.Location = new System.Drawing.Point(37, 241);
            this.txtBoxShow.Multiline = true;
            this.txtBoxShow.Name = "txtBoxShow";
            this.txtBoxShow.Size = new System.Drawing.Size(519, 190);
            this.txtBoxShow.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Artış değerini giriniz:";
            // 
            // txtBoxNumIncreaseValue
            // 
            this.txtBoxNumIncreaseValue.Location = new System.Drawing.Point(258, 142);
            this.txtBoxNumIncreaseValue.Name = "txtBoxNumIncreaseValue";
            this.txtBoxNumIncreaseValue.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNumIncreaseValue.TabIndex = 9;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(588, 449);
            this.Controls.Add(this.txtBoxNumIncreaseValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNumFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNumStart);
            this.Name = "Form";
            this.Text = "Sayıları Yan Yana Yazdırma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNumFinish;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNumIncreaseValue;
    }
}

