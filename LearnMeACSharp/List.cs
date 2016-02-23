using System;
using System.Text;

namespace LearnMeACSharp
{
    //Should implement this interface: https://msdn.microsoft.com/en-us/library/system.collections.ilist%28v=vs.110%29.aspx
    public class MyList<T> : System.Collections.Generic.IList<T>
    {
        T[] _backingArray = new T[2];
        int top = 0;
        int arrayLength = 2;
        public int Count
        {
            get { return top; }
        }
        public void Add(T item)
        {
            if(top < arrayLength)
            {
                _backingArray[top] = item;
                top++;
            }
            else
            {
                var newLength = arrayLength * 2;
                T[] newArray = new T[newLength];
                Array.Copy(_backingArray, newArray, top);
                _backingArray = newArray;
                arrayLength = newLength;
                _backingArray[top] = item;
                top++;
            }
        }

        public T this[int index]
        {
            get
            {
                return _backingArray[index];
            }
            set
            {
                _backingArray[index] = value;
            }
        }
        public int IndexOf(T item)
        {
            for (int i = 0;  i < top; i++)
            {
                if (_backingArray[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index == top)
            {
                Add(item);
            }
            else
            {
                T[] newArray = new T[top + 1];
                Array.Copy(_backingArray, newArray, index);
                newArray[index] = item;
                Array.ConstrainedCopy(_backingArray, index, newArray, index + 1, top - index);
                _backingArray = newArray;
                top++;
            }
        }

        public void RemoveAt(int index)
        {
            while (index < top - 1)
            {
                _backingArray[index] = _backingArray[index + 1];
                index++;
            }
            top--;
        }

        public void Clear()
        {
            top = 0;
            _backingArray = new T[2];          
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < top; i++)
            {
                if (_backingArray[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        //Copies the elements of the ICollection to an Array, starting at a particular Array index.
        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.ConstrainedCopy(_backingArray, 0, array, arrayIndex, top);
        }



        public bool IsReadOnly
        {
            get{
                return false;
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < top; i++)
            {
                if (_backingArray[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        //Enumerators are objects that handle iterating over a collection https://en.wikipedia.org/wiki/Iterator
        //They have special syntax in C#.
        //Check out: https://msdn.microsoft.com/library/65zzykke%28v=vs.100%29.aspx
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < top; i++)
            {
                yield return _backingArray[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < top; i++)
            {
                yield return i;
            }
        }
    }
}
