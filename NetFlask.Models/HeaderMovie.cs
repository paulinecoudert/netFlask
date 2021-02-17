using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class HeaderMovie
    {
        #region Fields
        private string _title, _age, _directors, _description, _videoLink, _genres;
        private double _rating, _criticsRating;
        private DateTime _release;
        private string _bigPicture, _picture;
        #endregion
        #region Properties

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

        public string Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
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

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string VideoLink
        {
            get
            {
                return _videoLink;
            }

            set
            {
                _videoLink = value;
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

        public DateTime Release
        {
            get
            {
                return _release;
            }

            set
            {
                _release = value;
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

        public string BigPicture
        {
            get
            {
                return _bigPicture;
            }

            set
            {
                _bigPicture = value;
            }
        }

        public string Picture
        {
            get
            {
                return _picture;
            }

            set
            {
                _picture = value;
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
        #endregion
    }
}