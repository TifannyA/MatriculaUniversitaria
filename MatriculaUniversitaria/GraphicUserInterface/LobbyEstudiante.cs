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
            ConsultarNota cn = new ConsultarNota();
            cn.Show();
        }

        private void realizarMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMatricula am = new AgregarMatricula(cedula);
            am.Show();
        }
    }
}
