using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    public class BackEnd : Developer
    {
        public string[] Languages { get; set; }
        public BackEnd(string Name, string Surname, int Age, int workExperience, string[] Languages) : base(Name, Surname, Age, workExperience)
        {
            this.Languages = Languages;
        }
    }
}
