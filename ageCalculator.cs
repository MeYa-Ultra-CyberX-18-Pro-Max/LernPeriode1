using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a date (DD/MM/YYYY):");
        DateTime enteredDate;

        // Check if the entered date is in the correct format
        if (DateTime.TryParse(Console.ReadLine(), out enteredDate))
        {
            while (true)
            {
                DateTime currentTime = DateTime.Now;

                // Calculate the elapsed time
                TimeSpan timeDifference = currentTime - enteredDate;

                // Calculate the years, months, and days
                int years = (int)(timeDifference.Days / 365.25);
                int months = (int)((timeDifference.Days % 365.25) / 30);
                int days = (int)((timeDifference.Days % 365.25) % 30);

                // Calculate the hours, minutes, and seconds
                int hours = timeDifference.Hours;
                int minutes = timeDifference.Minutes;
                int seconds = timeDifference.Seconds;

                // Display the elapsed time
                Console.Clear(); // Clear console to update the display
                Console.WriteLine($"Elapsed time: {years} years, {months} months, {days} days, {hours} hours, {minutes} minutes, {seconds} seconds.");

                // Wait for one second before updating the display
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid date in the format DD/MM/YYYY.");
        }
    }
}
