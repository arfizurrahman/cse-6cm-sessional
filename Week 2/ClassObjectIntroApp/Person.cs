namespace ClassObjectIntroApp;

public class Person
{
    // private int age;

    // public int Age {
    //     get {return age;}
    //     set {
    //         if(value >= 0){
    //             age = value;
    //         }else{
    //             Console.WriteLine("Age cannot be negative");
    //         }
    //     }
    // }  

    // public int Age { get; set; }
    // public string Name { get; set; }


    private int age; 
    private string name;


    public Person(){
        Console.WriteLine("Default constuctor called");
    }

     public Person(int age){
        Console.WriteLine($"Age: {age}");
    }

    public Person(int age, string name){
        this.age = age;
        this.name = name;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
