using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Utils;


namespace Models
{
    internal class Teacher : Person, IEmployee
    {
        private static double salary;

        static Teacher()
        {
            Teacher.salary = 120000;
        }

        public Teacher(int id, string dni, string first_name, string last_name, int age, string phone, EGenre genre, DateTime inscriptionDate, DateTime limitDate) : base(id, dni, first_name, last_name, age, phone, genre)
        {
        } 

        public double GetSalary()
        {
            return Teacher.salary;
        }
    }
}
