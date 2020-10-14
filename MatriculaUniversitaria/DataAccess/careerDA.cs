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
    class careerDA
    {
        public bool writeCareer(LinkedList<Career> careers)
        {
            StreamWriter sw = new StreamWriter(@"Career.txt");
            try
            {
                foreach (Career p in careers)
                {
                    string dats = p.printCareer();
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
        public LinkedList<Career> readCareer()
        {
            LinkedList<Career> careers = new LinkedList<Career>();
            StreamReader sr = new StreamReader(@"Career.txt");
            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    Career p = new Career(dats[0], dats[1],int.Parse(dats[2]),bool.Parse(dats[3]),DateTime.Parse(dats[4]),DateTime.Parse(dats[5]));
                    careers.AddLast(p);
                    line = sr.ReadLine();
                }
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
            return careers;
        }
    }
}
