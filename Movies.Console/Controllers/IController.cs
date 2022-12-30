using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp.Controllers
{
    public interface IController
    {
        string menuName { get; set; }
        public Dictionary<int, string> MenuOptions { get; set; }
        public void DisplayMenu();
        public bool ValidateMenuChoice(string input, out int menuChoice);
        public abstract void RunMenuChoice(int menuChoice, out bool exit);
    }
}
