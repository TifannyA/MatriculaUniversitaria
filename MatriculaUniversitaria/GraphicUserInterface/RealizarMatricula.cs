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


namespace matriculaUniversitaria.GraphicUserInterface
{
    public partial class RealizarMatricula : Form
    {
        courseDA cda = new courseDA();
        LinkedList<Course> Courses = new LinkedList<Course>();
        LinkedList<Career> careers = new LinkedList<Career>();
        careerDA crda = new careerDA();
        public RealizarMatricula()
        {
            InitializeComponent();
            Courses = cda.readCourse();
            careers = crda.readCareer();

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
    }
}
