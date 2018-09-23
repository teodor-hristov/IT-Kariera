﻿using System;

namespace Generics
{
    class SetUp
    {
        static void Main()
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.ToString());
        }
    }
}
