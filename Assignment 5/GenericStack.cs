using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class GenericStack
    {
        public class MyStack<T>
        {
            int top, size;
            T[] stack;

            public MyStack(int size)
            {
                top = -1;
                T[] stack = new T[size];
            }

            public int push(T val)
            {
                if (top == size - 1)
                {
                    return 0;
                }
                else
                {
                    stack[++top] = val;
                }
                return 1;
            }


            public T pop()
            {
                T del;
                T y = default(T);
                if (top >= 0)
                {
                    del = stack[top];
                    top--;
                    return del;
                }
                return y;
            }
        }
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter Max size of Stack :");
            size = int.Parse(Console.ReadLine());
            MyStack<int> stack = new MyStack<int>(size);
            while (true)
            {
                Console.WriteLine("Eneter your Choice :");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter value to push :");
                            int x = int.Parse(Console.ReadLine());
                            int result = stack.push(x);
                            if (result == 0)
                            {
                                Console.WriteLine("Element Pushed into Stack");
                            }
                            else
                            {
                                Console.WriteLine("Stack Overflow");
                            }
                            break;
                        }

                    case 2:
                        {
                            int Result = stack.pop();
                            if (Result != 0)
                            {
                                Console.WriteLine("Popped Element :" + Result);
                            }
                            else
                            {
                                Console.WriteLine("Stack Underflow ");
                            }
                            break;
                        }

                    case 3:
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid option ");
                            break;
                        }

                }

            }
        }
    }
}
