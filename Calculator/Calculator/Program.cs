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
            Console.WriteLine("Sum of Number "+sum);
            Console.ReadLine();
        }

        private static int addNumbers(int v1 , int v2)
        {
            return v1 + v2;
        }
    }
}
