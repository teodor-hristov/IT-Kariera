using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._5
{
    class Citizen : IPerson, IBirthable, IIdentifiable
    {

        private string birthdate;
        private string id;
        private string name;
        private int age;
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Age = age;
            this.Name = name;
            this.Id = id;
            this.Birthdate = birthdate;


        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        

        public string Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

    }
}
