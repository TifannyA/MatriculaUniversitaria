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
    public partial class EditarCarrera : Form
    {
        int carrera;
        LinkedList<Career> careers = new LinkedList<Career>();
        Career ca;
        careerDA cda = new careerDA();
        
        public EditarCarrera(int carrera)
        {
            this.carrera = carrera;
            InitializeComponent();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            careers = cda.readCareer();
            ca = careers.ElementAt(carrera);

            txtNombre.Text = ca.name;
            txtTotalCreditos.Text = ""+ca.totalCredit;
            if (ca.state)
            {
                cmbEstado.SelectedIndex = 0;
            }
            else 
            {
                cmbEstado.SelectedIndex = 1;
            }
            timerStart.Value = ca.startDate;
            dateEnd.Value = ca.endDate;

        }

        private void EditarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") && (txtTotalCreditos.Text.Equals("")) && (dateEnd.Value.Equals(DateTime.Now)))
            {
                MessageBox.Show("Error: información invalida");
            }
            else
            {
                bool state;
                if (cmbEstado.Text.Equals("Activo"))
                {
                    state = true;
                }
                else
                {
                    state = false;
                }
                Career c = new Career(txtCodigo.Text, txtNombre.Text, int.Parse(txtTotalCreditos.Text), state, timerStart.Value, dateEnd.Value);
                careers.Find(ca).Value=c;
                cda.writeCareer(careers);
            }
        }
    }
}
