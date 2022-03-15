using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    public class Person
    {
        protected int age; 
        public Person(string Name, string Surname, int age)
        {
            this.Name = Name;
            this.Surname = Surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age {get { return age; } set { if (age > 0 && age < 150) age = value; } }
        public string GetFullName(string Name, string Surname)
        {
            string fullName = Name + " " + Surname;
            return fullName;
        }
    }
}
