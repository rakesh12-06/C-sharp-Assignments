using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem;

namespace DelegateEmployee
{
    public delegate void EmployeeDelegate();
    internal class delegates6
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp = new Manager("Arjun", 45000);
            emp.CalculateSalary();
            EmployeeDelegate employeeDelegate = new EmployeeDelegate(emp.PrintEmpDetails);
            employeeDelegate();
            emp = new MarketingExecutive("John", 65000, 25);
            emp.CalculateSalary();
            EmployeeDelegate employeeDelegate2 = new EmployeeDelegate(emp.PrintEmpDetails);
            employeeDelegate2();
        }
    }
}
