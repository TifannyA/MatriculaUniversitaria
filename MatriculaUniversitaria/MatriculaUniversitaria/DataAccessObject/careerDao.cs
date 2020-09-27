using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaUniversitaria.Entities;

namespace MatriculaUniversitaria.DataAccessObject
{
    class careerDao
    {
        private List<Career> _careers;

        public List<Career> careers
        {
            get { return _careers; }
            set { _careers = value; }
        }

        public careerDao()
        {
            this._careers = new List<Career>(); ;
        }
    }
}
