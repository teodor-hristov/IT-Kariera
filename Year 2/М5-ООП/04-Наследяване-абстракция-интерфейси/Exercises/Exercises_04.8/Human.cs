using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises_04._8
{
    class Human : Citizenship
    {
        private int age;
        
        public Human(string name, int age, string id)
            :base(id,name)
        {
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
