using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_HelloWorld_MVC.Models
{
    /// <summary>
    /// Clase de utilidades de prueba, no se debe usar así
    /// </summary>
    public class ListadoPersona
    {
        public List<Persona> ListadoDefecto()
        {
            List<Persona> p = new List<Persona>();
            p.Add(new Persona("Javier", "Ruiz", new DateTimeOffset()));
            p.Add(new Persona("Javier2", "Ruiz2", new DateTimeOffset()));
            p.Add(new Persona("Javier3", "Ruiz3", new DateTimeOffset()));
            p.Add(new Persona("Javier4", "Ruiz4", new DateTimeOffset()));
            p.Add(new Persona("Javier5", "Ruiz5", new DateTimeOffset()));
            p.Add(new Persona("Javier6", "Ruiz6", new DateTimeOffset()));
            return p;
        }
        
    }
}