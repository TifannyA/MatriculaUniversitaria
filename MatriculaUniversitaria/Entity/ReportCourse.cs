using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.Entity
{
    class ReportCourse
    {

        Random rdm;
        public ReportCourse(int idEvaluation, string descrip, int idStudent, string state, DateTime date, string course)
        {
            _idEvaluation = idEvaluation;
            _Descrip = descrip;
            _idStudent = idStudent;
            _state = state;
            _Date = date;
            _Course = course;
        }
        private int _idEvaluation;

        public int idEvaluation
        {
            get { return _idEvaluation; }
            set { _idEvaluation = rdm.Next(100000,999999); }
        }

        private string _Descrip;

        public string Description
        {
            get { return _Descrip; }
            set { _Descrip = value; }
        }

        private int _idStudent;

        public int idStudent
        {
            get { return _idStudent; }
            set { _idStudent = value; }
        }

        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private string _Course;



        public string idCourse
        {
            get { return _Course; }
            set { _Course = value; }
        }

        public string printReport() 
        {
            return _idEvaluation+","+_Descrip + ","+_idStudent + "," +State + "," +Date.ToString() + "," + _Course;
        }



    }
}
