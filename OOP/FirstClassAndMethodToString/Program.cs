using FirstClassAndMethodToString;

Person[] people = new Person[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter a friend first name: ");

    Person person = new Person();
    person.Name = Console.ReadLine() ?? "";

    people[i] = person;
}
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Hello! my name is {people[i].ToString()}");
}