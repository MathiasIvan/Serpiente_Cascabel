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
    public partial class frmTipoHabitacion : Form
    {
        string alternativa;
        public frmTipoHabitacion()
        {
            InitializeComponent();
        }


        private void frmTipoHabitacion_Load(object sender, EventArgs e)
        {
            ActualizarListaTipoHabitaciones();
            BloquearFormulario();
        }


        private void lstTipoHabitacion_Click(object sender, EventArgs e)
        {
            Tipo_Habitacion th = (Tipo_Habitacion)lstTipoHabitacion.SelectedItem;

            if (th != null)
            {
                txtCodTipoHabitacion.Text = th.ID_TipoHabitacion.ToString();
                txtDescripcionTipoHabitacion.Text = th.Descripcion;
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var th = ObtenerDatosFormulario();

            if (alternativa == "Agregar")
            {
                Tipo_Habitacion.AgregarTipoHabitacion(th);
            }
            else if (alternativa == "Actualizar")
            {

                if (this.lstTipoHabitacion.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para Actualizar.");
                }

                else
                {
                    int indice = lstTipoHabitacion.SelectedIndex;
                    Tipo_Habitacion.ActualizarTipoHabitacion(th, indice);
                    ActualizarListaTipoHabitaciones();
                }

            }

            LimpiarFormulario();
            ActualizarListaTipoHabitaciones();
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
            DesbloquearFormulario();
            txtCodTipoHabitacion.Focus();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstTipoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Actualizar.");
            }
            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodTipoHabitacion.Focus();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstTipoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Eliminar.");
            }
            else
            {
                Tipo_Habitacion th = (Tipo_Habitacion)lstTipoHabitacion.SelectedItem;
                Tipo_Habitacion.EliminarTipoHabitacion(th);
                ActualizarListaTipoHabitaciones();
                LimpiarFormulario();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private Tipo_Habitacion ObtenerDatosFormulario()
        {
            Tipo_Habitacion tipohabitacion = new Tipo_Habitacion();
            tipohabitacion.ID_TipoHabitacion = txtCodTipoHabitacion.Text;
            tipohabitacion.Descripcion = txtDescripcionTipoHabitacion.Text;

            return tipohabitacion;
        }


        private void LimpiarFormulario()
        {
            txtCodTipoHabitacion.Text = "";
            txtDescripcionTipoHabitacion.Text = "";

        }


        private void ActualizarListaTipoHabitaciones()
        {
            lstTipoHabitacion.DataSource = null;
            lstTipoHabitacion.DataSource = Tipo_Habitacion.ObtenerTipoHabitaciones();
        }


        private void BloquearFormulario()
        {
            txtCodTipoHabitacion.Enabled = false;
            txtDescripcionTipoHabitacion.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void DesbloquearFormulario()
        {
            txtCodTipoHabitacion.Enabled = true;
            txtDescripcionTipoHabitacion.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

    }
}
