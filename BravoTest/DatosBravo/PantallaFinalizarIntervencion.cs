using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosBravo
{
    public partial class PantallaFinalizarIntervencion : Form
    {
        private GestoFinalizarIntervencion gestor;
        private Intervencion[] intervecionesEnCurso;

        public PantallaFinalizarIntervencion()
        {
            InitializeComponent();
        }

        private void PantallaFinalizarIntervencion_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Boolean ValidarDatosCompletos()
        {
            Boolean flag = true;
            TabPageDotaciones uc;
            foreach (TabPage tp in tbcDatos.TabPages)
            {
                if (!tp.Text.Equals("Seleccionar Intervención"))
                {
                    foreach (Control control in tp.Controls)
                    {
                        uc = (TabPageDotaciones)control;
                        flag = flag && uc.validarDatosCompletos();
                    }
                }
            }
            return flag;
        }


        private Boolean ValidarDatosCorrectos()
        {
            Boolean flag = true;
            TabPageDotaciones uc;
            foreach (TabPage tp in tbcDatos.TabPages)
            {
                if (!tp.Text.Equals("Seleccionar Intervención"))
                {
                    foreach (Control control in tp.Controls)
                    {
                        uc = (TabPageDotaciones)control;
                        flag = flag && uc.ValidarDatos();
                    }
                }
            }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCompletos())
            {
                if (ValidarDatosCorrectos())
                {
                    this.ingresarFechaHoraLlegadaDotacion();
                } else
                {
                    MessageBox.Show("Algunos datos ingresados son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Existen datos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void opcionFinalizarIntervencion(Sesion actualSesion, Bombero _bomberoEnSesion)
        {
            gestor = new GestoFinalizarIntervencion(actualSesion, _bomberoEnSesion, this);
            this.habilitarPantalla();
        }

        public void habilitarPantalla()
        {
            btnAceptar.Enabled = false;
            this.presionarAnterior();
            gestor.OpcionFinalizarIntervencion();
            this.Refresh();
        }

        public void solicitarSeleccionIntervencion(Intervencion[] _intervenciones)
        {
            //Funciona como id
            int i = 0;
            //Agrega cada una de las intervenciones a mostrar
            DataGridViewRow fila = null;
            
            foreach (var intervencion in _intervenciones)
            {
                fila = new DataGridViewRow();
                fila.CreateCells(dgvInterveciones);
                //Asignamos los valores
                //        fila.Cells["gvcUbicacion"].Value       = intervencion.getDomicilioReportado();
                fila.Cells[0].Value = intervencion.getDomicilioReportado();
                fila.Cells[1].Value = intervencion.getResumen();
                fila.Cells[3].Value = intervencion.getFechaCreacion();
                fila.Cells[2].Value = i;


                //Agregamos la fila al control
                dgvInterveciones.Rows.Add(fila);
                //Incrementamos contador
                i++;
            }
            this.ShowDialog();
        }

        public void todoBien()
        {
            MessageBox.Show("Intervencion finalizada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void todoMal()
        {

        }

        public void seleccionarIntervencion()
        {
            int nroInterevencion = -1;

            if (dgvInterveciones.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dgvInterveciones.SelectedRows)
                {
                    nroInterevencion = (int) row.Cells["gvcNroIntervencion"].Value;
                }
            } 
            gestor.IntervencionSeleccionada(nroInterevencion);
        }

        public void MostrarDotacion(String[][] dotaciones)
        {
            String dominio;
            DateTime fechaHora;
            String fecha;
            String hora;
            String kmInicial;

            for (int i = 0; i < dotaciones.GetLength(0); i++)
            {
                dominio   = dotaciones[i][0];
                fechaHora = Convert.ToDateTime(dotaciones[i][1]);
                fecha     = Convert.ToString(fechaHora.Date);
                hora      = Convert.ToString(fechaHora.TimeOfDay);
                kmInicial = dotaciones[i][2];

                TabPage tp = new TabPage(dominio);
                tp.Controls.Add(new TabPageDotaciones(dominio, fecha, hora, kmInicial));
                tbcDatos.TabPages.Add(tp);
            }

        }


        public void ingresarFechaHoraLlegadaDotacion()
        {
            String[,] fechasHoras = new String[tbcDatos.TabPages.Count-1,2];
            int i = 0;
            TabPageDotaciones uc;
            foreach (Control paginas in tbcDatos.TabPages)
            {
                if (!paginas.Text.Equals("Seleccionar Intervención"))
                {
                    foreach (Control control in paginas.Controls)
                    {
                        uc = (TabPageDotaciones)control;
                        fechasHoras[i-1,0] = uc.getDomino();
                        fechasHoras[i-1,1] = uc.getFechaLlegada() + " " + uc.getHoraLlegada();
                    }
                }
                i++;
            }
            gestor.fechaHoraLlegadaDotacionIngresada(fechasHoras);
        }

        public void solicitarKmUnidadMovil()
        {
            this.ingresarKmUnidadMovil();
        }

        public void ingresarKmUnidadMovil()
        {
            String[] dominios  = new String[tbcDatos.TabPages.Count-1];
            String[][] kilometros = new String[tbcDatos.TabPages.Count-1][];
            int i = 0;
            TabPageDotaciones uc;
            foreach (Control paginas in tbcDatos.TabPages)
            {
                if (!paginas.Text.Equals("Seleccionar Intervención"))
                {
                    foreach (Control control in paginas.Controls)
                    {
                        uc = (TabPageDotaciones)control;
                        dominios[i-1] = uc.getDomino();
                        kilometros[i - 1] = new String[2];
                        kilometros[i-1][0] = Convert.ToString(uc.getFechaLlegada());
                        kilometros[i-1][1] = Convert.ToString(uc.getKmFinal());
                    }
                }
                i++;
            }
            gestor.KMUnidadIngresado(dominios, kilometros);
        }

        public void solicitarConfirmacionFinalizacionIntervencion()
        {
            if (MessageBox.Show("¿Seguro desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.confirmarFinalizarIntervencion();
            }
        }

        public void confirmarFinalizarIntervencion()
        {
            gestor.FinalizacionIntervencionConfirmada();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void presionarSiguiente()
        {
            btnAnterior.Enabled  = true;
            btnSiguiente.Enabled = false;
            btnAceptar.Enabled   = true;
            dgvInterveciones.Enabled = false;
        }

        private void presionarAnterior()
        {
            btnAnterior.Enabled  = false;
            btnSiguiente.Enabled = true;
            btnAceptar.Enabled   = false;
            dgvInterveciones.Enabled = true;
        }

        private void limpiarPaginas()
        {
            foreach (TabPage pagina in tbcDatos.TabPages)
            {
                if (!pagina.Text.Equals("Seleccionar Intervención"))
                {
                    tbcDatos.TabPages.Remove(pagina);
                }
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (dgvInterveciones.Enabled)
            {
                if (dgvInterveciones.SelectedRows.Count == 1)
                {
                    presionarSiguiente();
                    this.seleccionarIntervencion();
                }
                else
                {
                    MessageBox.Show("Seleccione una intervención para continuar.");
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            presionarAnterior();
            limpiarPaginas();
        }
    }
}
