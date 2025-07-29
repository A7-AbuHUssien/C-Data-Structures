using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
    }
    static void Main(string[] args)
    {
        List<Person> Pepolelist = new List<Person>
        {
            new Person ("Ahmed",21),
            new Person ("Mohamed",41),
            new Person ("Bob",25),
            new Person ("Frank",19),
            new Person ("Helen",18),
            new Person ("Grace",99)
        };

        // Find
        Person founded = Pepolelist.Find(r => r.Name == "Ahmed");
        if (founded != null)
        {
            Console.WriteLine("Find Person Using 'Find' ");
            Console.WriteLine($"Founded Person: Name : {founded.Name},Age: {founded.Age}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        // FirstOrDefault
        Person p = Pepolelist.FirstOrDefault(i => i.Name == "Ahmed");
        if (p != null)
        {
            Console.WriteLine("Find Person Using 'FirstOrDefault' ");
            Console.WriteLine($"Founded Person: Name : {founded.Name},Age: {founded.Age}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        // FindAll
        List<Person> searchResult = Pepolelist.FindAll(s => s.Age > 20);
        if (searchResult != null)
        {
            Console.WriteLine("People Over 20, Using 'FindAll' ");
            searchResult.ForEach(item => Console.WriteLine($"Name: {item.Name},Age: {item.Age}"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }
        // Exists
        bool IsThereOver100 = Pepolelist.Exists(s => s.Age > 100);
        Console.WriteLine($"Is Exists People Over 100 => {IsThereOver100}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        // Any
        bool IsThereOver90 = Pepolelist.Any(s => s.Age > 90);
        Console.WriteLine($"Is Exists People Over 90 => {IsThereOver90}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        // Removing All>50
        Pepolelist.RemoveAll(q => q.Age > 50);
        Console.WriteLine("After Remove All > 50");
        Pepolelist.ForEach(per => Console.WriteLine($"Name : {per.Name},Age: {per.Age}"));
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");




    }
}

