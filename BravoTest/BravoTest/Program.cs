using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DatosBravo;


namespace BravoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryRolUsuarioBombero factory = new FactoryRolUsuarioBombero();
            factory.CrearBomberoUsuarioSesion(1);
            Sesion sesion = factory.sesion;
            Bombero bombero = factory.bombero;
            Console.WriteLine("Finalizar Intervencion..");
            PantallaFinalizarIntervencion finalizarIntervencion = new PantallaFinalizarIntervencion();
            finalizarIntervencion.opcionFinalizarIntervencion(sesion, bombero);
           // int intervencion = Convert.ToInt32(Console.ReadLine());
            //pantallaFinalizar.SeleccionarIntervencion(intervencion);
          //  Console.ReadLine();
        }
    }
}
