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
        public Intervencion(DateTimeOffset _fechaCreacion,string _ubicacion, string _resumen,Dotacion[] _dotaciones)
        {
            fechaCreacion = _fechaCreacion;
            ubicacion = _ubicacion;
            resumen = _resumen;
            dotaciones = _dotaciones;

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
        public void Finalizar()
        {

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
        public void AgregarHistorial()
        {

        }

    }
}
