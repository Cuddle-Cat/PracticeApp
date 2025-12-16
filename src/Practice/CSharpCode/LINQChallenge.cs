using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }
}

class LinqChallenge
{
    public static void Run()
    {
        var people = new List<Person>
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 35),
        };

        var olderThan30 = people.Where(p => p.Age > 30).ToList();

        double avgAge = people.Average(p => p.Age);

        Person oldest = people.OrderByDescending(p => p.Age).First();

        var sortedDesc = people.OrderByDescending(p => p.Age).ToList();

        Console.WriteLine("People older than 30:");
        foreach (var p in olderThan30)
        {
            Console.WriteLine($"{p.Name} - {p.Age}");
        }

        Console.WriteLine($"\nAverage age: {avgAge:F2}");
        Console.WriteLine($"\nOldest person: {oldest.Name} ({oldest.Age})");

        Console.WriteLine("\nSorted by age (descending):");
        foreach (var p in sortedDesc)
        {
            Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }
}
