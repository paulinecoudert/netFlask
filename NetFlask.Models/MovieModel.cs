using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class MovieModel
    {
        private int _idMovie;
        private string _title;
        private string _cast, _directors, _genres;
        private string _normalPoster, _mediumPoster, _largePoster;
        private TimeSpan _duration;
        private double _rating;
        private double _criticsRating;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Cast
        {
            get
            {
                return _cast;
            }

            set
            {
                _cast = value;
            }
        }

        public string Directors
        {
            get
            {
                return _directors;
            }

            set
            {
                _directors = value;
            }
        }

        public string Genres
        {
            get
            {
                return _genres;
            }

            set
            {
                _genres = value;
            }
        }

        public string NormalPoster
        {
            get
            {
                return _normalPoster;
            }

            set
            {
                _normalPoster = value;
            }
        }

        public string MediumPoster
        {
            get
            {
                return _mediumPoster;
            }

            set
            {
                _mediumPoster = value;
            }
        }

        public string LargePoster
        {
            get
            {
                return _largePoster;
            }

            set
            {
                _largePoster = value;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }

            set
            {
                _rating = value;
            }
        }

        public double CriticsRating
        {
            get
            {
                return _criticsRating;
            }

            set
            {
                _criticsRating = value;
            }
        }

        public int IdMovie
        {
            get
            {
                return _idMovie;
            }

            set
            {
                _idMovie = value;
            }
        }
    }
}