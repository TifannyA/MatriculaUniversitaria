using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaUniversitaria.Entities;

namespace MatriculaUniversitaria.DataAccessObject
{
    class personDao
    {
        private List<Person> _people = new List<Person>();

        public List<Person> people
        {
            get { return _people; }
            set { _people = value; }
        }

        public personDao()
        {
            this._people = new List<Person>(); ;
        }

    }
}
