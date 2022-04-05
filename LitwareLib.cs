using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib;

namespace LitwareLib
{
    class Employee
    {
        int EmpNo;
        string EmpName;
        double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;
        public string Name
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

        public int Number
        {
            get { return EmpNo; }
            set { EmpNo = value; }
        }

        public double Sal
        {
            get { return Salary; }
            set { Salary = value; }

        }

        public double HraSal
        {
            get { return HRA; }
            set { HRA = value; }
        }

        public double TaSal    
        {
            get { return TA; }
            set { TA = value; }
        }

        public double DaSal
        {
            get { return DA; }
            set { DA = value; }
        }

        public double GrossSal
        {
            get { return GrossSalary; }
            set { GrossSalary = value; }
        }

        public double PfSal
        {
            get { return PF; }
            set { PF = value; }
        }

        public double TdsSal
        {
            get { return TDS; }
            set { TDS = value; }
        }

        public double NetSal
        {
            get { return NetSalary; }  
            set { NetSalary = value; }
        }


    }



    internal class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Number = int.Parse(Console.ReadLine());
            emp.Name   = Console.ReadLine();
            emp.Sal    = double.Parse(Console.ReadLine());
            if (emp.Sal < 5000)
            {
                emp.HraSal = (10.0 * emp.Sal) / 100.0;
                emp.TaSal = (5.0 * emp.Sal) / 100.0;
                emp.DaSal = (15.0 * emp.Sal) / 100.0;
            }

            else if (emp.Sal < 10000)
            {
                emp.HraSal = (15.0 * emp.Sal) / 100.0;
                emp.TaSal = (10.0 * emp.Sal) / 100.0;
                emp.DaSal = (20.0 * emp.Sal) / 100.0;
            }

            else if (emp.Sal < 15000)
            {
                emp.HraSal = (20.0 * emp.Sal) / 100.0;
                emp.TaSal = (15.0 * emp.Sal) / 100.0;
                emp.DaSal = (25.0 * emp.Sal) / 100.0;
            }

            else if (emp.Sal < 20000)
            {
                emp.HraSal = (25.0 * emp.Sal) / 100.0;
                emp.TaSal = (20.0 * emp.Sal) / 100.0;
                emp.DaSal = (30.0 * emp.Sal) / 100.0;
            }

            else
            {
                emp.HraSal = (30.0 * emp.Sal) / 100.0;
                emp.TaSal = (25.0 * emp.Sal) / 100.0;
                emp.DaSal = (35.0 * emp.Sal) / 100.0;
            }

            emp.GrossSal = emp.Sal + emp.TaSal + emp.HraSal + emp.DaSal;
            CalculateSalary();

            void CalculateSalary()
            {
                emp.PfSal = (10.0 * emp.GrossSal) / 100.0;
                emp.TdsSal = (18.0 * emp.GrossSal) / 100.0;
                emp.NetSal = emp.GrossSal - (emp.PfSal + emp.TdsSal);
                Console.WriteLine("Employee Gross Salary is : " + emp.GrossSal);
                Console.WriteLine("Employee Net Salary is : " + emp.NetSal);
            }


        }


    }

}
