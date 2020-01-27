using System.Reflection;

namespace EmployeeDetails
{
    public class Employee
    {
        public delegate void MethodCall(string[] mssg, int i);
        public event MethodCall call;
        public string[] s1 = new string[3];
        public int i;

        public void doAction()
        {
            call(s1, i);
        }

        private int Id;
        private string  EmpName, DeptName;
        

        public Employee(int Id, string EmpName, string DeptName)
        {
            this.Id = Id;
           this.EmpName = EmpName;
           this.DeptName = DeptName;
        }

        public int GetId(Employee emp)
        {
            i = 0;
            s1[0] = MethodBase.GetCurrentMethod().Name;
            emp.call += new Employee.MethodCall(show_Action);
            emp.doAction();
            return this.Id;
           }

        public string GetName(Employee emp)
        {
            i = 1;
            s1[1] = MethodBase.GetCurrentMethod().Name;
            emp.call += new Employee.MethodCall(show_Action);
            emp.call -= new Employee.MethodCall(show_Action);
            emp.doAction();
            return this.EmpName;
        }

        public string GetDeptName(Employee emp)
        {
            i = 2;
            s1[2] = MethodBase.GetCurrentMethod().Name;
            emp.call += new Employee.MethodCall(show_Action);
            emp.call -= new Employee.MethodCall(show_Action);
            emp.doAction();
            return this.DeptName;
        }

        static void show_Action(string[] mssg, int i)
        {
            System.Console.WriteLine(mssg[i] + "method called");
        }
        public void Set( int UId)
        {
            string name = MethodBase.GetCurrentMethod().Name;
            Id=UId;
            System.Console.WriteLine("Updated Employee Id :"+ Id);
          
        }
        public void Set(string UName, int UId)
        {
            string name = MethodBase.GetCurrentMethod().Name;
            EmpName= UName;
            System.Console.WriteLine("Updated Employee Name :"+EmpName);
        }
        public void Set(string UDeptName , string UName, int UId)
        {
            string name = MethodBase.GetCurrentMethod().Name;
            DeptName=UDeptName;
            System.Console.WriteLine("Updated Employee DepartmentName:"+DeptName);
        }



      



    }
}
