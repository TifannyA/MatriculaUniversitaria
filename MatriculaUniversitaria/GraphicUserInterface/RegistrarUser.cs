using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matriculaUniversitaria.BussinesObject;
using matriculaUniversitaria.DataAccess;
using MatriculaUniversitaria.Entities;

namespace matriculaUniversitaria
{
    
    public partial class RegistrarUser : Form
    {
        GeneralBO lbo = new GeneralBO();
        personDA pda = new personDA();
        userDA uda = new userDA();
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
            if (((txtNombre.Text.Equals("")&& txtApellidos.Text.Equals("")&&txtUsuario.Text.Equals("") && 
                txtCodigo.Text.Equals("")) && (txtPersona.Text.Equals("") && txtPass.Text.Equals("")) &&
                (cbxEstado.Text.Equals("- Elija una opción -")&& (cbxTipo.Text.Equals("- Elija una opción -")))))
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                try
                {
                    LinkedList<Usuario> users = uda.readUsuario();
                    Usuario u = new Usuario(txtNombre.Text,txtApellidos.Text, int.Parse(txtUsuario.Text), txtCodigo.Text, int.Parse(txtPersona.Text), txtPass.Text,
                                DateTime.Now, cbxTipo.Text, cbxEstado.Text);
                    users.AddLast(u);
                    uda.writeUser(users);
                    MessageBox.Show("Terminó");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + " - " + ex.StackTrace);
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
            
            
    

    
 

    

