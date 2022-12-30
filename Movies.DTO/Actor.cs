using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DTO
{
    public class Actor : Person
    {
        public Actor() 
        {
            
        }

        public Actor(string Name, DateTime? DateOfBirth) : base(Name, DateOfBirth)
        {

        }
    }
}
