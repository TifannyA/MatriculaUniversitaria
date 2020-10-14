using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUniversitaria.Entities
{
    class Career
    {
        private string _id;
        private string _name;
        private int _totalCredit;
        private bool _state;
        private DateTime _startDate;
        private DateTime _endDate;

        public Career() 
        {
        
        }

        public Career(string id, string name, int totalCredit, bool state, DateTime startDate, DateTime endDate)
        {
            _id = id;
            _name = name;
            _totalCredit = totalCredit;
            _state = state;
            _startDate = startDate;
            _endDate = endDate;
        }

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int totalCredit
        {
            get { return _totalCredit; }
            set { _totalCredit = value; }
        }

        public bool state
        {
            get { return _state; }
            set { _state = value; }
        }
        public DateTime startDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime endDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string printCareer()
        {
            return this._id + "," + this._name + "," + this._totalCredit + "," + this._state + "," + this.startDate + "," + this.endDate;
        }
    }
}