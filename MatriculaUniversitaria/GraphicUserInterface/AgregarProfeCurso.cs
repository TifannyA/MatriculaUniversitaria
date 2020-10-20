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
    public partial class AgregarProfesorCurso : Form
    {
        personDA pda = new personDA();
        careerDA cda = new careerDA();
        courseDA cuda = new courseDA();
        TeacherCourseDA tcda = new TeacherCourseDA();
        LinkedList<Person> people = new LinkedList<Person>();
        LinkedList<Career> careers = new LinkedList<Career>();
        LinkedList<Course> Courses = new LinkedList<Course>();
        LinkedList<Person> profesores = new LinkedList<Person>();
        LinkedList<Course> CourseCharge = new LinkedList<Course>();

        public AgregarProfesorCurso()
        {
            InitializeComponent();
        }

        private void AgregarProfesorCurso_Load(object sender, EventArgs e)
        {
            people = pda.readPerson();
            careers = cda.readCareer();
            Courses = cuda.readCourse();
            foreach (var p in people)
            {
                if (p.type.Equals("Profesor"))
                {
                    profesores.AddLast(p);
                    ListaProfesor.Items.Add(p.name + " " + p.last + (" - ") + p.academyLvl);
                }
            }
            foreach (var ca in careers)
            {
                cmbCarrera.Items.Add(ca.name);
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Courses)
            {
                if (careers.ElementAt(cmbCarrera.SelectedIndex).id.Equals(item.idCareer))
                {
                    CourseCharge.AddLast(item);
                    ListaCurso.Items.Add(item.printCourse());
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ListaProfesor.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un profesor");
            }
            else
            {
                LinkedList<string> profes = tcda.readTeacherAssign();
                string asignar = profesores.ElementAt(ListaProfesor.SelectedIndex).dni + "," + profesores.ElementAt(ListaProfesor.SelectedIndex).name + " "
                    + profesores.ElementAt(ListaProfesor.SelectedIndex).last + "," + careers.ElementAt(cmbCarrera.SelectedIndex).id + "," + CourseCharge.ElementAt(ListaCurso.SelectedIndex).id;
                profes.AddLast(asignar);
                tcda.writeTeacherAssign(profes);
                MessageBox.Show("Asignación exitosa");
            }
        }
    }
}
