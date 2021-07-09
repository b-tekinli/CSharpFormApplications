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

        public Admin(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
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
    }
}
