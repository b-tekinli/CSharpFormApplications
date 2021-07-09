using LibraryAutomation;
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
    public partial class Login : Form
    {
        List<Person> persons = new List<Person>();

        public Login()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password = "";

            username = txtUserName.Text;
            password = txtPassword.Text;

            bool control = false;

            foreach (Person person in persons)
            {
                if (username.ToLower() == person.getUsername() && password.ToLower() == person.getPassword() && person.authority == "admin")
                {
                    // admin sayfasına yönlendir.
                    Admin admin = new Admin(persons);
                    admin.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == person.getUsername() && password.ToLower() == person.getPassword() && person.authority == "uye")
                {
                    Member member = new Member();
                    member.Show();
                    this.Hide();
                    control = true;
                    break;
                }
            }

            if (!control)
            {
                MessageBox.Show("Hatalı Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            persons.Add(new Person(1, "Beyza", "Tekinli", DateTime.Now, "beyza", "1", "admin"));
            persons.Add(new Person(2, "Yağmur", "Güzel", DateTime.Now, "yağmur", "2", "uye"));
            persons.Add(new Person(3, "Aleyna", "Öztürk", DateTime.Now, "aleyna", "3", "uye"));
            persons.Add(new Person(4, "Bilal", "Tek", DateTime.Now, "bilal", "4", "uye"));
        }
    }
}
