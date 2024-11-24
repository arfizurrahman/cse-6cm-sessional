namespace OOPPrinciplesPolymorphismAbstractionInterfaces;

public interface IAnimal
{
    void Speak();
    void Sleep(){
        Console.WriteLine("The animal is sleeping");
    }
    string Name {get; set;}
    
}