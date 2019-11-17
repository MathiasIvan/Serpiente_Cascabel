namespace Sistema_Hotel
{
    partial class frmTipoHabitacion
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
            this.lstTipoHabitacion = new System.Windows.Forms.ListBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionTipoHabitacion = new System.Windows.Forms.TextBox();
            this.txtCodTipoHabitacion = new System.Windows.Forms.TextBox();
            this.lblCodTipoHabitacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(93, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(291, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(237, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(372, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(453, 169);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(291, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstTipoHabitacion
            // 
            this.lstTipoHabitacion.FormattingEnabled = true;
            this.lstTipoHabitacion.Location = new System.Drawing.Point(12, 12);
            this.lstTipoHabitacion.Name = "lstTipoHabitacion";
            this.lstTipoHabitacion.Size = new System.Drawing.Size(237, 186);
            this.lstTipoHabitacion.TabIndex = 16;
            this.lstTipoHabitacion.TabStop = false;
            this.lstTipoHabitacion.Click += new System.EventHandler(this.lstTipoHabitacion_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(271, 53);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcionTipoHabitacion
            // 
            this.txtDescripcionTipoHabitacion.Location = new System.Drawing.Point(343, 50);
            this.txtDescripcionTipoHabitacion.Name = "txtDescripcionTipoHabitacion";
            this.txtDescripcionTipoHabitacion.Size = new System.Drawing.Size(185, 20);
            this.txtDescripcionTipoHabitacion.TabIndex = 11;
            // 
            // txtCodTipoHabitacion
            // 
            this.txtCodTipoHabitacion.Location = new System.Drawing.Point(386, 12);
            this.txtCodTipoHabitacion.Name = "txtCodTipoHabitacion";
            this.txtCodTipoHabitacion.Size = new System.Drawing.Size(142, 20);
            this.txtCodTipoHabitacion.TabIndex = 9;
            // 
            // lblCodTipoHabitacion
            // 
            this.lblCodTipoHabitacion.AutoSize = true;
            this.lblCodTipoHabitacion.Location = new System.Drawing.Point(271, 15);
            this.lblCodTipoHabitacion.Name = "lblCodTipoHabitacion";
            this.lblCodTipoHabitacion.Size = new System.Drawing.Size(110, 13);
            this.lblCodTipoHabitacion.TabIndex = 10;
            this.lblCodTipoHabitacion.Text = "Cod. Tipo Habitacion:";
            // 
            // frmTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 362);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstTipoHabitacion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcionTipoHabitacion);
            this.Controls.Add(this.txtCodTipoHabitacion);
            this.Controls.Add(this.lblCodTipoHabitacion);
            this.Name = "frmTipoHabitacion";
            this.Text = "Mantenimiento Tipo / Habitación";
            this.Load += new System.EventHandler(this.frmTipoHabitacion_Load);
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
        private System.Windows.Forms.ListBox lstTipoHabitacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcionTipoHabitacion;
        private System.Windows.Forms.TextBox txtCodTipoHabitacion;
        private System.Windows.Forms.Label lblCodTipoHabitacion;
    }
}