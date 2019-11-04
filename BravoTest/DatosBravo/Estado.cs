using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class Estado
    {
        string nombre;
        public Estado(string _nombre)
        {
            nombre = _nombre;
        }
        public virtual bool EsEnCurso()
        {
            return false;
        }
        public virtual bool EsCancelada()
        {
            return false;
        }
        public virtual bool EsFinalizada()
        {
            return false;
        }
        public virtual void Finalizar(Intervencion intervencion,string[][] datosIngresados,DateTimeOffset fechaHoraActual)
        {

        }
    }
}
