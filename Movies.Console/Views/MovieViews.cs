using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp.Views
{
    public class MovieViews
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("1  Search all movies");
            Console.WriteLine("2  Search movies by Genre");
            Console.WriteLine("3  Search movies by Title");
            Console.WriteLine("4  Go back");
        }
    }
}
