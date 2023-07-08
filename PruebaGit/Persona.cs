using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGit
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set;}

        public string Saludar()
        {
            return $"Hola minombre es {Nombre} y mi apellido es {Apellido}";
        }  
    }
}
