using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public Employee() : base() { }

        public Employee(string name, DateTime birthDate, Genders gender, double salary, string profession)
            : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public double Salary { get; set; }

        public string Profession { get; set; }


        public override string ToString()
        {
            return base.ToString() + " " + "Salary: " + Salary + " " + "Profession: " + Profession;
        }

        public Room Room = new Room();

        
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
        
        /*
        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }
        */
    }
}
