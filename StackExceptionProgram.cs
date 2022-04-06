using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(5);
            int option;
            option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    while(true)
                    {
                        if(myStack.Count == 5)
                        {
                            throw new StackOverflowException("Cannot push ! Stack 0verflow..");
                        }
                        myStack.Push(int.Parse(Console.ReadLine()));
                    }
                    break;

               case 2:
                    while(true)
                    {
                        if(myStack.Count==0)
                        {
                            throw new InsufficientExecutionStackException("Cannot pop !  Stack is Empty..");
                            break;
                        }
                        myStack.Pop();
                    }
                    break;

            }
        }
    }
}
