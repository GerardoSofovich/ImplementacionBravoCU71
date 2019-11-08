using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosBravo
{
    public partial class TabPageDotaciones : UserControl
    {
        public TabPageDotaciones(String _dominio, String _fecha, String _Hora, String _kmInicial)
        {
            InitializeComponent();
            
            edtDominio.Text     = _dominio;
            edtFechaSalida.Text = _fecha;
            edtHoraSalida.Text  =_Hora;
            edtKmSalida.Text    = _kmInicial;
        }

        private void lblHoraSalida_Click(object sender, EventArgs e)
        {

        }

        private void lblKmInicial_Click(object sender, EventArgs e)
        {

        }

        public Boolean ValidarFechas()
        {
            return true;
        }
        public Boolean ValidarHoras()
        {
            return true;
        }
        public Boolean ValidarKilometraje()
        {
            return true;
        }

        public string getFechaLlegada()
        {
            return edtFechaLlegada.Text;
        }
        public string getHoraLlegada()
        {
            return edtHoraLlegada.Text;
        }
        public int getKmFinal()
        {
            return int.Parse(edtKmFinal.Text);
        }
        public string getDomino()
        {
            return edtDominio.Text;
        }
        public int getKmInicial()
        {
            return int.Parse(edtKmSalida.Text);
        }

        public Boolean validarDatosCompletos()
        {
            Boolean flag = true;

            if (!edtFechaLlegada.MaskCompleted)
            {
                flag = false;
            }
            if (!edtHoraLlegada.MaskCompleted)
            {
                flag = false;
            }
            if (edtKmFinal.Text.Equals(""))
            {
                flag = false;
            }
            return flag;
        }

        private void edtFechaLlegada_Leave(object sender, EventArgs e)
        {

        }

        public Boolean ValidarDatos()
        {
            Boolean flag = true;
            if (edtFechaLlegada.MaskCompleted && edtHoraLlegada.MaskCompleted)
            {
                try
                {
                    DateTime fechaHoraSalida = Convert.ToDateTime(edtFechaSalida.Text + " " + edtHoraSalida.Text);
                    DateTime fechaHoraLlegada = Convert.ToDateTime(edtFechaLlegada.Text + " " + edtHoraLlegada.Text);
                    if (fechaHoraSalida >= fechaHoraLlegada)
                    {
                        flag = false;
                    }
                }
                catch (Exception e)
                {
                    flag = false;
                }
            } else
            {
                flag = false;
            }
            if (!edtKmFinal.Text.Equals(""))
            {
                int kmSalida  = Int32.Parse(edtKmSalida.Text);
                int kmLlegada = Int32.Parse(edtKmFinal.Text);
                if (kmSalida > kmLlegada)
                {
                    flag = false;
                }
            } else
            {
                flag = false;
            }
            
            return flag;
        }

        private void edtKmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
