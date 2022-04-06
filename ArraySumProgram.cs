using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {

        public static int SumOfArray(int[] arr)
        {
            return arr.Sum(); 
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of elements to be set in the Array");
            n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Array Elemens : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Sum of Array Elements is : " + SumOfArray(arr));
        }
    }
}
