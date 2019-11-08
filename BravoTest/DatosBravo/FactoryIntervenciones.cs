using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class FactoryIntervenciones
    {
        Intervencion[] intervenciones = new Intervencion[4];
        public void crearIntervenciones()
        {
            UnidadMovil unidadMovil1 = new UnidadMovil("342-hdo", 2342);
            DateTimeOffset dateTime1Salida = new DateTimeOffset(2019, 10, 27, 23, 00, 43, TimeSpan.Zero);
            Dotacion dotacion = new Dotacion(unidadMovil1, dateTime1Salida);
            Dotacion[] dotacions1 = new Dotacion[1];
            dotacions1[0] = dotacion;
            DateTimeOffset dateTime1 = new DateTimeOffset(2019, 10, 27, 22, 43, 31, TimeSpan.Zero);
            Intervencion intervencion1 = new Intervencion(dateTime1, "Avellaneda 2521", "Incendio de gravedad baja",dotacions1);
            Estado estado1 = new EnCurso();
            intervencion1.SetEstado(estado1);
            intervenciones[0] = intervencion1;

            UnidadMovil unidadMovil2 = new UnidadMovil("125-poi", 54645);
            DateTimeOffset dateTime2Salida = new DateTimeOffset(2019, 10, 27, 23, 06, 21, TimeSpan.Zero);
            Dotacion dotacion2 = new Dotacion(unidadMovil2, dateTime2Salida);
            UnidadMovil unidadMovil3 = new UnidadMovil("875-txy", 4534);
            DateTimeOffset dateTime3Salida = new DateTimeOffset(2019, 10, 27, 23, 09, 01, TimeSpan.Zero);
            Dotacion dotacion3 = new Dotacion(unidadMovil2, dateTime2Salida);
            Dotacion[] dotacions2 = new Dotacion[2];
            dotacions2[0] = dotacion2;
            dotacions2[1] = dotacion3;
            DateTimeOffset dateTime2= new DateTimeOffset(2019, 10, 27, 22, 55, 58, TimeSpan.Zero);
            Intervencion intervencion2 = new Intervencion(dateTime2, "Urquiza 123", "Emergencia en Recital, posibles lesiones",dotacions2);
            Estado estado2 = new EnCurso();
            intervencion2.SetEstado(estado2);
            intervenciones[1] = intervencion2;


            UnidadMovil unidadMovil5 = new UnidadMovil("907-efw",15631);
            DateTimeOffset dateTime5Salida = new DateTimeOffset(2019, 10, 28, 01, 30, 37, TimeSpan.Zero);
            Dotacion dotacion5 = new Dotacion(unidadMovil1, dateTime1Salida);
            UnidadMovil unidadMovil6 = new UnidadMovil("546-rew",54133);
            DateTimeOffset dateTime6Salida = new DateTimeOffset(2019, 10, 28, 01, 32, 02, TimeSpan.Zero);
            Dotacion dotacion6 = new Dotacion(unidadMovil1, dateTime1Salida);
            UnidadMovil unidadMovil7 = new UnidadMovil("342-hdo", 85664);
            DateTimeOffset dateTime7Salida = new DateTimeOffset(2019, 10, 28, 01, 32, 55, TimeSpan.Zero);
            Dotacion dotacion7 = new Dotacion(unidadMovil1, dateTime1Salida);
            Dotacion[] dotacions3 = new Dotacion[3];
            dotacions3[0] = dotacion5;
            dotacions3[1] = dotacion6;
            dotacions3[2] = dotacion7;
            DateTimeOffset dateTime3 = new DateTimeOffset(2019, 10, 28, 01, 22, 11, TimeSpan.Zero);
            Intervencion intervencion3 = new Intervencion(dateTime3, "Bulnes 541", "Explosion de garraga, Graveda alta",dotacions3);
            Estado estado3 = new EnCurso();
            intervencion3.SetEstado(estado3);
            intervenciones[2] = intervencion3;


            UnidadMovil unidadMovil4 = new UnidadMovil("342-hdo", 54474);
            DateTimeOffset dateTime4Salida = new DateTimeOffset(2019, 10, 27, 01, 11, 43, TimeSpan.Zero);
            Dotacion dotacion4 = new Dotacion(unidadMovil1, dateTime1Salida);
            Dotacion[] dotacions4 = new Dotacion[1];
            dotacions4[0] = dotacion4;
            DateTimeOffset dateTime4 = new DateTimeOffset(2019, 10, 28, 01, 43, 12, TimeSpan.Zero);
            Intervencion intervencion4 = new Intervencion(dateTime4, "Lavalleja 2678", "Choque de vehiculos",dotacions4);
            Estado estado4 = new Cancelada();
            intervencion4.SetEstado(estado4);
            intervenciones[3] = intervencion4;
        }
        public Intervencion[] GetIntervencions()
        {
            return intervenciones;
        }
    }
}
