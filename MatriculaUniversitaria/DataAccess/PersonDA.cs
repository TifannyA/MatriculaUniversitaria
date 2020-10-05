using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class PersonDA
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
            LinkedList<Person> people= new LinkedList<Person>();

            try
            {
                String line = null;
                StreamReader sr = new StreamReader("C:\\Sample.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split('-');
                    Person p = new Person();
                    p.id = int.Parse(dats[0]);
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
                Console.WriteLine("Executing finally block.");
            }
            return people;
        }
    }
}
