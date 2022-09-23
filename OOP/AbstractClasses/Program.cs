using AbstractClasses;

Dog dog = new Dog();
Console.WriteLine("Write your dog name: ");
dog.SetName(Console.ReadLine());

Console.WriteLine(dog.GetName());
dog.Eat();