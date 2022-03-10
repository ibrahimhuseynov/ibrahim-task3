using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(number(5));
            Console.ReadLine();
        }
       
        static int number(int num)
        {
            int i = 0;int s=0;
            while (s<=num)
            {
                i++;
                s = i * i;
            }
            return (i-1);
        }
    }
}
