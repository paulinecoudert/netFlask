using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class NewsModel
    {
        #region Fields
        private string _title, _description;
        private DateTime _theDate;
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

        public DateTime TheDate
        {
            get
            {
                return _theDate;
            }

            set
            {
                _theDate = value;
            }
        } 
        #endregion
    }
}