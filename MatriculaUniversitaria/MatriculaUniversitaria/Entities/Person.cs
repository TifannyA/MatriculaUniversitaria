using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUniversitaria.Entities
{
    class Person
    {
        private int _id;
        private int _dni;
        private string _name;
        private string _last;
        private char _sex;
        private DateTime _bornDate;
        private string _academyLvl;
        private DateTime _admisionDate;
        private string _admisionUser;
        private string _nationality;
        private string _state;

        public Person(int id, int dni, string name, string last, char sex, DateTime bornDate, string academyLvl, DateTime admisionDate, string admisionUser, string nationality, string state)
        {
            _id = id;
            _dni = dni;
            _name = name;
            _last = last;
            _sex = sex;
            _bornDate = bornDate;
            _academyLvl = academyLvl;
            _admisionDate = admisionDate;
            _admisionUser = admisionUser;
            _nationality = nationality;
            _state = state;
        }

        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string last
        {
            get { return _last; }
            set { _last = value; }
        }

        public char sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public string  academyLvl
        {
            get { return _academyLvl; }
            set { _academyLvl = value; }
        }

        public DateTime bonrDate
        {
            get { return _bornDate; }
            set { _bornDate = value; }
        }

        public DateTime admisionDate
        {
            get { return _admisionDate; }
            set { _admisionDate = value; }
        }

        public string admisionUser
        {
            get { return _admisionUser; }
            set { _admisionUser = value; }
        }

        public string nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        public string state
        {
            get { return _state; }
            set { _state = value; }
        }



        public string printPerson() 
        {
            return this._id + "-"+this._dni + "-" + this._name + "-"+this._last+"-"+this._sex+"-"+this._bornDate
                +"-"+this._admisionDate+"-"+this._admisionUser+"-"+this._nationality+"-"+this._state;
        }

    }
}
