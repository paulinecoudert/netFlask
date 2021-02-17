using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class ReviewModel
    {
        private MovieModel _movie;
        private string _user;
        private string _locality;
        private DateTime _reviewDate;

        private double _criticRating;
        private double _readerRating;

        

         

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string Locality
        {
            get
            {
                return _locality;
            }

            set
            {
                _locality = value;
            }
        }

        public DateTime ReviewDate
        {
            get
            {
                return _reviewDate;
            }

            set
            {
                _reviewDate = value;
            }
        }

        public double CriticRating
        {
            get
            {
                return _criticRating;
            }

            set
            {
                _criticRating = value;
            }
        }

        public double ReaderRating
        {
            get
            {
                return _readerRating;
            }

            set
            {
                _readerRating = value;
            }
        }

         

        

        public MovieModel Movie
        {
            get
            {
                return _movie;
            }

            set
            {
                _movie = value;
            }
        }
    }
}