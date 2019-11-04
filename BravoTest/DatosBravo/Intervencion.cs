using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Intervencion
    {
        DateTimeOffset fechaCreacion;
        string ubicacion;
        string resumen;
        Gravedad gravedad;
        TipoSiniestro tipoSiniestro;
        Estado estado;
        Dotacion[] dotaciones;
        List<HistorialIntervencion> historialesIntervencion;
        public Intervencion(DateTimeOffset _fechaCreacion,string _ubicacion, string _resumen,Dotacion[] _dotaciones)
        {
            fechaCreacion = _fechaCreacion;
            ubicacion = _ubicacion;
            resumen = _resumen;
            dotaciones = _dotaciones;
            historialesIntervencion = new List<HistorialIntervencion>();

        }
        public DateTimeOffset getFechaCreacion()
        {
            return fechaCreacion;
        }
        public void ObtenerDatos(out DateTimeOffset _fechaCreacion, out string _ubicacion, out string _resumen) 
        {
            _fechaCreacion = fechaCreacion;
            _ubicacion = ubicacion;
            _resumen = resumen;
        }
        public bool EsEnCurso()
        {
            return estado.EsEnCurso();
        }
        public void GetGravedad()
        {

        }
        public void GetTipoSiniestro()
        {


        }
        public void Finalizar(string [][] datosIngresados,DateTimeOffset fechaHoraActual)
        {
            estado.Finalizar(this,datosIngresados,fechaHoraActual);
        }
        public string[][] ObtenerDotaciones()
        {
            string[][] datosDotaciones = new string[ dotaciones.Count()][];
            for(int i = 0; i < dotaciones.Count(); i++)
            {
                datosDotaciones[i] = dotaciones[i].MostrarDotacion();

            }
            return datosDotaciones;

        }
        public void SetEstado(Estado _estado)
        {
            estado = _estado;
        }
        public void AgregarHistorial(HistorialIntervencion historialIntervencion)
        {
            historialesIntervencion.Add(historialIntervencion);
        }
        public  Dotacion[] GetDotacions()
        {
            return dotaciones;
        }

        public DateTimeOffset getFechaHoraSolicitud()
        {
            DateTimeOffset fechaHoraSolicitud = DateTimeOffset.Now;
            //  loop Buscar Fecha y hora de intervencion
            foreach (var historial in historialesIntervencion)
            {
                if (historial.esInformada())
                {
                    fechaHoraSolicitud = historial.getFechaHoraDesde();
                }
            }

            return fechaHoraSolicitud;
        }

        public String getDomicilioReportado()
        {
            return ubicacion;
        }

        public String obtenerGravedad()
        {
            return gravedad.GetNombre();

        }
    }
}
