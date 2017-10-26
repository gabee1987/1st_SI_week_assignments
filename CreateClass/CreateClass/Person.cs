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
        public Person() { }

        public Person(string name, DateTime birthDate, Genders gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public Genders Gender { get; set; }


        public override String ToString()
        {
            return "Name: " + Name + " " + "BirthDate: " + BirthDate.ToString("MM/dd/yyyy") + " " + "Gender: " + Gender;
        }

        
    }
}
