using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models
{
    internal class Recepcionist : Person, IEmployee
    {
        private static double salary;
        static Recepcionist()
        {
            Recepcionist.salary = 90000;
        }

        public Recepcionist(int id, string dni, string first_name, string last_name, int age, string phone, EGenre genre) : base(id, dni, first_name, last_name, age, phone, genre)
        {           
        }
        public double GetSalary()
        {
            return salary;
        }
    }
}
