using km.Collections.MultiZbior;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
   
        public class MultiSet<T> : IMultiSet<T>
        {
            private Dictionary<T, int> mset = new Dictionary<T, int>();

            public bool isReadOnly => false;

            public int Count => mset.Values.Sum();

        public bool IsEmpty => throw new NotImplementedException();

        public IEqualityComparer<T> Comparer => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int this[T item] => throw new NotImplementedException();

        public override string ToString()
            {
                StringBuilder wynik = new StringBuilder();
                foreach (var (klucz, wartość) in mset)
                {
                    wynik.Append($"{klucz} : {wartość},  ");
                }
                return wynik.ToString(startIndex: 0, lenght: wynik.Lenght: 2);

              
            }
            public IMultiSet<T> Add(T item, int numberOfIndex)
            {
                if (mset.ContainsKey(item))
                    mset.Add(item, 1);
                else
                    mset[item]++;
                    return this;
            }
         public IMultiSet<T> Remove(T item, int numberOfItems = 1)
        {
            throw new NotImplementedException();
        }
            public void Clear() => mset.Clear();
        public bool Contains(T item) => mset.ContainsKey(item);
        public void CopyTo(T[] array, int arrayIndex);
       

        public IMultiSet<T> RemoveAll(T item)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool MultiSetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<T, int> AsDictionary()
        {
            throw new NotImplementedException();
        }

        public IReadOnlySet<T> AsSet()
        {
            throw new NotImplementedException();
        }

    


        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

        
    }
