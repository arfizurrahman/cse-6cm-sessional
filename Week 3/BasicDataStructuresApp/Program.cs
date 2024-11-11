
/*--------------
   Array
----------------*/
using System.Collections;
using BasicDataStructuresApp;

int[] intArray = new int[5];
int[] intArray1 = new int[2]{1,2};

int[] intArray3 = {1,2};

string[] names = {"John","Arman"};

// for(int i= 0; i < names.Length; i++){
//     Console.WriteLine($"name: {names[i]}");
// }

// foreach(string name in names){
//     Console.WriteLine($"Name: {name}");
// }


/*--------------
   List
----------------*/
List<string> names1 = new List<string> {"Zahed", "Shihab", "Alim"};

List<string> names2 = new List<string> {"Azam", "Raj"};

names1.Add("Arman");

names1.Remove("Shihab");

names1.AddRange(names2);

Student student1 = new Student("Alim",22);
Student student2 = new Student("Raj",23);

List<Student> students = new List<Student>{
    student1, student2
};

foreach(Student student in students){
    Console.WriteLine($"{student.Name} {student.Age}");
}

// foreach(string name in names1){
//     Console.WriteLine($"Name: {name}");
// }


/*----------------
    Dictionary
----------------*/
Dictionary<string,string> books = new Dictionary<string, string>{
    {"234234-234234-234","Microservices"},
    {"12332-234234-234","Designing Scalable System"}
};

books.Add("2343-234234-324","Atomic Habits");
books.Remove("234234-234234-234");

// Console.WriteLine($"Book name: {books["234234-234234-234"]}");

// foreach(KeyValuePair<string, string> book in books){
//     Console.WriteLine($"ISBN: {book.Key}, Name: {book.Value}");
// }


// foreach(var book in books){
//     Console.WriteLine($"ISBN: {book.Key}, Name: {book.Value}");
// }

// Implicit vs Explicit Typing
int number = 10;
string name = "Akhil";
var number1 = 20;
var name1 = "Azam";



/*----------------
    Dictionary
----------------*/

var items = Tuple.Create("Book1","Book2",111);
// Console.WriteLine($"Title: {items.Item1}");

var member = (Name: "Amir", Age: "25");

// Console.WriteLine($"Member: {member.Name}");

/*----------------
    ArrayList
----------------*/

ArrayList arrayItems = new ArrayList();

arrayItems.Add("Amir");
arrayItems.Add("Sadman");

// foreach(var item in arrayItems){
//     Console.WriteLine(item);
// }