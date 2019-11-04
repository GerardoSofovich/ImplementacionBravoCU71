using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Informada:Estado
    {
        public Informada() : base("Informada")
        {

        }
        public override bool esInformada()
        {
            return true;
        }
    }
}
