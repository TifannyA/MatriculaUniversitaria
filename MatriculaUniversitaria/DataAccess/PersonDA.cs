using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriculaUniversitaria.DataAccess
{
    class personDA
    {
        public bool writePerson(LinkedList<Person> people)
        {
            StreamWriter sw = new StreamWriter(@"Person.txt");
            try
            {
                foreach (Person p in people)
                {
                    sw.WriteLine(p.printPerson());
                }
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }
            finally
            {
                sw.Close();
            }
            return true;
        }

        public LinkedList<Person> readPerson()
        {
            LinkedList<Person> people = new LinkedList<Person>();
            StreamReader sr = new StreamReader(@"Person.txt");

            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    Person p = new Person(int.Parse(dats[1]), dats[2], dats[3], dats[4],
                               DateTime.Parse(dats[5]), DateTime.Parse(dats[6]), dats[7], dats[8], dats[9], dats[10]);
                    people.AddLast(p);
                    line = sr.ReadLine();
                }
                    sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
            return people;
        }
    }
}
