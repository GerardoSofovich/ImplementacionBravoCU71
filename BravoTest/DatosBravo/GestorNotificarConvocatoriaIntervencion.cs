using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    class GestorNotificarConvocatoriaIntervencion
    {
        #region Propiedades
        private Intervencion intervencion;
        private Bombero[] bomberosCombocados;
        private String domicilioReportado;
        private DateTimeOffset fechaHoraActual;
        private DateTimeOffset fechaHoraSolicitud;
        private String gravedad;
        private String mensaje;
        private TipoSiniestro tipoSiniestro;
        private TipoAlerta tipoAlerta;
        #endregion

        public void nuevaNotificacion(Intervencion _intervencion)
        {
            this.intervencion = _intervencion;


            this.generarNotificacion();
        }

        public void generarNotificacion()
        {
            // Paso 2 del CU - obtenemos datos de la Intervencion
            this.fechaHoraSolicitud = intervencion.getFechaHoraSolicitud();
            this.domicilioReportado = intervencion.getDomicilioReportado();
            this.gravedad = intervencion.obtenerGravedad();
            //Generamos el texto a enviar
            mensaje = "Alerta de intervención: Gravedad " + this.gravedad + "\n    Reportado en " + this.domicilioReportado + " a las " + fechaHoraSolicitud ;
        }


    }
}
