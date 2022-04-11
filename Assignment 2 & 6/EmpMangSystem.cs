using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    interface IPrintable
    {
        void PrintEmpDetails();
    }
    public class Employee : IPrintable
    {
        public string name;
        public double netSalary, grossSalary;
        public Employee()
        {
            name = "";
            netSalary = 0.00;
        }
       public Employee(string name, double salary)
        {
           this.name = name;
           netSalary = salary;
        }

        public virtual void CalculateSalary()
        {
            // empty function for overriding
        }

        public void PrintEmpDetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS:\n");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Net Salary: {0}", netSalary);
            Console.WriteLine("Gross Salary: {0}\n",grossSalary);
        }
    }

    class Manager : Employee
    {
        private double petrolAllowance, foodAllowance, otherAllowance;

        public Manager(string name , double salary) 
        {
            base.name = name;
            netSalary = salary;
            petrolAllowance = 0.08 * salary;
            foodAllowance = 0.13 * salary;
            otherAllowance = 0.03 * salary;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + petrolAllowance + foodAllowance + otherAllowance;
        }
    }

    class MarketingExecutive : Employee
    {
        private float kilometerTravel, tourAllowance;
        private int telephoneAllowance;

        public MarketingExecutive(string name, double salary, float kilometers)
        {
            base.name=name;
            netSalary = salary;
            kilometerTravel = kilometers;
            tourAllowance = 5 * kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + kilometerTravel + tourAllowance + telephoneAllowance;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp;
            emp = new Manager("Arjun", 45000);
            emp.CalculateSalary();
            emp.PrintEmpDetails();
            emp = new MarketingExecutive("John", 65000 , 25);
            emp.CalculateSalary();
            emp.PrintEmpDetails();
        }
    }
}
