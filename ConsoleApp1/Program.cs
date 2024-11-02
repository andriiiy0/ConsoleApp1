using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
            new Person(){ Name = "Liza", Age = 18, City = "Moscow" },
            new Person(){ Name = "Oleg", Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }
        };

        var olderThan25 = people.Where(p => p.Age > 25).ToList();
        Console.WriteLine("Люди старші 25 років:");
        foreach (var person in olderThan25)
        {
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");
        }

        var notInKyiv = people.Where(p => p.City != "Kyiv").ToList();
        Console.WriteLine("Люди, які проживають не в Києві:");
        foreach (var person in notInKyiv)
        {
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");
        }

        var namesInKyiv = people.Where(p => p.City == "Kyiv").Select(p => p.Name).ToList();
        Console.WriteLine("Імена людей, які проживають у Києві:");
        foreach (var name in namesInKyiv)
        {
            Console.WriteLine(name);
        }

        var sergeysOlderThan35 = people.Where(p => p.Name == "Sergey" && p.Age > 35).ToList();
        Console.WriteLine("Люди старші 35 років з ім'ям Sergey:");
        foreach (var person in sergeysOlderThan35)
        {
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");
        }

        var inMoscow = people.Where(p => p.City == "Moscow").ToList();
        Console.WriteLine("Люди, які у Москві:");
        foreach (var person in inMoscow)
        {
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");
        }
    }
}
