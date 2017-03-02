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
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j < (num - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine();

            }

            for (int i = num-1; i > 0; i--)
            {
                for (int j = 0; j < (num-i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" {0}",i);
                }
                Console.WriteLine();

            }
        }
    }
}
