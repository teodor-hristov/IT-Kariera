using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise2
{
    class RacionalNumber
    {
        private List<RacionalNumber> racionalNumbersList = new List<RacionalNumber>();
        private List<int> getFinalNumberList;


        public RacionalNumber() { }
        public RacionalNumber(int numerator, int denumerator)
        {
            getFinalNumberList = new List<int>();
            this.Numerator = numerator;
            this.Denumerator = denumerator;
            getFinalNumberList.Add(Numerator / BiggestDivider(Numerator, Denumerator));
            getFinalNumberList.Add(Denumerator / BiggestDivider(Numerator, Denumerator));
        }


        public int Numerator { get; set; }
        public int Denumerator { get; set; }


        private int BiggestDivider(int numerator, int denumerator)
        {
            if (denumerator == 0)
            {
                return numerator;
            }
            else
            {
                return BiggestDivider(denumerator, numerator % denumerator);
            }
        }


        public void Print()
        {
            for (int i = 1; i < getFinalNumberList.Count; i++)
            {
                Console.WriteLine($"{getFinalNumberList[i-1]}/{getFinalNumberList[i]}");
            }
        }


    }
}
