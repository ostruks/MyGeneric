using System.Collections.Generic;

namespace MyLibrary
{
    public class MyLinkedList<T> where T : class
    {
        private LinkedList<T> _lists;

        public MyLinkedList()
        {
            _lists = new LinkedList<T>();
        }

        public void Add(T element)
        {
            if (_lists.Count == 0)
            {
                _lists.AddFirst(element);
            }
            else
                _lists.AddAfter(_lists.Last, element);
        }

        public void InsertAt(T element, int index)
        {
            int i = 0;
            T el = null;
            if (index <= _lists.Count
                && index > 0)
            {
                foreach (var a in _lists)
                {
                    if (i + 1 == index)
                    {
                        el = a;
                        _lists.AddAfter(_lists.Find(el), element);
                        break;
                    }
                    i++;
                }
            }
        }

        public void Remove(T element)
        {
            _lists.Remove(element);
        }

        public void RemoveAt(int index)
        {
            int i = 0;
            if (index <= _lists.Count
                && index > 0)
            {
                foreach (var a in _lists)
                {
                    if (i == index)
                    {
                        _lists.Remove(a);
                        break;
                    }
                    i++;
                }
            }
        }

        public T GetElement(int index)
        {
            int i = 0;
            if(index > _lists.Count
                && index > 0)
            {
                return null;
            }
            else
            {
                foreach (var a in _lists)
                {
                    if (i == index)
                    {
                        return a;
                    }
                    i++;
                }
            }
            return null;
        }

        public IEnumerable<T> GetElements()
        {
            foreach(var a in _lists)
            {
                yield return a;
            }
        }
    }
}
