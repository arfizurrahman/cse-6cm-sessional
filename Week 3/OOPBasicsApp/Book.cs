namespace OOPBasicsApp;

class Book{
    public string Title { get; set; }
    public string Author { get; set; }
    
    public Book() : this("Default Title")
    {

    }

    public Book(string title) : this(title, "Unknown Author")
    {
        
    }

    public Book(string title, string author){
        Title = title;
        Author = author;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}