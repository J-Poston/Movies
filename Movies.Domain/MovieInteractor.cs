using Movies.DTO;
using Movies.Repository;

namespace Movies.Domain
{
    public class MovieInteractor
    {
        private MovieRepository _repo;
        public MovieInteractor()
        {
            _repo = new MovieRepository();
        }

        public bool Add(Movie movie)
        {
            if (string.IsNullOrEmpty(movie.Title))
            {
                throw new ArgumentException("Movie Title cannot be null.");
            }
            return _repo.Add(movie);
        }

        public List<Movie>? SearchByGenre(string genre)
        {
            return _repo.GetAll().Where(x => x.Genre.ToLower().Contains(genre.ToLower())).ToList();
        }

        public List<Movie>? SearchByTitle(string title)
        {
            return _repo.GetAll().Where(x => x.Title.ToLower().Contains(title.ToLower())).ToList();
        }

        public List<Movie>? GetAllMovies()
        {
            return _repo.GetAll();
        }

        public bool GetIfExists(int Id, out Movie movieToReturn)
        {
            Movie movie = _repo.GetById(Id);
            movieToReturn = movie;
            return movieToReturn != null;
        }

        public bool Update(Movie movieToUpdate)
        {
            if (string.IsNullOrEmpty(movieToUpdate.Title))
            {
                throw new ArgumentException("Title cannot be null.");
            }

            Movie movie = _repo.GetById(movieToUpdate.Id);

            if (movieToUpdate == null)
            {
                // The item does not exist
                return false;
            }
            _repo.Update(movieToUpdate);
            return true;
        }
        public bool Delete(int Id)
        {
            Movie movie = _repo.GetById(Id);
            if (movie == null)
            {
                // The item does not exits
                return false;
            }
            _repo.Delete(movie);
            return true;
        }

    }
}