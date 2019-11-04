using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class HistorialIntervencion
    {
        Estado estado;
        DateTimeOffset fechaHoraDesde;
        public HistorialIntervencion(Estado _estado)
        {
            estado = _estado;
        }
        public void SetFechaHoraLlegada(DateTimeOffset _fechaHoraDesde)
        {
            fechaHoraDesde = _fechaHoraDesde;
        }

    }
}
