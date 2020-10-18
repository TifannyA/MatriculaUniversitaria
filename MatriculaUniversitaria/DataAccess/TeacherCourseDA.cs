using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class TeacherCourseDA
    {
        public bool writeTeacherAssign(LinkedList<string> TeacherCourse)
        {
            StreamWriter sw = new StreamWriter(@"TeacherAssign.txt");
            try
            {
                foreach (string u in TeacherCourse)
                {
                    string dats = u;
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
        public LinkedList<String> readTeacherAssign()
        {
            LinkedList<string> TeacherCourse = new LinkedList<string>();
            StreamReader sr = new StreamReader(@"TeacherAssign.txt");

            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    TeacherCourse.AddLast(line);
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
            return TeacherCourse;
        }
    }
}
