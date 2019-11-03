using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Cancelada:Estado
    {
        public Cancelada(string _nombre) : base(_nombre)
        {

        }
        public new bool EsCancelada()
        {
            return true;
        }
    }
}
