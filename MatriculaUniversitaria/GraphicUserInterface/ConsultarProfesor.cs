using matriculaUniversitaria.DataAccess;
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
    public partial class ConsultarProfesor : Form
    {
        TeacherCourseDA tcda = new TeacherCourseDA();
        public ConsultarProfesor()
        {
            InitializeComponent();
        }

        private void ConsultarProfesor_Load(object sender, EventArgs e)
        {
            foreach (var item in tcda.readTeacherAssign())
            {
                Lista.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarProfesorCurso ap = new AgregarProfesorCurso();
            ap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarProfesorCurso apc = new AgregarProfesorCurso();
            apc.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

