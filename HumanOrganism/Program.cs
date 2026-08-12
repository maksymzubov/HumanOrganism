using HumanOrganism;
using HumanOrganism.Anatomy.Bones;

Human human = new Human(Sex.Male, new DateOnly(1999, 5, 8));

Console.WriteLine(human.Sex); // Output: Male
Console.WriteLine(human.DateOfBirth); // Output: 5/8/1999
var identity = new Bone(new BoneIdentity(BoneType.Femur, BodySide.Left));
Bone? bone = human.Sceleton.GetBone(identity.Identity);
if  (bone != null)
{
    Console.WriteLine($"Found bone: {bone.Identity.Side} {bone.Identity.Type} ");
}
else
{
    Console.WriteLine("Bone not found.");
}