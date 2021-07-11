using LibraryAutomation.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Member : Form
    {
        List<Book> books;

        public Member(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Member_Load(object sender, EventArgs e)
        {

        }
    }
}
