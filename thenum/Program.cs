using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thenum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());

            ////taking care for the upper part of the pyramid
            //for (int i = 0; i <= num; i++)
            //{
            //    for (int j = 0; j < (num - i); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" {0}", i);
            //    }
            //    Console.WriteLine();

            //}
            ////taking care for the bottom part of the pyramid
            //for (int i = num-1; i > 0; i--)
            //{
            //    for (int j = 0; j < (num-i); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" {0}",i);
            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine("ENTER NEW NUMBER");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("enter number of seconds");
            //int count = int.Parse(Console.ReadLine());
            //int hours = 0;
            //int minutes = count / 60;
            //int seconds = count % 60;
            //if (minutes >= 60)
            //{
            //    hours = minutes / 60;
            //    minutes = minutes % 60;
            //}
            //Console.WriteLine("hours is {0}", hours);
            //Console.WriteLine("minutes is {0}", minutes);
            //Console.WriteLine("seconds is {0}", seconds);

            // is the number a primary number
            Console.WriteLine("give me a number");
            int theNum = int.Parse(Console.ReadLine());
            int[] myArray = new int [theNum];
            
                for (int i = 2; i < theNum; i++)
                {
                    if (theNum % i == 0)
                    {
                        myArray[i]=1;                      
                    }
                }
            string test = "yes primary";
            for (int i = 2; i < theNum; i++)
            {
                if (myArray[i] == 1)
                {
                    test = "not primary";
                }
            }
            Console.WriteLine("the number is {0} ",test);
            

        }
    }
}
