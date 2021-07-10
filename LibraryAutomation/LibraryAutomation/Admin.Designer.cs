
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
            this.grpBoxMembers = new System.Windows.Forms.GroupBox();
            this.mskTxtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBoxMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.grpBoxBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMembers
            // 
            this.grpBoxMembers.Controls.Add(this.mskTxtDate);
            this.grpBoxMembers.Controls.Add(this.btnUpdate);
            this.grpBoxMembers.Controls.Add(this.btnClear);
            this.grpBoxMembers.Controls.Add(this.btnDelete);
            this.grpBoxMembers.Controls.Add(this.btnAdd);
            this.grpBoxMembers.Controls.Add(this.txtPass);
            this.grpBoxMembers.Controls.Add(this.lblPass);
            this.grpBoxMembers.Controls.Add(this.txtAuth);
            this.grpBoxMembers.Controls.Add(this.lblAuth);
            this.grpBoxMembers.Controls.Add(this.txtUsername);
            this.grpBoxMembers.Controls.Add(this.lblUsername);
            this.grpBoxMembers.Controls.Add(this.lblCreationDate);
            this.grpBoxMembers.Controls.Add(this.txtSurname);
            this.grpBoxMembers.Controls.Add(this.lblSurname);
            this.grpBoxMembers.Controls.Add(this.txtName);
            this.grpBoxMembers.Controls.Add(this.lblName);
            this.grpBoxMembers.Controls.Add(this.txtID);
            this.grpBoxMembers.Controls.Add(this.lblid);
            this.grpBoxMembers.Location = new System.Drawing.Point(18, 337);
            this.grpBoxMembers.Name = "grpBoxMembers";
            this.grpBoxMembers.Size = new System.Drawing.Size(664, 377);
            this.grpBoxMembers.TabIndex = 0;
            this.grpBoxMembers.TabStop = false;
            this.grpBoxMembers.Text = "Üye İşlemleri";
            // 
            // mskTxtDate
            // 
            this.mskTxtDate.Location = new System.Drawing.Point(131, 194);
            this.mskTxtDate.Mask = "00/00/0000 90:00:00";
            this.mskTxtDate.Name = "mskTxtDate";
            this.mskTxtDate.Size = new System.Drawing.Size(165, 27);
            this.mskTxtDate.TabIndex = 13;
            this.mskTxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(356, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(290, 59);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(356, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(290, 59);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(356, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(290, 59);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(356, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(290, 59);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 293);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 27);
            this.txtPass.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPass.Location = new System.Drawing.Point(0, 298);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(46, 18);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Şifre:";
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(132, 340);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(164, 27);
            this.txtAuth.TabIndex = 11;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuth.Location = new System.Drawing.Point(0, 345);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(47, 18);
            this.lblAuth.TabIndex = 10;
            this.lblAuth.Text = "Yetki:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 242);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(164, 27);
            this.txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(0, 247);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 18);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreationDate.Location = new System.Drawing.Point(0, 199);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(129, 18);
            this.lblCreationDate.TabIndex = 6;
            this.lblCreationDate.Text = "Oluşturma Tarihi:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(132, 142);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 27);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(6, 145);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 18);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Soyad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 27);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(6, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 27);
            this.txtID.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(6, 46);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 18);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID:";
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
            // 
            // Auth
            // 
            this.Auth.HeaderText = "Yetki";
            this.Auth.MinimumWidth = 6;
            this.Auth.Name = "Auth";
            this.Auth.Width = 85;
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
            this.dgvBooks.Size = new System.Drawing.Size(746, 238);
            this.dgvBooks.TabIndex = 3;
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
            // 
            // writer
            // 
            this.writer.HeaderText = "Yazar";
            this.writer.MinimumWidth = 6;
            this.writer.Name = "writer";
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
            this.publisher.HeaderText = "Yayın Adı";
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
            this.yearOfPublication.HeaderText = "Yayın Yılı";
            this.yearOfPublication.MinimumWidth = 6;
            this.yearOfPublication.Name = "yearOfPublication";
            this.yearOfPublication.Width = 80;
            // 
            // grpBoxBooks
            // 
            this.grpBoxBooks.Controls.Add(this.maskedTextBox1);
            this.grpBoxBooks.Controls.Add(this.button1);
            this.grpBoxBooks.Controls.Add(this.button2);
            this.grpBoxBooks.Controls.Add(this.button3);
            this.grpBoxBooks.Controls.Add(this.button4);
            this.grpBoxBooks.Controls.Add(this.textBox1);
            this.grpBoxBooks.Controls.Add(this.label1);
            this.grpBoxBooks.Controls.Add(this.textBox2);
            this.grpBoxBooks.Controls.Add(this.label2);
            this.grpBoxBooks.Controls.Add(this.textBox3);
            this.grpBoxBooks.Controls.Add(this.label3);
            this.grpBoxBooks.Controls.Add(this.label4);
            this.grpBoxBooks.Controls.Add(this.textBox4);
            this.grpBoxBooks.Controls.Add(this.label5);
            this.grpBoxBooks.Controls.Add(this.textBox5);
            this.grpBoxBooks.Controls.Add(this.label6);
            this.grpBoxBooks.Controls.Add(this.textBox6);
            this.grpBoxBooks.Controls.Add(this.label7);
            this.grpBoxBooks.Location = new System.Drawing.Point(708, 337);
            this.grpBoxBooks.Name = "grpBoxBooks";
            this.grpBoxBooks.Size = new System.Drawing.Size(746, 377);
            this.grpBoxBooks.TabIndex = 0;
            this.grpBoxBooks.TabStop = false;
            this.grpBoxBooks.Text = "Kitap İşlemleri";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(131, 194);
            this.maskedTextBox1.Mask = "00/00/0000 90:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(165, 27);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(356, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(356, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 59);
            this.button2.TabIndex = 12;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(356, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(290, 59);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(356, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 59);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 27);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şifre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 27);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yetki:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 27);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oluşturma Tarihi:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 27);
            this.textBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soyad:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 27);
            this.textBox5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ad:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 27);
            this.textBox6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 748);
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.MaskedTextBox mskTxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auth;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLang;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn piece;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfPublication;
        private System.Windows.Forms.GroupBox grpBoxBooks;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
    }
}