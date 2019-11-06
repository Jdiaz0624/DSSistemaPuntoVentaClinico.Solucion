namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    partial class TipoProductoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoProductoConsulta));
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsuarioConectado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.lbPerfilUsuarioConectado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.txtDescripcion);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Location = new System.Drawing.Point(0, 65);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(509, 143);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Tipo de Producto Consulta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(142, 62);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(351, 30);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbUsuarioConectado);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 59);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbUsuarioConectado
            // 
            this.lbUsuarioConectado.AutoSize = true;
            this.lbUsuarioConectado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioConectado.Location = new System.Drawing.Point(3, 16);
            this.lbUsuarioConectado.Name = "lbUsuarioConectado";
            this.lbUsuarioConectado.Size = new System.Drawing.Size(236, 28);
            this.lbUsuarioConectado.TabIndex = 10;
            this.lbUsuarioConectado.Text = "Usuario Conectado";
            this.lbUsuarioConectado.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1074, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.lbClave);
            this.gbOpciones.Controls.Add(this.txtClave);
            this.gbOpciones.Controls.Add(this.btnDeshabilitar);
            this.gbOpciones.Controls.Add(this.btnModificar);
            this.gbOpciones.Controls.Add(this.btnRestablecer);
            this.gbOpciones.Controls.Add(this.btnNuevo);
            this.gbOpciones.Controls.Add(this.btnConsultar);
            this.gbOpciones.Location = new System.Drawing.Point(515, 64);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(598, 144);
            this.gbOpciones.TabIndex = 2;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(181, 96);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(63, 25);
            this.lbClave.TabIndex = 2;
            this.lbClave.Text = "Clave";
            this.lbClave.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.Silver;
            this.txtClave.Location = new System.Drawing.Point(249, 93);
            this.txtClave.MaxLength = 100;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(217, 30);
            this.txtClave.TabIndex = 2;
            this.txtClave.Visible = false;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.Enabled = false;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Location = new System.Drawing.Point(6, 84);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(141, 49);
            this.btnDeshabilitar.TabIndex = 6;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.toolTip1.SetToolTip(this.btnDeshabilitar, "Deshabilitar Registro Seleccionado");
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(447, 28);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 49);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar Registro Seleccionado");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.Enabled = false;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Location = new System.Drawing.Point(300, 28);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(141, 49);
            this.btnRestablecer.TabIndex = 5;
            this.btnRestablecer.Text = "Restablecer";
            this.toolTip1.SetToolTip(this.btnRestablecer, "Restablecer Pantalla");
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(153, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(141, 49);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.toolTip1.SetToolTip(this.btnNuevo, "Crear Nuevo Registro");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(6, 29);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(141, 49);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnConsultar, "Buscar Registros");
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dtListado);
            this.gbListado.Location = new System.Drawing.Point(0, 215);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(1113, 298);
            this.gbListado.TabIndex = 3;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Tipo de Productos";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 26);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1107, 269);
            this.dtListado.TabIndex = 0;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentClick);
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 73;
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Location = new System.Drawing.Point(1, 523);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(103, 25);
            this.lbNumeroPagina.TabIndex = 4;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(107, 521);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 30);
            this.txtNumeroPagina.TabIndex = 5;
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumeroPagina.ValueChanged += new System.EventHandler(this.txtNumeroPagina_ValueChanged);
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(323, 519);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 30);
            this.txtNumeroRegistros.TabIndex = 7;
            this.txtNumeroRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNumeroRegistros.ValueChanged += new System.EventHandler(this.txtNumeroRegistros_ValueChanged);
            // 
            // lbNumeroRegistros
            // 
            this.lbNumeroRegistros.AutoSize = true;
            this.lbNumeroRegistros.Location = new System.Drawing.Point(196, 521);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(123, 25);
            this.lbNumeroRegistros.TabIndex = 6;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // lbPerfilUsuarioConectado
            // 
            this.lbPerfilUsuarioConectado.AutoSize = true;
            this.lbPerfilUsuarioConectado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfilUsuarioConectado.Location = new System.Drawing.Point(733, 523);
            this.lbPerfilUsuarioConectado.Name = "lbPerfilUsuarioConectado";
            this.lbPerfilUsuarioConectado.Size = new System.Drawing.Size(197, 28);
            this.lbPerfilUsuarioConectado.TabIndex = 11;
            this.lbPerfilUsuarioConectado.Text = "Perfil de Usuario";
            // 
            // TipoProductoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1125, 566);
            this.Controls.Add(this.lbPerfilUsuarioConectado);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoProductoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoProductoConsulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TipoProductoConsulta_FormClosing);
            this.Load += new System.EventHandler(this.TipoProductoConsulta_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.Label lbUsuarioConectado;
        private System.Windows.Forms.Label lbPerfilUsuarioConectado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox txtClave;
    }
}