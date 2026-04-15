namespace NetDev;

public class PhoneBook
{
    private Entry[] entries;
    public PhoneBook(Entry[] entries)
    {this.entries = entries;}

    public string Find(string firstName, string lastName)
    {
        int left = 0;
        int right = entries.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            Entry current = entries[mid];

            int lastNameCompare = string.Compare(
                lastName,
                current.GetLastName(),
                StringComparison.Ordinal
            );

            if (lastNameCompare == 0)
            {
                int firstNameCompare = string.Compare(
                    firstName,
                    current.GetFirstName(),
                    StringComparison.Ordinal
                );

                if (firstNameCompare == 0)
                {
                    return current.GetPhoneNumber(); 
                } 
                if (firstNameCompare < 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else if (lastNameCompare < 0)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return null; 
    }
}

