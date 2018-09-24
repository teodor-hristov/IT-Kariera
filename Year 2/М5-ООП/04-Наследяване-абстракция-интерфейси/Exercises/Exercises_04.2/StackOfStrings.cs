using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._2
{
    class StackOfStrings : Stack<string>
    {
        public List<string> Data { get; private set; }
    }
}
