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
    public partial class frmCliente : Form
    {
        string alternativa;
        public frmCliente()
        {
            InitializeComponent();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            BloquearFormulario();
            cboNacionalidadCliente.DataSource = Enum.GetValues(typeof(Nacionalidades));
        }


        private void lstCliente_Click(object sender, EventArgs e)
        {
            Cliente c = (Cliente)lstCliente.SelectedItem;

            if (c != null)
            {
                txtCodCliente.Text = c.ID_Cliente;
                txtNombreCliente.Text = c.Nombre;
                txtDireccionCliente.Text = c.Direccion;
                txtNroDocumentoCliente.Text = c.NroDocumento;
                txtTelefonoCliente.Text = c.Telefono;
                cboNacionalidadCliente.SelectedItem = c.Nacionalidad;
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var c = ObtenerDatosFormulario();

            if (alternativa == "Agregar")
            {
                Cliente.AgregarCliente(c);
            }
            else if (alternativa == "Actualizar")
            {

                if (this.lstCliente.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para Actualizar.");
                }

                else
                {
                    int indice = lstCliente.SelectedIndex;
                    Cliente.ActualizarCliente(c, indice);
                    ActualizarListaClientes();
                }

            }

            LimpiarFormulario();
            ActualizarListaClientes();
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
            txtCodCliente.Focus();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Actualizar");
            }
            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodCliente.Focus();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Eliminar.");
            }
            else
            {
                Cliente c = (Cliente)lstCliente.SelectedItem;
                Cliente.EliminarCliente(c);
                ActualizarListaClientes();
                LimpiarFormulario();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private Cliente ObtenerDatosFormulario()
        {
            Cliente cliente = new Cliente();
            cliente.ID_Cliente = txtCodCliente.Text;
            cliente.Nombre = txtNombreCliente.Text;
            cliente.Direccion = txtDireccionCliente.Text;
            cliente.NroDocumento = txtNroDocumentoCliente.Text;
            cliente.Telefono = txtTelefonoCliente.Text;
            cliente.Nacionalidad = (Nacionalidades)cboNacionalidadCliente.SelectedItem;

            return cliente;
        }


        private void LimpiarFormulario()
        {
            txtCodCliente.Text = "";
            txtNombreCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtNroDocumentoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            cboNacionalidadCliente.SelectedItem = null;
        }


        private void ActualizarListaClientes()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientes();
        }


        private void BloquearFormulario()
        {
            txtCodCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtDireccionCliente.Enabled = false;
            txtNroDocumentoCliente.Enabled = false;
            txtTelefonoCliente.Enabled = false;
            cboNacionalidadCliente.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstCliente.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void DesbloquearFormulario()
        {
            txtCodCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            txtDireccionCliente.Enabled = true;
            txtNroDocumentoCliente.Enabled = true;
            txtTelefonoCliente.Enabled = true;
            cboNacionalidadCliente.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstCliente.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

    }
}
