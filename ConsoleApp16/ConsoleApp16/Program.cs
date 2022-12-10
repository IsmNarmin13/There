using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Lorem",6);
            Person person2 = new Person("Nara",55);
            
            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            foreach (Person person in persons)
            {
                if (person._name.Contains("a") && person._age > 20)
                {
                    Console.WriteLine(person._name);
                }              
            }
        }
    }
    class Person
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}
