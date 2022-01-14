using System;
using System.Collections.Generic;

namespace MyNumberOneQuestion
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> Input = new List<int>(){7 , 10, 18, 06, 23, 27, 29, 66,26, 25};
            LargestInPut(Input);
           // Console.WriteLine();
        }
        public static void LargestInPut(List<int> Input)
        {
            string ReturnOutput = string.Empty;
            List<string> newInputList = Input.ConvertAll<string>
            (delegate(int x){return x.ToString();});
            newInputList.Sort(CompareElement);

            for(int k = 0; k < Input.Count; k++)
            {
                ReturnOutput = ReturnOutput + newInputList[k];
            }
            if(ReturnOutput[0] == '0' && ReturnOutput.Length > 1)
            {
                Console.Write("0");
            }
            Console.Write(ReturnOutput);
        }
        public static int CompareElement(string i, string j)
        {
            string ij = i + j;
            string ji = j + i;
            
            return ij.CompareTo(ji) > 0 ? - 1 : 1;

        }
    }
}
