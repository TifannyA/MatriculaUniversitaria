using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Career p = new Career();
                    p.id = int.Parse(dats[0]);
                    p.name = dats[1];
                    p.totalCredit = int.Parse(dats[2]);
                    p.state = bool.Parse(dats[3]);
                    p.startDate = DateTime.Parse(dats[4]);
                    p.endDate = DateTime.Parse(dats[5]);
                    careers.AddLast(p);
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
            return careers;
        }
    }
}
