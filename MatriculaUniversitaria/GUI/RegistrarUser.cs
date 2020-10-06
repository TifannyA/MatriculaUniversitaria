using System;
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
        Usuario usuario = new Usuario();
        private Boolean editar;
        private Boolean ver = false;
        private Boolean error = false;
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
            //Usuario usuario = new Usuario();
            ////if (txtPass.Text==txtPass.Text)
            ////{
            ////    if (u.(txtUsuario.Text, txtCodigo.Text, txtPersona.Text, txtPass.Text, cbxTipoUsu.Text,txtEstado.Text) > 0)
            ////    {
            ////        MessageBox.Show("Cuenta creada con éxito");
            ////    }
            ////    else
            ////        MessageBox.Show("No se pudo crear la cuenta");
            ////}
            ////Form1 f1 = new Form1();
            ////f1.Show();
            //error = false;
            //usuario.admin = true;
            //try
            //{
            //    if (rbAdmin.Checked)
            //    {
            //        usuario.admin = true;
            //    }
            //    else if (rbProfe.Checked)
            //    {
            //        usuario.admin = false;

            //        usuario.pid_user(txtUsuario.Text);
            //        usuario.pcod(txtCodigo.Text);
            //        usuario.pid_person(txtPersona.Text);

            //        if (txtVc.getText().equals(""))
            //        {
            //            txtVc.setText(txtContrasena.getText());
            //        }
            //        if (txtVc.getText().length() >= 5)
            //        {
            //            usuario.setContrasena(txtVc.getText().trim());
            //        }
            //        else
            //        {
            //            error = true;
            //            MessageBox.Show("La contraseña debe de ser mayor a 5 dígitos" + "Matrícula");
            //        }


            //        if (ubo.guardar(usuario))
            //        {
            //            this.Close();
            //        }




            //    catch (Exception e)
            //    {
            //    }
            //}


            //    private void textBox4_TextChanged(object sender, EventArgs e)
            //    {

            //    }
            //}
        }    
    }
}


    

