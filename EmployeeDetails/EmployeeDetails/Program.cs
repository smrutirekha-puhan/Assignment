using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id :");
           int id  =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            string emp_name= Console.ReadLine();
            Console.WriteLine("Enter Employee DepartmentName :");
            string dept_name = Console.ReadLine();

            Employee emp = new Employee(id, emp_name, dept_name);

            int eid = emp.GetId(emp);
            Console.WriteLine("Employee Id : {0}", eid);
            string ename = emp.GetName(emp);
            Console.WriteLine("Employee Name : {0}", ename);
            string edept = emp.GetDeptName(emp);
            Console.WriteLine("Employee DepartmentName : {0}", edept);

            Console.WriteLine("Enter Employee Id To Update :");
            int uid = Convert.ToInt32(Console.ReadLine());
            emp.Set(uid);

            Console.WriteLine("Enter Employee Name To Update :");
            String uname = Console.ReadLine();
            emp.Set(uname,0);

            Console.WriteLine("Enter Employee DepartmentName To Update:");
            String Udeptname = Console.ReadLine();
            emp.Set(Udeptname,null ,0 );




            Console.ReadKey();







        }
    }
}
