using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class LinkedList3
    {
       public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        static void Main(string[] args)
        {
            int x = 0;
            LinkedList<Employee> list = new LinkedList<Employee>();
            //Adding new Empoloyee details
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            e1.Id = 1;
            e1.Name = "Ravi";
            e1.Salary = 40000;
            e2.Id = 2;
            e2.Name = "Vamsi";
            e2.Salary = 50000;
            e3.Id = 3;
            e3.Name = "Bunny";
            e3.Salary = 70000;
            list.AddLast(e1);
            list.AddLast(e2);
            list.AddLast(e3);
            Console.WriteLine("Displaying list of employees");
            foreach(var data in list)
                Console.WriteLine(data.Name);
            Console.WriteLine("Displaying total number of employees");
            Console.WriteLine(list.Count);
            //To search an employee based on name
            foreach(var data in list)
            {
                if (data.Name == "Bunny")
                {
                    x = 0;
                    Console.WriteLine("Employee found");
                    break;
                }
                else
                    x = 1;
            }
            if(x==1)
                Console.WriteLine("Employee not found");

        }
    }
}
