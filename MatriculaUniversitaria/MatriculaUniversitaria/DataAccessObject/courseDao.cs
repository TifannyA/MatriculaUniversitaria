using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaUniversitaria.Entities;

namespace MatriculaUniversitaria.DataAccessObject
{
    class coruseDao
    {
        private List<Course> _courses;

        public List<Course> courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public coruseDao()
        {
            this._courses = new List<Course>(); ;
        }

    }
}
