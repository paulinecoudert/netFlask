using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Entities
{
    public class GenreEntity
    {
        private int _idGenre;
        private string _label;

        public int IdGenre
        {
            get
            {
                return _idGenre;
            }

            set
            {
                _idGenre = value;
            }
        }

        public string Label
        {
            get
            {
                return _label;
            }

            set
            {
                _label = value;
            }
        }
    }
}
