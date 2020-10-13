using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matriculaUniversitaria.Properties;

namespace matriculaUniversitaria

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string datos = Settings.Default.pass;
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtidUsuario.Text == "208010868" && txtPass.Text=="123")
            {
                MessageBox.Show("Bienvenido Administrador");
            }
            else
            {
                MessageBox.Show("Datos inválidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RegistrarUser fm = new RegistrarUser();
            //fm.Show();
            this.Close();
            
        }
    }
}
