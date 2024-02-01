using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Person> persons = new List<Person>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            break;

        }
    }

    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }








}