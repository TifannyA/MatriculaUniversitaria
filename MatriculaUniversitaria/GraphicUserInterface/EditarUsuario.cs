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

namespace matriculaUniversitaria.GraphicUserInterface
{
    public partial class EditarUsuario : Form
    {
        personDA pda = new personDA();
        LinkedList<Person> people = new LinkedList<Person>();
        Person p = new Person();

        int num;
        public EditarUsuario(int num)
        {
            this.num = num;
            InitializeComponent();
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbAcademylvl.Items.Add("Diplomado");
            cmbAcademylvl.Items.Add("Bachillerato");
            cmbAcademylvl.Items.Add("Licenciatura");
            people = pda.readPerson();
            p = people.ElementAt(num);
            cargarPersona();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Person np = new Person(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, cmbSexo.Text,
                       timerBornDate.Value, DateTime.Now, cmbAcademylvl.Text, "Tiffany", txtCountry.Text, txtState.Text);
                people.Find(p).Value = np;
                pda.writePerson(people);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarPersona() 
        {
            
            
            txtDni.Text = p.dni+"";
            txtNombre.Text = p.name;
            txtApellido.Text = p.last;
            txtCountry.Text = p.nationality;
            txtState.Text = p.state;
            if (p.sex.Equals("Masculino"))
            {
                cmbSexo.SelectedIndex= 0;
            }
            else {
                cmbSexo.SelectedIndex = 1;
            }
            if (p.academyLvl.Equals("Diplomado"))
            {
                cmbAcademylvl.SelectedIndex = 0;
            }
            else if (p.academyLvl.Equals("Bachillerato"))
            {
                cmbAcademylvl.SelectedIndex = 1;
            }
            else 
            {
                cmbAcademylvl.SelectedIndex = 2;
            }
            timerBornDate.Value = p.bonrDate; 
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
