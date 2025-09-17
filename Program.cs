using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biobokaren
{
    internal class Program
    {
        
        
            const double TAX_RATE = 0.06;
            const double DISCOUNT_RATE = 0.15;
            const string CURRENCY = "SEK";

            static void Main(string[] args)

        {
            string[] movies = { "The Shawshank Redemption", "The Dark Knight", "Forrest Gump" };
            string[] showTimes = { "12:00", "15:00", "19:00" };
            double[] prices = { 100.0, 120.0, 150.0 };

            int selectedMovie = -1;
            int selectedTimeIndes = -1;
            int ticketCount = 0;
            bool isStudent = false;

            bool running = true;
            while (running)

                {

                ShowMenu();
                if (!int.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (menuChoice)

                {
                    case 1:
                        ListMovies(movies, showTimes, basePrices);
                        break;

                    case 2:
                        ListMovies(movies, showTimes, basePrices);
                        Console.Write("Select a movie by number: ", movies.Length - 1);
                        if ( (!int.TryParse(Console.ReadLine(), out int movieIdx) || movieIdx < 0 || movieIdx >= movies.Length)
                        {
                            Console.WriteLine("Invalid movie selection.");
                            break;
                        }

                        selectedMovie = movieIdx;

                        Console.WriteLine("Available showtimes:");
                        for (int i = 0; i < showTimes.Length; i++)
                            Console.WriteLine($"{i}. {showTimes[i]}");
                        Console.WriteLine("Enter the index of the desired showtime: ");
                        if (!int.TryParse(Console.ReadLine(), out int timeIdx) || timeIdx < 0 || timeIdx >= showTimes.Length)
                        {
                            Console.WriteLine("Invalid showtime selection.");
                            selectedTimeIndex = -1;
                            break;
                        }
                        selectedTimeIndex = timeIdx;

                        Console.Write("Enter number of tickets: ");
                        if (!int.TryParse(Console.ReadLine(), out ticketCount) || ticketCount <= 0)
                        {
                            Console.WriteLine("Invalid ticket count.");
                            ticketCount = 0;
                            break;
                        }
                        ticketCount = tickets;

                        Console.WriteLine($"Selectedt: {movies[selectedMovie]} at {showTimes[selectedTimeIndex]} for {ticketCount} tickets.");
                        break;

                    case 3:
                        isStudent = !isStudent;
                        Console.WriteLine(isStudent ? "Student discount applied." : "Student discount removed.");
                        break;

                    case 4:
                        if (selectedMovie < 0 || selectedTimeIndex < 0 || ticketCountt <= 0)
                            {
                            Console.WriteLine("Select a movie, showtime, and ticket count first.");
                            break;
                        }


        
    }
}
