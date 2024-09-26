using System;

namespace EmployeeApp
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName, int age, string position, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}, Age: {Age}, Position: {Position}, Salary: {Salary:C}");
        }

        public void GiveRaise(decimal percentage)
        {
            Salary += Salary * (percentage / 100);
            Console.WriteLine($"{FirstName} {LastName} got a raise of {percentage}%. New Salary: {Salary:C}");
        }
    }
}
