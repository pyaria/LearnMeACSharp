using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace LearnMeACSharp
{
    public class Program
    {

        //Implement a Generic Stack http://en.wikipedia.org/wiki/Stack_%28abstract_data_type%29
        static Func<int, int> addNToInput(int n)
        {
            return (x => x + n);
        }
        public static void Main(string[] args)
        {
            Func<int, int> addOneToInput = addNToInput(1);
            Console.WriteLine(addOneToInput(2)); //result = 3;

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }

    
}
