using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Hotel;

namespace Sistema_Hotel
{
    public partial class frmEstadoHabitacion : Form
    {
        string alternativa;
        public frmEstadoHabitacion()
        {
            InitializeComponent();
        }


        private void frmEstadoHabitacion_Load(object sender, EventArgs e)
        {
            ActualizarListaEstadoHabitacion();
            BloquearFormulario();
        }


        private void lstEstadoHabitacion_Click(object sender, EventArgs e)
        {
            Estado_Habitacion et = (Estado_Habitacion)lstEstadoHabitacion.SelectedItem;

            if (et != null)
            {
                txtCodEstadoHabitacion.Text = et.ID_EstadoHabitacion.ToString();
                txtDescripcionEstadoHabitacion.Text = et.Descripcion;
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var et = ObtenerDatosFormulario();

            if (alternativa == "Agregar")
            {
                Estado_Habitacion.AgregarEstadoHabitacion(et);
            }
            else if (alternativa == "Actualizar")
            {

                if (this.lstEstadoHabitacion.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una Fila para Actualizar. ");
                }

                else
                {
                    int indice = lstEstadoHabitacion.SelectedIndex;
                    Estado_Habitacion.AcualizarEstadoHabitacion(et, indice);
                    ActualizarListaEstadoHabitacion();
                }

            }

            LimpiarFormulario();
            ActualizarListaEstadoHabitacion();
            BloquearFormulario();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormularios();
            txtCodEstadoHabitacion.Focus();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstEstadoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Actualizar. ");
            }
            else
            {
                alternativa = "Actualizar";
                DesbloquearFormularios();
                txtCodEstadoHabitacion.Focus();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEstadoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Eliminar. ");
            }
            else
            {
                Estado_Habitacion et = (Estado_Habitacion)lstEstadoHabitacion.SelectedItem;
                Estado_Habitacion.EliminarEstadoHabitacion(et);
                ActualizarListaEstadoHabitacion();
                LimpiarFormulario();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private Estado_Habitacion ObtenerDatosFormulario()
        {
            Estado_Habitacion estadoHabitacion = new Estado_Habitacion();
            estadoHabitacion.ID_EstadoHabitacion = txtCodEstadoHabitacion.Text;
            estadoHabitacion.Descripcion = txtDescripcionEstadoHabitacion.Text;

            return estadoHabitacion;
        }


        private void LimpiarFormulario()
        {
            txtCodEstadoHabitacion.Text = "";
            txtDescripcionEstadoHabitacion.Text = "";
        }


        private void ActualizarListaEstadoHabitacion()
        {
            lstEstadoHabitacion.DataSource = null;
            lstEstadoHabitacion.DataSource = Estado_Habitacion.ObtenerEstadoHabitacion();
        }


        private void BloquearFormulario()
        {
            txtCodEstadoHabitacion.Enabled = false;
            txtDescripcionEstadoHabitacion.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstEstadoHabitacion.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
        }


        private void DesbloquearFormularios()
        {
            txtCodEstadoHabitacion.Enabled = true;
            txtDescripcionEstadoHabitacion.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstEstadoHabitacion.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

    }
}
