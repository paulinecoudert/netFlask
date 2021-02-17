using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class SliderModel
    {
        #region Fields 
        private string _link, _picture; 
        #endregion

        #region Properties
        public string Link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
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
        #endregion
    }
}