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
    public partial class EditarNotas : Form
    {
        int cedula;
        int seleccion;
        personDA pda = new personDA();
        LinkedList<Person> people = new LinkedList<Person>();
        LinkedList<Person> Mypeople = new LinkedList<Person>();
        StudentCalificationDA scda = new StudentCalificationDA();
        LinkedList<StudentCalification> califications = new LinkedList<StudentCalification>();
        LinkedList<StudentCalification> myStudentcalifications = new LinkedList<StudentCalification>();
        public EditarNotas(int cedula, int seleccion)
        {
            InitializeComponent();
            this.cedula = cedula;
            this.seleccion = seleccion;
        }

        private void EditarNotas_Load(object sender, EventArgs e)
        {
            califications = scda.readCalification();
            people = pda.readPerson();

            foreach (var student in califications)
            {
                foreach (var person in people)
                {
                    if (student.teacher == cedula && student.idStudent == person.dni)
                    {
                        Mypeople.AddLast(person);
                        myStudentcalifications.AddLast(student);
                    }
                }
            }

            lblEstudiante.Text = myStudentcalifications.ElementAt(seleccion).idStudent + " - "+ Mypeople.ElementAt(seleccion).name + Mypeople.ElementAt(seleccion).last;
            lblCurso.Text = myStudentcalifications.ElementAt(seleccion).idCourse;
            txtNota.Text = myStudentcalifications.ElementAt(seleccion).calification+"";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentCalification std = myStudentcalifications.ElementAt(seleccion);
            StudentCalification edited = std;
            edited.calification = int.Parse(txtNota.Text);
            edited.state = comboBox1.Text;
            califications.Find(std).Value = edited;
            scda.writeCalification(califications);
            MessageBox.Show("Cambio exitoso");
        }
    }
}
