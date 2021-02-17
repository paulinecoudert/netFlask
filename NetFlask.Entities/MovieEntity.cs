    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Entities
{
    public class MovieEntity
    {
        #region Fields
        private int _idMovie;
        private string _title;
        private int _duration;
        private string _picture;
        private string __trailer;
        private DateTime? _releaseDate;
        private string _summary;
        private string _shortDescription;
        private double _rating;
        private double _criticsRating;
        #endregion

        #region Properties
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

        public int Duration
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

        public string Trailer
        {
            get
            {
                return __trailer;
            }

            set
            {
                __trailer = value;
            }
        }

        public DateTime? ReleaseDate
        {
            get
            {
                return _releaseDate;
            }

            set
            {
                _releaseDate = value;
            }
        }

        public string Summary
        {
            get
            {
                return _summary;
            }

            set
            {
                _summary = value;
            }
        }

        public string ShortDescription
        {
            get
            {
                return _shortDescription;
            }

            set
            {
                _shortDescription = value;
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
        #endregion
    }
}
