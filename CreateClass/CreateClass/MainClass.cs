using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class MainClass
    {
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

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine(person4);


            Employee employee1 = new Employee("Olivia", new DateTime(1980, 08, 14), Genders.Female, 34524.45, "Marketing leader");
            Employee employee2 = new Employee();
            employee2.Name = "David";
            employee2.BirthDate = new DateTime(1975, 12, 24);
            employee2.Gender = Genders.Male;
            employee2.Salary = 65500;
            employee2.Profession = "Engineer";

            Console.WriteLine(employee1);
            Console.WriteLine(employee2);


            Employee Kovacs = new Employee("Géza", DateTime.Now, Genders.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();


            //Set the name of the person
            Console.Write("Enter the name of the person: ");
            person5.Name = Console.ReadLine();

            //Set the birth date of the person
            bool correctDate = false;
            bool correctGender = false;
            while (correctDate != true)
            {
                Console.Write("Enter the birthdate of the person in this format: yyyy,mm,dd : ");
                string userInputBirthDate = Console.ReadLine();
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
                    Console.WriteLine("Invalid gender input");
                }
            }

            Console.WriteLine("\nUser created person: \n");
            Console.WriteLine(person5);


            Console.ReadLine();
        }
    }
}
