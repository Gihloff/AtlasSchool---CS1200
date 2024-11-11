using System.Security.Cryptography.X509Certificates;
using LockerRental.DTOs;

namespace LockerRental.Actions
{
    public static class ConsoleIO
    {
        public static string GetRequiredString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input));
            return input;
        }

        public static void DisplayLockerContents(LockerContents dto, int LockerNumber)
        {
            if (dto == null)
            {
                Console.WriteLine($"Locker {LockerNumber} is EMPTY.");
            }
            else
            {
                Console.WriteLine($"Locker {LockerNumber} contains: {dto.Description} (Rented by {dto.RenterName})");
            }
        }

        public static int GetLockerNumber()
        {
            int LockerNumber;
            do
            {
                Console.Write("Enter Locker Number (1-100): ");
            } while (!int.TryParse(Console.ReadLine(), out LockerNumber) || LockerNumber < 1 || LockerNumber > 100);
            return LockerNumber;
        }

        public static int GetMenuOption()
        {
            Console.Clear();
            Console.WriteLine("Locker Rental Menu");
            Console.WriteLine("=============================");
            Console.WriteLine("1. View a locker");
            Console.WriteLine("2. Rent a locker");
            Console.WriteLine("3. End a locker rental");
            Console.WriteLine("4. List all locker contents");
            Console.WriteLine("5. Quit");
            Console.Write("\nEnter your choice (1-5): ");

            int Choice;
            while (!int.TryParse(Console.ReadLine(), out Choice) || Choice < 1 || Choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }

            return Choice;
        }

        public static void AnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

}