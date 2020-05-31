using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Exercise
{
    class Program
    {
        //Let's imagine that we have a Collection of Id's with Name, Surname, Adress, and Id.No. Create an easy access library for CRUD
        //(creating, removing, updating and deleting infos)
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Id = 1;
            person1.Name = "Mateo";
            person1.Surname = "Stefanek";
            person1.Address = "Bizovacka ulica";
            person1.StNumber = 85;

            Person person2 = new Person();
            person2.Id = 2;
            person2.Name = "Filip";
            person2.Surname = "Stefanek";
            person2.Address = "Bizovacka ulica";
            person2.StNumber = 83;

            List<Person> personList = new List<Person>();
            personList.Add(person1);
            personList.Add(person2);

MENU:       Console.WriteLine("Welcome to the ID library of a PD of State Underdog! What would you want to do? \n Choose:\n");
            Console.WriteLine("1. Check all existing info. \n 2. Search library by one of parameters. \n 3. Change informations of one person. \n 4. Delete an ID. \n 5. Exit.\n");
            int menu = 0;
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu != 1 && menu != 2 && menu != 3 && menu != 4 && menu!=5)
            {
                Console.WriteLine("Your choice is not available in the existing menu. Try again!\n");
                goto MENU;
            }
            if (menu == 5) Environment.Exit(1);
            if (menu == 1)
            {
                foreach (Person person in personList)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4} \n", person.Id, person.Name, person.Surname, person.Address, person.StNumber);
                   
                }
                Console.WriteLine("Would You like something else? \n");
                goto MENU;
            }


          

            //Person person2 = new Person() { Id = 2, Name = "Filip", Surname = "Stefanek", Address = "Bizovacka", StNumber = 83 };

        }

        class Person {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Address { get; set; }
            public int StNumber { get; set; }

           /* public Person(int id, string name, string surname, string address, int stnumber)
            {
                Id = id;
                Name = name;
                Surname = surname;
                Address = address;
                StNumber = stnumber;
            
            }
            */

        }

    }
}
