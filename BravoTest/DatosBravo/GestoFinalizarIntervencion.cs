using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class GestoFinalizarIntervencion
    {

        Sesion sesion;
        PantallaFinalizarIntervencion pantalla;
        Bombero bomberoEnSesion;
        Intervencion[] intervenciones;
        DateTimeOffset fechaHoraActual;
        Intervencion intervencionSeleciondaObject;
        string[][] datosPantalla;
        string[][] kilometrajeUnidad;
        string[,] fechasHoras;

        public GestoFinalizarIntervencion(Sesion actualSesion,Bombero _bomberoEnSesion,PantallaFinalizarIntervencion _pantalla)
        {
            sesion = actualSesion;
            bomberoEnSesion = _bomberoEnSesion;
            pantalla = _pantalla;
        }
        public void FinalizacionIntervencionConfirmada()
        {
            FinalizarIntervencion();
            pantalla.todoBien();
        }
        public void KMUnidadIngresado(String[] _dominios, string[][] _kilometros)
        {
            kilometrajeUnidad = _kilometros;
             ValidarKMUnidadesMoviles(kilometrajeUnidad);
            //pantalla.solicitarConfirmacionFinalizacionIntervencion();

        }
        public void fechaHoraLlegadaDotacionIngresada(String[,] _fechasHoras)
        {
            fechasHoras = _fechasHoras;
            pantalla.solicitarKmUnidadMovil();
        }
        public void IntervencionSeleccionada(int _intervencion)
        {
            intervencionSeleciondaObject = intervenciones[_intervencion];
            pantalla.MostrarDotacion(intervencionSeleciondaObject.ObtenerDotaciones());
        }
        public void OpcionFinalizarIntervencion()
        {
            if (ValidarRolUsuario())
            {
                ObtenerFechaActual();

                intervenciones = ObtenerIntervencionesEnCurso();
                OrdenarIntervencionesXFechaCreacion();
                pantalla.solicitarSeleccionIntervencion(intervenciones);
            }
            else
            {
                pantalla.todoMal();
            }                
        }
        public void FinCU()
        {

        }
        public void FinalizarIntervencion()
        {
            intervencionSeleciondaObject.Finalizar(datosPantalla,fechaHoraActual);
        }
        public bool ValidarKMUnidadMovil(string[] kilometrajes,int i)
        {
            
            double kmInicial = Convert.ToDouble(intervenciones[i].ObtenerDotaciones()[i][2]);
            double kmFinal = Convert.ToDouble(kilometrajes[1]);
            return kmFinal > kmInicial;
        }
        public string[][] ObtenerDotaciones()
        {
            return intervencionSeleciondaObject.ObtenerDotaciones();
        }
        public void OrdenarIntervencionesXFechaCreacion()
        {
            intervenciones = intervenciones.OrderBy(x => x.getFechaCreacion()).ToArray();
        }
        public void ObtenerFechaActual()
        {
            fechaHoraActual = DateTimeOffset.Now;
        }
        public Intervencion[] ObtenerIntervencionesEnCurso()
        {
            FactoryIntervenciones factory = new FactoryIntervenciones();
            factory.crearIntervenciones();
            Intervencion[] intervencions = factory.GetIntervencions().Where(x=>x.EsEnCurso()).ToArray();
            return intervencions;
        }
        public bool ValidarRolUsuario()
        {
            return sesion.ValidarRol(bomberoEnSesion);
        }
        public void ValidarKMUnidadesMoviles(string[][] datosIngresados)
        {
            datosPantalla = datosIngresados;
            pantalla.solicitarConfirmacionFinalizacionIntervencion();
        }
    }
}
