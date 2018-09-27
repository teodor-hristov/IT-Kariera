using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercises_04._8
{
    abstract class Citizenship : ILiving, IPermission, IReal
    {
        private string id;
        private string name;

        private bool isFake;

        public bool IsFake
        {
            get { return isFake; }
            set { isFake = value; }
        }

        public Citizenship(string id, string name)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public bool Check(string lastNums)
        {
            if (Regex.IsMatch(this.Id, lastNums))
            {
                IsFake = true;
            }
            else
            {
                IsFake = false;
            }
            return isFake;

        }



    }
}
