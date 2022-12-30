using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp.Controllers
{
    public abstract class Controller : IController
    {
        public string menuName { get; set; }
        public Dictionary<int, string> MenuOptions { get; set; }
        public string input { get; set; }
        public Controller(string menuName) 
        {
            this.menuName = menuName;
            MenuOptions = new Dictionary<int, string>();   
        }        

        public void DisplayMenu()
        {
            Console.WriteLine("**********");
            Console.WriteLine(menuName);
            Console.WriteLine("**********");
            foreach (KeyValuePair<int, string> option in MenuOptions)
            {
                Console.WriteLine($"{option.Key} {option.Value}");
            }
        }
        public bool ValidateMenuChoice(string input, out int menuChoice)
        {
            int.TryParse(input, out menuChoice);
            if(MenuOptions.ContainsKey(menuChoice)) { return true; }
            else { return false; }
        }
        public abstract void RunMenuChoice(int menuChoice, out bool exit);

    }
}
