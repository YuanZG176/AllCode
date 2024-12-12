// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;
class DemoAnimals2
{
    static void Main()
    {
        Dog spot = new Dog("Spot");
        Cat puff = new Cat("Puff");
        DisplayAnimals(spot);
        DisplayAnimals(puff);
    }

    public static void DisplayAnimals(Animal creature)
    {
        WriteLine(creature.Name+" says "+creature.Speak());
    }
}













abstract class Animal
{
    private string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public string Name
    {
        get
        {
            return name;
        }
    }
    public abstract string Speak();
}


class Dog : Animal
{
    public Dog(string name) : base(name)
    {

    }
    public override string Speak()
    {
        return "woof";
    }
}


class Cat : Animal
{
    public Cat(string name) : base(name)
    {

    }
    public override string Speak()
    {
        return "meow";
    }
}
