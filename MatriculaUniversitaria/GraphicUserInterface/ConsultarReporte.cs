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
    public partial class ConsultarReporte : Form
    {
        ReportCourseDA rcda = new ReportCourseDA();
        LinkedList<ReportCourse> reports = new LinkedList<ReportCourse>();
        public ConsultarReporte()
        {
            InitializeComponent();
        }

        private void ConsultarReporte_Load(object sender, EventArgs e)
        {
            reports = rcda.readCalification();
            foreach (var item in reports)
            {
                if (item.State.Equals("Aplicada"))
                {
                    Lista.Items.Add(item.idStudent+" - "+item.idCourse + " - " + item.Description + " - " + item.Date.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
