using matriculaUniversitaria.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class StudentCalificationDA
    {
        public bool writeCalification(LinkedList<StudentCalification> enrollments)
        {
            StreamWriter sw = new StreamWriter(@"Calification.txt");
            try
            {
                foreach (StudentCalification u in enrollments)
                {
                    string dats = u.printCalification();
                    sw.WriteLine(dats);
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
        public LinkedList<StudentCalification> readCalification()
        {
            LinkedList<StudentCalification> enrollments = new LinkedList<StudentCalification>();
            StreamReader sr = new StreamReader(@"Calification.txt");
            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    StudentCalification en = new StudentCalification(dats[2], dats[1], int.Parse(dats[0]), int.Parse(dats[3]), dats[4],int.Parse(dats[5]));
                    enrollments.AddLast(en);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
            return enrollments;
        }
    }
}
