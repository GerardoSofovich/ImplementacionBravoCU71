using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Cancelada:Estado
    {
        public Cancelada() : base("Cancelada")
        {

        }
        public new bool EsCancelada()
        {
            return true;
        }
    }
}
