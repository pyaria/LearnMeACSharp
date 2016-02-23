using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnMeACSharp
{
    public static class FunctionalPractice
    {
        //Add one to each element, and then sum the collection
        public static int AddOneToAllAndSum(IEnumerable<int> input){
            int summed = 0;
            foreach (int element in input)
            {
                summed += element + 1;
            }
            return summed;
        }

        //Return an array that has two copies of any value that appears only a single time across both lists
        public static int[] DuplicateUniques(IEnumerable<int> a,IEnumerable<int> b){
            //You might use SelectMany, and some of these http://msdn.microsoft.com/en-us/library/bb546153.aspx
            //You probably also need .ToArray() to satisfy the signature
            int[] newArray = a.ToArray();
            foreach (int element in a)
            {
                if (b.Contains(element))
                {

                }
            }
        }

        //Returns a function that multiplies its input by the parameter 'a' below.
        public static Func<int, int> MultiplyBy(int a){
            // Lambda syntax (input parameters) => expression
            // Or http://msdn.microsoft.com/en-us/library/bb397687.aspx
            throw new System.NotImplementedException();
        }
    }
    
}
