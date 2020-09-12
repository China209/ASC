namespace Prototipo_No_Funcional.Mantenimientos.Compras
{
    partial class frmCompras_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras_Principal));
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlNavegador = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.dgvDatosCompras = new System.Windows.Forms.DataGridView();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.CodCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NomProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecDocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecCancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnRecepcion = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlNavegador.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.pnlMenuLateral.Controls.Add(this.btnDevoluciones);
            this.pnlMenuLateral.Controls.Add(this.btnOrdenCompra);
            this.pnlMenuLateral.Controls.Add(this.btnRecepcion);
            this.pnlMenuLateral.Controls.Add(this.btnCompras);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(89, 653);
            this.pnlMenuLateral.TabIndex = 0;
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
            this.pnlNavegador.Location = new System.Drawing.Point(89, 0);
            this.pnlNavegador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.Size = new System.Drawing.Size(893, 83);
            this.pnlNavegador.TabIndex = 1;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(89, 608);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(893, 45);
            this.pnlInferior.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.dgvDatosCompras);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(89, 83);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(893, 525);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // dgvDatosCompras
            // 
            this.dgvDatosCompras.AllowUserToAddRows = false;
            this.dgvDatosCompras.AllowUserToDeleteRows = false;
            this.dgvDatosCompras.AllowUserToOrderColumns = true;
            this.dgvDatosCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCompra,
            this.Proveedor,
            this.NomProveedor,
            this.EstatusProv,
            this.FecDocu,
            this.FecRecepcion,
            this.FecCancelacion,
            this.Bodega,
            this.NoPagos,
            this.Subtotal,
            this.Total,
            this.FormaEnvio});
            this.dgvDatosCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvDatosCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatosCompras.Name = "dgvDatosCompras";
            this.dgvDatosCompras.ReadOnly = true;
            this.dgvDatosCompras.RowHeadersWidth = 51;
            this.dgvDatosCompras.RowTemplate.Height = 24;
            this.dgvDatosCompras.Size = new System.Drawing.Size(893, 525);
            this.dgvDatosCompras.TabIndex = 0;
            // 
            // bntAgregar
            // 
            this.bntAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // CodCompra
            // 
            this.CodCompra.HeaderText = "Código";
            this.CodCompra.MinimumWidth = 6;
            this.CodCompra.Name = "CodCompra";
            this.CodCompra.ReadOnly = true;
            this.CodCompra.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 125;
            // 
            // NomProveedor
            // 
            this.NomProveedor.HeaderText = "Nombre";
            this.NomProveedor.MinimumWidth = 6;
            this.NomProveedor.Name = "NomProveedor";
            this.NomProveedor.ReadOnly = true;
            this.NomProveedor.Width = 125;
            // 
            // EstatusProv
            // 
            this.EstatusProv.HeaderText = "Estatus";
            this.EstatusProv.MinimumWidth = 6;
            this.EstatusProv.Name = "EstatusProv";
            this.EstatusProv.ReadOnly = true;
            this.EstatusProv.Width = 125;
            // 
            // FecDocu
            // 
            this.FecDocu.HeaderText = "Fecha de documento";
            this.FecDocu.MinimumWidth = 6;
            this.FecDocu.Name = "FecDocu";
            this.FecDocu.ReadOnly = true;
            this.FecDocu.Width = 125;
            // 
            // FecRecepcion
            // 
            this.FecRecepcion.HeaderText = "Fecha de Recepción";
            this.FecRecepcion.MinimumWidth = 6;
            this.FecRecepcion.Name = "FecRecepcion";
            this.FecRecepcion.ReadOnly = true;
            this.FecRecepcion.Width = 125;
            // 
            // FecCancelacion
            // 
            this.FecCancelacion.HeaderText = "Fecha de cancelación";
            this.FecCancelacion.MinimumWidth = 6;
            this.FecCancelacion.Name = "FecCancelacion";
            this.FecCancelacion.ReadOnly = true;
            this.FecCancelacion.Width = 125;
            // 
            // Bodega
            // 
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.MinimumWidth = 6;
            this.Bodega.Name = "Bodega";
            this.Bodega.ReadOnly = true;
            this.Bodega.Width = 125;
            // 
            // NoPagos
            // 
            this.NoPagos.HeaderText = "Número de Pagos";
            this.NoPagos.MinimumWidth = 6;
            this.NoPagos.Name = "NoPagos";
            this.NoPagos.ReadOnly = true;
            this.NoPagos.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total de Documento";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // FormaEnvio
            // 
            this.FormaEnvio.HeaderText = "Forma de Envío del Documento";
            this.FormaEnvio.MinimumWidth = 6;
            this.FormaEnvio.Name = "FormaEnvio";
            this.FormaEnvio.ReadOnly = true;
            this.FormaEnvio.Width = 125;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.Location = new System.Drawing.Point(0, 83);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(89, 72);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.FlatAppearance.BorderSize = 0;
            this.btnRecepcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnRecepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcion.Image = ((System.Drawing.Image)(resources.GetObject("btnRecepcion.Image")));
            this.btnRecepcion.Location = new System.Drawing.Point(0, 148);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Size = new System.Drawing.Size(89, 72);
            this.btnRecepcion.TabIndex = 2;
            this.btnRecepcion.UseVisualStyleBackColor = true;
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnOrdenCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnOrdenCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenCompra.Image")));
            this.btnOrdenCompra.Location = new System.Drawing.Point(0, 217);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(89, 72);
            this.btnOrdenCompra.TabIndex = 3;
            this.btnOrdenCompra.UseVisualStyleBackColor = true;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(116)))), ((int)(((byte)(106)))));
            this.btnDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Image = ((System.Drawing.Image)(resources.GetObject("btnDevoluciones.Image")));
            this.btnDevoluciones.Location = new System.Drawing.Point(0, 290);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(89, 72);
            this.btnDevoluciones.TabIndex = 4;
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // frmCompras_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlNavegador);
            this.Controls.Add(this.pnlMenuLateral);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCompras_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlNavegador.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlNavegador;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.DataGridView dgvDatosCompras;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCompra;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstatusProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecDocu;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecCancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaEnvio;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Button btnRecepcion;
    }
}