using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Entities
{
    public class CrewEntity
    {
        private int _idCrew;
        private string _firstName, _lastName, _job;

        public int IdCrew
        {
            get
            {
                return _idCrew;
            }

            set
            {
                _idCrew = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Job
        {
            get
            {
                return _job;
            }

            set
            {
                _job = value;
            }
        }
    }
}
