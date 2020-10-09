using matriculaUniversitaria.BussinesObject;
using matriculaUniversitaria.DataAccess;
using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace matriculaUniversitaria.GUI
{
    public partial class AgregarUsuario : Form
    {
        GeneralBO lbo = new GeneralBO();
        personDA pda = new personDA();
        userDA uda = new userDA();
        public AgregarUsuario()
        {
            
            InitializeComponent();
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbAcademylvl.Items.Add("Diplomado");
            cmbAcademylvl.Items.Add("Bachillerato");
            cmbAcademylvl.Items.Add("Licenciatura");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (((txtDni.Text.Equals("") && txtNombre.Text.Equals("")) && (txtApellido.Text.Equals("") && txtCountry.Text.Equals("")) &&
                (txtState.Text.Equals("") && txtpass.Text.Equals("")) && (cmbSexo.Text.Equals("- Elija una opción -"))))
            {
                MessageBox.Show("Datos incompletos");
            }
            else {
                try
                {
                    LinkedList<Person> people = pda.readPerson();
                    Person np = new Person(int.Parse(txtDni.Text),txtNombre.Text,txtApellido.Text,cmbSexo.Text,
                                timerBornDate.Value,DateTime.Now,cmbAcademylvl.Text,"Tiffany",txtCountry.Text,txtState.Text);
                    people.AddLast(np);
                    pda.writePerson(people);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + " - " + ex.StackTrace);
                }
                
            }
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
