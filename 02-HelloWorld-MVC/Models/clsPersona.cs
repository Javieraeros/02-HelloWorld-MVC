using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HelloWorld_MVC.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTimeOffset FechaNac { get; set; }

        public Persona(){
            Nombre = "";
            Apellidos = "";
            FechaNac = new DateTimeOffset();
            }

        public Persona(string nombre, string apellidos, DateTimeOffset fechaNac)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
        }
    }
}
