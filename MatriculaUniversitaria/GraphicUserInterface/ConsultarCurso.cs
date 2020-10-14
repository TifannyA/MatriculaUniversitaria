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
    public partial class ConsultarCurso : Form
    {
        LinkedList<Career> careers = new LinkedList<Career>();
        careerDA cda = new careerDA();
        public ConsultarCurso()
        {
            careers = cda.readCareer();
            InitializeComponent();
            cargarCarrera();
        }

        private void ConsultarCurso_Load(object sender, EventArgs e)
        {

        }

        private void cargarCarrera() {
            
            
            foreach (Career c in careers)
            {
                cmbCareer.Items.Add(c.name);
            }
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCareer.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una carrera para agregar el curso");
            }
            else
            {
                AgregarCurso ac = new AgregarCurso(careers.ElementAt(cmbCareer.SelectedIndex).id);
                ac.Show();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
