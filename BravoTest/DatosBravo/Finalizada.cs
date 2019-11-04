using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Finalizada:Estado
    {
        public Finalizada(string _nombre) : base(_nombre)
        {

        }
        public override bool EsFinalizada()
        {
            return true;
        }
    }
}
