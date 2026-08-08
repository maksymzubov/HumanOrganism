using System;
using System.Collections.Generic;
using System.Text;

namespace HumanOrganism
{
    public class Human
    {
        public Sex Sex { get; }
        public DateOnly DateOfBirth { get; }

        public Human(Sex sex, DateOnly dateOfBirth)
        {
            Sex = sex;
            DateOfBirth = dateOfBirth;
        }
    }
}

  
