using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUniversitaria.Entities
{
    class Course
    {
        private int _id;
        private string _name;
        private int _credits;
        private int _idCareer;
        private int _price;
        private int _totalCost;

        public int totalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }


        public int price
        {
            get { return _price; }
            set { _price = value; }
        }


        public int idCareer
        {
            get { return _idCareer; }
            set { _idCareer = value; }
        }


        public int credits
        {
            get { return _credits; }
            set { _credits = value; }
        }


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string toString()
        {
            return this._id + "," + this._name + "," + this._credits + "," + this._idCareer + "," + this._price + "," + this._totalCost;
        }

    }
}
