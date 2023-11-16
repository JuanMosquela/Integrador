using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person
    {
        private int id;
        private string dni;
        private string first_name;
        private string last_name;
        private int age;
        private string phone;
        
        private EGenre genre;

        public Person (int id, string dni, string first_name, string last_name, int age, string phone, EGenre genre)
        {
            this.id = id;
            this.dni = dni;
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.phone = phone;
            this.genre = genre;

        }

        public int Id { get { return this.id;  }  }

        public string Dni { get { return this.dni; } }

        public string FirstName { get { return first_name; } set { this.first_name = value; } }

        public string LastName { get { return last_name; } }

        public string FullName { get { return $"{first_name} {last_name}"; } }        

        public int Age { get { return age; } }

        public string Phone { get { return phone; } }

        public EGenre Genre { get { return genre; } }

        protected virtual bool IsValidDNI(string dni)
        {
            return false;
        }
       
    }

        public enum EGenre { MALE, FEM, NONE }
}
