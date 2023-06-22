using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop_poperties.github_io.clases
{
    public class persona
    {
        private string ?idPerson;
        private string ?name;
        private string ?age;
        private string ?email;


    public persona (string idPerson, string name, string age, string email){

             this.idPerson = idPerson;
             this.name = name;
             this.age = age;
             this.email = email;
          
    }

    }
}