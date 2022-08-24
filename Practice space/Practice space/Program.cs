using System;
//REQUIRED FOR DECLARING DICTIONARY
using System.Collections.Generic;
using System.Linq;

namespace Practice_space
{
    class Program
    {
        //HASHTABLES
        static void Main(string[] args)
        {
            //DICTIONARIES

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };


            // DICTIONARY EXAMPLE - EMPLOYEE INFO

            Employee[] employees =
            {
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8),
            };

            Dictionary<string, Employee> employeesDictionary = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDictionary.Add(emp.Role, emp);
            }

            Employee emp1 = employeesDictionary["Intern"];
            Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}, Rate: {3} \n", emp1.Name, emp1.Role, emp1.Salary, emp1.Rate);


            //TRYGETVALUE - EXAMPLE

            Employee result;
            if (employeesDictionary.TryGetValue("Lead Developer", out result))
            {
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}, Rate: {3} \n", result.Name, result.Role, result.Salary, result.Rate);
            }
            else
            {
                Console.WriteLine("Sorry but that we cannot find the key you're looking for.");
            }


            //DISPLAY ALL FROM DICTIONARY

            for (int count = 0; count < employeesDictionary.Count; count++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDictionary.ElementAt(count);
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}, Rate: {3} \n", employeeValue.Name, employeeValue.Role, employeeValue.Salary, employeeValue.Rate);
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Role { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public float Rate { get; set; }

        //yearly salary = rate/h * number of days * number of weeks * number of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }

    
}