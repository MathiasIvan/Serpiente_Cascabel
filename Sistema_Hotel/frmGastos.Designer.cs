namespace Sistema_Hotel
{
    partial class frmGastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstGastos = new System.Windows.Forms.ListBox();
            this.txtCostoTotalGasto = new System.Windows.Forms.TextBox();
            this.txtCantidadGasto = new System.Windows.Forms.TextBox();
            this.dtpFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.txtCodGasto = new System.Windows.Forms.TextBox();
            this.cboServicioGasto = new System.Windows.Forms.ComboBox();
            this.cboReservaGasto = new System.Windows.Forms.ComboBox();
            this.lblCostoTotalGasto = new System.Windows.Forms.Label();
            this.lblCantidadServicio = new System.Windows.Forms.Label();
            this.lblFechaGasto = new System.Windows.Forms.Label();
            this.lblServicioGasto = new System.Windows.Forms.Label();
            this.lblCodRerservaGasto = new System.Windows.Forms.Label();
            this.lblCodGasto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(173, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(92, 295);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 295);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(236, 23);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(336, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(416, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "&Limpiar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(255, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lstGastos
            // 
            this.lstGastos.FormattingEnabled = true;
            this.lstGastos.Location = new System.Drawing.Point(12, 12);
            this.lstGastos.Name = "lstGastos";
            this.lstGastos.Size = new System.Drawing.Size(236, 264);
            this.lstGastos.TabIndex = 31;
            this.lstGastos.TabStop = false;
            // 
            // txtCostoTotalGasto
            // 
            this.txtCostoTotalGasto.Location = new System.Drawing.Point(350, 202);
            this.txtCostoTotalGasto.Name = "txtCostoTotalGasto";
            this.txtCostoTotalGasto.Size = new System.Drawing.Size(141, 20);
            this.txtCostoTotalGasto.TabIndex = 24;
            // 
            // txtCantidadGasto
            // 
            this.txtCantidadGasto.Location = new System.Drawing.Point(338, 164);
            this.txtCantidadGasto.Name = "txtCantidadGasto";
            this.txtCantidadGasto.Size = new System.Drawing.Size(153, 20);
            this.txtCantidadGasto.TabIndex = 22;
            // 
            // dtpFechaGasto
            // 
            this.dtpFechaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGasto.Location = new System.Drawing.Point(375, 127);
            this.dtpFechaGasto.Name = "dtpFechaGasto";
            this.dtpFechaGasto.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaGasto.TabIndex = 20;
            // 
            // txtCodGasto
            // 
            this.txtCodGasto.Location = new System.Drawing.Point(349, 12);
            this.txtCodGasto.Name = "txtCodGasto";
            this.txtCodGasto.Size = new System.Drawing.Size(142, 20);
            this.txtCodGasto.TabIndex = 14;
            // 
            // cboServicioGasto
            // 
            this.cboServicioGasto.FormattingEnabled = true;
            this.cboServicioGasto.Location = new System.Drawing.Point(334, 88);
            this.cboServicioGasto.Name = "cboServicioGasto";
            this.cboServicioGasto.Size = new System.Drawing.Size(157, 21);
            this.cboServicioGasto.TabIndex = 18;
            // 
            // cboReservaGasto
            // 
            this.cboReservaGasto.FormattingEnabled = true;
            this.cboReservaGasto.Location = new System.Drawing.Point(336, 50);
            this.cboReservaGasto.Name = "cboReservaGasto";
            this.cboReservaGasto.Size = new System.Drawing.Size(155, 21);
            this.cboReservaGasto.TabIndex = 15;
            // 
            // lblCostoTotalGasto
            // 
            this.lblCostoTotalGasto.AutoSize = true;
            this.lblCostoTotalGasto.Location = new System.Drawing.Point(280, 205);
            this.lblCostoTotalGasto.Name = "lblCostoTotalGasto";
            this.lblCostoTotalGasto.Size = new System.Drawing.Size(64, 13);
            this.lblCostoTotalGasto.TabIndex = 23;
            this.lblCostoTotalGasto.Text = "Costo Total:";
            // 
            // lblCantidadServicio
            // 
            this.lblCantidadServicio.AutoSize = true;
            this.lblCantidadServicio.Location = new System.Drawing.Point(280, 167);
            this.lblCantidadServicio.Name = "lblCantidadServicio";
            this.lblCantidadServicio.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadServicio.TabIndex = 21;
            this.lblCantidadServicio.Text = "Cantidad:";
            // 
            // lblFechaGasto
            // 
            this.lblFechaGasto.AutoSize = true;
            this.lblFechaGasto.Location = new System.Drawing.Point(280, 129);
            this.lblFechaGasto.Name = "lblFechaGasto";
            this.lblFechaGasto.Size = new System.Drawing.Size(89, 13);
            this.lblFechaGasto.TabIndex = 19;
            this.lblFechaGasto.Text = "Fecha / Servicio:";
            // 
            // lblServicioGasto
            // 
            this.lblServicioGasto.AutoSize = true;
            this.lblServicioGasto.Location = new System.Drawing.Point(280, 91);
            this.lblServicioGasto.Name = "lblServicioGasto";
            this.lblServicioGasto.Size = new System.Drawing.Size(48, 13);
            this.lblServicioGasto.TabIndex = 17;
            this.lblServicioGasto.Text = "Servicio:";
            // 
            // lblCodRerservaGasto
            // 
            this.lblCodRerservaGasto.AutoSize = true;
            this.lblCodRerservaGasto.Location = new System.Drawing.Point(280, 53);
            this.lblCodRerservaGasto.Name = "lblCodRerservaGasto";
            this.lblCodRerservaGasto.Size = new System.Drawing.Size(50, 13);
            this.lblCodRerservaGasto.TabIndex = 16;
            this.lblCodRerservaGasto.Text = "Reserva:";
            // 
            // lblCodGasto
            // 
            this.lblCodGasto.AutoSize = true;
            this.lblCodGasto.Location = new System.Drawing.Point(280, 15);
            this.lblCodGasto.Name = "lblCodGasto";
            this.lblCodGasto.Size = new System.Drawing.Size(63, 13);
            this.lblCodGasto.TabIndex = 13;
            this.lblCodGasto.Text = "Cod. Gasto:";
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 400);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstGastos);
            this.Controls.Add(this.txtCostoTotalGasto);
            this.Controls.Add(this.txtCantidadGasto);
            this.Controls.Add(this.dtpFechaGasto);
            this.Controls.Add(this.txtCodGasto);
            this.Controls.Add(this.cboServicioGasto);
            this.Controls.Add(this.cboReservaGasto);
            this.Controls.Add(this.lblCostoTotalGasto);
            this.Controls.Add(this.lblCantidadServicio);
            this.Controls.Add(this.lblFechaGasto);
            this.Controls.Add(this.lblServicioGasto);
            this.Controls.Add(this.lblCodRerservaGasto);
            this.Controls.Add(this.lblCodGasto);
            this.Name = "frmGastos";
            this.Text = "Nonima de Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstGastos;
        private System.Windows.Forms.TextBox txtCostoTotalGasto;
        private System.Windows.Forms.TextBox txtCantidadGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaGasto;
        private System.Windows.Forms.TextBox txtCodGasto;
        private System.Windows.Forms.ComboBox cboServicioGasto;
        private System.Windows.Forms.ComboBox cboReservaGasto;
        private System.Windows.Forms.Label lblCostoTotalGasto;
        private System.Windows.Forms.Label lblCantidadServicio;
        private System.Windows.Forms.Label lblFechaGasto;
        private System.Windows.Forms.Label lblServicioGasto;
        private System.Windows.Forms.Label lblCodRerservaGasto;
        private System.Windows.Forms.Label lblCodGasto;
    }
}