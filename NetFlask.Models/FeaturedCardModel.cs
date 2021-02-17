using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class FeaturedCardModel
    {
        private MovieModel _movies;
        private string _moreInfo;

        public MovieModel Movies
        {
            get
            {
                return _movies;
            }

            set
            {
                _movies = value;
            }
        }

        public string MoreInfo
        {
            get
            {
                return _moreInfo;
            }

            set
            {
                _moreInfo = value;
            }
        }
    }
}