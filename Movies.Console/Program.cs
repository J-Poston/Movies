using Movies.ConsoleApp.Controllers;
using Movies.Domain;
using Movies.DTO;

//PopulateMovies();

string errorMessage = null;
bool exit = false;
MainController mainController = new MainController("Main Menu");

while (exit == false)
{
    if (errorMessage != null)
    {
        WriteError(errorMessage);
    }
    mainController.DisplayMenu();
    int menuChoice = 0;
    string input = Console.ReadLine();
    bool validOption = mainController.ValidateMenuChoice(input, out menuChoice);
    if (validOption) { mainController.RunMenuChoice(menuChoice, out exit); }
    if (!validOption) { errorMessage = "Invalid entry"; }  
}


static void WriteError(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

static void PopulateMovies()
{
    MovieInteractor movieInteractor = new MovieInteractor();

    List<Movie> movies = new List<Movie>()
    {
        new Movie() {Title = "Shawshank Redemption", Genre="Drama",Runtime =142},
        new Movie() {Title = "Jurassic Park", Genre="Adventure",Runtime=127},
        new Movie() {Title = "Toy Story", Genre="Animated",Runtime=81},
        new Movie() {Title = "Fury", Genre="Action",Runtime=134},
        new Movie() {Title = "Central Intelligence", Genre="Comedy",Runtime=107},
        new Movie() {Title = "Dodgeball", Genre="Comedy",Runtime=92},
        new Movie() {Title = "Saving Private Ryan", Genre="Adventure",Runtime=169},
        new Movie() {Title = "The Prestige", Genre="Mystery",Runtime=130},
        new Movie() {Title = "The Rundown (2003)", Genre="Comedy",Runtime=104},
        new Movie() {Title = "The Dark Knight", Genre="Action",Runtime=152},
        new Movie() {Title = "Interstellar", Genre="Action",Runtime=169},
        new Movie() {Title = "Inception", Genre="Action",Runtime=158},
        new Movie() {Title = "Tenet", Genre="Adventure",Runtime=150},
        new Movie() {Title = "Memento", Genre="Mystery",Runtime=113},
        new Movie() {Title = "Avatar", Genre="Action",Runtime=162}
    };

    foreach(Movie movie in movies)
    {
        movieInteractor.Add(movie);
    }
}