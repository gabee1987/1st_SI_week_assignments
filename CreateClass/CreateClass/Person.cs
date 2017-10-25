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
        private String Name { get; set; }
        private DateTime BirthDate { get; set; }
        private Genders Gender { get; set; }

        public Person() { }

        public Person(string Name, DateTime BirthDate, Genders Gender)
        {
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
        }

        public override String ToString()
        {
            return "Person: " + this.Name + " " + this.BirthDate.ToString("dd/mm/yyyy") + " " + this.Gender;
        }

        static void Main(string[] args)
        {
            Person person1 = new Person("John", new DateTime(1985, 05, 21), Genders.Male);
            Person person2 = new Person("Edward", new DateTime(1974, 11, 15), Genders.Male);
            Person person3 = new Person("Nancy", new DateTime(1990, 01, 02), Genders.Female);
            Person person4 = new Person();
            Person person5 = new Person();

            person4.Name = "Carol";
            person4.BirthDate = new DateTime(1989, 03, 24);
            person4.Gender = Genders.Female;


            //Set the name of the person
            Console.Write("Enter the name of the person: ");
            person5.Name = Console.ReadLine();

            //Set the birth date of the person
            bool correctDate = false;
            bool correctGender = false;
            while (correctDate != true)
            {
                Console.Write("Enter the birthdate of the person in this format: yyyy,mm,dd : ");
                var userInputBirthDate = Console.ReadLine();
                DateTime birthDate;
                if (DateTime.TryParse(userInputBirthDate, out birthDate))
                {
                    person5.BirthDate = birthDate;
                    correctDate = true;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect date format.");
                }
            }
            while (correctGender != true)
            {

                //Set the gender of the person
                Console.Write("Enter the gender of the person: ");
                String userInputGender = Console.ReadLine().ToLower();
                if (userInputGender == "male")
                {
                    person5.Gender = Genders.Male;
                    correctGender = true;
                }
                else if (userInputGender == "female")
                {
                    person5.Gender = Genders.Female;
                    correctGender = true;
                }
                else
                {
                    throw new ApplicationException("Invalid gender input");
                }
            }


            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine(person4);
            Console.WriteLine("\nUser created person: \n");
            Console.WriteLine(person5);




            Console.ReadLine();
        }
    }
}
