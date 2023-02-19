using System;
using System.Collections.Generic;

namespace GenerateBinaryNums
{
     class Program
    {
        static void Main(string[] args)
        {
            var queueOfBinary = GenerateBinary(10);
           string res = string.Join(",",queueOfBinary);
            Console.WriteLine(res);
        }

        private static int ConvertToBinary(int dec)
        {
            string binary = Convert.ToString(dec, 2);
            return Convert.ToInt32(binary);
        }

        public static Queue<int> GenerateBinary(int N)
        {
            Queue<int> queue = new Queue<int>();

           for(int i = 1; i <= N; i++)
            {
               int result = ConvertToBinary(i); 
                queue.Enqueue(result);  
               
            }
            return queue;
        }

        
    }
}

// create a method that generates binary 
//create a new Queue of integer q
//declare a loop that will loop N number of times
//for each looping,we  enqueue the value of binary numbers btw 1 and N
//return queue

/* int value = 8;
               string binary = Convert.ToString(value, 2);*/

