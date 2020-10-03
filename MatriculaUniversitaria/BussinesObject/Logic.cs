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

        public eliminarPersona(Person p) 
        {
            _people.Remove(p);
        }


    }
}
