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
        private int id_usuario;
        private string codigo;
        private int id_persona;
        private string contrasenna;
        private DateTime fecha_exp;
        private string estado;
        private Boolean _admin;
        private Boolean _activo;


        public Usuario()
        {

        }
        

        public Usuario(int pid_user, string pcod, int pid_person, string ppass,DateTime pfechaExp,string pestado, Boolean admin, Boolean activo)
        {
            id_usuario = pid_user;
            codigo = pcod;
            id_persona = pid_person;
            contrasenna = ppass;
            fecha_exp = pfechaExp;
            estado = pestado;
            _admin = admin;
            _activo = activo;
        }
        public int pid_user
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string pcod
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int pid_person
        {
            get { return id_persona; }
            set { id_persona = value; }
        }
        public string ppass
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }

        public DateTime pfechaExp
        {
            get { return fecha_exp; }
            set { fecha_exp = value; }
        }

        public Boolean admin
        {
            get { return _admin; }
            set { _admin = value; }
        }
        public Boolean activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string printUsuario()
        {
            return this.id_usuario + "," + this.codigo + "," + this.id_persona + "," + this.contrasenna + "," + this.fecha_exp + "," + this.estado;
        }
    }
}
