﻿using matriculaUniversitaria.DataAccess;
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
    public partial class LobbyProfesor : Form
    {
        int cedula;
        public LobbyProfesor(int cedula)
        {
            this.cedula = cedula;
            StudentCalificationDA scda = new StudentCalificationDA();
            InitializeComponent();
        }

        private void cursosAsignadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAsignacion ca = new ConsultarAsignacion(cedula);
            ca.Show();
        }

        private void reporteEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstudiantes re = new ReporteEstudiantes(cedula);
            re.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarNota cn = new ConsultarNota(cedula);
            cn.Show();
        }
    }
}
