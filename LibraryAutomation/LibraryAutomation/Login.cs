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
        List<Book> books = new List<Book>();

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
                    Admin admin = new Admin(persons, books);
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
            persons.Add(new Person(4, "Bilal", "Türkk", DateTime.Now, "bilal", "4", "uye"));
            persons.Add(new Person(5, "Şevval", "Tekinli", DateTime.Now, "sevval", "5", "uye"));


            books.Add(new Book(1, "İçimizdeki Şeytan", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            books.Add(new Book(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
            books.Add(new Book(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 100, 350, 2010));
            books.Add(new Book(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can Çocuk Yayınları", "Roman", 50, 60, 2018));
            books.Add(new Book(5, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 650, 220, 2015));
            // books.Add(new Book(6, "Tehlikeli Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 420, 500, 2018));
        }
    }
}
