using NetFlask.DAL.Repositories;
using NetFlask.Entities;
using NetFlask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Repositories
{
    //alias du datacontext
    public class DataContext
    {
        IConcreteRepository<MovieEntity> _movieRepo;
        IConcreteRepository<GenreEntity> _genreRepo;
        IConcreteRepository<CrewEntity> _crewRepo;
        IConcreteRepository<MessageEntity> _messageRepository;
        IConcreteRepository<RatingEntity> _ratingRepository;

        public DataContext(string connectionString)
        {
            _movieRepo = new MovieRepository(connectionString);
            _genreRepo = new GenreRepository(connectionString);
            _crewRepo = new CrewRepository(connectionString);
            _messageRepository = new MessageRepository(connectionString);
            _ratingRepository = new RatingRepository(connectionString);
        }

        #region Movies

        public HeaderMovie GetHeaderMovie()
        {
            //Récupération de mon entity
            MovieEntity movieFromDB = _movieRepo.GetOne(12);
            List<GenreEntity> genresFromDb = ((GenreRepository)_genreRepo).GetFromMovie(330457);
            string genres = "";
            foreach (GenreEntity item in genresFromDb)
            {
                  genres += item.Label + ",";
            }
            genres = genres.Substring(0, genres.Length - 1);
            List<CrewEntity> DirectorsFromDb = ((CrewRepository)_crewRepo).GetDirectors(330457);
            string directors = "";
            foreach (CrewEntity item in DirectorsFromDb)
            {
                directors += item.FirstName+" "+item.LastName + ",";
            }
            directors = directors.Substring(0, directors.Length - 1);

            //Mapping de l'entity vers le model
            HeaderMovie movieForController = new HeaderMovie();
            movieForController.Title = movieFromDB.Title; //"Frozen II";
            movieForController.Age = "All Age";
            movieForController.Directors = directors;
            movieForController.Rating = movieFromDB.Rating; //((RatingRepository)_ratingRepository).GetByMovie(movieFromDB.IdMovie).Average(m => m.Score);
            movieForController.CriticsRating = movieFromDB.CriticsRating;
            movieForController.Genres = genres;
            movieForController.Release = movieFromDB.ReleaseDate.Value; //new DateTime(2019, 11, 22);
            movieForController.Description = movieFromDB.Summary; //"Anna, Elsa, Kristoff, Olaf and Sven leave Arendelle to travel to an ancient, autumn-bound forest of an enchanted land. They set out to find the origin of Elsa's powers in order to save their kingdom";
            movieForController.VideoLink = movieFromDB.Trailer; //"#";
            movieForController.BigPicture = "https://www.themoviedb.org/t/p/original" + movieFromDB.Picture; //"FrozenII.jpg";

            return movieForController;
        }

        public List<MovieModel> GetAllMovies()
        {
            return _movieRepo.Get()
                .Select(m => 
                new MovieModel() { 
                    Title = m.Title, Duration = new TimeSpan(m.Duration) }
                ).ToList(); 
        }
        #endregion

        #region Contact
        public bool SaveContact(ContactModel cm)
        {
            //MAppers
            MessageEntity me = new MessageEntity();
            me.Nom = cm.Nom;
            me.Email = cm.Email;
            me.Information = cm.Message;
            me.Phone = cm.Phone;

            return _messageRepository.Insert(me);
        }
        #endregion

        #region Review
        public List<ReviewModel> GetAllReviewsMovies()
        {
            return _movieRepo.Get()
                .Select(m =>
                new ReviewModel()
                {
                    Movie = new MovieModel()
                    {
                        IdMovie = m.IdMovie,
                        Title = m.Title,
                        Genres = String.Join(", ", ((GenreRepository)_genreRepo).GetFromMovie(m.IdMovie).Select(p => p.Label)),
                        Directors = String.Join(", ", ((CrewRepository)_crewRepo).GetDirectors(m.IdMovie).Select(p =>  p.FirstName + " " + p.LastName)),
                         Duration = new TimeSpan(m.Duration),
                         MediumPoster= "https://www.themoviedb.org/t/p/original"+m.Picture
                     },
                      CriticRating = m.CriticsRating,
                       ReaderRating = m.Rating
                }
                
                ).ToList();
        }
        #endregion
    }
}
