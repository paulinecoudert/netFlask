using NetFlask.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class ReviewViewModel
    {
        #region Fields
        private List<ReviewModel> _reviews;
        private List<FeaturedCardModel> _featuredToday;
        private List<FeaturedCardModel> _featuredEntertainement;
        private List<FeaturedCardModel> _alsoLike;
        private List<SliderModel> _slider;
        #endregion

        #region Properties
        public List<ReviewModel> Reviews
        {
            get
            {
                return _reviews;
            }

            set
            {
                _reviews = value;
            }
        }

        public List<FeaturedCardModel> FeaturedToday
        {
            get
            {
                return _featuredToday;
            }

            set
            {
                _featuredToday = value;
            }
        }

        public List<FeaturedCardModel> FeaturedEntertainement
        {
            get
            {
                return _featuredEntertainement;
            }

            set
            {
                _featuredEntertainement = value;
            }
        }

        public List<FeaturedCardModel> AlsoLike
        {
            get
            {
                return _alsoLike;
            }

            set
            {
                _alsoLike = value;
            }
        }

        public List<SliderModel> Slider
        {
            get
            {
                return _slider;
            }

            set
            {
                _slider = value;
            }
        }
        #endregion

        public ReviewViewModel()
        {
            //SectionReview
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            Reviews = ctx.GetAllReviewsMovies();
            //ReviewModel rm = new ReviewModel()
            //{
            //    Movie = new MovieModel() { Title = "Interstellar", Cast = "Will Smith, Margot Robbie, Adrian Martinez, Rodrigo Santoro, BD Wong, Robert Taylor", Directors = "Glenn Ficarra, John Requa", Genres = "Crime", Duration = new TimeSpan(1, 45, 0), MediumPoster = "r4.jpg" },
            //    CriticRating = 3.5,
            //    ReaderRating = 3.3,
            //    Locality = "TNN",
            //    User = "Reagan Gavin Rasquinha",
            //    ReviewDate = new DateTime(2015, 3, 12),
                
            //};
            //Reviews.Add(rm);

            //rm = new ReviewModel()
            //{
            //    Movie = new MovieModel() { Title = "Big Hero", Cast = "Will Smith, Margot Robbie, Adrian Martinez, Rodrigo Santoro, BD Wong, Robert Taylor", Directors = "Glenn Ficarra, John Requa", Genres = "Crime", Duration = new TimeSpan(1, 45, 0), MediumPoster="r5.jpg" },
            //    CriticRating = 3.5,
            //    ReaderRating = 3.3,
            //    Locality = "TNN",
            //    User = "Reagan Gavin Rasquinha",
            //    ReviewDate = new DateTime(2015, 3, 12)
            //};
            //Reviews.Add(rm);
            
            //rm = new ReviewModel()
            //{
            //    Movie = new MovieModel() { Title = "Lego Movie", Cast = "Will Smith, Margot Robbie, Adrian Martinez, Rodrigo Santoro, BD Wong, Robert Taylor", Directors = "Glenn Ficarra, John Requa", Genres = "Crime", Duration = new TimeSpan(1, 45, 0), MediumPoster = "r1.jpg" },
            //    CriticRating = 3.5,
            //    ReaderRating = 3.3,
            //    Locality = "TNN",
            //    User = "Reagan Gavin Rasquinha",
            //    ReviewDate = new DateTime(2015, 3, 12)
            //};
            //Reviews.Add(rm);

            //rm = new ReviewModel()
            //{
            //    Movie = new MovieModel() { Title = "SpiderMan", Cast = "Will Smith, Margot Robbie, Adrian Martinez, Rodrigo Santoro, BD Wong, Robert Taylor", Directors = "Glenn Ficarra, John Requa", Genres = "Crime", Duration = new TimeSpan(1, 45, 0), MediumPoster = "r2.jpg" },
            //    CriticRating = 3.5,
            //    ReaderRating = 3.3,
            //    Locality = "TNN",
            //    User = "Reagan Gavin Rasquinha",
            //    ReviewDate = new DateTime(2015, 3, 12)
            //};
            //Reviews.Add(rm);

            //rm = new ReviewModel()
            //{
            //    Movie = new MovieModel() { Title = "Iron Man 3", Cast = "Will Smith, Margot Robbie, Adrian Martinez, Rodrigo Santoro, BD Wong, Robert Taylor", Directors = "Glenn Ficarra, John Requa", Genres = "Crime", Duration = new TimeSpan(1, 45, 0), MediumPoster = "r3.jpg" },
            //    CriticRating = 3.5,
            //    ReaderRating = 3.3,
            //    Locality = "TNN",
            //    User = "Reagan Gavin Rasquinha",
            //    ReviewDate = new DateTime(2015, 3, 12)
            //};
            //Reviews.Add(rm);


            //FeaturedToday
            FeaturedToday = new List<FeaturedCardModel>();
            FeaturedToday.Add(new FeaturedCardModel() { MoreInfo = "", Movies = new MovieModel() { Title = "Plaguers", NormalPoster = "f1.jpg" } });
            FeaturedToday.Add(new FeaturedCardModel() { MoreInfo = "", Movies = new MovieModel() { Title = "Priest", NormalPoster = "f2.jpg" } });
            FeaturedToday.Add(new FeaturedCardModel() { MoreInfo = "", Movies = new MovieModel() { Title = "Avatar", NormalPoster = "f3.jpg" } });
            FeaturedToday.Add(new FeaturedCardModel() { MoreInfo = "", Movies = new MovieModel() { Title = "Jurasic World", NormalPoster = "f4.jpg" } });
            FeaturedToday.Add(new FeaturedCardModel() { MoreInfo = "", Movies = new MovieModel() { Title = "A la poursuite de demain", NormalPoster = "f5.jpg" } });
            FeaturedToday.Add(new FeaturedCardModel() { MoreInfo = "", Movies = new MovieModel() { Title = "Bombay Velvet", NormalPoster = "f6.jpg" } });


            //FeaturedEnt
            FeaturedEntertainement = new List<FeaturedCardModel>();
            FeaturedEntertainement.Add(new FeaturedCardModel() { MoreInfo = "Watch ‘Bombay Velvet’ trailer during WC match", Movies = new MovieModel() { Title = "Bombay Velvet", NormalPoster = "f6.jpg" } });
            FeaturedEntertainement.Add(new FeaturedCardModel() { MoreInfo = "Watch ‘Bombay Velvet’ trailer during WC match", Movies = new MovieModel() { Title = "A la poursuite de demain", NormalPoster = "f5.jpg" } });
            FeaturedEntertainement.Add(new FeaturedCardModel() { MoreInfo = "Watch ‘Bombay Velvet’ trailer during WC match", Movies = new MovieModel() { Title = "Jurasic World", NormalPoster = "f4.jpg" } });
            FeaturedEntertainement.Add(new FeaturedCardModel() { MoreInfo = "Watch ‘Bombay Velvet’ trailer during WC match", Movies = new MovieModel() { Title = "Avatar", NormalPoster = "f3.jpg" } });
            FeaturedEntertainement.Add(new FeaturedCardModel() { MoreInfo = "Watch ‘Bombay Velvet’ trailer during WC match", Movies = new MovieModel() { Title = "Priest", NormalPoster = "f2.jpg" } });
            FeaturedEntertainement.Add(new FeaturedCardModel() { MoreInfo = "Watch ‘Bombay Velvet’ trailer during WC match", Movies = new MovieModel() { Title = "Plaguers", NormalPoster = "f1.jpg" } });



            //AlsoLike
            AlsoLike = new List<FeaturedCardModel>();
            AlsoLike.Add(new FeaturedCardModel() { MoreInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movies = new MovieModel() { Title = "Lorem Ipsum", MediumPoster = "mi.jpg" } });
            AlsoLike.Add(new FeaturedCardModel() { MoreInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movies = new MovieModel() { Title = "Lorem Ipsum", MediumPoster = "mi1.jpg" } });
            AlsoLike.Add(new FeaturedCardModel() { MoreInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movies = new MovieModel() { Title = "Lorem Ipsum", MediumPoster = "mi2.jpg" } });
            AlsoLike.Add(new FeaturedCardModel() { MoreInfo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movies = new MovieModel() { Title = "Lorem Ipsum", MediumPoster = "mi3.jpg" } });

            //Section Slider
            Slider = new List<SliderModel>();
            Slider.Add(new SliderModel() { Link = "#", Picture = "m1.jpg" });
            Slider.Add(new SliderModel() { Link = "#", Picture = "m2.jpg" });
            Slider.Add(new SliderModel() { Link = "#", Picture = "m3.jpg" });
            Slider.Add(new SliderModel() { Link = "#", Picture = "m4.jpg" });
        }
    }
}