namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Design and implement a Class for the employees in a company:
            //Console.WriteLine("Employee Information:");
            //Employee emp = new Employee(1, "Ziad", 5, 75000, new DateTime(2015, 6, 1), "Male");
            //emp.DisplayInfo(); 
            #endregion

            #region Develop a Class to represent the Hiring Date Data
            //Console.WriteLine("Hiring Date Example:");
            //HiringDate hireDate = new HiringDate(15, 8, 2020);
            //Console.WriteLine($"Hiring Date: {hireDate}"); 
            #endregion

            #region We need to restrict the Gender field to be only M or F [Male or Female] 
            //Console.WriteLine("Employee Information:");
            //try
            //{
            //    Employee emp = new Employee(1, "John Doe", 5, 75000, new DateTime(2015, 6, 1), "M");
            //    emp.DisplayInfo();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
            // you Will find thi at Employee Class and SecurityPrivileges Eum
            #endregion

            #region We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
            // you Will find this at Employee Class
            #endregion

            #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            var EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(101, "Reem", SecurityPrivileges.DBA, 3000.00, DateTime.Now, "F");  // Guest
            //EmpArr[1] = new Employee(102, "Bob", SecurityPrivileges.Guest, 6000.00, DateTime.Now, "M"); // DBA
            //EmpArr[2] = new Employee(103, "Ziad", SecurityPrivileges.Secretary, 9000.00, DateTime.Now, "M"); // Security Officer

            //foreach (var employee in EmpArr)
            //{
            //    Console.WriteLine(employee.ToString());
            //} 
            #endregion

        }
    }
}
