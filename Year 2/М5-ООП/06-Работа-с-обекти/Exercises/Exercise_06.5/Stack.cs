using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_06._5
{
    class Stack<T>
    {
        private List<T> container;

        private class StackIterator<T> : IEnumerator<T>
        {
            private readonly List<T> container;
            private int counter;
            public StackIterator(List<T> container)
            {
                this.Reset();
                container.Reverse();
                this.container = container;
                
            }
            public T Current => this.container[counter];
            object IEnumerator.Current => this.Current;
            public void Dispose(){}
            public bool MoveNext() => this.counter++ < this.container.Count-1;
            public void Reset() => this.counter = -1;
        }

        public Stack(params T[] items)
        {
            container = new List<T>(items);
        }

        public T Pop()
        {
            T temp = container.Last();
            container.Remove(temp);
            return temp;
        }

        public T Peek()
        {
            T temp = container.Last();
            return temp;
        }

        public void Push(params T[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                container.Add(item[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StackIterator<T>(this.container);
        }

    }
}
