using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Person
    {
        public int id { get; set; }
        public int dni { get; set; }
        public string name { get; set; }
        public string last { get; set; }
        public char sex { get; set; }
        public DateTime bornDate { get; set; }
        public string academyLvl { get; set; }
        public DateTime admisionDate { get; set; }
        public string admisionUser { get; set; }
        public string nationality { get; set; }
        public string state { get; set; }

        public string printPerson() 
        {
            return this.id + "-"+this.dni + "-" + this.name + "-"+this.last+"-"+this.sex+"-"+this.bornDate
                +"-"+this.admisionDate+"-"+this.admisionUser+"-"+this.nationality+"-"+this.state;
        }

    }
}
