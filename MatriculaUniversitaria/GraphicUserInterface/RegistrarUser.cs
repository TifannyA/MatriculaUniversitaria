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
        LinkedList<Usuario> users = new LinkedList<Usuario>();


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
            if (txtCodigo.Text.Equals("") && txtPass.Text.Equals(""))
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                try
                {
                    foreach (var person in pda.readPerson())
                    {
                        if (person.dni == int.Parse(txtCodigo.Text) && !(txtPass.Text.Equals(""))&&!(txtPass.Text.Equals("")))
                        {
                            Usuario u = new Usuario(txtCodigo.Text, txtPass.Text);
                            users.AddLast(u);
                            uda.writeUser(users);
                            MessageBox.Show("Registro exitoso");
                        }
                    }
                    
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
            
            
    

    
 

    

