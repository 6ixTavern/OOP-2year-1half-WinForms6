using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    public class MyСontainer<T>
    {
        private LinkedList<T> LinkedList;
        public MyСontainer()
        {
            LinkedList = new LinkedList<T>();
        }
        public T First()
        {
            return LinkedList.First();
        }
        public T Last()
        {
            return LinkedList.Last();
        }
        public int Count() => LinkedList.Count();
        public void Clear()
        {
            LinkedList.Clear();
        }
        public void RemoveLast()
        {
            LinkedList.RemoveLast();
        }
        public void RemoveFirst()
        {
            LinkedList.RemoveFirst();
        }
        public bool Remove(T value)
        {
            return LinkedList.Remove(value);
        }
        public void Remove(LinkedListNode<T> node)
        {
            LinkedList.Remove(node);
        }
        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedList.AddFirst(node);
        }
        public void AddFirst(T value)
        {
            LinkedList.AddFirst(value);
        }
        public void AddLast(LinkedListNode<T> node)
        {
            LinkedList.AddLast(node);
        }
        public void AddLast(T value)
        {
            LinkedList.AddLast(value);
        }
        public bool Contains(T value)
        {
            return LinkedList.Contains(value);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedList.CopyTo(array, arrayIndex);
        }
        public LinkedListNode<T> Find(T value)
        {
            return LinkedList.Find(value);
        }
        public LinkedList<T>.Enumerator GetEnumerator()
        {
            return LinkedList.GetEnumerator();
        }
        public MyСontainer<T> FindAll(Predicate<T> filter)
        {
            MyСontainer<T> result = new MyСontainer<T>();
            var item = LinkedList.First;
            while (item != null)
            {
                if (filter(item.Value))
                    result.AddLast(item.Value);
                item = item.Next;
            }
            return result;
        }
    }
}
