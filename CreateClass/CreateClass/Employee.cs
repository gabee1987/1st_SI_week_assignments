using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        double salary;
        string profession;

        public Employee() : base() { }

        public Employee(string name, DateTime birthDate, Genders gender, double salary, string profession)
            : base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public float Salary { get; set; }

        public string Profession { get; set; }


        public override string ToString()
        {
            return base.ToString() + " " + "Salary: " + this.salary + " " + "Profession: " + this.profession;
        }

        Room room = new Room();
    }
}
