using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    public class Developer : Person
    {
        public Developer(string Name, string Surname, int Age, int workExperience) : base(Name, Surname, Age)
        {
            this.workExperience = WorkExperience;
        }
        protected int workExperience;
        public int WorkExperience { get { return workExperience; } set { if (workExperience > 0 && workExperience < 100) workExperience = value; } }
        /// <summary>
        /// Adds years experience
        /// </summary>
        /// <param Grow count: ="grow"></param>
        public void AddYearsExperiance(int grow)
        {
            workExperience += grow;
        }
    }

}
