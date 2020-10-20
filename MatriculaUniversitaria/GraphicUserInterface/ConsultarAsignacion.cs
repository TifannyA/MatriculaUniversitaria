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
    public partial class ConsultarAsignacion : Form
    {
        int cedula;
        TeacherCourseDA tcda = new TeacherCourseDA();
        public ConsultarAsignacion(int cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        private void ConsultarAsignacion_Load(object sender, EventArgs e)
        {
            foreach (string item in tcda.readTeacherAssign())
            {
                if (cedula == int.Parse(item.Split(',')[0]))
                {
                    lista.Items.Add(item);
                }
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
