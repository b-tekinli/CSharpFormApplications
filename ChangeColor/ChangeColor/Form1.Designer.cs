
namespace ChangeColor
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
            this.txtBoxBlue = new System.Windows.Forms.TextBox();
            this.txtBoxGreen = new System.Windows.Forms.TextBox();
            this.txtBoxRed = new System.Windows.Forms.TextBox();
            this.inputMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMixColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxBlue
            // 
            this.txtBoxBlue.Location = new System.Drawing.Point(231, 248);
            this.txtBoxBlue.Name = "txtBoxBlue";
            this.txtBoxBlue.Size = new System.Drawing.Size(125, 27);
            this.txtBoxBlue.TabIndex = 0;
            this.txtBoxBlue.TextChanged += new System.EventHandler(this.txtBoxBlue_TextChanged);
            // 
            // txtBoxGreen
            // 
            this.txtBoxGreen.Location = new System.Drawing.Point(231, 182);
            this.txtBoxGreen.Name = "txtBoxGreen";
            this.txtBoxGreen.Size = new System.Drawing.Size(125, 27);
            this.txtBoxGreen.TabIndex = 1;
            this.txtBoxGreen.TextChanged += new System.EventHandler(this.txtBoxGreen_TextChanged);
            // 
            // txtBoxRed
            // 
            this.txtBoxRed.Location = new System.Drawing.Point(231, 120);
            this.txtBoxRed.Name = "txtBoxRed";
            this.txtBoxRed.Size = new System.Drawing.Size(125, 27);
            this.txtBoxRed.TabIndex = 2;
            this.txtBoxRed.TextChanged += new System.EventHandler(this.txtBoxRed_TextChanged);
            // 
            // inputMessage
            // 
            this.inputMessage.AutoSize = true;
            this.inputMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputMessage.Location = new System.Drawing.Point(87, 76);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(108, 25);
            this.inputMessage.TabIndex = 3;
            this.inputMessage.Text = "Enter color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(172, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(155, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(167, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue:";
            // 
            // btnMixColor
            // 
            this.btnMixColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMixColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMixColor.Location = new System.Drawing.Point(172, 325);
            this.btnMixColor.Name = "btnMixColor";
            this.btnMixColor.Size = new System.Drawing.Size(184, 44);
            this.btnMixColor.TabIndex = 7;
            this.btnMixColor.Text = "Mix the Colors";
            this.btnMixColor.UseVisualStyleBackColor = false;
            this.btnMixColor.Click += new System.EventHandler(this.btnMixColor_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 420);
            this.Controls.Add(this.btnMixColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputMessage);
            this.Controls.Add(this.txtBoxRed);
            this.Controls.Add(this.txtBoxGreen);
            this.Controls.Add(this.txtBoxBlue);
            this.Name = "Form";
            this.Text = "ChangeColor";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBlue;
        private System.Windows.Forms.TextBox txtBoxGreen;
        private System.Windows.Forms.TextBox txtBoxRed;
        private System.Windows.Forms.Label inputMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMixColor;
    }
}

