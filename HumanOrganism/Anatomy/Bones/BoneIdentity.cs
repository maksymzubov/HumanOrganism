using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HumanOrganism.Anatomy.Bones
{
    public class BoneIdentity
    {
        public BoneType Type { get; }
        public BodySide? Side { get; }
        public int? Number { get; }
        public DigitPosition? DigitPosition { get; } 
        public PhalanxPosition? PhalanxPosition { get; } 

        public BoneIdentity(BoneType type, BodySide? side = null, int? number = null, DigitPosition? digitPosition = null, PhalanxPosition? phalanxPosition = null)
        {
            Type = type;
            Side = side;
            Number = number;
            DigitPosition = digitPosition;
            PhalanxPosition = phalanxPosition;

        }
    }
}
