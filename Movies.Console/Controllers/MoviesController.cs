using Movies.ConsoleApp.Views;
using Movies.Domain;
using Movies.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Movies.ConsoleApp.Controllers
{
    public class MoviesController : Controller
    {

        public MovieInteractor movieInteractor { get; set; }
        public List<Movie>? movies { get; set; }

        public MoviesController(string menuName) : base(menuName)
        {
            this.MenuOptions.Add(1, "Show all movies");
            this.MenuOptions.Add(2, "Search by genre");
            this.MenuOptions.Add(3, "Search by title");
            this.MenuOptions.Add(4, "Return to main menu");          
        }

        public override void RunMenuChoice(int menuChoice, out bool exit)
        {
            switch (menuChoice)
            {
                case 1:
                    ShowAllMovies();
                    exit = false;
                    break;
                
                case 2:
                    SearchByGenre();
                    exit = false;
                    break;

                case 3:
                    SearchByTitle();
                    exit = false;
                    break;

                case 4:
                    exit = true;
                    break;

                default:
                    exit = true; 
                    break;
            }
        }

        public void ShowAllMovies()
        {
            Console.WriteLine("Searching for movies ...");
            movieInteractor = new MovieInteractor();
            movies = movieInteractor.GetAllMovies();
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title}  {movie.Genre}  {movie.Runtime}");
            }
        }
        public void SearchByGenre()
        {
            Console.Write("Please enter a movie genre: ");
            string title = Console.ReadLine();
            movieInteractor = new MovieInteractor();
            movies = movieInteractor.SearchByGenre(title);
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title}  {movie.Genre}  {movie.Runtime}");
            }
        }
        public void SearchByTitle()
        {
            Console.Write("Please enter a movie title: ");
            string title = Console.ReadLine();
            movieInteractor = new MovieInteractor();
            movies = movieInteractor.SearchByTitle(title);
            foreach(Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title}  {movie.Genre}  {movie.Runtime}");
            }
        }
    }
}
