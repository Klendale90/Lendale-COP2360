using System;

class Program
{
    static void Main()
    {
        // Create a new Dog instance
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Breed = "Golden Retriever";
        myDog.Age = 3;

        // Print the dog's information
        Console.WriteLine("Dog Information:");
        Console.WriteLine("Name: " + myDog.Name);
        Console.WriteLine("Breed: " + myDog.Breed);
        Console.WriteLine("Age: " + myDog.Age + " years old");
    }
}

// Dog class from Classes.txt
public class Dog
{
    public string Name;
    public string Breed;
    public int Age;
}
