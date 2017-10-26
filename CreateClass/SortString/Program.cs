using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = str.Split(' ');
            //words.ToList().ForEach(Console.Write);
            //Console.WriteLine("{0}", string.Join(", ", words));
            string joinedBaseWords = string.Join(" ", words);
            Console.WriteLine("Base string: \n");
            Console.WriteLine(joinedBaseWords);
            Console.WriteLine("\nAfter sorting: \n");
            Array.Sort(words);
            string joinedSortedWords = string.Join(" ", words);
            Console.WriteLine(joinedSortedWords);
            //words.ToList().ForEach(Console.Write);
            //Console.WriteLine("{0}", string.Join(", ", words));



            Console.ReadLine();
        }
    }
}
