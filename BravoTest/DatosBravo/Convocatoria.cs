using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Convocatoria
    {
        Bombero bombero;
        bool confirmo;
        public Convocatoria(bool _confirmo,Bombero _bombero)
        {
            confirmo = _confirmo;
            bombero = _bombero;
        }
    }
}
