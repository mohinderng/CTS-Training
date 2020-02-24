using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFCodeFirstDemo
{
    class Program
    {
        public string name;
        static void Main(string[] args)
        {
          //  Console.WriteLine("Enter name to be searched");
           // string nm = Console.ReadLine();
           // Search(nm);
           Console.WriteLine("Enter the value with which you want to replace the name");
            string nme = Console.ReadLine();
            UpdateData(nme);
            // InsertData();

           //ShowAllEmployees();
        }

        private static void ShowAllEmployees()
        {
            EmployeeContext empctx = new EmployeeContext();
            var employees = empctx.Employees;

            foreach (var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
            }
        }

        private static void InsertData()
            {
           
                EmployeeContext ect = new EmployeeContext();

                Console.WriteLine("Enter Employee name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Designation");
                string desg = Console.ReadLine();
                Console.WriteLine("Enter salary");
                double sal = Convert.ToDouble(Console.ReadLine());

                ect.Employees.Add(new Employee
                {
                    Ename = name,
                    Designation = desg,
                    Salary = sal
                });
               
            }

        private static void Search(string na)
        {
            EmployeeContext ec = new EmployeeContext();
            var emp = ec.Employees;

            var a = from e in emp where e.Ename == na select e;

            foreach (var n in a)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",n.Eid,n.Ename,n.Designation,n.Salary);
        }
        }

        private static void UpdateData(string nn)
        {
            Console.WriteLine("Enter New Employee name");
            string name = Console.ReadLine();

            EmployeeContext ee = new EmployeeContext();
            var ex = ee.Employees;

            var aa = from b in ex where b.Ename == nn select b;

            foreach(Employee x in aa)
            {
                x.Ename = name;
            }
            ee.SaveChanges();
        }
        
        }
    }