namespace Prototipo_No_Funcional.Mantenimientos.Inventarios
{
    partial class frmIntentario_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntentario_Principal));
            this.dgvDatosCompras = new System.Windows.Forms.DataGridView();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescInventario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LineaInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamañoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNavegador = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCompras)).BeginInit();
            this.pnlNavegador.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosCompras
            // 
            this.dgvDatosCompras.AllowUserToAddRows = false;
            this.dgvDatosCompras.AllowUserToDeleteRows = false;
            this.dgvDatosCompras.AllowUserToOrderColumns = true;
            this.dgvDatosCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tamaño,
            this.DescInventario,
            this.LineaInventario,
            this.ExistenciaInventario,
            this.TipoInv,
            this.TamañoInv,
            this.Color});
            this.dgvDatosCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosCompras.Location = new System.Drawing.Point(0, 104);
            this.dgvDatosCompras.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dgvDatosCompras.Name = "dgvDatosCompras";
            this.dgvDatosCompras.ReadOnly = true;
            this.dgvDatosCompras.RowHeadersWidth = 51;
            this.dgvDatosCompras.RowTemplate.Height = 24;
            this.dgvDatosCompras.Size = new System.Drawing.Size(932, 399);
            this.dgvDatosCompras.TabIndex = 5;
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.MinimumWidth = 6;
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.ReadOnly = true;
            this.Tamaño.Width = 125;
            // 
            // DescInventario
            // 
            this.DescInventario.HeaderText = "Descripcion";
            this.DescInventario.MinimumWidth = 6;
            this.DescInventario.Name = "DescInventario";
            this.DescInventario.ReadOnly = true;
            this.DescInventario.Width = 125;
            // 
            // LineaInventario
            // 
            this.LineaInventario.HeaderText = "Linea";
            this.LineaInventario.MinimumWidth = 6;
            this.LineaInventario.Name = "LineaInventario";
            this.LineaInventario.ReadOnly = true;
            this.LineaInventario.Width = 125;
            // 
            // ExistenciaInventario
            // 
            this.ExistenciaInventario.HeaderText = "Existencias";
            this.ExistenciaInventario.MinimumWidth = 6;
            this.ExistenciaInventario.Name = "ExistenciaInventario";
            this.ExistenciaInventario.ReadOnly = true;
            this.ExistenciaInventario.Width = 125;
            // 
            // TipoInv
            // 
            this.TipoInv.HeaderText = "Tipo";
            this.TipoInv.MinimumWidth = 6;
            this.TipoInv.Name = "TipoInv";
            this.TipoInv.ReadOnly = true;
            this.TipoInv.Width = 125;
            // 
            // TamañoInv
            // 
            this.TamañoInv.HeaderText = "Tamaño";
            this.TamañoInv.MinimumWidth = 6;
            this.TamañoInv.Name = "TamañoInv";
            this.TamañoInv.ReadOnly = true;
            this.TamañoInv.Width = 125;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
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
            this.pnlNavegador.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.Size = new System.Drawing.Size(932, 104);
            this.pnlNavegador.TabIndex = 4;
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(606, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(101, 104);
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
            this.btnAyuda.Location = new System.Drawing.Point(505, 0);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(101, 104);
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
            this.btnImprimir.Location = new System.Drawing.Point(404, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(101, 104);
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
            this.btnBuscar.Location = new System.Drawing.Point(303, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 104);
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
            this.btnEliminar.Location = new System.Drawing.Point(202, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 104);
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
            this.btnActualizar.Location = new System.Drawing.Point(101, 0);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 104);
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
            this.bntAgregar.Size = new System.Drawing.Size(101, 104);
            this.bntAgregar.TabIndex = 0;
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
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
            this.pnlInferior.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(259, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(424, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // frmIntentario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.dgvDatosCompras);
            this.Controls.Add(this.pnlNavegador);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIntentario_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIntentario_Principal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCompras)).EndInit();
            this.pnlNavegador.ResumeLayout(false);
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewComboBoxColumn DescInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamañoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.Panel pnlNavegador;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHoraFecha;
    }
}