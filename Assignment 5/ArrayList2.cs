using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Salary { get; set; }  
    }


    internal class ArrayList2
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Rakesh";
            emp.Salary = 50000;
            ArrayList empList = new ArrayList();
            empList.Add(emp);
            foreach (var data in empList)
                Console.Write("Employee Id = {0}, Employee Name = {1}, Employee Salary =  {2} ", emp.Id, emp.Name , emp.Salary );
        }
    }
}


