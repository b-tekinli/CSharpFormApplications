
namespace CheckListBoxAddCountryItem
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
            this.chkedLstBox = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxAdd = new System.Windows.Forms.ListBox();
            this.btnDell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkedLstBox
            // 
            this.chkedLstBox.FormattingEnabled = true;
            this.chkedLstBox.Items.AddRange(new object[] {
            "Türkiye",
            "Kafkasya",
            "İspanya",
            "Brezilya",
            "Amerika",
            "Yeni Zelanda",
            "Rusya",
            "İtalya",
            "Norveç",
            "Hindistan"});
            this.chkedLstBox.Location = new System.Drawing.Point(24, 107);
            this.chkedLstBox.Name = "chkedLstBox";
            this.chkedLstBox.Size = new System.Drawing.Size(160, 246);
            this.chkedLstBox.TabIndex = 0;
            this.chkedLstBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkedLstBox_ItemCheck);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "TÜMÜNÜ EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(119, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜLKELER";
            // 
            // lstBoxAdd
            // 
            this.lstBoxAdd.FormattingEnabled = true;
            this.lstBoxAdd.ItemHeight = 20;
            this.lstBoxAdd.Location = new System.Drawing.Point(217, 107);
            this.lstBoxAdd.Name = "lstBoxAdd";
            this.lstBoxAdd.Size = new System.Drawing.Size(164, 244);
            this.lstBoxAdd.TabIndex = 3;
            // 
            // btnDell
            // 
            this.btnDell.BackColor = System.Drawing.Color.Red;
            this.btnDell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDell.ForeColor = System.Drawing.Color.White;
            this.btnDell.Location = new System.Drawing.Point(217, 399);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(164, 56);
            this.btnDell.TabIndex = 4;
            this.btnDell.Text = "TÜMÜNÜ KALDIR";
            this.btnDell.UseVisualStyleBackColor = false;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(393, 493);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.lstBoxAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkedLstBox);
            this.Name = "Form1";
            this.Text = "Seç ve Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkedLstBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxAdd;
        private System.Windows.Forms.Button btnDell;
    }
}

