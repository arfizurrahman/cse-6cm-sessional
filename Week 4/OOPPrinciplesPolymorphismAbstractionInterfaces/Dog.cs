namespace OOPPrinciplesPolymorphismAbstractionInterfaces;

public class Dog: IAnimal
{
    public string Name { get; set; }
    public void Speak(){
        Console.WriteLine($"{Name} says: Woof!");
    }

}