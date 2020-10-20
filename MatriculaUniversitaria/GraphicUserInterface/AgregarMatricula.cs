using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatriculaUniversitaria.Entities;
using matriculaUniversitaria.DataAccess;
using matriculaUniversitaria.Entity;

namespace matriculaUniversitaria.GraphicUserInterface
{
    public partial class AgregarMatricula : Form
    {
        int cedula;

        courseDA cda = new courseDA();
        LinkedList<int> teachers = new LinkedList<int>();
        LinkedList<Course> Courses = new LinkedList<Course>();
        LinkedList<Career> careers = new LinkedList<Career>();
        LinkedList<Enrollment> enrollments = new LinkedList<Enrollment>();
        LinkedList<StudentCalification> califications = new LinkedList<StudentCalification>();
        
        
        careerDA crda = new careerDA();
        EnrollmentDA eda = new EnrollmentDA();
        TeacherCourseDA tcda = new TeacherCourseDA();
        StudentCalificationDA scda = new StudentCalificationDA();

        public AgregarMatricula(int cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
            Courses = cda.readCourse();
            careers = crda.readCareer();
            enrollments = eda.readEnrollment();
            califications = scda.readCalification();

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            if (cboCarrera.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una carrera");
            }
            else
            {
                foreach (var c in Courses)
                {
                    if (c.idCareer.Equals(careers.ElementAt(cboCarrera.SelectedIndex).id))
                    {
                        Lista.Items.Add(c.printCourse());
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void AgregarMatricula_Load(object sender, EventArgs e)
        {

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            string periodo;
            if (DateTime.Now.Month == 1 || DateTime.Now.Month == 2 || DateTime.Now.Month == 3 || DateTime.Now.Month == 4)
            {
                periodo = "I";
            }
            else if (DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
            {
                periodo = "II";
            }
            else 
            {
                periodo = "III";
            }
            Enrollment matricula = new Enrollment(cedula,1234,periodo,DateTime.Now,"",DateTime.Now);
            enrollments.AddLast(matricula);
            eda.writeEnrollmentn(enrollments);
            StudentCalification sc = new StudentCalification(periodo,Courses.ElementAt(Lista.SelectedIndex).id,cedula,0,"Reprobado",teachers.ElementAt(cmbProfesor.SelectedIndex));
            califications.AddLast(sc);
            scda.writeCalification(califications);
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProfesor.Items.Clear();
            foreach (string teacher in tcda.readTeacherAssign())
            {
                if (Courses.ElementAt(Lista.SelectedIndex).id.Equals(teacher.Split(',')[3]))
                {
                    teachers.AddLast(int.Parse(teacher.Split(',')[0]));
                    cmbProfesor.Items.Add(teacher.Split(',')[1]);
                }
            }
        }
    }
}
