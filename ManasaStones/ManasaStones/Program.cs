using System;
using System.Collections.Generic;

namespace ManasaStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int stones = 3;
            int a = 1;
            int b = 2;
            int val = 0;
            List<int> values = new List<int>();
            for(int i = 0; i < stones; i++)
            {
                for(int j = 0; j < stones-i; j++)
                {
                    val = +b;
                }
                values.Add(val);
                val = (i + 1) * a;
            }
            values.Sort();

            foreach (int v in values)
                Console.Write(v + " ");
            
        }
    }
}
