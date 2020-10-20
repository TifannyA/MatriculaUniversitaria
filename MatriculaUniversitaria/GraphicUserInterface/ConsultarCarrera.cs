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
    public partial class ConsultarCarrera : Form
    {
        careerDA cda = new careerDA();
        LinkedList<Career> careers = new LinkedList<Career>();
        public ConsultarCarrera()
        {
            careers = cda.readCareer();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCarrera ac = new AgregarCarrera();
            ac.Show();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarCarrera_Load(object sender, EventArgs e)
        {

        }

        /**
         * Método recorrer la lista para cargar la carrera en un listBox
         */
        private void cargarCarrera()
        {
            try
            {
                careers = cda.readCareer();
                Lista.Items.Clear();
                foreach (Career ca in careers)
                {
                    Lista.Items.Add(ca.printCareer());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarCarrera();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex < 0)
            {
                MessageBox.Show("Error: Carrera no seleccionada");
            }
            else
            {
                EditarCarrera cc = new EditarCarrera(Lista.SelectedIndex);
                cc.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex < 0)
            {
                MessageBox.Show("Error: persona no selecionada");
            }
            else
            {
                Career c = new Career();
                c = careers.ElementAt(Lista.SelectedIndex);
                DialogResult boton = MessageBox.Show("Desea eliminar a " + c.name + "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (boton == DialogResult.OK)
                {
                    careers.Remove(c);
                    cda.writeCareer(careers);
                    cargarCarrera();
                    
                }
            }
        }
    }
}
