using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matriculaUniversitaria.DataAccess;
using matriculaUniversitaria.GUI;
using matriculaUniversitaria.Properties;
using MatriculaUniversitaria.Entities;

namespace matriculaUniversitaria

{
    public partial class Form1 : Form
    {
        userDA uda = new userDA();
        personDA pda = new personDA();
        public Form1()
        {
            InitializeComponent();
        }

        string datos = Settings.Default.pass;


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person p in pda.readPerson())
            {
                if (int.Parse(txtidUsuario.Text) == p.dni)
                {
                    foreach (Usuario us in uda.readUsuario())
                    {
                        if (txtidUsuario.Text.Equals(us.pcod) && txtPass.Text.Equals(us.ppass))
                        {
                            if (p.type.Equals("Administrador"))
                            {
                                LobbyAdmin admin = new LobbyAdmin();
                                admin.Show();
                                break;
                            }
                            else if (p.type.Equals("Profesor"))
                            {
                                MessageBox.Show("Seccion de profesor en mantenimiento");
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Seccion de alumnos en mantenimiento");
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RegistrarUser ru = new RegistrarUser();
            ru.Show();
        }
    }
}
