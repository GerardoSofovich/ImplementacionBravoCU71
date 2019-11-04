using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class EnCurso:Estado
    {
        public EnCurso() : base("En Curso")
        {

        }
        public override bool EsEnCurso()
        {
            return true;
        }
        public override void Finalizar(Intervencion intervencion,string[][] datosIngresados,DateTimeOffset fechaHoraActual)
        {
            Estado estado = new Finalizada();
            HistorialIntervencion historialIntervencionFinalizada = new HistorialIntervencion(estado);
            historialIntervencionFinalizada.SetFechaHoraLlegada(fechaHoraActual);
            for (int i = 0; i < datosIngresados.Count(); i++)
            {
                intervencion.GetDotacions()[i].SetFechaHoraLlegada(Convert.ToDateTime(datosIngresados[i][0]));
                intervencion.GetDotacions()[i].SetKMUnidadMovil(Convert.ToDouble(datosIngresados[i][1]));
            }
            intervencion.AgregarHistorial(historialIntervencionFinalizada);
            intervencion.SetEstado(estado);
        }
    }
}
