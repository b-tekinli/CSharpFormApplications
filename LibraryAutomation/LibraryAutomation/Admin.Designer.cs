
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
            this.grpBoxMemberTransaction = new System.Windows.Forms.GroupBox();
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
            this.grpBoxMemberTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMemberTransaction
            // 
            this.grpBoxMemberTransaction.Controls.Add(this.mskTxtDate);
            this.grpBoxMemberTransaction.Controls.Add(this.btnUpdate);
            this.grpBoxMemberTransaction.Controls.Add(this.btnClear);
            this.grpBoxMemberTransaction.Controls.Add(this.btnDelete);
            this.grpBoxMemberTransaction.Controls.Add(this.btnAdd);
            this.grpBoxMemberTransaction.Controls.Add(this.txtPass);
            this.grpBoxMemberTransaction.Controls.Add(this.lblPass);
            this.grpBoxMemberTransaction.Controls.Add(this.txtAuth);
            this.grpBoxMemberTransaction.Controls.Add(this.lblAuth);
            this.grpBoxMemberTransaction.Controls.Add(this.txtUsername);
            this.grpBoxMemberTransaction.Controls.Add(this.lblUsername);
            this.grpBoxMemberTransaction.Controls.Add(this.lblCreationDate);
            this.grpBoxMemberTransaction.Controls.Add(this.txtSurname);
            this.grpBoxMemberTransaction.Controls.Add(this.lblSurname);
            this.grpBoxMemberTransaction.Controls.Add(this.txtName);
            this.grpBoxMemberTransaction.Controls.Add(this.lblName);
            this.grpBoxMemberTransaction.Controls.Add(this.txtID);
            this.grpBoxMemberTransaction.Controls.Add(this.lblid);
            this.grpBoxMemberTransaction.Location = new System.Drawing.Point(12, 12);
            this.grpBoxMemberTransaction.Name = "grpBoxMemberTransaction";
            this.grpBoxMemberTransaction.Size = new System.Drawing.Size(316, 724);
            this.grpBoxMemberTransaction.TabIndex = 0;
            this.grpBoxMemberTransaction.TabStop = false;
            this.grpBoxMemberTransaction.Text = "Üye İşlemleri";
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
            this.btnUpdate.Location = new System.Drawing.Point(10, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(290, 47);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 613);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(290, 47);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(10, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(290, 47);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(290, 47);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 289);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 27);
            this.txtPass.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 293);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(42, 20);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Şifre:";
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(132, 336);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(164, 27);
            this.txtAuth.TabIndex = 11;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(6, 340);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(43, 20);
            this.lblAuth.TabIndex = 10;
            this.lblAuth.Text = "Yetki:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 238);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(164, 27);
            this.txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 242);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 20);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(6, 194);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(119, 20);
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
            this.lblSurname.Location = new System.Drawing.Point(6, 152);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(53, 20);
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
            this.lblName.Location = new System.Drawing.Point(6, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 20);
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
            this.lblid.Location = new System.Drawing.Point(6, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID:";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMembers.Location = new System.Drawing.Point(690, 12);
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
            this.dgvPersons.Location = new System.Drawing.Point(334, 58);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 29;
            this.dgvPersons.Size = new System.Drawing.Size(896, 254);
            this.dgvPersons.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Ad";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Soyad";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "OluşturmaTarihi";
            this.CreationDate.MinimumWidth = 6;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Width = 125;
            // 
            // Username
            // 
            this.Username.HeaderText = "KullanıcıAdı";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Şifre";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Auth
            // 
            this.Auth.HeaderText = "Yetki";
            this.Auth.MinimumWidth = 6;
            this.Auth.Name = "Auth";
            this.Auth.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 748);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.grpBoxMemberTransaction);
            this.Name = "Admin";
            this.Text = "Admin Sayfası";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grpBoxMemberTransaction.ResumeLayout(false);
            this.grpBoxMemberTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMemberTransaction;
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
    }
}