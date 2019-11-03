using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class PantallaFinalizarIntervencion
    {
        GestoFinalizarIntervencion gestor;
        Intervencion[] intervencionesEnCurso;
        int[] opciones;
        string[][] datosIngresados;
        bool kmValidado;
        public void Escribir()
        {
            Console.WriteLine("Test pantalla");
        }
        public void ConfirmarFinalizacionIntervencion()
        {

        }
        public void IngresarKMUnidadMovil(int n)
        {
            Console.WriteLine("Escriba el Kilometraje de Vuelta");
            double readKM = Convert.ToDouble(Console.ReadLine());
            datosIngresados[n][1] = readKM.ToString();
        }
        public void IngresarFechaHoraLlegadaDotacion(int n,DateTimeOffset dateTime)
        {
            datosIngresados[n][0] = dateTime.ToString();
        }
        public void SeleccionarIntervencion(int intervencion)
        {
            gestor.IntervencionSeleccionada(intervencion);
        }
        public void FinalizarIntervencion()
        {

        }
        public  void HabilitarPantalla(Sesion sesion,Bombero bombero)
        {
            gestor = new GestoFinalizarIntervencion(sesion,bombero,this);
            Console.WriteLine("Pantalla Habilitada");
            gestor.OpcionFinalizarIntervencion();
        }
       
        public void SolicitarSeleccionIntervencion(Intervencion[] intervencions)
        {
            intervencionesEnCurso = intervencions;
            
            int cantidadIntervenciones = intervencionesEnCurso.Count();
            Console.WriteLine("Fecha Creacion, Ubicacion, Resumen");
            DateTimeOffset dateTime;
            string ubicacion;
            string mensaje;
            for(int i = 0; i < cantidadIntervenciones; i++)
            {
                intervencionesEnCurso[i].ObtenerDatos(out dateTime, out ubicacion, out mensaje);
                Console.WriteLine(i + 1.ToString() + "--" + dateTime.ToString() + "--" + ubicacion + "--" + mensaje);
            }
            opciones = new int[intervencionesEnCurso.Count()];
            for(int i =0;i< cantidadIntervenciones; i++)
            {
                Console.WriteLine("{0} " + " -- Elija la dotacion que desee", i + 1);
            }
            Console.WriteLine("...");

        }
        public DateTimeOffset SolicitarFechaHoraLlegadaDotacion()
        {
            DateTimeOffset dateTime = DateTimeOffset.Now;
            Console.WriteLine("Escriba la Fecha Hora Llegada");
            return dateTime;
        }
        public void SolicitarConfirmacionFinalizacionIntervencion()
        {

        }
        public void todoMal()
        {
            Console.WriteLine("Escriba un bombero decente");
        }
        public void MostrarDotacion(string[][] _datosDotacion)
        {
            int cantidadDotaciones = _datosDotacion.Count();
            datosIngresados = new string[cantidadDotaciones][];
            Console.WriteLine("Datos Dotaciones");
            Console.WriteLine("Dotacion-- Dominio Unidad -- FechaHoraSalida -- KM inicio");
            for(int i = 0; i < cantidadDotaciones; i++)
            {
                Console.WriteLine("{0}-- {1} -- {2} -- {3}km",i+1,_datosDotacion[i][0],_datosDotacion[i][1], _datosDotacion[i][2]);
                DateTimeOffset date= SolicitarFechaHoraLlegadaDotacion();
                IngresarFechaHoraLlegadaDotacion(i,date);
                IngresarKMUnidadMovil(i);
                kmValidado = gestor.ValidarKMUnidadesMoviles(_datosDotacion[i], i);
            }
        }
    }
}
