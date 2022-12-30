using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp.Controllers
{
    public class MainController : Controller
    {
        public MainController(string menuName) : base(menuName)
        {
            this.MenuOptions.Add(1, "Movies");
            this.MenuOptions.Add(2, "Actors");
            this.MenuOptions.Add(3, "Exit");
        }
        public override void RunMenuChoice(int menuChoice, out bool exit)
        {
            switch (menuChoice)
            {
                case 1:
                    RunMoviesController();
                    exit = false;
                    break;

                case 2:
                    RunActorsController();
                    exit = false;
                    break;

                case 3:
                    Environment.Exit(0);
                    exit = true;
                    break;

                default:
                    exit = true;
                    break;
            }
        }

        public void RunMoviesController()
        {
            bool exitMovies = false;
            MoviesController moviesController = new MoviesController("Movie Database");
            while (exitMovies == false)
            {
                moviesController.DisplayMenu();
                int menuChoice = 0;
                string input = Console.ReadLine();
                bool validOption = moviesController.ValidateMenuChoice(input, out menuChoice);
                if (validOption) { moviesController.RunMenuChoice(menuChoice, out exitMovies); }
                // else errorMessage = 
            }
        }

        public void RunActorsController()
        {
            bool exitActors = false;
            ActorsController actorsController = new ActorsController("Actors Database");
            while(true)
            {
                actorsController.DisplayMenu();
                int menuChoice = 0;
                string input = Console.ReadLine();
                bool validOption = actorsController.ValidateMenuChoice(input, out menuChoice);
                if (validOption) { actorsController.RunMenuChoice(menuChoice, out exitActors); }
                // else errorMessage =
            }
        }
    }
}
