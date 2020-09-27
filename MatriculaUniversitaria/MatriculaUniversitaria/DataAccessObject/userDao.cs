using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaUniversitaria.Entities;

namespace MatriculaUniversitaria.DataAccessObject
{
    class userDao
    {

        private List<User> _users = new List<User>();

        public List<User> users
        {
            get { return _users; }
            set { _users = value; }
        }

        public userDao()
        {
            this._users = new List<User>(); ;
        }

    }
}
