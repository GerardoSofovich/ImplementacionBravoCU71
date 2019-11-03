using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Rol
    {
        string Nombre;
        public Rol(string _nombre)
        {
            Nombre = _nombre;
        } 
        public string GetNombre()
        {
            return Nombre;
        }
    }
}
