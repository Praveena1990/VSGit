using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Update From GitHub
            int sum = addNumbers(10 , 12);
            Console.WriteLine("Sum of Numbers "+sum);
            Console.ReadLine();

            //Update from VS
        }

        private static int addNumbers(int v1 , int v2)
        {
            return v1 + v2;
        }
    }
}
