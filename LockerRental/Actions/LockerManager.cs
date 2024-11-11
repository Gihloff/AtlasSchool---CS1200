using LockerRental.DTOs;
using LockerRental.Actions;

namespace LockerRental.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers = new LockerContents[100];

        public void ListContents()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                ConsoleIO.DisplayLockerContents(_lockers[i], i + 1);
            }
        }

        public void ViewLocker(int number)
        {
            int index = number - 1;
            ConsoleIO.DisplayLockerContents(_lockers[index], number);

        }
        public void RentLocker(int number)
        {
            int index = number - 1;

            if (_lockers[index] != null)
            {
                Console.WriteLine($"Sorry, locker {number} is already rented");
                return;
            }

            string description = ConsoleIO.GetRequiredString("Enter item to store in the locker: ");
            string renterName = ConsoleIO.GetRequiredString("Enter your full name: ");

            _lockers[index] = new LockerContents { Description = description, RenterName = renterName };

            Console.WriteLine($"Locker {number} has been rented for storing: {description}. Rented by: {renterName}");
        }

        public void EndRental(int number)
        {
            int index = number - 1;

            if (_lockers[index] == null)
            {
                Console.WriteLine($"Locker {number} is not currently rented.");
                return;
            }

            Console.WriteLine($"Rental for Locker {number} has ended. Please take your {_lockers[index].Description}.");
            _lockers[index] = null;
        }
    }
}