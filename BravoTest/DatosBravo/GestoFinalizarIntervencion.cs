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
        public GestoFinalizarIntervencion(Sesion actualSesion,Bombero _bomberoEnSesion,PantallaFinalizarIntervencion _pantalla)
        {
            sesion = actualSesion;
            bomberoEnSesion = _bomberoEnSesion;
            pantalla = _pantalla;
        }
        public void FinalizacionIntervencionConfirmada()
        {

        }
        public void KMUnidadIngresado()
        {

        }
        public void fechaHoraLlegadaDotacionIngresada()
        {

        }
        public void IntervencionSeleccionada(int _intervencion)
        {
            intervencionSeleciondaObject = intervenciones[_intervencion - 1];
            pantalla.MostrarDotacion(intervencionSeleciondaObject.ObtenerDotaciones());
        }
        public void OpcionFinalizarIntervencion()
        {
            if (ValidarRolUsuario())
            {
                ObtenerFechaActual();
                
                intervenciones=ObtenerIntervencionesEnCurso();
                OrdenarIntervencionesXFechaCreacion();
                pantalla.SolicitarSeleccionIntervencion(intervenciones);
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

        }
        public bool ValidarKMUnidadesMoviles(string[] kilometrajes,int i)
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
        public bool tomarDatos(string[][] datosIngresados)
        {
            bool validacion = true;
            int datos = datosIngresados.Count();
            for(int i = 0; i < datos; i++)
            {
                validacion = ValidarKMUnidadesMoviles(datosIngresados[i],i);
                if (!validacion)
                {
                    break;
                }
            }
            return validacion;
        }
    }
}
