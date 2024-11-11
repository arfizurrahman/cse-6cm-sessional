
public class ExampleClass
{
// Static variable that must be initialized at runtime
private static readonly long baseline;

// Static constructor
static ExampleClass()
{
baseline = DateTime.Now.Ticks;
Console.WriteLine("Static constructor sets baseline to {0}", baseline);
}

// Instance constructor
public ExampleClass()
{
Console.WriteLine("Instance constructor called.");
}

}