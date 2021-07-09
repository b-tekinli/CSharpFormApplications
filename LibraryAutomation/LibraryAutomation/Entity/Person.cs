using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Entity
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime creationDate { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string authority { get; set; }


        public Person()
        {

        }


        public Person(int id, string name, string surname, DateTime creationDate, string username, string password, string authority)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.creationDate = creationDate;
            this.username = username;
            this.password = password;
            this.authority = authority;
        }


        public void setID(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
        }

        public DateTime getCreationDate()
        {
            return this.creationDate;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setAuthority(string authority)
        {
            this.authority = authority;
        }

        public string getAuthority()
        {
            return this.authority;
        }

        public override string ToString()
        {
            return "Ad - Soyad :" + this.name + " " + this.surname;
        }
    }
}
