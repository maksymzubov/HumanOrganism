using System;
using System.Collections.Generic;
using System.Text;
using HumanOrganism.Anatomy;

namespace HumanOrganism
{
    public class Human
    {
        public Sex Sex { get; }
        public DateOnly DateOfBirth { get; }
        public Skeleton Sceleton { get; }

        public Human(Sex sex, DateOnly dateOfBirth)
        {
            Sex = sex;
            DateOfBirth = dateOfBirth;
            Sceleton = new Skeleton();
        }
    }
}

  
