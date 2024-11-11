namespace OOPBasicsApp;

public class DbConnection {
    private static readonly string connectionString;

    // No access modifier
    // No parameters
    // Implicit Invocation
    // Single Execution
    // Runs before the instance constructors 
    static DbConnection() {
        connectionString = "connection string";
        Console.WriteLine($"Connection string is set to: {connectionString} inside static constructor");
    }

    public DbConnection() {
        Console.WriteLine("Default constructor called");
    }
}