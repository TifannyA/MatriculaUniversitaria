﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriculaUniversitaria
{
    public partial class RegistrarUser : Form
    {
        Usuario u = new Usuario();
        public RegistrarUser()
        {
            InitializeComponent();
        }

        private void RegistrarUser_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void registrarUsuario()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text==txtPass.Text)
            {
                if (Usuario.CrearCuenta(txtUsuario.Text, txtCodigo.Text, txtPersona.Text, txtPass.Text, cbxTipoUsu.Text,txtEstado.Text) > 0)
                {
                    MessageBox.Show("Cuenta creada con éxito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            }
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
