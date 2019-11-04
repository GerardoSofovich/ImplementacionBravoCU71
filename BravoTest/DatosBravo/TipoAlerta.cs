using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    class TipoAlerta
    {
        #region Atributos

        private String nombre;
        private String descripcion;
        private int intensidadSonora;//reveer tipo - eliminar comentario para presentacion
        private String tono;//reveer tipo - eliminar comentario para presentacion

        #endregion

        #region Metodos de seteo
        public void SetNombre(String _nombre)
        {
            this.nombre = _nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }

        public void setDescripcion(String _descripcion)
        {
            this.descripcion = _descripcion;
        }
        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setIntensidadSonora(int _intensidadSonora)
        {
            this.intensidadSonora = _intensidadSonora;
        }
        public int getIntensidadSonora()
        {
            return this.intensidadSonora;
        }

        public void setTono(String _tono)
        {
            this.tono = _tono;
        }
        public String getTono()
        {
            return this.tono;
        }
        #endregion
    }
}
