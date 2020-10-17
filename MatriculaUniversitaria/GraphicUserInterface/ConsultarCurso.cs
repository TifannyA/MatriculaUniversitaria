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
    public partial class ConsultarCurso : Form
    {
        LinkedList<Career> careers = new LinkedList<Career>();
        careerDA cda = new careerDA();
        LinkedList<Course> courses = new LinkedList<Course>();
        courseDA cuda = new courseDA();
        public ConsultarCurso()
        {
            careers = cda.readCareer();
            InitializeComponent();
            cargarCarrera();
            courses = cuda.readCourse();
        }

        private void ConsultarCurso_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarCarrera() {
            
            
            foreach (Career c in careers)
            {
                cmbCareer.Items.Add(c.name);
            }
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCareer.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una carrera para agregar el curso");
            }
            else
            {
                AgregarCurso ac = new AgregarCurso(careers.ElementAt(cmbCareer.SelectedIndex).id);
                ac.Show();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un curso para editar");
            }
            else 
            {
                EditarCurso ec = new EditarCurso(Lista.SelectedIndex);
                ec.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un curso para eliminar");
            }
            else
            {
                Course c = new Course();
                c = courses.ElementAt(Lista.SelectedIndex);
                DialogResult boton = MessageBox.Show("Desea eliminar a " + c.name + "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (boton == DialogResult.OK)
                {
                    courses.Remove(c);
                    cuda.writeCourse(courses);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                if (cmbCareer.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una carrera para ver los cursos");
                }
                else 
                {
                    foreach (var c in courses)
                    {
                    if (c.idCareer.Equals(careers.ElementAt(cmbCareer.SelectedIndex).id))
                    {
                        Lista.Items.Add(c.printCourse());
                    }
                    }
                }
        }
    }
}
