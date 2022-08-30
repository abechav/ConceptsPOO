using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        //Atribute
        private string _firtsName;

        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        //Methods
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName} - Birth: {BirthDate} - Hiring: {HiringDate} - Is Active: {IsActive}";
        }
    }
}
