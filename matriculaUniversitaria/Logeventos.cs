using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace matriculaUniversitaria
{
    class Logeventos
    {
        private string path = "";

        public Logeventos(string path)
        {
            this.path = path;
        }
        private string nombreArchivo()
        {
            string nombre = "";
            nombre = "log " + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + ".txt";
            return nombre;
        }

        private void directorio()
        {
            try
            {
                if (!Directory.Exists(this.path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (DirectoryNotFoundException e)
            {

                throw new Exception(e.Message);
            }
        }
        public void agregarLog(string evento)
        {
            //StreamWriter sw = new StreamWriter("");
            try
            {


                directorio();
                string nombre = nombreArchivo();
                string cadena = "";
                cadena += "Hora del evento: " + DateTime.Now + "Situación generada: " + evento;
                /*con el true se agrega una nueva linea al archivo existente y si no lo sobre escribe */
                StreamWriter sw = new StreamWriter(this.path + "/" + nombre, true);
                sw.Write(cadena);
                sw.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error al agregar archivo");

            }
        }
    }
}

