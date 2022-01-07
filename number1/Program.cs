using System;
using System.Collections.Generic;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        static void Plist(List<int> k, int i)
        {
            for(int p = i; p < k.Count; p++)
            {
                Console.Write(k[p] + " ");
                Console.WriteLine();
            }
        }
      

    }
}
