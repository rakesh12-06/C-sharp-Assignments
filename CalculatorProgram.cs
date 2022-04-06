using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            char operator1; 
            float answer;
            Console.WriteLine("Enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator");
            operator1 = char.Parse(Console.ReadLine());

            switch (operator1)
            {
                case '+' :
                    answer = num1 + num2;
                    Console.WriteLine(answer);
                    break;

                case '-' :
                    answer = num1 - num2;
                    Console.WriteLine(answer);
                    break;

                case '/' :
                    answer = num1 / num2;
                    Console.WriteLine(answer);
                    break;
                
                case '*':
                    answer = num1 * num2;
                    Console.WriteLine(answer);
                    break;
                
                default:
                    Console.WriteLine("Invalid operator ");
                    break;
            }

        }
    }
}
