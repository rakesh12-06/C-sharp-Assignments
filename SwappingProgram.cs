using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Program
    {
        public static void SwapMethod(int num1,int num2)
        {
            num1= num1 + num2;
            num2= num1 - num2;
            num1= num1 - num2;
            Console.WriteLine("Num1 = " + num1 + " Num2 = " + num2 );
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two Numbers");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping....");
            Console.WriteLine("Num1 = " + num1 + " Num2 = " + num2);
            Console.WriteLine("After Swapping ...");
            SwapMethod(num1,num2);
        }
    }
}
