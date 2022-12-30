using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp.Controllers
{
    public class ActorsController : Controller
    {
        public ActorsController(string menuName) : base(menuName)
        {
            this.MenuOptions.Add(1, "Show all Actors");
            this.MenuOptions.Add(2, "Search by name");
            this.MenuOptions.Add(3, "Return to main menu");
        }
        public override void RunMenuChoice(int menuChoice, out bool exit)
        {
            switch (menuChoice)
            {
                case 1:
                    exit = true;
                    break;

                case 2:
                    exit = true;
                    break;

                case 3:
                    exit = true;
                    break;

                default:
                    exit = true;
                    break;
            }
        }
    }
}
