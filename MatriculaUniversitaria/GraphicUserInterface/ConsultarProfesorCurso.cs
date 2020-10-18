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
    public partial class ConsultarProfesorCurso : Form
    {
        personDA pda = new personDA();
        careerDA cda = new careerDA();
        courseDA cuda = new courseDA();
        LinkedList<Person> people = new LinkedList<Person>();
        LinkedList<Career> careers = new LinkedList<Career>();
        LinkedList<Course> Courses = new LinkedList<Course>();
        public ConsultarProfesorCurso()
        {
            InitializeComponent();
        }

        private void ConsultarProfesorCurso_Load(object sender, EventArgs e)
        {
            people = pda.readPerson();
            careers = cda.readCareer();
            Courses = cuda.readCourse();
            foreach (var p in people)
            {
                if (p.type.Equals("Profesor"))
                {
                    ListaProfesor.Items.Add(p.name+" "+p.last +(" - ")+p.academyLvl);
                }
            }
            foreach (var ca in careers)
            {
                cmbCarrera.Items.Add(ca.name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Courses)
            {
                if (careers.ElementAt(cmbCarrera.SelectedIndex).id.Equals(item.idCareer))
                {
                    ListaCurso.Items.Add(item.printCourse());
                }
            }
        }

        private void ListaProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
