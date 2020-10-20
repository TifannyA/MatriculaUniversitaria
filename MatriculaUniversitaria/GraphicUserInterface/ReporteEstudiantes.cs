using matriculaUniversitaria.DataAccess;
using matriculaUniversitaria.Entity;
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
    public partial class ReporteEstudiantes : Form
    {
        int cedula;
        personDA pda = new personDA();
        courseDA cda = new courseDA();
        TeacherCourseDA tcda = new TeacherCourseDA();
        LinkedList<Course> courses = new LinkedList<Course>();
        LinkedList<Person> people = new LinkedList<Person>();
        LinkedList<Person> MyStudent = new LinkedList<Person>();
        StudentCalificationDA scda = new StudentCalificationDA();
        LinkedList<StudentCalification> Califications = new LinkedList<StudentCalification>();
        
        public ReporteEstudiantes(int cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {
            Califications = scda.readCalification();
            people = pda.readPerson();
            courses = cda.readCourse();

            foreach (var teacher in tcda.readTeacherAssign())
            {
                foreach (var course in courses)
                {
                    if (teacher.Split(',')[3].Equals(course.id))
                    {
                        cmbCurso.Items.Add(course.id);
                    }
                }
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string myStudent = null;
            foreach (var item in MyStudent)
            {
                myStudent = item.dni + " " + item.name + " " + item.last + Environment.NewLine;
            }
            MessageBox.Show(myStudent);
        }

        private void ListaEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var calification in Califications)
            {
                foreach (var person in people)
                {
                    if (person.dni == calification.idStudent && calification.teacher == cedula && calification.idCourse.Equals(cmbCurso.Text))
                    {
                        MyStudent.AddLast(person);
                        ListaEstudiantes.Items.Add(person.dni + " - " + person.name + person.last);
                    }
                }
            }

        }
    }
}
