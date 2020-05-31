using System;

namespace Exercise_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person();
            person.Name = "Kruno";
            person.Year = 137;
            Console.WriteLine("Hi, my name is {0}, and I am {1} years old!", person.Name, person.Year);

        }
    }
    public class Person{
        public string Name;
        public int Year;
    }
}
