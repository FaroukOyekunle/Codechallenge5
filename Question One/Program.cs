using System;
using System.Collections.Generic;

namespace Question_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int x = 1, y = 1; y <= UserInput; x++, y += 1 )
            {
                list.Add(y);
            }
            Console.WriteLine(list.Count);


          //  FirstStair();
        }
        // static void FirstStairCase()
        // {
        //     int InitCount = 0;
        //     int fk = 1;
        //     for(int i = 0; i < InitCount; i++)
        //     {
        //         InitCount -= fk;
        //         fk++;
        //     }
        //     Console.WriteLine( fk -1);
      // }
    }
}
