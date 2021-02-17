using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class VideoTileModel
    {
        private string _picture, _description, _name, _video;
        private bool _isLastCol;
         

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

        public bool IsLastCol
        {
            get
            {
                return _isLastCol;
            }

            set
            {
                _isLastCol = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Video
        {
            get
            {
                return _video;
            }

            set
            {
                _video = value;
            }
        }
    }
}