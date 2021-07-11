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
            foreach (Book book in books)
            {
                dgvBooksForMember.Rows.Add(book.getBookID(), book.getBookName(), book.getWriter(), book.getBookLanguage(), book.getPublisher(), book.getBookKind(), book.getPiece(), book.getNumberOfPages(), book.getyearOfPublication());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(txtBookID.Text);
            Book targetBook = null;

            foreach (Book book in books)
            {
                if (book.getBookID() == bookID)
                {
                    targetBook = book;
                }
            }

            dgvBooksForMember.Rows.Clear();
            dgvBooksForMember.Rows.Add(targetBook.getBookID(), targetBook.getBookName(), targetBook.getWriter(), targetBook.getBookLanguage(), targetBook.getPublisher(), targetBook.getBookKind(), targetBook.getPiece(), targetBook.getNumberOfPages(), targetBook.getyearOfPublication());
        }


    }
}
