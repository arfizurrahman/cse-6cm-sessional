public class Singleton
{
    // Static field initializer calls instance constructor.
    private static Singleton instance = new Singleton();

    private Singleton()
    { 
        Console.WriteLine("Executes before static constructor.");
    }

    static Singleton()
    { 
        Console.WriteLine("Executes after instance constructor.");
    }

    public static Singleton Instance => instance;
}