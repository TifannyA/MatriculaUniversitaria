using matriculaUniversitaria.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class ReportCourseDA
    {
        public bool writeCalification(LinkedList<ReportCourse> enrollments)
        {
            StreamWriter sw = new StreamWriter(@"Report.txt");
            try
            {
                foreach (ReportCourse u in enrollments)
                {
                    string dats = u.printReport();
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
        public LinkedList<ReportCourse> readCalification()
        {
            LinkedList<ReportCourse> enrollments = new LinkedList<ReportCourse>();
            StreamReader sr = new StreamReader(@"Report.txt");
            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    ReportCourse en = new ReportCourse(int.Parse(dats[0]),dats[1], int.Parse(dats[2]),dats[3],DateTime.Parse(dats[4]),dats[5]);
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
