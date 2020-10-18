using matriculaUniversitaria.DataAccess;
using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriculaUniversitaria.GraphicUserInterface
{
    public partial class AgregarCarrera : Form
    {
        careerDA cda = new careerDA();
        LinkedList<Career> careers;
        public AgregarCarrera()
        {
            InitializeComponent();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            careers = cda.readCareer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")&&(txtTotalCreditos.Text.Equals(""))&&(dateEnd.Value.Equals(DateTime.Now)))
            {
                MessageBox.Show("Error: información invalida");
            }
            else {
                bool state;
                if (cmbEstado.Text.Equals("Activo"))
                {
                    state = true;
                }
                else 
                {
                    state = false;                
                }
                Career c = new Career(txtCodigo.Text,txtNombre.Text,int.Parse(txtTotalCreditos.Text),state,timerStart.Value,dateEnd.Value);
                careers.AddLast(c);
                cda.writeCareer(careers);
                MessageBox.Show("Carrera agregada satisfactoriamente");
            }
        }

        private void AgregarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
