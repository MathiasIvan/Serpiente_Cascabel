using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Hotel
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.Show();
        }



        private void registradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrador frmregistrador = new frmRegistrador();
            frmregistrador.Show();
        }



        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion frmhabitacion = new frmHabitacion();
            frmhabitacion.Show();
        }



        private void tipoHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoHabitacion frmtipohabitacion = new frmTipoHabitacion();
            frmtipohabitacion.Show();
        }

        

        private void estadoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoHabitacion frmestadohabitacion = new frmEstadoHabitacion();
            frmestadohabitacion.Show();
        }



        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGastos frmgastos = new frmGastos();
            frmgastos.Show();
        }



        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva frmreserva = new frmReserva();
            frmreserva.Show();
        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
