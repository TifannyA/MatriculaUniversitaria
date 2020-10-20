using matriculaUniversitaria.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class EnrollmentDA
    {
        public bool writeEnrollmentn(LinkedList<Enrollment> enrollments)
        {
            StreamWriter sw = new StreamWriter(@"Enrollment.txt");
            try
            {
                foreach (Enrollment u in enrollments)
                {
                    string dats = u.printEnrollment();
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
        public LinkedList<Enrollment> readEnrollment()
        {
            LinkedList<Enrollment> enrollments = new LinkedList<Enrollment>();
            StreamReader sr = new StreamReader(@"Enrollment.txt");

            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    Enrollment en = new Enrollment(int.Parse(dats[0]), int.Parse(dats[1]), dats[2], DateTime.Parse(dats[3]), dats[5], DateTime.Parse(dats[4]));
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
