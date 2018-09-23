using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    interface IBox<T>
    {
        void Add(T element);

        T Remove();

        int Count { get; }
    }
}
