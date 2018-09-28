using System;

namespace Exercise_06._5
{
    class App
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>("pesho","gosho","qsen");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Push("pesho1", "gosho1", "qsen1");
            stack.Pop();
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
