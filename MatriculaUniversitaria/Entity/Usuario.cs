using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria
{

    public class Usuario
    {
        private string codigo;
        private string contrasenna;


        public Usuario()
        {
        }


        public Usuario(string pcod,string ppass)
        {
            codigo = pcod;
            contrasenna = ppass;
        }

        public string pcod
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string ppass
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }

        
        public string printUsuario()
        {
            return this.codigo + "," + this.contrasenna;
        }
    }
}
