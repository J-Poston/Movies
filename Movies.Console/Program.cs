using Movies.ConsoleApp;

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
