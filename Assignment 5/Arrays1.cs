using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Arrays1
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            string[] arr2 = new string[5];  
            string[] arr3 = new string[5];
            Console.WriteLine("Enter String array elements : ");
            for(int i=0;i<5;i++)
                arr2[i]=Console.ReadLine();
            Console.WriteLine("Copying string elements to new array");
            Array.Copy(arr2, 0, arr3, 0, 5);
            Console.WriteLine("Printing new array elements : ");
            foreach(string str in arr3)
                Console.WriteLine(str);
            Console.WriteLine("Clearing new array elemenst : ");
            Array.Clear(arr3, 0, 5);
            Console.WriteLine("Enter integer array elemments : ");
            for(int i=0;i<5;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements after sorting : ");
            Array.Sort(arr1);
            foreach(int i in arr1)
                Console.WriteLine(i);
            Console.WriteLine("Array elements in reverse order : ");
            Array.Reverse(arr1);
            foreach (int i in arr1)
                Console.WriteLine(i);

        }
    }
}
