using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client : Person
    {    

        private DateTime inscriptionDate;
        private DateTime limitDate;
        private bool banned;
        public Client(int id, string dni, string first_name, string last_name, int age, string phone, EGenre genre, DateTime inscriptionDate, DateTime limitDate) : base(id, dni, first_name, last_name, age, phone, genre) 
        { 
            this.inscriptionDate = inscriptionDate;
            this.limitDate = limitDate;  
        } 

        public Client(int id, string dni, string first_name, string last_name, int age, string phone, EGenre genre) : this(id, dni, first_name, last_name, age, phone, genre, DateTime.Today, DateTime.Today.AddDays(30))
        {           
        }
     
        public DateTime InscriptionDate { get {  return inscriptionDate; } }

        public DateTime LimitDate { get { return limitDate; } }
    }
}
