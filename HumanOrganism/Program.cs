using HumanOrganism;

Human human = new Human(Sex.Male, new DateOnly(1999, 5, 8));

Console.WriteLine(human.Sex); // Output: Male
Console.WriteLine(human.DateOfBirth); // Output: 5/8/1999