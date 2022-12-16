using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Movies.DTO;


namespace Movies.Repository
{
    public class MovieRepository
    {
        
        private IConfigurationRoot _configuration;
        private DbContextOptionsBuilder<AppDbContext> _optionsBuilder;

        public MovieRepository()
        {
            BuildOptions();
        }
        public void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ProductionDatabase"));
        }

        public Movie GetById(int Id)
        {
            using (AppDbContext db = new AppDbContext(_optionsBuilder.Options))
            {
                return db.Movies.FirstOrDefault(x => x.Id == Id);
            }
        }
        public List<Movie> GetAll()
        {
            using (AppDbContext db = new AppDbContext(_optionsBuilder.Options))
            {
                return db.Movies.ToList();
            }
        }
        public bool Add(Movie movie)
        {
            using (AppDbContext db = new AppDbContext(_optionsBuilder.Options))
            {
                Movie existingMovie = db.Movies.FirstOrDefault(x => x.Title == movie.Title);

                if(existingMovie == null)
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                    return true;
                }
                
                return false;
            }            
        }

        public bool Update(Movie movie)
        {
            using (AppDbContext db = new AppDbContext(_optionsBuilder.Options))
            {
                Movie checkMovie = db.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
                if(checkMovie != null)
                {
                    db.Movies.Update(movie);
                    db.SaveChanges();
                    return true;
                }                
                return false;
            }                
        }

        public bool Delete(int movieId)
        {
            using (AppDbContext db = new AppDbContext(_optionsBuilder.Options))
            {
                Movie movie = db.Movies.Where(x => x.Id == movieId).FirstOrDefault();
                if(movie != null)
                {
                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    return true;
                }                
                return false;
            }                
        }
        public bool Delete(Movie movie)
        {
            using (AppDbContext db = new AppDbContext(_optionsBuilder.Options))
            {
                Movie checkMovie = db.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
                if (checkMovie != null)
                {
                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
