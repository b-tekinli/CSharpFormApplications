﻿using LibraryAutomation.Entity;
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
    public partial class Admin : Form
    {
        List<Person> persons;
        List<Book> books;

        public Admin(List<Person> persons, List<Book> books)
        {
            InitializeComponent();
            this.persons = persons;
            this.books = books;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach (Person person in persons)
            {
                dgvPersons.Rows.Add(person.getID(), person.getName(), person.getSurname(), person.getCreationDate(), person.getUsername(), person.getPassword(), person.getAuthority());
            }

            foreach (Book book in books)
            {
                dgvBooks.Rows.Add(book.getBookID(), book.getBookName(), book.getWriter(), book.getBookLanguage(), book.getPublisher(), book.getBookKind(), book.getPiece(), book.getNumberOfPages(), book.getyearOfPublication());
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            dgvPersons.Rows.Add(Convert.ToInt32(txtIDMember.Text), txtNameMember.Text, txtSurname.Text, mskTxtDate.Text, txtUsername.Text, txtPass.Text, txtAuth.Text);
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            dgvPersons.Rows.Remove(dgvPersons.CurrentRow);
        }

        public void fillInText()
        {
            txtIDMember.Text = dgvPersons.CurrentRow.Cells[0].Value.ToString();
            txtNameMember.Text = dgvPersons.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgvPersons.CurrentRow.Cells[2].Value.ToString();
            mskTxtDate.Text = dgvPersons.CurrentRow.Cells[3].Value.ToString();
            txtUsername.Text = dgvPersons.CurrentRow.Cells[4].Value.ToString();
            txtPass.Text = dgvPersons.CurrentRow.Cells[5].Value.ToString();
            txtAuth.Text = dgvPersons.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillInText();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            string id = txtIDMember.Text;
            string name = txtNameMember.Text;
            string surname = txtSurname.Text;
            string creationDate = mskTxtDate.Text;
            string username = txtUsername.Text;
            string pass = txtPass.Text;
            string auth = txtAuth.Text;


            dgvPersons.Rows.Remove(dgvPersons.CurrentRow);
            dgvPersons.Rows.Add(id, name, surname, creationDate, username, pass, auth);
        }

        private void btnClearMember_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpBoxMembers.Controls.Count; i++)
            {
                if (grpBoxMembers.Controls[i] is TextBox || grpBoxMembers.Controls[i] is MaskedTextBox)
                {
                    grpBoxMembers.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            dgvBooks.Rows.Add(Convert.ToInt32(txtIdBook.Text), txtNameBook.Text, txtWriter.Text, txtLang.Text, txtPublisher.Text, txtBookKind.Text, txtPiece.Text, txtNumberOfPages.Text, txtYearOfPublication.Text);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            dgvBooks.Rows.Remove(dgvBooks.CurrentRow);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string bookID = txtIdBook.Text;
            string bookName = txtNameBook.Text;
            string writer = txtWriter.Text;
            string bookLanguage = txtLang.Text;
            string publisher = txtPublisher.Text;
            string bookKind = txtBookKind.Text;
            string piece = txtPiece.Text;
            string numberOfPages = txtNumberOfPages.Text;
            string yearOfPublication = txtYearOfPublication.Text;

            dgvBooks.Rows.Remove(dgvBooks.CurrentRow);
            dgvBooks.Rows.Add(bookID, bookName, writer, bookLanguage, publisher, bookKind, piece, numberOfPages, yearOfPublication);
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpBoxBooks.Controls.Count; i++)
            {
                if (grpBoxBooks.Controls[i] is TextBox)
                {
                    grpBoxBooks.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdBook.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtNameBook.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtWriter.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            txtLang.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            txtPublisher.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString();
            txtBookKind.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            txtPiece.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            txtNumberOfPages.Text = dgvBooks.CurrentRow.Cells[7].Value.ToString();
            txtYearOfPublication.Text = dgvBooks.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
