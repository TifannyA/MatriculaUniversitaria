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
    public partial class EditarCurso : Form
    {
        courseDA cda = new courseDA();
        LinkedList<Course> cursos = new LinkedList<Course>();
        Course curso;
        public EditarCurso(int num)
        {
            InitializeComponent();
            cursos = cda.readCourse();
            this.curso = cursos.ElementAt(num);
            lblPreCodigo.Text = curso.id;
            lblCodigo.Text = curso.idCareer;
            txtCodigo.Text = curso.id.Split('-')[1].Trim();
            txtNombre.Text = curso.name;
            txtPrecio.Text = ""+curso.price;
            txtCreditos.Text = "" + curso.credits;
            txtCosto.Text = "" + curso.totalCost;

        }

        private void EditarCurso_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") && txtNombre.Text.Equals("") && txtCreditos.Text.Equals("") && txtPrecio.Text.Equals("") && txtCosto.Text.Equals(""))
            {
                MessageBox.Show("Error: Datos incompletos");
            }
            else
            {
                Course c = new Course(lblPreCodigo.Text, txtNombre.Text, int.Parse(txtCreditos.Text),curso.idCareer, int.Parse(txtPrecio.Text), int.Parse(txtCosto.Text));
                cursos.Find(curso).Value = c;
                cda.writeCourse(cursos);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            lblPreCodigo.Text = curso.idCareer + " - " + txtCodigo.Text;
        }
    }
}
