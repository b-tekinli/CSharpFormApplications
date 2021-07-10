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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvPersons.Rows.Add(Convert.ToInt32(txtID.Text), txtName.Text, txtSurname.Text, mskTxtDate.Text, txtUsername.Text, txtPass.Text, txtAuth.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvPersons.Rows.Remove(dgvPersons.CurrentRow);
        }

        public void fillInText()
        {
            txtID.Text = dgvPersons.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvPersons.CurrentRow.Cells[1].Value.ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string creationDate = mskTxtDate.Text;
            string username = txtUsername.Text;
            string pass = txtPass.Text;
            string auth = txtAuth.Text;


            dgvPersons.Rows.Remove(dgvPersons.CurrentRow);
            dgvPersons.Rows.Add(id, name, surname, creationDate, username, pass, auth);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpBoxMembers.Controls.Count; i++)
            {
                if (grpBoxMembers.Controls[i] is TextBox || grpBoxMembers.Controls[i] is MaskedTextBox)
                {
                    grpBoxMembers.Controls[i].Text = string.Empty;
                }
            }
        }
    }
}
