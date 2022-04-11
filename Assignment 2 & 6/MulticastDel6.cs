using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem;

namespace MultiCastDelegate
{
    public delegate void EmployeeDelegate();
    internal class MulticastDel6
    {
        static void Main(String[] args)
        {
            Employee emp1,emp2;
            emp1 = new Manager("Arjun", 45000);
            emp1.CalculateSalary();
            emp2 = new MarketingExecutive("John", 65000, 25);
            emp2.CalculateSalary();
            EmployeeDelegate employeeDelegate = new EmployeeDelegate(emp1.PrintEmpDetails);
            employeeDelegate += emp2.PrintEmpDetails;
            employeeDelegate();

        }
    }
}
