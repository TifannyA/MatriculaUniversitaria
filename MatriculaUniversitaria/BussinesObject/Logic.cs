using MatriculaUniversitaria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriculaUniversitaria.BussinesObject
{
    class Logic
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

        public void agregarPersona( Person p)
        {
            _people.AddLast(p);

        }

        public void editarPersona(Person p, Person e) 
        {
            _people.Find(e).Value=p;  
        }

        public void eliminarPersona(Person p) 
        {
            _people.Remove(p);
        }

        public void agregarCarrera(Career c)
        {
            _career.AddLast(c);

        }

        public void editarCarrera(Career p, Career e)
        {
            _career.Find(e).Value = p;
        }

        public void eliminarCarrera(Career p)
        {
            _career.Remove(p);
        }

        public void agregarCurso(Course p)
        {
            _Course.AddLast(p);

        }

        public void editarCurso(Course p, Course e)
        {
            _Course.Find(e).Value = p;
        }

        public void eliminarCurso(Course p)
        {
            _Course.Remove(p);
        }

        public void agregarUsuario(Usuario p)
        {
            _users.AddLast(p);

        }

        public void editarUsuario(Usuario p, Usuario e)
        {
            _users.Find(e).Value = p;
        }

        public void eliminarUsuario(Usuario p)
        {
            _users.Remove(p);
        }


    }
}
