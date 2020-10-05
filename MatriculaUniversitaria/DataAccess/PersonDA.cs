using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string dats = p.printPerson();
                    sw.WriteLine(dats);
                    sw.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
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
                    Person p = new Person();
                    p.id = int.Parse(dats[0]);
                    p.dni = int.Parse(dats[1]);
                    p.name = dats[2];
                    p.last = dats[3];
                    p.sex = char.Parse(dats[4]);
                    p.bonrDate = DateTime.Parse(dats[5]);
                    p.admisionDate = DateTime.Parse(dats[6]);
                    p.admisionUser = dats[7];
                    p.nationality = dats[8];
                    p.state= dats[9];
                    people.AddLast(p);
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
            return people;
        }
    }
}
