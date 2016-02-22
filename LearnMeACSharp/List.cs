using System;
using System.Text;

namespace LearnMeACSharp
{
    //Should implement this interface: https://msdn.microsoft.com/en-us/library/system.collections.ilist%28v=vs.110%29.aspx
    public class List<T> : System.Collections.Generic.IList<T>
    {
        T[] _backingArray;
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
        //Copies the elements of the ICollection to an Array, starting at a particular Array index.
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }



        public bool IsReadOnly
        {
            get{
                return false;
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
