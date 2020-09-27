using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaUniversitaria.Entities;

namespace MatriculaUniversitaria.Entities
{
    class User : Person
    {
        private int _user;
        private int _pass;

        public int user
        {
            get { return _user; }
            set { _user = value; }
        }

        public int pass
        {
            get { return _pass; }
            set { _pass = value; }
        }



        public User (int id, int dni, string name, string last, char sex, DateTime bornDate, string academyLvl, DateTime admisionDate, string admisionUser, string nationality, string state,int user,string pass) 
            : base (id, dni, name, last, sex, bornDate, academyLvl, admisionDate, admisionUser, nationality, state)
        {
            this.user = _user;
            this.pass = _pass;
        }
    }
}
