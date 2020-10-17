using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUniversitaria.Entities
{
    class Course
    {
        private string _id;
        private string _name;
        private int _credits;
        private string _idCareer;
        private int _price;
        private int _totalCost;

        public Course()
        {
        }
        public Course(string id, string name, int credits, string idCareer, int price, int totalCost)
        {
            _id = id;
            _name = name;
            _credits = credits;
            _idCareer = idCareer;
            _price = price;
            _totalCost = totalCost;
        }

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


        public string idCareer
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


        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string printCourse()
        {
            return this._id + "," + this._name + "," + this._credits + "," + this._idCareer + "," + this._price + "," + this._totalCost;
        }

    }
}
