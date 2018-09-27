using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises_04._8
{
    class Human : Citizenship, IBirthable
    {
        private int age;
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        public Human(string name, int age, string id, DateTime birthDate)
            :base(id,name)
        {
            this.Age = age;
            this.DateOfBirth = birthDate;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
