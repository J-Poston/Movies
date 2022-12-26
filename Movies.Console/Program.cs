using Movies.ConsoleApp;
using Movies.Domain;
using Movies.DTO;

/*
int myInt = 0;
Console.WriteLine("Please enter a whole number.");
myInt = ConsoleInputHelper.GetInt();
Console.WriteLine($"You entered {myInt}");

double myDouble = 0;
Console.WriteLine("Please enter a decimal.");
myDouble = ConsoleInputHelper.GetDouble();
Console.WriteLine($"You entered {myDouble}");

bool myBool = false;
Console.WriteLine("Please enter true or false.");
myBool = ConsoleInputHelper.GetBool();
Console.WriteLine($"You entered {myBool}");
*/

PopulateMovies();

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
    Console.WriteLine("Success");
}