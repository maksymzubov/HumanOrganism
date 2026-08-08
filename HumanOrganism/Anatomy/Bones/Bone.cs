

namespace HumanOrganism.Anatomy.Bones
{
    public class Bone
    {
        public BoneType Type { get; }
        public BodySide? Side { get; }

        public Bone(BoneType type, BodySide? side = null)
        {
            Type = type;
            Side = side;
        }
    }
}

