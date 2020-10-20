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
    public partial class ConsultarNotasEstudiante : Form
    {
        int cedula;
        personDA pda = new personDA();
        StudentCalificationDA scda = new StudentCalificationDA();
        LinkedList<Person> people = new LinkedList<Person>();
        LinkedList<StudentCalification> califications = new LinkedList<StudentCalification>();

        public ConsultarNotasEstudiante(int cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
            
        }

        private void ConsultarNotasEstudiante_Load(object sender, EventArgs e)
        {
            califications = scda.readCalification();
            people = pda.readPerson();
            foreach (var student in califications)
            {
                if (student.idStudent == cedula)
                {
                    Lista.Items.Add("Curso: "+ student.idCourse + " - Nota: " + student.calification+ " - Estado: "+ student.state);
                }
                
            }
        }
    }
}
