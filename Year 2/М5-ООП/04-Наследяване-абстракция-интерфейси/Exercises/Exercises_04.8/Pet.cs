using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._8
{
    class Pet : IBirthable, IUnique
    {
        
        private DateTime dateOfBirth;
        private string name;

        public Pet(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }

        public string Id { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        
    }
}
