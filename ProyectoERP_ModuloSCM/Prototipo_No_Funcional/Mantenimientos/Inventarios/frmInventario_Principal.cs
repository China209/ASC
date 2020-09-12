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
    public partial class frmInventario_Principal : Form
    {
        public frmInventario_Principal()
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
    }
}
