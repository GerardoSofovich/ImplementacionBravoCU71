using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Bombero
    {
        Rol rol;
        public void SetRol(Rol _rol)
        {
            rol = _rol;
        }
        public bool esEncargadoGuardia()
        {
            if(rol.GetNombre()=="Encargado de Guardia")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
