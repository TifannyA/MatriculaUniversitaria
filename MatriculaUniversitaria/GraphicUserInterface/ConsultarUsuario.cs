using matriculaUniversitaria.DataAccess;
using matriculaUniversitaria.GUI;
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
    public partial class ConsultarUsuario : Form
    {
        personDA pda = new personDA();
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<Person> people = new LinkedList<Person>();
            people = pda.readPerson();
            Lista.Items.Clear();
            foreach (Person p in people)
            {
                Lista.Items.Add(p.printPerson());
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarUsuario au = new AgregarUsuario();
            au.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex < 0)
            {
                MessageBox.Show("Error: persona no selecionada");
            }
            else 
            { 
                EditarUsuario eu = new EditarUsuario(Lista.SelectedIndex);
                eu.Show();
            }
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
