using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnMeACSharp
{
    public class Program
    {

        //Implement a Generic Stack http://en.wikipedia.org/wiki/Stack_%28abstract_data_type%29
        public static void Main(string[] args)
        {
            var myList = new MyList<int>();
            var correctList = new System.Collections.Generic.List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            correctList.Add(1);
            correctList.Add(2);
            correctList.Add(3);

            myList.RemoveAt(0);
            correctList.RemoveAt(0);

            myList.Insert(1, 100);
            correctList.Insert(1, 100);


            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
