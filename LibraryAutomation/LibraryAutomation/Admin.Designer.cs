
using System;

namespace LibraryAutomation
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.grpBoxMembers = new System.Windows.Forms.GroupBox();
            this.mskTxtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.ımageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnClearMember = new System.Windows.Forms.Button();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtNameMember = new System.Windows.Forms.TextBox();
            this.lblNameMember = new System.Windows.Forms.Label();
            this.txtIDMember = new System.Windows.Forms.TextBox();
            this.lblIdMember = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.lblBooks = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxBooks = new System.Windows.Forms.GroupBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnClearBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookKind = new System.Windows.Forms.TextBox();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.lblPiece = new System.Windows.Forms.Label();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.txtYearOfPublication = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblYearOfPublication = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.lblWriter = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.lblIdBook = new System.Windows.Forms.Label();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.txtSearchPersonID = new System.Windows.Forms.TextBox();
            this.btnRefreshPerson = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnRefreshBook = new System.Windows.Forms.Button();
            this.txtSearchBookID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.grpBoxBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMembers
            // 
            this.grpBoxMembers.Controls.Add(this.mskTxtDate);
            this.grpBoxMembers.Controls.Add(this.btnUpdateMember);
            this.grpBoxMembers.Controls.Add(this.txtPass);
            this.grpBoxMembers.Controls.Add(this.lblPass);
            this.grpBoxMembers.Controls.Add(this.btnClearMember);
            this.grpBoxMembers.Controls.Add(this.txtAuth);
            this.grpBoxMembers.Controls.Add(this.lblAuth);
            this.grpBoxMembers.Controls.Add(this.btnDeleteMember);
            this.grpBoxMembers.Controls.Add(this.txtUsername);
            this.grpBoxMembers.Controls.Add(this.lblUsername);
            this.grpBoxMembers.Controls.Add(this.btnAddMember);
            this.grpBoxMembers.Controls.Add(this.lblCreationDate);
            this.grpBoxMembers.Controls.Add(this.txtSurname);
            this.grpBoxMembers.Controls.Add(this.lblSurname);
            this.grpBoxMembers.Controls.Add(this.txtNameMember);
            this.grpBoxMembers.Controls.Add(this.lblNameMember);
            this.grpBoxMembers.Controls.Add(this.txtIDMember);
            this.grpBoxMembers.Controls.Add(this.lblIdMember);
            this.grpBoxMembers.Location = new System.Drawing.Point(18, 317);
            this.grpBoxMembers.Name = "grpBoxMembers";
            this.grpBoxMembers.Size = new System.Drawing.Size(664, 419);
            this.grpBoxMembers.TabIndex = 0;
            this.grpBoxMembers.TabStop = false;
            this.grpBoxMembers.Text = "Üye İşlemleri";
            // 
            // mskTxtDate
            // 
            this.mskTxtDate.Location = new System.Drawing.Point(159, 203);
            this.mskTxtDate.Mask = "00/00/0000 90:00:00";
            this.mskTxtDate.Name = "mskTxtDate";
            this.mskTxtDate.Size = new System.Drawing.Size(155, 27);
            this.mskTxtDate.TabIndex = 13;
            this.mskTxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMember.ImageIndex = 3;
            this.btnUpdateMember.ImageList = this.ımageListIcons;
            this.btnUpdateMember.Location = new System.Drawing.Point(405, 261);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(192, 59);
            this.btnUpdateMember.TabIndex = 12;
            this.btnUpdateMember.Text = "Güncelle";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // ımageListIcons
            // 
            this.ımageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListIcons.ImageStream")));
            this.ımageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListIcons.Images.SetKeyName(0, "add.ico");
            this.ımageListIcons.Images.SetKeyName(1, "clear.ico");
            this.ımageListIcons.Images.SetKeyName(2, "delete.ico");
            this.ımageListIcons.Images.SetKeyName(3, "update.ico");
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(488, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(149, 27);
            this.txtPass.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPass.Location = new System.Drawing.Point(347, 111);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(46, 18);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Şifre:";
            // 
            // btnClearMember
            // 
            this.btnClearMember.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearMember.ImageIndex = 1;
            this.btnClearMember.ImageList = this.ımageListIcons;
            this.btnClearMember.Location = new System.Drawing.Point(405, 348);
            this.btnClearMember.Name = "btnClearMember";
            this.btnClearMember.Size = new System.Drawing.Size(192, 59);
            this.btnClearMember.TabIndex = 12;
            this.btnClearMember.Text = "Temizle";
            this.btnClearMember.UseVisualStyleBackColor = true;
            this.btnClearMember.Click += new System.EventHandler(this.btnClearMember_Click);
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(489, 153);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(149, 27);
            this.txtAuth.TabIndex = 11;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuth.Location = new System.Drawing.Point(347, 158);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(47, 18);
            this.lblAuth.TabIndex = 10;
            this.lblAuth.Text = "Yetki:";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMember.ImageIndex = 2;
            this.btnDeleteMember.ImageList = this.ımageListIcons;
            this.btnDeleteMember.Location = new System.Drawing.Point(82, 347);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(192, 59);
            this.btnDeleteMember.TabIndex = 12;
            this.btnDeleteMember.Text = "Sil";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(489, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 27);
            this.txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(347, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 18);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.ImageIndex = 0;
            this.btnAddMember.ImageList = this.ımageListIcons;
            this.btnAddMember.Location = new System.Drawing.Point(82, 261);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(192, 59);
            this.btnAddMember.TabIndex = 12;
            this.btnAddMember.Text = "Ekle";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreationDate.Location = new System.Drawing.Point(24, 208);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(129, 18);
            this.lblCreationDate.TabIndex = 6;
            this.lblCreationDate.Text = "Oluşturma Tarihi:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(160, 151);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(154, 27);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(24, 154);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 18);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Soyad:";
            // 
            // txtNameMember
            // 
            this.txtNameMember.Location = new System.Drawing.Point(160, 103);
            this.txtNameMember.Name = "txtNameMember";
            this.txtNameMember.Size = new System.Drawing.Size(154, 27);
            this.txtNameMember.TabIndex = 3;
            // 
            // lblNameMember
            // 
            this.lblNameMember.AutoSize = true;
            this.lblNameMember.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameMember.Location = new System.Drawing.Point(24, 103);
            this.lblNameMember.Name = "lblNameMember";
            this.lblNameMember.Size = new System.Drawing.Size(30, 18);
            this.lblNameMember.TabIndex = 2;
            this.lblNameMember.Text = "Ad:";
            // 
            // txtIDMember
            // 
            this.txtIDMember.Location = new System.Drawing.Point(160, 55);
            this.txtIDMember.Name = "txtIDMember";
            this.txtIDMember.Size = new System.Drawing.Size(154, 27);
            this.txtIDMember.TabIndex = 1;
            // 
            // lblIdMember
            // 
            this.lblIdMember.AutoSize = true;
            this.lblIdMember.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdMember.Location = new System.Drawing.Point(24, 55);
            this.lblIdMember.Name = "lblIdMember";
            this.lblIdMember.Size = new System.Drawing.Size(27, 18);
            this.lblIdMember.TabIndex = 0;
            this.lblIdMember.Text = "ID:";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMembers.ForeColor = System.Drawing.Color.Red;
            this.lblMembers.Location = new System.Drawing.Point(328, 18);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(91, 27);
            this.lblMembers.TabIndex = 1;
            this.lblMembers.Text = "ÜYELER";
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Surname,
            this.CreationDate,
            this.Username,
            this.Password,
            this.Auth});
            this.dgvPersons.Location = new System.Drawing.Point(18, 62);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 29;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(664, 238);
            this.dgvPersons.TabIndex = 2;
            this.dgvPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellClick);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.ForeColor = System.Drawing.Color.Red;
            this.lblBooks.Location = new System.Drawing.Point(1019, 18);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(110, 27);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "KİTAPLAR";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.writer,
            this.bookLang,
            this.publisher,
            this.bookKind,
            this.piece,
            this.numberOfPages,
            this.yearOfPublication});
            this.dgvBooks.Location = new System.Drawing.Point(708, 62);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 29;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(764, 238);
            this.dgvBooks.TabIndex = 3;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
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
            // grpBoxBooks
            // 
            this.grpBoxBooks.Controls.Add(this.btnUpdateBook);
            this.grpBoxBooks.Controls.Add(this.btnClearBook);
            this.grpBoxBooks.Controls.Add(this.btnDeleteBook);
            this.grpBoxBooks.Controls.Add(this.btnAddBook);
            this.grpBoxBooks.Controls.Add(this.txtBookKind);
            this.grpBoxBooks.Controls.Add(this.lblBookKind);
            this.grpBoxBooks.Controls.Add(this.txtNumberOfPages);
            this.grpBoxBooks.Controls.Add(this.lblNumberOfPages);
            this.grpBoxBooks.Controls.Add(this.txtPiece);
            this.grpBoxBooks.Controls.Add(this.lblPiece);
            this.grpBoxBooks.Controls.Add(this.txtLang);
            this.grpBoxBooks.Controls.Add(this.txtYearOfPublication);
            this.grpBoxBooks.Controls.Add(this.txtPublisher);
            this.grpBoxBooks.Controls.Add(this.lblLang);
            this.grpBoxBooks.Controls.Add(this.lblYearOfPublication);
            this.grpBoxBooks.Controls.Add(this.lblPublisher);
            this.grpBoxBooks.Controls.Add(this.txtWriter);
            this.grpBoxBooks.Controls.Add(this.lblWriter);
            this.grpBoxBooks.Controls.Add(this.txtNameBook);
            this.grpBoxBooks.Controls.Add(this.lblNameBook);
            this.grpBoxBooks.Controls.Add(this.txtIdBook);
            this.grpBoxBooks.Controls.Add(this.lblIdBook);
            this.grpBoxBooks.Location = new System.Drawing.Point(708, 317);
            this.grpBoxBooks.Name = "grpBoxBooks";
            this.grpBoxBooks.Size = new System.Drawing.Size(746, 419);
            this.grpBoxBooks.TabIndex = 0;
            this.grpBoxBooks.TabStop = false;
            this.grpBoxBooks.Text = "Kitap İşlemleri";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBook.ImageIndex = 3;
            this.btnUpdateBook.ImageList = this.ımageListIcons;
            this.btnUpdateBook.Location = new System.Drawing.Point(429, 261);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(192, 59);
            this.btnUpdateBook.TabIndex = 13;
            this.btnUpdateBook.Text = "Güncelle";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnClearBook
            // 
            this.btnClearBook.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearBook.ImageIndex = 1;
            this.btnClearBook.ImageList = this.ımageListIcons;
            this.btnClearBook.Location = new System.Drawing.Point(429, 348);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(192, 59);
            this.btnClearBook.TabIndex = 14;
            this.btnClearBook.Text = "Temizle";
            this.btnClearBook.UseVisualStyleBackColor = true;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.ImageIndex = 2;
            this.btnDeleteBook.ImageList = this.ımageListIcons;
            this.btnDeleteBook.Location = new System.Drawing.Point(106, 347);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(192, 59);
            this.btnDeleteBook.TabIndex = 15;
            this.btnDeleteBook.Text = "Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.ImageIndex = 0;
            this.btnAddBook.ImageList = this.ımageListIcons;
            this.btnAddBook.Location = new System.Drawing.Point(106, 261);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(192, 59);
            this.btnAddBook.TabIndex = 16;
            this.btnAddBook.Text = "Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookKind
            // 
            this.txtBookKind.Location = new System.Drawing.Point(508, 50);
            this.txtBookKind.Name = "txtBookKind";
            this.txtBookKind.Size = new System.Drawing.Size(164, 27);
            this.txtBookKind.TabIndex = 11;
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookKind.Location = new System.Drawing.Point(383, 55);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(87, 18);
            this.lblBookKind.TabIndex = 10;
            this.lblBookKind.Text = "Kitap Türü:";
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.Location = new System.Drawing.Point(509, 143);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(164, 27);
            this.txtNumberOfPages.TabIndex = 11;
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfPages.Location = new System.Drawing.Point(383, 148);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(95, 18);
            this.lblNumberOfPages.TabIndex = 10;
            this.lblNumberOfPages.Text = "Sayfa Sayısı:";
            // 
            // txtPiece
            // 
            this.txtPiece.Location = new System.Drawing.Point(509, 97);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(164, 27);
            this.txtPiece.TabIndex = 11;
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPiece.Location = new System.Drawing.Point(383, 102);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(44, 18);
            this.lblPiece.TabIndex = 10;
            this.lblPiece.Text = "Adet:";
            // 
            // txtLang
            // 
            this.txtLang.Location = new System.Drawing.Point(186, 155);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(164, 27);
            this.txtLang.TabIndex = 9;
            // 
            // txtYearOfPublication
            // 
            this.txtYearOfPublication.Location = new System.Drawing.Point(509, 191);
            this.txtYearOfPublication.Name = "txtYearOfPublication";
            this.txtYearOfPublication.Size = new System.Drawing.Size(164, 27);
            this.txtYearOfPublication.TabIndex = 9;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(186, 191);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(164, 27);
            this.txtPublisher.TabIndex = 9;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLang.Location = new System.Drawing.Point(60, 160);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(89, 18);
            this.lblLang.TabIndex = 8;
            this.lblLang.Text = "Kitabın Dili:";
            // 
            // lblYearOfPublication
            // 
            this.lblYearOfPublication.AutoSize = true;
            this.lblYearOfPublication.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYearOfPublication.Location = new System.Drawing.Point(383, 196);
            this.lblYearOfPublication.Name = "lblYearOfPublication";
            this.lblYearOfPublication.Size = new System.Drawing.Size(81, 18);
            this.lblYearOfPublication.TabIndex = 8;
            this.lblYearOfPublication.Text = "Basım Yılı:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPublisher.Location = new System.Drawing.Point(60, 196);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(71, 18);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "Yayınevi:";
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(186, 120);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(164, 27);
            this.txtWriter.TabIndex = 5;
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWriter.Location = new System.Drawing.Point(60, 123);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(51, 18);
            this.lblWriter.TabIndex = 4;
            this.lblWriter.Text = "Yazar:";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(186, 87);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(164, 27);
            this.txtNameBook.TabIndex = 3;
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameBook.Location = new System.Drawing.Point(60, 87);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(74, 18);
            this.lblNameBook.TabIndex = 2;
            this.lblNameBook.Text = "Kitap Adı:";
            // 
            // txtIdBook
            // 
            this.txtIdBook.Location = new System.Drawing.Point(186, 50);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(164, 27);
            this.txtIdBook.TabIndex = 1;
            // 
            // lblIdBook
            // 
            this.lblIdBook.AutoSize = true;
            this.lblIdBook.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdBook.Location = new System.Drawing.Point(60, 50);
            this.lblIdBook.Name = "lblIdBook";
            this.lblIdBook.Size = new System.Drawing.Size(27, 18);
            this.lblIdBook.TabIndex = 0;
            this.lblIdBook.Text = "ID:";
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(18, 12);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(107, 33);
            this.btnSearchPerson.TabIndex = 4;
            this.btnSearchPerson.Text = "Kişi Ara";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // txtSearchPersonID
            // 
            this.txtSearchPersonID.Location = new System.Drawing.Point(131, 13);
            this.txtSearchPersonID.Multiline = true;
            this.txtSearchPersonID.Name = "txtSearchPersonID";
            this.txtSearchPersonID.Size = new System.Drawing.Size(48, 32);
            this.txtSearchPersonID.TabIndex = 5;
            // 
            // btnRefreshPerson
            // 
            this.btnRefreshPerson.Location = new System.Drawing.Point(185, 13);
            this.btnRefreshPerson.Name = "btnRefreshPerson";
            this.btnRefreshPerson.Size = new System.Drawing.Size(107, 33);
            this.btnRefreshPerson.TabIndex = 4;
            this.btnRefreshPerson.Text = "Yenile";
            this.btnRefreshPerson.UseVisualStyleBackColor = true;
            this.btnRefreshPerson.Click += new System.EventHandler(this.btnRefreshPerson_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(708, 13);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(107, 33);
            this.btnSearchBook.TabIndex = 4;
            this.btnSearchBook.Text = "Kitap Ara";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnRefreshBook
            // 
            this.btnRefreshBook.Location = new System.Drawing.Point(875, 14);
            this.btnRefreshBook.Name = "btnRefreshBook";
            this.btnRefreshBook.Size = new System.Drawing.Size(107, 33);
            this.btnRefreshBook.TabIndex = 4;
            this.btnRefreshBook.Text = "Yenile";
            this.btnRefreshBook.UseVisualStyleBackColor = true;
            this.btnRefreshBook.Click += new System.EventHandler(this.btnRefreshBook_Click);
            // 
            // txtSearchBookID
            // 
            this.txtSearchBookID.Location = new System.Drawing.Point(822, 14);
            this.txtSearchBookID.Multiline = true;
            this.txtSearchBookID.Name = "txtSearchBookID";
            this.txtSearchBookID.Size = new System.Drawing.Size(47, 32);
            this.txtSearchBookID.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 741);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // id
            // 
            this.id.FillWeight = 10F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Ad";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Soyad";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "Oluşturma Tarihi";
            this.CreationDate.MinimumWidth = 6;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Width = 90;
            // 
            // Username
            // 
            this.Username.HeaderText = "Kullanıcı Adı";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Şifre";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 87;
            // 
            // Auth
            // 
            this.Auth.HeaderText = "Yetki";
            this.Auth.MinimumWidth = 6;
            this.Auth.Name = "Auth";
            this.Auth.Width = 85;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 782);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchBookID);
            this.Controls.Add(this.txtSearchPersonID);
            this.Controls.Add(this.btnRefreshBook);
            this.Controls.Add(this.btnRefreshPerson);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.grpBoxBooks);
            this.Controls.Add(this.grpBoxMembers);
            this.Name = "Admin";
            this.Text = "Admin Sayfası";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grpBoxMembers.ResumeLayout(false);
            this.grpBoxMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.grpBoxBooks.ResumeLayout(false);
            this.grpBoxBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMembers;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtNameMember;
        private System.Windows.Forms.Label lblNameMember;
        private System.Windows.Forms.TextBox txtIDMember;
        private System.Windows.Forms.Label lblIdMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnClearMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.MaskedTextBox mskTxtDate;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox grpBoxBooks;
        private System.Windows.Forms.TextBox txtBookKind;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.TextBox txtPiece;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.Label lblIdBook;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.TextBox txtYearOfPublication;
        private System.Windows.Forms.Label lblYearOfPublication;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ImageList ımageListIcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLang;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn piece;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublication;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.TextBox txtSearchPersonID;
        private System.Windows.Forms.Button btnRefreshPerson;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnRefreshBook;
        private System.Windows.Forms.TextBox txtSearchBookID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auth;
    }
}