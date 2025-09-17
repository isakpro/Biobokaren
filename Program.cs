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
        }
        
    }
}
