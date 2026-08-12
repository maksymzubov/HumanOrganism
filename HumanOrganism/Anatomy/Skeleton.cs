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
        public Bone? GetBone(BoneIdentity identity)
        {
            foreach (var bone in Bones)
            {
                if (bone.Identity.Equals(identity))
                {
                    return bone;
                }
            }
            return null;
        }

        private IEnumerable<Bone> CreateAppendicularBones()
        {
            foreach (var bone in CreatePectoralGirdleBones())
            {
                yield return bone;
            }
        }
        private IEnumerable<Bone> CreatePectoralGirdleBones()
        {
            yield return new Bone(new BoneIdentity(BoneType.Clavicle, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Clavicle, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Scapula, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Scapula, BodySide.Right));
        }
        private IEnumerable<Bone> CreateUpperLimbBones()
        {
            yield return new Bone(new BoneIdentity(BoneType.Humerus, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Humerus, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Radius, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Radius, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Ulna, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Ulna, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Scaphoid, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Scaphoid, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Lunate, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Lunate, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Triquetrum, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Triquetrum, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Pisiform, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Pisiform, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Trapezium, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Trapezium, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Trapezoid, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Trapezoid, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Capitate, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Capitate, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Hamate, BodySide.Left));
            yield return new Bone(new BoneIdentity(BoneType.Hamate, BodySide.Right));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Left, 1));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Right, 1));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Left, 2));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Right, 2));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Left, 3));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Right, 3));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Left, 4));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Right, 4));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Left, 5));
            yield return new Bone(new BoneIdentity(BoneType.Metacarpal, BodySide.Right, 5));

        }

    }
}
