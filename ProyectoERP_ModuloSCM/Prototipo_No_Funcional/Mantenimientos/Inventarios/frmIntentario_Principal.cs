using Prototipo_No_Funcional.MDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_No_Funcional.Mantenimientos.Inventarios
{
    public partial class frmIntentario_Principal : Form
    {
        public frmIntentario_Principal()
        {
            InitializeComponent();
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmAuxiliar aux = new frmAuxiliar();
            aux.Show();
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmIntentario_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
