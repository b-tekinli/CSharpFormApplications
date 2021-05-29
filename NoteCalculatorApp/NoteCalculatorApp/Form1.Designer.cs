
namespace NoteCalculatorApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrtHesaplama = new System.Windows.Forms.Button();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblOrtSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. Notunuzu giriniz: ";
            // 
            // btnOrtHesaplama
            // 
            this.btnOrtHesaplama.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrtHesaplama.Location = new System.Drawing.Point(46, 159);
            this.btnOrtHesaplama.Name = "btnOrtHesaplama";
            this.btnOrtHesaplama.Size = new System.Drawing.Size(150, 37);
            this.btnOrtHesaplama.TabIndex = 1;
            this.btnOrtHesaplama.Text = "Ortalamayı Bul";
            this.btnOrtHesaplama.UseVisualStyleBackColor = false;
            this.btnOrtHesaplama.Click += new System.EventHandler(this.btnOrtHesaplama_Click);
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(222, 113);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(125, 31);
            this.txtNot2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. Notunuzu giriniz: ";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(222, 73);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(125, 31);
            this.txtNot1.TabIndex = 2;
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrt.Location = new System.Drawing.Point(222, 163);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(94, 25);
            this.lblOrt.TabIndex = 0;
            this.lblOrt.Text = "Ortalama: ";
            // 
            // lblOrtSonuc
            // 
            this.lblOrtSonuc.AutoSize = true;
            this.lblOrtSonuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrtSonuc.Location = new System.Drawing.Point(313, 165);
            this.lblOrtSonuc.Name = "lblOrtSonuc";
            this.lblOrtSonuc.Size = new System.Drawing.Size(22, 25);
            this.lblOrtSonuc.TabIndex = 3;
            this.lblOrtSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 249);
            this.Controls.Add(this.lblOrtSonuc);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.btnOrtHesaplama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Average Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrtHesaplama;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblOrtSonuc;
    }
}

