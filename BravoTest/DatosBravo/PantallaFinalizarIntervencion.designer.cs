namespace DatosBravo
{
    partial class PantallaFinalizarIntervencion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaFinalizarIntervencion));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.lblContacto = new System.Windows.Forms.LinkLabel();
            this.lblBravo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblMapa = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.tbcDatos = new System.Windows.Forms.TabControl();
            this.tpgSeleccionIntervencion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInterveciones = new System.Windows.Forms.DataGridView();
            this.gvcUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcNroIntervencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.tbcDatos.SuspendLayout();
            this.tpgSeleccionIntervencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterveciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSuperior.Controls.Add(this.imgHome);
            this.pnlSuperior.Controls.Add(this.lblContacto);
            this.pnlSuperior.Controls.Add(this.lblBravo);
            this.pnlSuperior.Controls.Add(this.imgLogo);
            resources.ApplyResources(this.pnlSuperior, "pnlSuperior");
            this.pnlSuperior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSuperior.Name = "pnlSuperior";
            // 
            // imgHome
            // 
            resources.ApplyResources(this.imgHome, "imgHome");
            this.imgHome.Name = "imgHome";
            this.imgHome.TabStop = false;
            // 
            // lblContacto
            // 
            this.lblContacto.ActiveLinkColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.lblContacto, "lblContacto");
            this.lblContacto.DisabledLinkColor = System.Drawing.Color.White;
            this.lblContacto.ForeColor = System.Drawing.Color.White;
            this.lblContacto.LinkColor = System.Drawing.Color.White;
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.TabStop = true;
            // 
            // lblBravo
            // 
            resources.ApplyResources(this.lblBravo, "lblBravo");
            this.lblBravo.ForeColor = System.Drawing.Color.White;
            this.lblBravo.Name = "lblBravo";
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // lblMapa
            // 
            this.lblMapa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.lblMapa, "lblMapa");
            this.lblMapa.ForeColor = System.Drawing.Color.White;
            this.lblMapa.Name = "lblMapa";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnSiguiente, "btnSiguiente");
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tpgSeleccionIntervencion);
            resources.ApplyResources(this.tbcDatos, "tbcDatos");
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.SelectedIndex = 0;
            // 
            // tpgSeleccionIntervencion
            // 
            this.tpgSeleccionIntervencion.Controls.Add(this.label1);
            this.tpgSeleccionIntervencion.Controls.Add(this.dgvInterveciones);
            resources.ApplyResources(this.tpgSeleccionIntervencion, "tpgSeleccionIntervencion");
            this.tpgSeleccionIntervencion.Name = "tpgSeleccionIntervencion";
            this.tpgSeleccionIntervencion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvInterveciones
            // 
            this.dgvInterveciones.AllowUserToAddRows = false;
            this.dgvInterveciones.AllowUserToDeleteRows = false;
            this.dgvInterveciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterveciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvcUbicacion,
            this.gvcResumen,
            this.gvcNroIntervencion,
            this.gvcFechaCreacion});
            resources.ApplyResources(this.dgvInterveciones, "dgvInterveciones");
            this.dgvInterveciones.Name = "dgvInterveciones";
            this.dgvInterveciones.ReadOnly = true;
            // 
            // gvcUbicacion
            // 
            this.gvcUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.gvcUbicacion, "gvcUbicacion");
            this.gvcUbicacion.Name = "gvcUbicacion";
            this.gvcUbicacion.ReadOnly = true;
            this.gvcUbicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gvcResumen
            // 
            this.gvcResumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.gvcResumen, "gvcResumen");
            this.gvcResumen.Name = "gvcResumen";
            this.gvcResumen.ReadOnly = true;
            this.gvcResumen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gvcNroIntervencion
            // 
            resources.ApplyResources(this.gvcNroIntervencion, "gvcNroIntervencion");
            this.gvcNroIntervencion.Name = "gvcNroIntervencion";
            this.gvcNroIntervencion.ReadOnly = true;
            this.gvcNroIntervencion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gvcFechaCreacion
            // 
            resources.ApplyResources(this.gvcFechaCreacion, "gvcFechaCreacion");
            this.gvcFechaCreacion.Name = "gvcFechaCreacion";
            this.gvcFechaCreacion.ReadOnly = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnAnterior, "btnAnterior");
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // PantallaFinalizarIntervencion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.tbcDatos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMapa);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PantallaFinalizarIntervencion";
            this.Load += new System.EventHandler(this.PantallaFinalizarIntervencion_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.tbcDatos.ResumeLayout(false);
            this.tpgSeleccionIntervencion.ResumeLayout(false);
            this.tpgSeleccionIntervencion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterveciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblBravo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.LinkLabel lblContacto;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.Label lblMapa;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TabControl tbcDatos;
        private System.Windows.Forms.TabPage tpgSeleccionIntervencion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInterveciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcNroIntervencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvcFechaCreacion;
    }
}

