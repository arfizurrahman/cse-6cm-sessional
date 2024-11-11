using System.IO;

string filePath = @"E:\IIUC\CSE\6CM - Software Development\Sessional (CSE 3638 - CSE 3640)\cse-6cm-sessional\Week 3\libraryData.txt";

string[] books = {"Designing Data Intensice Application","A guide to Modular Monolith", "Atomic Habits"};
// File.WriteAllLines(filePath,books);

if(File.Exists(filePath)){
    string[] readBooks = File.ReadAllLines(filePath);
    foreach(string book in readBooks){
        Console.WriteLine(book);
    }
}else{
    Console.WriteLine("File not found");
}