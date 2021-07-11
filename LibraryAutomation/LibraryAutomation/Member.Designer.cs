
namespace LibraryAutomation
{
    partial class Member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvBooksForMember = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksForMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(263, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(123, 21);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(125, 27);
            this.txtBookID.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvBooksForMember
            // 
            this.dgvBooksForMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksForMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.writer,
            this.bookLang,
            this.publisher,
            this.bookKind,
            this.piece,
            this.numberOfPages,
            this.yearOfPublication});
            this.dgvBooksForMember.Location = new System.Drawing.Point(12, 69);
            this.dgvBooksForMember.Name = "dgvBooksForMember";
            this.dgvBooksForMember.RowHeadersWidth = 51;
            this.dgvBooksForMember.RowTemplate.Height = 29;
            this.dgvBooksForMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksForMember.Size = new System.Drawing.Size(776, 297);
            this.dgvBooksForMember.TabIndex = 5;
            // 
            // bookID
            // 
            this.bookID.HeaderText = "ID";
            this.bookID.MinimumWidth = 6;
            this.bookID.Name = "bookID";
            this.bookID.Width = 50;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Kitap Adı";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 110;
            // 
            // writer
            // 
            this.writer.HeaderText = "Yazar";
            this.writer.MinimumWidth = 6;
            this.writer.Name = "writer";
            this.writer.Width = 110;
            // 
            // bookLang
            // 
            this.bookLang.HeaderText = "Kitap Dili";
            this.bookLang.MinimumWidth = 6;
            this.bookLang.Name = "bookLang";
            this.bookLang.Width = 80;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Yayınevi";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.Width = 125;
            // 
            // bookKind
            // 
            this.bookKind.HeaderText = "Kitap Türü";
            this.bookKind.MinimumWidth = 6;
            this.bookKind.Name = "bookKind";
            this.bookKind.Width = 80;
            // 
            // piece
            // 
            this.piece.HeaderText = "Adet";
            this.piece.MinimumWidth = 6;
            this.piece.Name = "piece";
            this.piece.Width = 50;
            // 
            // numberOfPages
            // 
            this.numberOfPages.HeaderText = "Sayfa Sayısı";
            this.numberOfPages.MinimumWidth = 6;
            this.numberOfPages.Name = "numberOfPages";
            this.numberOfPages.Width = 50;
            // 
            // yearOfPublication
            // 
            this.yearOfPublication.HeaderText = "Basım Yılı";
            this.yearOfPublication.MinimumWidth = 6;
            this.yearOfPublication.Name = "yearOfPublication";
            this.yearOfPublication.Width = 80;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.dgvBooksForMember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Name = "Member";
            this.Text = "Üye Sayfası";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksForMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvBooksForMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLang;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn piece;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublication;
    }
}