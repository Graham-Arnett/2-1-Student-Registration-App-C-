using System.Diagnostics;

namespace StudentRegApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Registration App");

            String choice;
            //start loop
            do
            {
                Console.Write("Enter first name: ");
                String firstName = Console.ReadLine();

                Console.Write("Enter last name: ");
                String lastName = Console.ReadLine();

                Console.Write("Enter birth year: ");
                String birthyear = Console.ReadLine();

                String password = firstName + birthyear;

                Console.WriteLine($"Welcome  {firstName} {lastName}");
                Console.WriteLine("Registration complete.");
                Console.WriteLine($"Your temporary password is: {password}");
                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToUpper().Trim(); ;
            }while(choice == "Y");
            Console.WriteLine("Goodbye");
        }
    }
}
