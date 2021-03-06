﻿using matriculaUniversitaria.GraphicUserInterface;
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


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCarrera cc = new ConsultarCarrera();
            cc.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarCurso cc = new ConsultarCurso();
            cc.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e) 
        { 
        
        }

        private void LobbyAdmin_Load(object sender, EventArgs e)
        {

        }

        private void administrarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProfesor cp = new ConsultarProfesor();
            cp.Show();
        }

        private void evaluacionACursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarReporte cr = new ConsultarReporte();
            cr.Show();
        }
    }
}
