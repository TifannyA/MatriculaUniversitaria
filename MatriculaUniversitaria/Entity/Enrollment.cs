using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.Entity
{
    class Enrollment
    {
        public Enrollment(int idPerson, int idFactura, string periodo, DateTime fechaMatricula, string state, DateTime fechaPago)
        {
            _idPerson = idPerson;
            _idFactura = idFactura;
            _Periodo = periodo;
            _FechaMatricula = fechaMatricula;
            _State = state;
            _FechaPago = fechaPago;
        }

        private int _idPerson;

        public int idPerson
        {
            get { return _idPerson; }
            set { _idPerson = value; }
        }

        private int _idFactura;

        public int idFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }

        private string _Periodo;

        public string periodo
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }

        private DateTime _FechaMatricula;

        public DateTime fechaMatricula
        {
            get { return _FechaMatricula; }
            set { _FechaMatricula = value; }
        }

        private string _State;

        public string state
        {
            get { return _State; }
            set { _State = value; }
        }

        private DateTime _FechaPago;


        public DateTime FechaPago
        {
            get { return _FechaPago; }
            set { _FechaPago = value; }
        }

        public string printEnrollment()
        {
            return _idPerson + "," + _idFactura + "," + _Periodo + "," + _FechaMatricula + "," + _FechaPago + "," + "Matriculado";
        }
    }
}
