using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Erudit", "Jupolli", 20, "DevOps Engineer", 100000m);
            Employee employee2 = new Employee("Dea", "Simnica", 20, "Frontend Developer", 120000m);

            employee1.DisplayEmployeeInfo();
            employee2.DisplayEmployeeInfo();

            employee2.GiveRaise(10);

            Console.ReadLine(); 
        }
    }
}
