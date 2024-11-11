namespace OOPBasicsApp;

public class Employee : Person
{
    public void DisplayGender(){
        Gender = "Male";
        Console.WriteLine($"Gender: {Gender}");
     }
}