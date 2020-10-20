using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.Entity
{
    class StudentCalification
    {
        public StudentCalification(string period, string course, int idStudent, int calification, string state,int teacher)
        {
            _period = period;
            _Course = course;
            _idStudent = idStudent;
            _calification = calification;
            _state = state;
        }
        private int _idTeacher;

        public int teacher
        {
            get { return _idTeacher; }
            set { _idTeacher = value; }
        }


        private string _period;

        public string period
        {
            get { return _period; }
            set { _period = value; }

        }
        private string _Course;

        public string idCourse
        {
            get { return _Course; }
            set { _Course = value; }
        }

        private int _idStudent;

        public int idStudent
        {
            get { return _idStudent; }
            set { _idStudent = value; }
        }

        private int _calification;

        public int calification
        {
            get { return _calification; }
            set { _calification = value; }
        }

        private string _state;



        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        public string printCalification() {
            return _idStudent + "," + _Course + "," + _period + "," + _calification + "," + _state + "," + _idTeacher ;
        }
    }
}
