using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria
{
    class Usuario
    {
        public int id_usuario { get; set; }
        public int codigo { get; set; }
        public string id_persona { get; set; }
        public string contrasenna { get; set; }


        public Usuario()
        {

        }

        public Usuario(int id_usuario, int codigo, string id_persona, string contrasenna)
        {
            this.id_usuario = id_usuario;
            this.codigo = codigo;
            this.id_persona = id_persona;
            this.contrasenna = contrasenna;
        }


    }
}
