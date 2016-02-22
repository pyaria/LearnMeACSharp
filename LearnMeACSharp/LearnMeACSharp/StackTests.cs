using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearnMeACSharp
{
    public class StackTests
    {
        [Fact]
        public void PushCountCheck()
        {
            Stack<int> s = new Stack<int>();
            Assert.Equal(s.Count, 0);
            var x = new Random().Next();
            s.Push(x);
            s.Push(2);
            s.Push(3);
            Assert.Equal(s.Count, 3);
        }
        [Theory]
        [InlineData("a","b")]
        [InlineData("abcdefghijklm","nopqrstuvwxyz")]
        public void PopTest(string a, string b) {
            Stack<string> s = new Stack<string>();
            s.Push(a);
            s.Push(b);
            Assert.Equal(b, s.Pop());
            Assert.Equal(a, s.Pop());
        }
        [Theory]
        [InlineData("a", "b")]
        [InlineData("abcdefghijklm", "nopqrstuvwxyz")]
        public void PeekTest(string a, string b)
        {
            Stack<string> s = new Stack<string>();
            s.Push(a);
            s.Push(b);
            Assert.Equal(b, s.Peek());
            Assert.Equal(b, s.Pop());
            Assert.Equal(a, s.Peek());
            Assert.Equal(a, s.Peek());
            Assert.Equal(a, s.Pop());
        }
        [Fact]
        public void LargeStackTest()
        {
            int size = 5000000;
            Stack<Object> bigStack = new Stack<Object>();
            for (int i = 0; i < size; i++)
            {
                bigStack.Push(new Object());
            }
            Assert.Equal(size, bigStack.Count);
        }
        public void ExceptionTest()
        {
            var s = new Stack<int>();
            Assert.Throws(typeof(InvalidOperationException), ()=>s.Peek());
            Assert.Throws(typeof(InvalidOperationException), ()=>s.Pop());
        }
    }
}
