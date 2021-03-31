
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
            this.SuspendLayout();
            // 
            // txtBoxBlue
            // 
            this.txtBoxBlue.Location = new System.Drawing.Point(220, 295);
            this.txtBoxBlue.Name = "txtBoxBlue";
            this.txtBoxBlue.Size = new System.Drawing.Size(125, 27);
            this.txtBoxBlue.TabIndex = 0;
            // 
            // txtBoxGreen
            // 
            this.txtBoxGreen.Location = new System.Drawing.Point(220, 229);
            this.txtBoxGreen.Name = "txtBoxGreen";
            this.txtBoxGreen.Size = new System.Drawing.Size(125, 27);
            this.txtBoxGreen.TabIndex = 1;
            // 
            // txtBoxRed
            // 
            this.txtBoxRed.Location = new System.Drawing.Point(220, 167);
            this.txtBoxRed.Name = "txtBoxRed";
            this.txtBoxRed.Size = new System.Drawing.Size(125, 27);
            this.txtBoxRed.TabIndex = 2;
            this.txtBoxRed.TextChanged += new System.EventHandler(this.txtBoxRed_TextChanged);
            // 
            // inputMessage
            // 
            this.inputMessage.AutoSize = true;
            this.inputMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputMessage.Location = new System.Drawing.Point(76, 123);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(108, 25);
            this.inputMessage.TabIndex = 3;
            this.inputMessage.Text = "Enter color:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 420);
            this.Controls.Add(this.inputMessage);
            this.Controls.Add(this.txtBoxRed);
            this.Controls.Add(this.txtBoxGreen);
            this.Controls.Add(this.txtBoxBlue);
            this.Name = "Form";
            this.Text = "ChangeColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBlue;
        private System.Windows.Forms.TextBox txtBoxGreen;
        private System.Windows.Forms.TextBox txtBoxRed;
        private System.Windows.Forms.Label inputMessage;
    }
}

