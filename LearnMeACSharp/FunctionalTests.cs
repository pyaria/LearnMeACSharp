using System;
using LearnMeACSharp;
using System.Linq;
using Xunit;
namespace LearnMeACSharpTests
{
    public class FunctionalTests
    {
       
        [Fact]
        public void FunctionTest()
        {
            int[] t = {1,2,3,4};
            Assert.Equal(FunctionalPractice.AddOneToAllAndSum(t), 14);

            int[] u = { };
            Assert.Equal(FunctionalPractice.AddOneToAllAndSum(u), 0);
        }
        [Fact]
        public void DuplicateUniqueTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 2, 3, 4 };
            Assert.Equal(new int[]{1,1,4,4}, FunctionalPractice.DuplicateUniques(a,b));

            int[] c = { 1, 2, 3, 4, 5, 7, 8, 10 };
            int[] d = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(new int[] {6, 6, 9, 9 }, FunctionalPractice.DuplicateUniques(c, d));

            int[] e = { 1, 1, 2 };
            int[] f = { 2, 3 };
            Assert.Equal(new int[] { 3, 3 }, FunctionalPractice.DuplicateUniques(e, f));

            f.GroupBy((int x) =>
            
                ""
            );

        }
      
        [Fact]
        public void MultiplyByTest()
        {


            var multBy5 = FunctionalPractice.MultiplyBy(5);
            var result = multBy5(3);
            var result1 = multBy5(4);
            var result2 = multBy5(5);
            Assert.Equal(1, FunctionalPractice.MultiplyBy(1)(1));
            Assert.Equal(4, FunctionalPractice.MultiplyBy(2)(2));
            Assert.Equal(15, multBy5(3));

        }
    }
}
