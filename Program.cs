using System;

namespace Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write on the same line");
            Console.WriteLine("This will \nwrap to the next line");
            Console.WriteLine("This will \"print out the quotation mark.");

            string firstName = "evans";
            string lastName = "Fundira";

            // Concatenation
            Console.WriteLine(firstName + " " + lastName);

            // Functions with strings
            Console.WriteLine("Length of last name: " + lastName.Length);

            // Methods on strings
            Console.WriteLine("First name in uppercase: " + firstName.ToUpper());

            // Method with a parameter (e.g., Contains), it's case-sensitive
            Console.WriteLine("Does last name contain 'fu'? " + lastName.Contains("fu"));

            // Access characters using index
            Console.WriteLine("First character of first name: " + firstName[0]);

            // IndexOf will tell you if the value is there and at what position
            Console.WriteLine("Index of 'a' in last name: " + lastName.IndexOf('a'));

            // Substring, to grab from an index onwards
            Console.Write("Substring of first name from index 1: ");
            Console.WriteLine(firstName.Substring(1));

            // You can also give index and length, i.e., how many characters you want to grab
            Console.Write("Substring of first name from index 1, length 2: ");
            Console.WriteLine(firstName.Substring(1, 2));

            Console.Read();
        }
    }
}
