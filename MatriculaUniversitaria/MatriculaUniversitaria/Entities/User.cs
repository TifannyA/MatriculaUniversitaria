using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaUniversitaria.Entities;

namespace MatriculaUniversitaria.Entities
{
    class User
    {
        private int _user;
        private string _code;
        private int _idPerson;
        private string _pass;

        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }


        public int idPerson
        {
            get { return _idPerson; }
            set { _idPerson = value; }
        }


        public string code
        {
            get { return _code; }
            set { _code = value; }
        }


        public int user
        {
            get { return _user; }
            set { _user = value; }
        }

        public string toString() 
        {
            return this._user + "-" +this._code+"-"+this._idPerson;
        }

    }
}
