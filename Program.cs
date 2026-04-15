// See https://aka.ms/new-console-template for more information

using NetDev;

Entry[] entries = new Entry[5]; 
entries[0] = new Entry("Agathe", "Ackermann", "555-11133322"); 
entries[1] = new Entry("Bernd", "Ackermann", "555-2251243"); 
entries[2] = new Entry("Winfried", "Becker", "555-225123"); 
entries[3] = new Entry("Alex", "Diess", "555-343112"); 
entries[4] = new Entry("Beatrix", "Diess", "555-2123123"); 
PhoneBook phoneBook = new PhoneBook(entries); 
// Here, the output should be true: 
Console.WriteLine( 
    entries[0].GetPhoneNumber().Equals(phoneBook.Find("Agathe", "Ackermann")) ); 
