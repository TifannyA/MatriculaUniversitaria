using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class courseDA
    {
        public bool writeCourse(LinkedList<Course> Courses)
        {
            StreamWriter sw = new StreamWriter(@"Courses.txt");
            try
            {
                foreach (Course p in Courses)
                {
                    string dats = p.toString();
                    sw.WriteLine(dats);
                    sw.Close();
                }

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
        public LinkedList<Course> readCourse()
        {
            LinkedList<Course> Courses = new LinkedList<Course>();
            StreamReader sr = new StreamReader(@"Courses.txt");

            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    Course p = new Course();
                    p.id = int.Parse(dats[0]);
                    p.name = dats[1];
                    p.credits = int.Parse(dats[2]);
                    p.idCareer = int.Parse(dats[3]);
                    p.price = int.Parse(dats[4]);
                    p.totalCost = int.Parse(dats[5]);
                    Courses.AddLast(p);
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
            return Courses;
        }
    }
}
