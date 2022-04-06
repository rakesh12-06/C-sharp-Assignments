using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        public static void CalculateAC(float r,float Pi)
        {
            float area, circum;
            area = Pi*r*r;
            circum = 2 * Pi * r;
            Console.WriteLine("Area of Circle is : " + area);
            Console.WriteLine("Circumference of Circle is : " + circum);
        }
        static void Main(string[] args)
        {
            const float Pi = 3.1428F;
            float r;
            Console.WriteLine("Enter radius of circle");
            r = float.Parse(Console.ReadLine());
            CalculateAC(r,Pi);
        }
    }
}
