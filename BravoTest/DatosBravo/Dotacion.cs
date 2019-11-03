using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Dotacion
    {
        UnidadMovil unidadMovil;
        DateTimeOffset fechaHoraLlegada;
        DateTimeOffset fechaHoraSalida;
        public Dotacion(UnidadMovil _unidadMovil,DateTimeOffset _fechaHoraSalida)
        {
            unidadMovil = _unidadMovil;
            fechaHoraSalida = _fechaHoraSalida;
        }

        public void SetKMUnidadMovil()
        {
            
        }
        public void SetFechaHoraLlegada(DateTimeOffset _fechaHoraLlegada)
        {
            fechaHoraLlegada = _fechaHoraLlegada;
        }
        public string[] MostrarDotacion()
        {
            string[] datos = new string[3];

            datos[0] = ObtenerDominioUnidad();
            datos[1] = fechaHoraSalida.ToString();
            datos[2] = ObtenerKilometraje().ToString();
            return datos;
        }
        public string ObtenerDominioUnidad()
        {
            return unidadMovil.GetDominio();
        }
        public double ObtenerKilometraje()
        {
            return unidadMovil.GetKM();
        }
    }
}
