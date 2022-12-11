using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Repository
{
    public class MovieRepository
    {
        AppDbContext db;

        public MovieRepository()
        {
            db = new AppDbContext();
        }
    }
}
