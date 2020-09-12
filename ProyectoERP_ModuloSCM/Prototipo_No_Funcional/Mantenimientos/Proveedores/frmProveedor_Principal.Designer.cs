namespace Prototipo_No_Funcional.Mantenimientos.Proveedores
{
    partial class frmProveedor_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor_Principal));
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlNavegador = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.dgvDatosCompras = new System.Windows.Forms.DataGridView();
            this.CodProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusProveedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NomProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalleProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasiProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCompras)).BeginInit();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(0, 503);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // pnlNavegador
            // 
            this.pnlNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.pnlNavegador.Controls.Add(this.btnCerrarSesion);
            this.pnlNavegador.Controls.Add(this.btnAyuda);
            this.pnlNavegador.Controls.Add(this.btnImprimir);
            this.pnlNavegador.Controls.Add(this.btnBuscar);
            this.pnlNavegador.Controls.Add(this.btnEliminar);
            this.pnlNavegador.Controls.Add(this.btnActualizar);
            this.pnlNavegador.Controls.Add(this.bntAgregar);
            this.pnlNavegador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavegador.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegador.Margin = new System.Windows.Forms.Padding(5);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.Size = new System.Drawing.Size(932, 83);
            this.pnlNavegador.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(486, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(81, 83);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(405, 0);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(81, 83);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(324, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(81, 83);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(243, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 83);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(162, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 83);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(81, 0);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 83);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // bntAgregar
            // 
            this.bntAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntAgregar.FlatAppearance.BorderSize = 0;
            this.bntAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.bntAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.bntAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAgregar.Image = ((System.Drawing.Image)(resources.GetObject("bntAgregar.Image")));
            this.bntAgregar.Location = new System.Drawing.Point(0, 0);
            this.bntAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(81, 83);
            this.bntAgregar.TabIndex = 0;
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
            // 
            // dgvDatosCompras
            // 
            this.dgvDatosCompras.AllowUserToAddRows = false;
            this.dgvDatosCompras.AllowUserToDeleteRows = false;
            this.dgvDatosCompras.AllowUserToOrderColumns = true;
            this.dgvDatosCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProveedor,
            this.EstatusProveedor,
            this.NomProveedor,
            this.CalleProveedor,
            this.TelProveedor,
            this.ClasiProveedor,
            this.SaldoProveedor});
            this.dgvDatosCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosCompras.Location = new System.Drawing.Point(0, 83);
            this.dgvDatosCompras.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDatosCompras.Name = "dgvDatosCompras";
            this.dgvDatosCompras.ReadOnly = true;
            this.dgvDatosCompras.RowHeadersWidth = 51;
            this.dgvDatosCompras.RowTemplate.Height = 24;
            this.dgvDatosCompras.Size = new System.Drawing.Size(932, 420);
            this.dgvDatosCompras.TabIndex = 3;
            // 
            // CodProveedor
            // 
            this.CodProveedor.HeaderText = "Código";
            this.CodProveedor.MinimumWidth = 6;
            this.CodProveedor.Name = "CodProveedor";
            this.CodProveedor.ReadOnly = true;
            this.CodProveedor.Width = 125;
            // 
            // EstatusProveedor
            // 
            this.EstatusProveedor.HeaderText = "Estatus";
            this.EstatusProveedor.MinimumWidth = 6;
            this.EstatusProveedor.Name = "EstatusProveedor";
            this.EstatusProveedor.ReadOnly = true;
            this.EstatusProveedor.Width = 125;
            // 
            // NomProveedor
            // 
            this.NomProveedor.HeaderText = "Nombre";
            this.NomProveedor.MinimumWidth = 6;
            this.NomProveedor.Name = "NomProveedor";
            this.NomProveedor.ReadOnly = true;
            this.NomProveedor.Width = 125;
            // 
            // CalleProveedor
            // 
            this.CalleProveedor.HeaderText = "Calle";
            this.CalleProveedor.MinimumWidth = 6;
            this.CalleProveedor.Name = "CalleProveedor";
            this.CalleProveedor.ReadOnly = true;
            this.CalleProveedor.Width = 125;
            // 
            // TelProveedor
            // 
            this.TelProveedor.HeaderText = "Telefono";
            this.TelProveedor.MinimumWidth = 6;
            this.TelProveedor.Name = "TelProveedor";
            this.TelProveedor.ReadOnly = true;
            this.TelProveedor.Width = 125;
            // 
            // ClasiProveedor
            // 
            this.ClasiProveedor.HeaderText = "Clasificacion";
            this.ClasiProveedor.MinimumWidth = 6;
            this.ClasiProveedor.Name = "ClasiProveedor";
            this.ClasiProveedor.ReadOnly = true;
            this.ClasiProveedor.Width = 125;
            // 
            // SaldoProveedor
            // 
            this.SaldoProveedor.HeaderText = "Saldo";
            this.SaldoProveedor.MinimumWidth = 6;
            this.SaldoProveedor.Name = "SaldoProveedor";
            this.SaldoProveedor.ReadOnly = true;
            this.SaldoProveedor.Width = 125;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 458);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(932, 45);
            this.pnlInferior.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(274, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(439, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // frmProveedor_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.dgvDatosCompras);
            this.Controls.Add(this.pnlNavegador);
            this.Controls.Add(this.pnlMenuLateral);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProveedor_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProveedor_Principal_FormClosing);
            this.Load += new System.EventHandler(this.frmProveedor_Principal_Load);
            this.pnlNavegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCompras)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlNavegador;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.DataGridView dgvDatosCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProveedor;
        private System.Windows.Forms.DataGridViewComboBoxColumn EstatusProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalleProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasiProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoProveedor;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHoraFecha;
    }
}