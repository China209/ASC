using Prototipo_No_Funcional.Mantenimientos.Compras;
using Prototipo_No_Funcional.Mantenimientos.Inventarios;
using Prototipo_No_Funcional.Mantenimientos.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_No_Funcional.MDI
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntentario_Principal inventario = new frmIntentario_Principal();
            inventario.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras_Principal compras = new frmCompras_Principal();
            compras.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor_Principal proveedor = new frmProveedor_Principal();
            proveedor.Show();
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
