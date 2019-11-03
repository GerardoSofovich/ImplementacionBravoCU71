using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class EnCurso:Estado
    {
        public EnCurso(string _nombre) : base(_nombre)
        {

        }
        public override bool EsEnCurso()
        {
            return true;
        }
        public override void Finalizar()
        {

        }
    }
}
