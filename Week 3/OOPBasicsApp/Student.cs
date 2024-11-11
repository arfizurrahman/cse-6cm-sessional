namespace OOPBasicsApp;

public class Student
{
    // Fields
    private string name;

    // Properties
    public string Name {
        get{return name; }
        set{name = value; }
    }

    public int Age { get; set; } // Autoproperty

    public void DisplayInfo(){
        Console.WriteLine($"Name: {name}, Age: {Age}");
    }
}