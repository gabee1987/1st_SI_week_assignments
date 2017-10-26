using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Genders { Male, Female };

    class Person
    {
        private string name;
        private DateTime birthDate;
        private Genders gender;

        public Person() { }

        public Person(string name, DateTime birthDate, Genders gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Genders Gender { get; set; }


        public override String ToString()
        {
            return "Name: " + this.name + " " + "BirthDate: " + this.birthDate.ToString("dd/mm/yyyy") + " " + "Gender: " + this.gender;
        }

        
    }
}
