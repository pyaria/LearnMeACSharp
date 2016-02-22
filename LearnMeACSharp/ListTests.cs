using System;
using LearnMeACSharp;
using System.Linq;
using Xunit;
namespace LearnMeACSharpTests
{
    public class ListTests
    {
        [Fact]
        public void AddTest()
        {
            var controlList = new System.Collections.Generic.List<int>();
            System.Collections.Generic.IList<int> testList = new List<int>();

            var r = new System.Random();
            for (int i = 0; i < 1000; i++)
            {
                var next = r.Next();
                controlList.Add(next);
                testList.Add(next);
                Assert.Equal(controlList.Count, testList.Count);
            }

        }

        [Fact]
        public void AddIndexAndValueCheckTest()
        {
            System.Collections.Generic.IList<int> testList = new List<int>();
            var controlList = new System.Collections.Generic.List<int>();
            var r = new System.Random();
            for (int i = 0; i < 1000; i++)
            {
                var next = r.Next();
                controlList.Add(next);
                testList.Add(next);
                Assert.Equal(controlList.Count, testList.Count);
            }
            for (int i = 0; i < 1000; i++)
            {
                Assert.True(testList.IndexOf(controlList[i]) == i);
            }

        }
        [Fact]
        public void AddAndRemoveAtTest()
        {
            var controlList = new System.Collections.Generic.List<int>();
            System.Collections.Generic.IList<int> testList = new List<int>();
            var r = new System.Random();
            for (int i = 0; i < 1000; i++)
            {
                var next = r.Next();
                controlList.Add(next);
                testList.Add(next);
                Assert.Equal(controlList.Count, testList.Count);
            }
            for (int i = 0; i < controlList.Count; i++)
            {
                if (r.Next() < int.MaxValue / 2)
                {
                    testList.RemoveAt(i);
                    controlList.RemoveAt(i);
                }
            }
            Assert.Equal(testList.Count, controlList.Count);
            for (int i = 0; i < controlList.Count; i++)
            {
                Assert.True(testList.IndexOf(controlList[i]) == i);
            }

        }
        [Fact]
        public void ListRNDTest()
        {
            System.Collections.Generic.IList<int> testList = new List<int>();
            var controlList = new System.Collections.Generic.List<int>();
            var r = new System.Random();
            for (int i = 0; i < 1000; i++)
            {
                var next = r.Next();
                controlList.Add(next);
                testList.Add(next);
                Assert.Equal(controlList.Count, testList.Count);
            }
            for (int i = 0; i < 1000; i++)
            {
                Assert.True(testList.IndexOf(controlList[i]) == i);
            }
            for (int i = 0; i < controlList.Count; i++)
            {
                if (r.Next() < int.MaxValue / 2)
                {
                    testList.RemoveAt(i);
                    controlList.RemoveAt(i);
                }
                else
                {
                    var newItem = r.Next();
                    testList.Insert(i, newItem);
                    controlList.Insert(i, newItem);
                }
            }
            Assert.Equal(controlList.Count, testList.Count);


            foreach (var itm in controlList){
                Assert.True(testList.Contains(itm));    
            }
            for (int i = 0; i < controlList.Count / 2; i++ )
            {
                var e = controlList[i];
                controlList.Remove(e);
                testList.Remove(e);
            }
            Assert.Equal(controlList.Count, testList.Count);

            int[] controllarray = new int[controlList.Count+1];
            int[] testArray = new int[testList.Count+1];
            controllarray[0] = r.Next();
            testArray[0] = controllarray[0];
            controlList.CopyTo(controllarray, 1);
            testList.CopyTo(testArray, 1);

            var q = from a in testArray
                    join b in controllarray on a equals b
                    select a;


            Assert.True(testArray.Length == controllarray.Length && q.Count() == controllarray.Length);
            controlList.Clear();
            testList.Clear();
            Assert.Equal(controlList.Count,testList.Count);
        }
    }
}
