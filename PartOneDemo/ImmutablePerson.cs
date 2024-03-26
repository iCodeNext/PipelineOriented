namespace PartOneDemo;
public record Person(string FirstName, string LastName, string Email)
{
    public Person WithName(string firstName)
    {
        return this with { FirstName = firstName };
    }

    public Person WithLastName(string lastName)
    {
        return this with { LastName = lastName };
    }

    public Person WithEmail(string email)
    {
        return this with { Email = email };
    }
}