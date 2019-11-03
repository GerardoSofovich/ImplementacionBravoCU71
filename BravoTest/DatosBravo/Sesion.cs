using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Sesion
    {
        Usuario usuario;
        public Sesion(Usuario _usuario)
        {
            usuario=_usuario;
        }
        public bool ValidarRol(Bombero bombero)
        {
            return bombero.esEncargadoGuardia();
        }
    }
}
