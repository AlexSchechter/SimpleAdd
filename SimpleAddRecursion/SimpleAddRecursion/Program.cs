using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAddRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a positive integer: ");
            SimpleAdd(Console.ReadLine());
            
        }

        private static int SimpleAdd(string number)
        {
            if (number > 1)
                number = number + SimpleAdd (number -1)
            else
                return number;
        }
    }

   
}
