using Encapsulation.Models;
using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the name: ");
            string name = Console.ReadLine();
            Console.Write("Write the surname: ");
            string surname = Console.ReadLine();
            Console.Write("Write the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write work experience: ");
            int workExperience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write how many languages know: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            string[] languages = new string[s];
            for (int i = 1; i <= s; i++)
            {
                Console.Write("\n Write" + " " + i + " " + "language: ");
                languages[n] = Console.ReadLine();
            }
            Person person = new Person(name, surname, age);
            Developer developer = new Developer(name, surname, age, workExperience);
            FrontEnd frontEnd = new FrontEnd(name, surname, age, workExperience, languages);
            BackEnd backEnd = new BackEnd(name, surname, age, workExperience, languages);
            Console.Clear();
            Console.WriteLine("Full name: " + person.GetFullName(name, surname) + "\n" + "Age: " + age + "\nWork experience: " + workExperience);
            Console.Write("Languages: ");
            for (int i = 1; i <= s; i++)
            {
                Console.Write(languages[n] + ", ");
            }
        }
    }
}
