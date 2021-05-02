
namespace CheckListBoxAddSportsItem
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
            this.lstBoxAddItems = new System.Windows.Forms.ListBox();
            this.chkedLstBoxItems = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxAddItems
            // 
            this.lstBoxAddItems.FormattingEnabled = true;
            this.lstBoxAddItems.ItemHeight = 20;
            this.lstBoxAddItems.Location = new System.Drawing.Point(252, 70);
            this.lstBoxAddItems.Name = "lstBoxAddItems";
            this.lstBoxAddItems.Size = new System.Drawing.Size(176, 244);
            this.lstBoxAddItems.TabIndex = 3;
            // 
            // chkedLstBoxItems
            // 
            this.chkedLstBoxItems.FormattingEnabled = true;
            this.chkedLstBoxItems.Items.AddRange(new object[] {
            "Türkiye",
            "Brezilya",
            "Amerika",
            "Yeni Zelanda",
            "Rusya",
            "İtalya",
            "İspanya",
            "Norveç",
            "Hindistan",
            "Lübnan"});
            this.chkedLstBoxItems.Location = new System.Drawing.Point(37, 70);
            this.chkedLstBoxItems.Name = "chkedLstBoxItems";
            this.chkedLstBoxItems.Size = new System.Drawing.Size(172, 246);
            this.chkedLstBoxItems.TabIndex = 2;
            this.chkedLstBoxItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkedLstBoxItems_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(171, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜLKELER";
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.Color.Lime;
            this.btnAddAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAll.ForeColor = System.Drawing.Color.White;
            this.btnAddAll.Location = new System.Drawing.Point(48, 351);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(150, 62);
            this.btnAddAll.TabIndex = 5;
            this.btnAddAll.Text = "TÜMÜNÜ EKLE";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.Red;
            this.btnDelAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelAll.ForeColor = System.Drawing.Color.White;
            this.btnDelAll.Location = new System.Drawing.Point(263, 351);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(156, 62);
            this.btnDelAll.TabIndex = 6;
            this.btnDelAll.Text = "TÜMÜNÜ KALDIR";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(453, 435);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxAddItems);
            this.Controls.Add(this.chkedLstBoxItems);
            this.Name = "Form1";
            this.Text = "Seç ve Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxAddItems;
        private System.Windows.Forms.CheckedListBox chkedLstBoxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDelAll;
    }
}

