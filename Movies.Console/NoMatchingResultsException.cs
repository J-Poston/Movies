using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp
{
    public class NoMatchingResultsException : Exception
    {
        public NoMatchingResultsException() 
        {
            
        }

        public NoMatchingResultsException(string message) 
            : base(message) 
        { 

        }

        public NoMatchingResultsException(string message, Exception inner)
            : base(message,inner)
        {

        }
        
    }
}
