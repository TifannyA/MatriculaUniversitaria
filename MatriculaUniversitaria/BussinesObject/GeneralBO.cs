using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace matriculaUniversitaria.BussinesObject
{
     class GeneralBO
    {

        private LinkedList<Person> _people;

        public LinkedList<Person> people
        {
            get { return _people; }
            set { _people = value; }
        }


        private LinkedList<Career> _career;

        public LinkedList<Career> careers
        {
            get { return _career; }
            set { _career= value; }
        }

        private LinkedList<Course> _Course;

        public  LinkedList<Course> courses
        {
            get { return _Course; }
            set { _Course = value; }
        }

        private LinkedList<Usuario> _users;

        public LinkedList<Usuario> users
        {
            get { return _users; }
            set { _users = value; }
        }

        /*
         * Método que nos permite agrregar una nueva persona.
         */
        public void agregarPersona( Person p)
        {
            _people.AddLast(p);

        }

        /*
         * Método que nos permite editar una persona.
         */
        public void editarPersona(Person p, Person e) 
        {
            _people.Find(e).Value=p;  
        }

        /*
         * Método que nos permite eliminar una persona.
         */
        public void eliminarPersona(Person p) 
        {
            _people.Remove(p);
        }

        /*
         * Método que nos permite agregar una nueva carrera.
         */
        public void agregarCarrera(Career c)
        {
            _career.AddLast(c);

        }

        /*
         * Método que nos permite editar una carrera.
         */
        public void editarCarrera(Career p, Career e)
        {
            _career.Find(e).Value = p;
        }

        /*
         * Método que nos permite eliminar una  carrera.
         */
        public void eliminarCarrera(Career p)
        {
            _career.Remove(p);
        }

        /*
         * Método que nos permite agregar un nuevo curso.
         */
        public void agregarCurso(Course p)
        {
            _Course.AddLast(p);

        }

        /*
         * Método que nos permite editar un curso.
         */
        public void editarCurso(Course p, Course e)
        {
            _Course.Find(e).Value = p;
        }

        /*
         * Método que nos permite eliminar un curso.
         */
        public void eliminarCurso(Course p)
        {
            _Course.Remove(p);
        }

        /*
         * Método que nos permite agregar un nuevo usuario.
         */
        public void agregarUsuario(Usuario p)
        {
            _users.AddLast(p);

        }
        /*
         * Método que nos permite editar un usuario.
         */
        public void editarUsuario(Usuario p, Usuario e)
        {
            _users.Find(e).Value = p;
        }

        /*
         * Método que nos permite eliminar un usuario.
         */
        public void eliminarUsuario(Usuario p)
        {
            _users.Remove(p);
        }


       

    }
}
