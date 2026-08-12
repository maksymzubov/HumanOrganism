using System;
using System.Collections.Generic;
using System.Text;
using HumanOrganism.Anatomy.Bones;

namespace HumanOrganism.Anatomy
{
    public class Skeleton
    {
        public IReadOnlyCollection<Bone> Bones { get; }

        public Skeleton()
        {
            Bones = new List<Bone>()
            {
                new Bone (new BoneIdentity(BoneType.Femur, BodySide.Left)),
                new Bone (new BoneIdentity(BoneType.Femur, BodySide.Right)),
                new Bone (new BoneIdentity(BoneType.Sternum))
            };
        }

    }
}
