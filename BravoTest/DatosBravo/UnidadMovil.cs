using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class UnidadMovil
    {
        string dominio;
        double KM;
        public UnidadMovil(string _dominio,double _KM)
        {
            dominio = _dominio;
            KM = _KM;
        }
        public string GetDominio()
        {
            return dominio;
        }
        public double GetKM()
        {
            return KM;
        }
        public void SetKM(double _KM)
        {
            KM = _KM;
        }
    }
}
