using System;

namespace Personal_database_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my friend! We're creating a database of students of our school. Would You be kind and leave us your informations?");
        Informations:
            Personal person1 = new Personal();
            Console.WriteLine("Type Your name: \n ");
            person1.Name = Console.ReadLine();
            Console.WriteLine("Type Your surname: \n ");
            person1.Surname = Console.ReadLine();
            Console.WriteLine("Which Year were You born: \n ");
        Birthyear:
            string Year = Console.ReadLine();
            int Year1;
            if (int.TryParse(Year, out Year1))
            {
                person1.Birthyear = Year1;
            }
            else {
                Console.WriteLine("We are sorry... Could You retype the year, please!");
                goto Birthyear;
            }
            Console.WriteLine("Thank You ");
            person1.Infos();
            Console.Read();
        }
    }
    class Personal
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Birthyear { get; set; }

        public void Infos()
        {
            Console.WriteLine("{0}, {1}, {2}", Name, Surname, Birthyear);
        
        }
    }
}
