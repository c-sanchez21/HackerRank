using System;
using System.Collections.Generic;

namespace ManasaStones
{
    class Program
    {
        //Problem: https://www.hackerrank.com/challenges/manasa-and-stones/problem
        static void Main(string[] args)
        {
            int[] res = stones(4, 10, 100);
        }
        public static int[] stones(int n, int a, int b)
        {
            List<int> values = new List<int>();//Possible values of last stone
            int val;
            n--;//First stone is always zero
            for (int i = n; i >= 0; i--)
            {
                val = 0;
                val += i * a;
                val += (n - i) * b;
                if (!values.Contains(val))
                    values.Add(val);
            }
            values.Sort();
            return values.ToArray();
        }
    }
}
