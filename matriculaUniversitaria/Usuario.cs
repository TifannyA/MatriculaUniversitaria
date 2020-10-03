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
    class Usuario
    {
        public string id_usuario { get; set; }
        public string codigo { get; set; }
        public string id_persona { get; set; }
        public string contrasenna { get; set; }

        Logeventos log = new Logeventos(@" C:\Users\Usuario\source\repos\TifannyA\pruebas\");

        public Usuario()
        {

        }
        public static int CrearCuenta(string pUsuario, string pCodigo, string pPersona,string pPass,string TUsuario,string pEstado)
        {
            int resultado = 0;
            
            return resultado;
                }

        public Usuario(string id_usuario, string codigo, string id_persona, string contrasenna)
        {
            this.id_usuario = id_usuario;
            this.codigo = codigo;
            this.id_persona = id_persona;
            this.contrasenna = contrasenna;
        }

       


    }
}
