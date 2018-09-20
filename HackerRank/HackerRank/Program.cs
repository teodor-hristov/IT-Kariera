using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the formingMagicSquare function below.
    static int formingMagicSquare(int[][] s)
    {

        int minCostReplacement = 0, sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                sum += s[i][j];
            }
        }
        if (sum % s.Length == 0)
        {
            return minCostReplacement = 0;
        }
        else
        {
            for (int i = 0; i < 10000; i++)
            {
                if ((sum + i) % 9 == 0)
                {
                    return Math.Abs(i);
                }
            }
        }
        return 0;

    }

    static void Main(string[] args)
    {
        int[][] s =
{
            new int[] {4,8,2},
            new int[] {4,5,7},
            new int[] {6,1,6}
};
        Console.WriteLine(formingMagicSquare(s));
    }
}
