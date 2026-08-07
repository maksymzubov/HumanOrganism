using System;
using System.Collections.Generic;
using System.Text;

namespace HumanOrganism
{
    public class Human
    {
        public Sex Sex { get; }

        public Human(Sex sex)
        {
            Sex = sex;
        }
    }
}
