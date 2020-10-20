using matriculaUniversitaria.DataAccess;
using System;
using System.Collections.Generic;
using MatriculaUniversitaria.Entities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matriculaUniversitaria.Entity;

namespace matriculaUniversitaria.GraphicUserInterface
{
    public partial class ConsultarNota : Form
    {
        int cedula;
        personDA pda = new personDA();
        StudentCalificationDA scda = new StudentCalificationDA();
        LinkedList<Person> people = new LinkedList<Person>();
        LinkedList<Person> myStudents = new LinkedList<Person>();
        LinkedList<StudentCalification> califications = new LinkedList<StudentCalification>();
        LinkedList<StudentCalification> myStudentcalifications = new LinkedList<StudentCalification>();
        public ConsultarNota(int cedula)
        {
            this.cedula = cedula; 
            InitializeComponent();
            califications = scda.readCalification();
            people = pda.readPerson();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EditarNotas en = new EditarNotas(cedula,Lista.SelectedIndex);
            en.Show();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarNota_Load(object sender, EventArgs e)
        {
            foreach (var student in califications)
            {
                foreach (var person in people)
                {
                    if (student.teacher == cedula && student.idStudent == person.dni)
                    {
                        myStudents.AddLast(person);
                        myStudentcalifications.AddLast(student);
                        Lista.Items.Add(person.dni + " - " + person.name + " " + person.last+ " - Nota: "+student.calification);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
