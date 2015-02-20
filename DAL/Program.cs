using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Net.Mime;
using DAL.Models;

namespace DAL
{
    class Program
    {
        private static void Main(string[] args)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PaulContext>());
            DatabaseHelper dbHelper = new DatabaseHelper();
            var isRunning = true;
            var isTesting = false;
            if (isTesting)
            {
                dbHelper.AddToDatabase(true);
            }

            string cmd;
            while (isRunning)
            {
                Console.Write("Film Name: ");
                var filmName = Console.ReadLine();
                Console.Write("Genre: ");
                var genre = Console.ReadLine();
                Console.Write("Synopsis: ");
                var synopsis = Console.ReadLine();
                Console.Write("Rating: ");
                decimal rating;
                decimal.TryParse(Console.ReadLine(), out rating);
                Console.Write("Release Date:");
                int releaseDate;
                int.TryParse(Console.ReadLine(), out releaseDate);

                Console.Write("Select Mode:");
                cmd = Console.ReadLine().ToLower();
                switch (cmd)
                {
                    case "imdb":
                        dbHelper.AddImdbInfo(filmName, genre, rating, releaseDate, synopsis);
                        break;

                    case "psnl":
                        dbHelper.AddToDatabase(filmName, genre, rating, releaseDate, synopsis, null, false);
                        break;
                }
                
            }
        }
    }
}
