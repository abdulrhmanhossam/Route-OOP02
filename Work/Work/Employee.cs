namespace Work
{
    public class Employee
    {
        public Employee(int iD, string name, SecurityPrivileges securityLevel, double salary,
            DateTime hireDate, string gender)
        {
            ID = iD;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }

        public double Salary { get; set; }
        public DateTime HireDate { get; set; }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
            }
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                ID, Name, SecurityLevel, Salary, HireDate.ToShortDateString(), Gender);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}," +
                $" Salary: {Salary:C}, Hire Date: {HireDate.ToShortDateString()}, Gender: {Gender}");
        }
    }
}
