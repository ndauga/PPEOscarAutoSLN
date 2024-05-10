using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO1ConcessionnaireLib
{
    public class User
    {
        //Objet contenant les info Utilisateur.
        //Atributs
        private string name;
        private string password;
        //Constructeur
        public User(string name, string password)
        {
            Password = password;
            Name = name;
        }
        //Getter setter
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
    }
}
