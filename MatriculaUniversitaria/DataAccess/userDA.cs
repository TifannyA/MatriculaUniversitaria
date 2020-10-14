﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.DataAccess
{
    class userDA
    {
        public bool writeUser(LinkedList<Usuario> users)
        {
            StreamWriter sw = new StreamWriter(@"Usuario.txt");
            try
            {
                foreach (Usuario u in users)
                {
                    string dats = u.printUsuario();
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
        public LinkedList<Usuario> readUsuario()
        {
            LinkedList<Usuario> users = new LinkedList<Usuario>();
            StreamReader sr = new StreamReader(@"Usuario.txt");

            try
            {
                String line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] dats = line.Split(',');
                    Usuario u = new Usuario();
                    u.pnombre = dats[0];
                    u.papellidos = dats[1];
                    u.pid_user = int.Parse(dats[2]);
                    u.pcod = dats[3];
                    u.pid_person = int.Parse(dats[4]);
                    u.ppass = dats[5];
                    u.pfechaExp = DateTime.Parse(dats[6]);
                    u.estado = dats[7];
                    users.AddLast(u);
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
            return users;
        }
    }
}

