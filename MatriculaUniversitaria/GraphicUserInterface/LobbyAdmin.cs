using matriculaUniversitaria.GraphicUserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriculaUniversitaria.GUI
{

    public partial class LobbyAdmin : Form
    {
        public LobbyAdmin()
        {
            InitializeComponent();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuario cu = new ConsultarUsuario();
            cu.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void LobbyAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
