using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Usuario
    {



        public bool ValidarUsuario(Bombero bombero)
        {
           return  bombero.esEncargadoGuardia();
        }
    }
}
