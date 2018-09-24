using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercises_04._2
{
    class RandomList : ArrayList
    {
        public int RandomNum { get => new Random().Next(0, base.Count-1); }

        public string RandomString()
        {
            string item;
            int rnd = RandomNum;
            item = base[rnd].ToString();
            base.RemoveAt(rnd);
            return item;
        }
    }
}
