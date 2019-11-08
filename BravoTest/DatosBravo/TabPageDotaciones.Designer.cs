namespace DatosBravo
{
    partial class TabPageDotaciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.edtKmFinal = new System.Windows.Forms.TextBox();
            this.edtKmSalida = new System.Windows.Forms.TextBox();
            this.lblKmFinal = new System.Windows.Forms.Label();
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.edtHoraLlegada = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraLlegada = new System.Windows.Forms.Label();
            this.edtHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.edtFechaLlegada = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.edtDominio = new System.Windows.Forms.TextBox();
            this.edtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edtKmFinal
            // 
            this.edtKmFinal.AccessibleName = "edtKmLlegada";
            this.edtKmFinal.Location = new System.Drawing.Point(469, 301);
            this.edtKmFinal.Name = "edtKmFinal";
            this.edtKmFinal.Size = new System.Drawing.Size(413, 24);
            this.edtKmFinal.TabIndex = 24;
            this.edtKmFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtKmFinal_KeyPress);
            // 
            // edtKmSalida
            // 
            this.edtKmSalida.AccessibleName = "";
            this.edtKmSalida.Enabled = false;
            this.edtKmSalida.Location = new System.Drawing.Point(20, 301);
            this.edtKmSalida.Name = "edtKmSalida";
            this.edtKmSalida.Size = new System.Drawing.Size(413, 24);
            this.edtKmSalida.TabIndex = 25;
            // 
            // lblKmFinal
            // 
            this.lblKmFinal.AccessibleName = "lblKmFinal";
            this.lblKmFinal.AutoSize = true;
            this.lblKmFinal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKmFinal.Location = new System.Drawing.Point(465, 282);
            this.lblKmFinal.Name = "lblKmFinal";
            this.lblKmFinal.Size = new System.Drawing.Size(121, 19);
            this.lblKmFinal.TabIndex = 22;
            this.lblKmFinal.Text = "Kilometraje Final";
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AccessibleName = "lblKmInicial";
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKmInicial.Location = new System.Drawing.Point(16, 282);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(129, 19);
            this.lblKmInicial.TabIndex = 23;
            this.lblKmInicial.Text = "Kilometraje inicial";
            this.lblKmInicial.Click += new System.EventHandler(this.lblKmInicial_Click);
            // 
            // edtHoraLlegada
            // 
            this.edtHoraLlegada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtHoraLlegada.Location = new System.Drawing.Point(469, 209);
            this.edtHoraLlegada.Mask = "00:00";
            this.edtHoraLlegada.Name = "edtHoraLlegada";
            this.edtHoraLlegada.Size = new System.Drawing.Size(413, 24);
            this.edtHoraLlegada.TabIndex = 21;
            this.edtHoraLlegada.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoraLlegada
            // 
            this.lblHoraLlegada.AccessibleName = "lblHoraLlegada";
            this.lblHoraLlegada.AutoSize = true;
            this.lblHoraLlegada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoraLlegada.Location = new System.Drawing.Point(465, 187);
            this.lblHoraLlegada.Name = "lblHoraLlegada";
            this.lblHoraLlegada.Size = new System.Drawing.Size(126, 19);
            this.lblHoraLlegada.TabIndex = 20;
            this.lblHoraLlegada.Text = "Hora de Llegada";
            // 
            // edtHoraSalida
            // 
            this.edtHoraSalida.Enabled = false;
            this.edtHoraSalida.Location = new System.Drawing.Point(20, 209);
            this.edtHoraSalida.Mask = "00:00";
            this.edtHoraSalida.Name = "edtHoraSalida";
            this.edtHoraSalida.Size = new System.Drawing.Size(413, 24);
            this.edtHoraSalida.TabIndex = 19;
            this.edtHoraSalida.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AccessibleName = "lblHoraSalida";
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoraSalida.Location = new System.Drawing.Point(16, 187);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(112, 19);
            this.lblHoraSalida.TabIndex = 18;
            this.lblHoraSalida.Text = "Hora de Salida";
            this.lblHoraSalida.Click += new System.EventHandler(this.lblHoraSalida_Click);
            // 
            // edtFechaLlegada
            // 
            this.edtFechaLlegada.Location = new System.Drawing.Point(469, 123);
            this.edtFechaLlegada.Mask = "00/00/0000";
            this.edtFechaLlegada.Name = "edtFechaLlegada";
            this.edtFechaLlegada.Size = new System.Drawing.Size(413, 24);
            this.edtFechaLlegada.TabIndex = 17;
            this.edtFechaLlegada.ValidatingType = typeof(System.DateTime);
            this.edtFechaLlegada.Leave += new System.EventHandler(this.edtFechaLlegada_Leave);
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AccessibleName = "lblFechaLlegada";
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaLlegada.Location = new System.Drawing.Point(465, 101);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(137, 19);
            this.lblFechaLlegada.TabIndex = 16;
            this.lblFechaLlegada.Text = "Fecha de Llegada";
            // 
            // edtDominio
            // 
            this.edtDominio.AccessibleName = "edtDominio";
            this.edtDominio.Enabled = false;
            this.edtDominio.Location = new System.Drawing.Point(22, 46);
            this.edtDominio.Name = "edtDominio";
            this.edtDominio.Size = new System.Drawing.Size(860, 24);
            this.edtDominio.TabIndex = 15;
            // 
            // edtFechaSalida
            // 
            this.edtFechaSalida.Enabled = false;
            this.edtFechaSalida.Location = new System.Drawing.Point(20, 123);
            this.edtFechaSalida.Mask = "00/00/0000";
            this.edtFechaSalida.Name = "edtFechaSalida";
            this.edtFechaSalida.Size = new System.Drawing.Size(413, 24);
            this.edtFechaSalida.TabIndex = 14;
            this.edtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AccessibleName = "lblFechaSalida";
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaSalida.Location = new System.Drawing.Point(16, 101);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(123, 19);
            this.lblFechaSalida.TabIndex = 13;
            this.lblFechaSalida.Text = "Fecha de Salida";
            // 
            // lblDominio
            // 
            this.lblDominio.AccessibleName = "lblDominio";
            this.lblDominio.AutoSize = true;
            this.lblDominio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDominio.Location = new System.Drawing.Point(18, 24);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(143, 19);
            this.lblDominio.TabIndex = 12;
            this.lblDominio.Text = "Dominio de unidad";
            // 
            // TabPageDotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtKmFinal);
            this.Controls.Add(this.edtKmSalida);
            this.Controls.Add(this.lblKmFinal);
            this.Controls.Add(this.lblKmInicial);
            this.Controls.Add(this.edtHoraLlegada);
            this.Controls.Add(this.lblHoraLlegada);
            this.Controls.Add(this.edtHoraSalida);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.edtFechaLlegada);
            this.Controls.Add(this.lblFechaLlegada);
            this.Controls.Add(this.edtDominio);
            this.Controls.Add(this.edtFechaSalida);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblDominio);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabPageDotaciones";
            this.Size = new System.Drawing.Size(903, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtKmFinal;
        private System.Windows.Forms.TextBox edtKmSalida;
        private System.Windows.Forms.Label lblKmFinal;
        private System.Windows.Forms.Label lblKmInicial;
        private System.Windows.Forms.MaskedTextBox edtHoraLlegada;
        private System.Windows.Forms.Label lblHoraLlegada;
        private System.Windows.Forms.MaskedTextBox edtHoraSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.MaskedTextBox edtFechaLlegada;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.TextBox edtDominio;
        private System.Windows.Forms.MaskedTextBox edtFechaSalida;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblDominio;
    }
}
