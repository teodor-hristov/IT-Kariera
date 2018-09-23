using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethodsAndInterfaces
{
    interface IBox<T>
    {
        void Add(T element);

        T Remove();

        int Count { get; }
    }
}
