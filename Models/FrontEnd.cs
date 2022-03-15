using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    public class FrontEnd : Developer
    {
        public string[] Languages { get; set; }
        public FrontEnd(string Name, string Surname, int Age, int workExperience, string[] Languages) : base(Name, Surname, Age, workExperience)
        {
            this.Languages = Languages;
        }
    }
}
