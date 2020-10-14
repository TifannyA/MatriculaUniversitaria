﻿using System;
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
        private string nombre;
        private string apellidos;
        private int id_usuario;
        private string codigo;
        private int id_persona;
        private string contrasenna;
        private DateTime fecha_exp;
        private string _estado;
        private string _tipo;


        public Usuario()
        {
        }


        public Usuario(string pnombre, string papellidos,int pid_user, string pcod, int pid_person, string ppass, DateTime pfechaExp,  string tipo, string pestado)
        {
            nombre = pnombre;
            apellidos = papellidos;
            id_usuario = pid_user;
            codigo = pcod;
            id_persona = pid_person;
            contrasenna = ppass;
            fecha_exp = pfechaExp;
<<<<<<< HEAD
            estado = pestado;
=======
>>>>>>> master
            _tipo = tipo;
            _estado = estado;
        }
        public string pnombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string papellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public  int pid_user
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

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        
        public string printUsuario()
        {
            return this.nombre+ "," +this.apellidos+ ","+ this.id_usuario + "," + this.codigo + "," + this.id_persona + "," + this.contrasenna + "," + this.fecha_exp + "," + this.tipo + "," + this.estado;
        }
    }
}
