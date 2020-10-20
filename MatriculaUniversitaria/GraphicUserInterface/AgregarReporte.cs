using matriculaUniversitaria.DataAccess;
using matriculaUniversitaria.Entity;
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
    public partial class AgregarReporte : Form
    {
        int cedula;
        ReportCourseDA rcda = new ReportCourseDA();
        LinkedList<ReportCourse> reports = new LinkedList<ReportCourse>(); 
        LinkedList<ReportCourse> Myreports = new LinkedList<ReportCourse>();
        public AgregarReporte(int cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
            txtDesc.Enabled=false;
        }

        private void AgregarReporte_Load(object sender, EventArgs e)
        {
            reports = rcda.readCalification();
            foreach (var item in reports)
            {
                if (item.State.Equals("Pendiente")&& item.idStudent == cedula)
                {
                    Myreports.AddLast(item);
                    cmbPendiente.Items.Add(item.idCourse + item.State);
                }
            }
        }

        private void cmbPendiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPendiente.SelectedIndex>-1)
            {
                txtDesc.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPendiente.SelectedIndex > -1)
            {
                ReportCourse edited = Myreports.ElementAt(cmbPendiente.SelectedIndex);
                edited.Description = txtDesc.Text;
                edited.State = "Aplicada";
                reports.Find(Myreports.ElementAt(cmbPendiente.SelectedIndex)).Value = edited;
                rcda.writeCalification(reports);
                MessageBox.Show("Evaluación aplicada");
            }
            else 
            {
                MessageBox.Show("Seleccione una evaluacion para continuar");
            }
            
        }
    }
}
