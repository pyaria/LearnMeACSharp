using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnMeACSharp
{
    public class Stack<T>
    {
        int length = 2;
        T[] _backingStore = new T[2];
        int top = 0;
        public void Push(T x)
        {
            if(top < length)
            {
                _backingStore[top] = x;
                top++;
            }
            else
            {
                var newLength = length * 2;
                T[] newArray = new T[newLength];
                Array.Copy(_backingStore, newArray, top);
                _backingStore = newArray;
                length = newLength;
                _backingStore[top] = x;
                top++;
            }
        }
        public T Pop()
        {
            top--;
            return (_backingStore[top]);
   
        }
        public T Peek()
        {
            return (_backingStore[top - 1]);
        }
        public int Count {
            get
            {
                return top;
            }
        }    
    }
}
