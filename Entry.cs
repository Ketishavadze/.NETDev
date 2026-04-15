namespace NetDev;

public class Entry
{
    private string? lastName;
    private string? firstName;
    private string? phoneNumber;

    public Entry(string? firstName, string? lastName, string? phoneNumber)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.phoneNumber = phoneNumber;
    }
    
    public string? GetLastName() => lastName;
    public string? GetFirstName() => firstName;
    public string? GetPhoneNumber() => phoneNumber;
}