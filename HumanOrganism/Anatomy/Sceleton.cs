using System;
using System.Collections.Generic;
using System.Text;
using HumanOrganism.Anatomy.Bones;

namespace HumanOrganism.Anatomy
{
    public class Sceleton
    {
        public IReadOnlyCollection<Bone> Bones { get; }

        public Sceleton()
        {
            Bones = new List<Bone>()
            {
                new Bone (BoneType.Femur, BodySide.Left),
                new Bone (BoneType.Femur, BodySide.Right),
                new Bone (BoneType.Sternum)
            };
        }

    }
}
