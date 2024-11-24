namespace OOPPrinciplesPolymorphismAbstractionInterfaces;

public class Cat: IAnimal
{
    public string Name { get; set; }
    public void Speak(){
        Console.WriteLine($"{Name} says: Mewo!");
    }

}