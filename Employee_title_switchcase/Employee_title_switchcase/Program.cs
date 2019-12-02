using System;

namespace Employees_title_switch_case
{
    class Program
    {
        //Make an app that matches a number representing the employee's level to a title. 
        static void Main(string[] args)
        {
            /*int employeeLevel = 200;
            string employeeName = "John Doe";
            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Executive Director";
                    break;
            } 

            Console.WriteLine($"{employeeName}, {title}");*/

            Employee employee1 = new Employee();
            Console.WriteLine("Input employee name and company rating:\n");
            Console.WriteLine("Name:");
            employee1.Name = Console.ReadLine();
            Console.WriteLine("Rating:");
            int rating = Convert.ToInt32(Console.ReadLine());

            employee1.Level = rating;
            Console.WriteLine($"{employee1.Name}, {employee1.employeeTitle(employee1.Level)}");

            //HOW TO ADD MORE OBJECTS TO CLASS WITH USER INPUT???
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public string employeeTitle(int Level)
        {
            string title = "Associcate";
            switch (Level)
            {
                case 100:
                    title = "Junior Associate";
                    return title;

                case 200:
                    title = "Senior Associate";
                    return title;

                case 300:
                    title = "Manager";
                    return title;

                case 400:
                    title = "Executive Director";
                    return title;

            }
            return title;
        }

    }
}
