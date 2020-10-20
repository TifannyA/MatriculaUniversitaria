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
    public partial class LobbyEstudiante : Form
    {
        int cedula;
        public LobbyEstudiante(int cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void realizarMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMatricula am = new AgregarMatricula(cedula);
            am.Show();
        }

        private void LobbyEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarNotasEstudiante cne = new ConsultarNotasEstudiante(cedula);
            cne.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void evaluacionAProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarReporte ar = new AgregarReporte(cedula);
            ar.Show();
        }
    }
}
