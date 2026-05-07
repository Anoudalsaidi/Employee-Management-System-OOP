using System.Globalization;
using System.Threading.Channels;

namespace project01
{


    class Employee
    {
        public string Name { get; set; }
        public string Departments { get; set; }

        private int id;
        private double salary;

        public int ID
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { if (value >= 0) salary = value; }
        }

        public Employee(int id, string name, string departments, double salary)
        {
            ID = id;
            Name = name;
            Departments = departments;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Department: {Departments}, Salary: {Salary}");
        }
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(int id, string name, string departments, double salary, string lang)
            : base(id, name, departments, salary)
        {
            ProgrammingLanguage = lang;
        }

        public override void Work()
        {
            Console.WriteLine("Developer is writing code");
        }
    }

    class Designer : Employee
    {
        public string DesignTool { get; set; }

        public Designer(int id, string name, string departments, double salary, string tool)
            : base(id, name, departments, salary)
        {
            DesignTool = tool;
        }

        public override void Work()
        {
            Console.WriteLine("Designer is creating UI designs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Developer(101, "Anoud", "IT", 1200, "C#"));
            employees.Add(new Designer(202, "Malak", "Design", 700, "Figma"));

            foreach (Employee emp in employees)
            {
                emp.DisplayInfo();
                emp.Work();
                Console.WriteLine("-------------------");
            }
        }
    }

}
