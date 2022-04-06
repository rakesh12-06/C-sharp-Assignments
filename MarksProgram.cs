using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[5];
            Console.WriteLine("Enter marks of five students");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Average Marks of 5 students is : " + arr.Average());
            Console.WriteLine("Highest Marks obtaines is : " + arr.Max());
        }
    }
}
