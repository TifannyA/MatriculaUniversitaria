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
    public partial class AgregarCurso : Form
    {
        string ca;
        courseDA cda = new courseDA();
        LinkedList<Course> courses;
        public AgregarCurso(string career)
        {
            InitializeComponent();
            ca = career;
            lblCodigo.Text = career;
            courses = cda.readCourse();
        }

        private void AgregarCurso_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            lblPreCodigo.Text = ca +" - "+ txtCodigo.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") && txtNombre.Text.Equals("") && txtCreditos.Text.Equals("") && txtPrecio.Text.Equals("") && txtCosto.Text.Equals(""))
            {
                MessageBox.Show("Error: Datos incompletos");
            }
            else {
                Course c = new Course(lblPreCodigo.Text,txtNombre.Text,int.Parse(txtCreditos.Text),ca,int.Parse(txtPrecio.Text),int.Parse(txtCosto.Text));
                courses.AddLast(c);
                cda.writeCourse(courses);
            }
        }
    }
}
