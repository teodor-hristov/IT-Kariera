using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Box<T> : IBox<T>
    {
        int DEFAULT_LIST_SIZE = 0;
        private List<T> itemHolder;

        public List<T> ItemHolder
        {
            get { return itemHolder; }
            set { itemHolder = value; }
        }

        public Box()
        {
            itemHolder = new List<T>();
            Count = DEFAULT_LIST_SIZE;
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            itemHolder.Add(element);
        }


        public T Remove()
        {
            T item = ItemHolder.Last();
            ItemHolder.Remove(item);
            return item;
        }


        public override string ToString()
        {
            string str = "";
            
            foreach (T item in ItemHolder)
            {
                str += $"{item.GetType().FullName}: {item}\n";
            }
            return str;
        }
    }
}
