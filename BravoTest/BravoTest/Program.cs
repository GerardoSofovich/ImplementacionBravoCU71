using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosBravo;


namespace BravoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryRolUsuarioBombero factory = new FactoryRolUsuarioBombero();
            factory.CrearBomberoUsuarioSesion(1);
            Sesion sesion = factory.Sesion;
            Bombero bombero = factory.Bombero;
            Console.WriteLine("Finalizar Intervencion..");
            PantallaFinalizarIntervencion pantallaFinalizar = new PantallaFinalizarIntervencion();
            pantallaFinalizar.HabilitarPantalla(sesion, bombero);
            int intervencion = Convert.ToInt32(Console.ReadLine());
            pantallaFinalizar.SeleccionarIntervencion(intervencion);
            Console.ReadLine();
        }
    }
}
