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
        LinkedList<Person> people = new LinkedList<Person>();
        
        public ConsultarUsuario()
        {
            people = pda.readPerson();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex < 0)
            {
                MessageBox.Show("Error: persona no selecionada");
            }
            else
            {
                Person p = new Person();
                p = people.ElementAt(Lista.SelectedIndex);
                DialogResult boton = MessageBox.Show("Desea eliminar a "+p.name+ "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (boton == DialogResult.OK)
                {
                    people.Remove(people.ElementAt(Lista.SelectedIndex));
                    pda.writePerson(people);
                }
                
            }
        }
    }
}
