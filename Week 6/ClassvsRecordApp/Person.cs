public class PersonClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";

    public PersonClass(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public record PersonRecord(string FirstName, string LastName)
{
    public string FullName => $"{FirstName} {LastName}";
};