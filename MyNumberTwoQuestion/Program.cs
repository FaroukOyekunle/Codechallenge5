using System;

namespace MyNumberTwoQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
             int []arr = {1, 3, 2, 5, 7, 3 };
           int k = arr.Length;

           k = DuplicateValue(arr, k);

           for(int i = 0; i < k; i++)
           {
               Console.WriteLine(arr[i] );
           }
        }
        
    }
}
