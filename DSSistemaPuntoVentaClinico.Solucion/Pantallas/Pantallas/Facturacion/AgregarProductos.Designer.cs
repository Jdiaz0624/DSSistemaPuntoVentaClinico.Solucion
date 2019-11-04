namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion
{
    partial class AgregarProductos
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
            this.gbBuscarproductos = new System.Windows.Forms.GroupBox();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCantidaRegistros = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ddlTipoProducto = new System.Windows.Forms.ComboBox();
            this.gbListadoProductos = new System.Windows.Forms.GroupBox();
            this.dtSeleccionarproducto = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbTipoProducto = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbcantidadDisponible = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtCantidadUsar = new System.Windows.Forms.TextBox();
            this.lbCantidadUsar = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTercerprecio = new System.Windows.Forms.TextBox();
            this.txtSegundoPrecio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbTercerPrecio = new System.Windows.Forms.Label();
            this.lbSegundoPrecio = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbProductosAgregados = new System.Windows.Forms.GroupBox();
            this.dtProductosAgregados = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rbAgregarPrimerprecio = new System.Windows.Forms.RadioButton();
            this.rbAgregarSegundoPrecio = new System.Windows.Forms.RadioButton();
            this.rbAgregarTercerprecio = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuitar = new System.Windows.Forms.Button();
            this.gbBuscarproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.gbListadoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSeleccionarproducto)).BeginInit();
            this.gbProductosAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductosAgregados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarproductos
            // 
            this.gbBuscarproductos.Controls.Add(this.txtNumeroRegistros);
            this.gbBuscarproductos.Controls.Add(this.lbNumeroRegistros);
            this.gbBuscarproductos.Controls.Add(this.txtNumeroPagina);
            this.gbBuscarproductos.Controls.Add(this.lbNumeroPagina);
            this.gbBuscarproductos.Controls.Add(this.button1);
            this.gbBuscarproductos.Controls.Add(this.button2);
            this.gbBuscarproductos.Controls.Add(this.lbCantidaRegistros);
            this.gbBuscarproductos.Controls.Add(this.label17);
            this.gbBuscarproductos.Controls.Add(this.label16);
            this.gbBuscarproductos.Controls.Add(this.label15);
            this.gbBuscarproductos.Controls.Add(this.label14);
            this.gbBuscarproductos.Controls.Add(this.txtDescripcion);
            this.gbBuscarproductos.Controls.Add(this.txtCodigo);
            this.gbBuscarproductos.Controls.Add(this.ddlTipoProducto);
            this.gbBuscarproductos.Controls.Add(this.gbListadoProductos);
            this.gbBuscarproductos.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarproductos.Name = "gbBuscarproductos";
            this.gbBuscarproductos.Size = new System.Drawing.Size(1164, 362);
            this.gbBuscarproductos.TabIndex = 8;
            this.gbBuscarproductos.TabStop = false;
            this.gbBuscarproductos.Text = "Buscar Productos";
            this.gbBuscarproductos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(313, 317);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 32);
            this.txtNumeroRegistros.TabIndex = 39;
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
            this.lbNumeroRegistros.Location = new System.Drawing.Point(181, 320);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(130, 23);
            this.lbNumeroRegistros.TabIndex = 38;
            this.lbNumeroRegistros.Text = "No.Registros";
            this.lbNumeroRegistros.Click += new System.EventHandler(this.lbNumeroRegistros_Click);
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(124, 317);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 32);
            this.txtNumeroPagina.TabIndex = 37;
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumeroPagina.ValueChanged += new System.EventHandler(this.txtNumeroPagina_ValueChanged);
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Location = new System.Drawing.Point(11, 320);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(111, 23);
            this.lbNumeroPagina.TabIndex = 36;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(769, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cerrar";
            this.toolTip1.SetToolTip(this.button1, "Cerrar Pantalla");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(520, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Consultar";
            this.toolTip1.SetToolTip(this.button2, "Buscar Productos");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCantidaRegistros
            // 
            this.lbCantidaRegistros.AutoSize = true;
            this.lbCantidaRegistros.Location = new System.Drawing.Point(822, 22);
            this.lbCantidaRegistros.Name = "lbCantidaRegistros";
            this.lbCantidaRegistros.Size = new System.Drawing.Size(43, 23);
            this.lbCantidaRegistros.TabIndex = 34;
            this.lbCantidaRegistros.Text = "000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(624, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 23);
            this.label17.TabIndex = 33;
            this.label17.Text = "Cantidad Existente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(79, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 23);
            this.label16.TabIndex = 32;
            this.label16.Text = "Descripción";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(122, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Codigo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tipo de Producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(210, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(295, 32);
            this.txtDescripcion.TabIndex = 30;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Silver;
            this.txtCodigo.Location = new System.Drawing.Point(209, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(295, 32);
            this.txtCodigo.TabIndex = 29;
            // 
            // ddlTipoProducto
            // 
            this.ddlTipoProducto.BackColor = System.Drawing.Color.Silver;
            this.ddlTipoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlTipoProducto.FormattingEnabled = true;
            this.ddlTipoProducto.Location = new System.Drawing.Point(209, 19);
            this.ddlTipoProducto.Name = "ddlTipoProducto";
            this.ddlTipoProducto.Size = new System.Drawing.Size(296, 31);
            this.ddlTipoProducto.TabIndex = 29;
            // 
            // gbListadoProductos
            // 
            this.gbListadoProductos.Controls.Add(this.dtSeleccionarproducto);
            this.gbListadoProductos.Location = new System.Drawing.Point(12, 122);
            this.gbListadoProductos.Name = "gbListadoProductos";
            this.gbListadoProductos.Size = new System.Drawing.Size(1146, 192);
            this.gbListadoProductos.TabIndex = 0;
            this.gbListadoProductos.TabStop = false;
            this.gbListadoProductos.Text = "Listado de Productos";
            // 
            // dtSeleccionarproducto
            // 
            this.dtSeleccionarproducto.AllowUserToAddRows = false;
            this.dtSeleccionarproducto.AllowUserToDeleteRows = false;
            this.dtSeleccionarproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtSeleccionarproducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtSeleccionarproducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dtSeleccionarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSeleccionarproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtSeleccionarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtSeleccionarproducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSeleccionarproducto.Location = new System.Drawing.Point(3, 28);
            this.dtSeleccionarproducto.Name = "dtSeleccionarproducto";
            this.dtSeleccionarproducto.ReadOnly = true;
            this.dtSeleccionarproducto.RowTemplate.Height = 24;
            this.dtSeleccionarproducto.Size = new System.Drawing.Size(1140, 161);
            this.dtSeleccionarproducto.TabIndex = 0;
            this.dtSeleccionarproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSeleccionarproducto_CellContentClick);
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
            this.Select.Width = 76;
            // 
            // lbTipoProducto
            // 
            this.lbTipoProducto.AutoSize = true;
            this.lbTipoProducto.Location = new System.Drawing.Point(39, 385);
            this.lbTipoProducto.Name = "lbTipoProducto";
            this.lbTipoProducto.Size = new System.Drawing.Size(174, 23);
            this.lbTipoProducto.TabIndex = 9;
            this.lbTipoProducto.Text = "Tipo de Producto";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(116, 420);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(97, 23);
            this.lbProducto.TabIndex = 10;
            this.lbProducto.Text = "Producto";
            // 
            // lbcantidadDisponible
            // 
            this.lbcantidadDisponible.AutoSize = true;
            this.lbcantidadDisponible.Location = new System.Drawing.Point(4, 454);
            this.lbcantidadDisponible.Name = "lbcantidadDisponible";
            this.lbcantidadDisponible.Size = new System.Drawing.Size(209, 23);
            this.lbcantidadDisponible.TabIndex = 11;
            this.lbcantidadDisponible.Text = "Cantidad Disponible";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.BackColor = System.Drawing.Color.Silver;
            this.txtTipoProducto.Enabled = false;
            this.txtTipoProducto.Location = new System.Drawing.Point(217, 381);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(327, 32);
            this.txtTipoProducto.TabIndex = 12;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.Silver;
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(217, 416);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(327, 32);
            this.txtProducto.TabIndex = 13;
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.BackColor = System.Drawing.Color.Silver;
            this.txtCantidadDisponible.Enabled = false;
            this.txtCantidadDisponible.Location = new System.Drawing.Point(217, 451);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(327, 32);
            this.txtCantidadDisponible.TabIndex = 14;
            // 
            // txtCantidadUsar
            // 
            this.txtCantidadUsar.BackColor = System.Drawing.Color.Silver;
            this.txtCantidadUsar.Location = new System.Drawing.Point(217, 486);
            this.txtCantidadUsar.Name = "txtCantidadUsar";
            this.txtCantidadUsar.Size = new System.Drawing.Size(327, 32);
            this.txtCantidadUsar.TabIndex = 15;
            // 
            // lbCantidadUsar
            // 
            this.lbCantidadUsar.AutoSize = true;
            this.lbCantidadUsar.Location = new System.Drawing.Point(65, 490);
            this.lbCantidadUsar.Name = "lbCantidadUsar";
            this.lbCantidadUsar.Size = new System.Drawing.Size(148, 23);
            this.lbCantidadUsar.TabIndex = 16;
            this.lbCantidadUsar.Text = "Cantidad Usar";
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Location = new System.Drawing.Point(595, 491);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(115, 23);
            this.lbDescuento.TabIndex = 24;
            this.lbDescuento.Text = "Descuento";
            this.lbDescuento.Visible = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.Silver;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(715, 486);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(327, 32);
            this.txtDescuento.TabIndex = 23;
            this.txtDescuento.Visible = false;
            // 
            // txtTercerprecio
            // 
            this.txtTercerprecio.BackColor = System.Drawing.Color.Silver;
            this.txtTercerprecio.Enabled = false;
            this.txtTercerprecio.Location = new System.Drawing.Point(715, 451);
            this.txtTercerprecio.Name = "txtTercerprecio";
            this.txtTercerprecio.Size = new System.Drawing.Size(193, 32);
            this.txtTercerprecio.TabIndex = 22;
            // 
            // txtSegundoPrecio
            // 
            this.txtSegundoPrecio.BackColor = System.Drawing.Color.Silver;
            this.txtSegundoPrecio.Enabled = false;
            this.txtSegundoPrecio.Location = new System.Drawing.Point(715, 416);
            this.txtSegundoPrecio.Name = "txtSegundoPrecio";
            this.txtSegundoPrecio.Size = new System.Drawing.Size(193, 32);
            this.txtSegundoPrecio.TabIndex = 21;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Silver;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(715, 381);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(193, 32);
            this.txtPrecio.TabIndex = 20;
            // 
            // lbTercerPrecio
            // 
            this.lbTercerPrecio.AutoSize = true;
            this.lbTercerPrecio.Location = new System.Drawing.Point(572, 455);
            this.lbTercerPrecio.Name = "lbTercerPrecio";
            this.lbTercerPrecio.Size = new System.Drawing.Size(138, 23);
            this.lbTercerPrecio.TabIndex = 19;
            this.lbTercerPrecio.Text = "Tercer precio";
            // 
            // lbSegundoPrecio
            // 
            this.lbSegundoPrecio.AutoSize = true;
            this.lbSegundoPrecio.Location = new System.Drawing.Point(548, 420);
            this.lbSegundoPrecio.Name = "lbSegundoPrecio";
            this.lbSegundoPrecio.Size = new System.Drawing.Size(163, 23);
            this.lbSegundoPrecio.TabIndex = 18;
            this.lbSegundoPrecio.Text = "Segundo Precio";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(640, 386);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(71, 23);
            this.lbPrecio.TabIndex = 17;
            this.lbPrecio.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1048, 477);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 41);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar Producto seleccionado a factura");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbProductosAgregados
            // 
            this.gbProductosAgregados.Controls.Add(this.dtProductosAgregados);
            this.gbProductosAgregados.Location = new System.Drawing.Point(8, 524);
            this.gbProductosAgregados.Name = "gbProductosAgregados";
            this.gbProductosAgregados.Size = new System.Drawing.Size(1146, 192);
            this.gbProductosAgregados.TabIndex = 1;
            this.gbProductosAgregados.TabStop = false;
            this.gbProductosAgregados.Text = "Productos Agregados ";
            // 
            // dtProductosAgregados
            // 
            this.dtProductosAgregados.AllowUserToAddRows = false;
            this.dtProductosAgregados.AllowUserToDeleteRows = false;
            this.dtProductosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtProductosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProductosAgregados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dtProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductosAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dtProductosAgregados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtProductosAgregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProductosAgregados.Location = new System.Drawing.Point(3, 28);
            this.dtProductosAgregados.Name = "dtProductosAgregados";
            this.dtProductosAgregados.ReadOnly = true;
            this.dtProductosAgregados.RowTemplate.Height = 24;
            this.dtProductosAgregados.Size = new System.Drawing.Size(1140, 161);
            this.dtProductosAgregados.TabIndex = 0;
            this.dtProductosAgregados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProductosAgregados_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Select";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Select";
            this.dataGridViewButtonColumn1.ToolTipText = "Select";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 76;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1048, 430);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 41);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.toolTip1.SetToolTip(this.btnVolver, "Volver Atras");
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rbAgregarPrimerprecio
            // 
            this.rbAgregarPrimerprecio.AutoSize = true;
            this.rbAgregarPrimerprecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAgregarPrimerprecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAgregarPrimerprecio.Location = new System.Drawing.Point(913, 383);
            this.rbAgregarPrimerprecio.Name = "rbAgregarPrimerprecio";
            this.rbAgregarPrimerprecio.Size = new System.Drawing.Size(71, 27);
            this.rbAgregarPrimerprecio.TabIndex = 42;
            this.rbAgregarPrimerprecio.TabStop = true;
            this.rbAgregarPrimerprecio.Text = "Usar";
            this.rbAgregarPrimerprecio.UseVisualStyleBackColor = true;
            this.rbAgregarPrimerprecio.CheckedChanged += new System.EventHandler(this.rbAgregarPrimerprecio_CheckedChanged);
            // 
            // rbAgregarSegundoPrecio
            // 
            this.rbAgregarSegundoPrecio.AutoSize = true;
            this.rbAgregarSegundoPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAgregarSegundoPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAgregarSegundoPrecio.Location = new System.Drawing.Point(913, 418);
            this.rbAgregarSegundoPrecio.Name = "rbAgregarSegundoPrecio";
            this.rbAgregarSegundoPrecio.Size = new System.Drawing.Size(71, 27);
            this.rbAgregarSegundoPrecio.TabIndex = 43;
            this.rbAgregarSegundoPrecio.TabStop = true;
            this.rbAgregarSegundoPrecio.Text = "Usar";
            this.rbAgregarSegundoPrecio.UseVisualStyleBackColor = true;
            this.rbAgregarSegundoPrecio.CheckedChanged += new System.EventHandler(this.rbAgregarSegundoPrecio_CheckedChanged);
            // 
            // rbAgregarTercerprecio
            // 
            this.rbAgregarTercerprecio.AutoSize = true;
            this.rbAgregarTercerprecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAgregarTercerprecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAgregarTercerprecio.Location = new System.Drawing.Point(914, 452);
            this.rbAgregarTercerprecio.Name = "rbAgregarTercerprecio";
            this.rbAgregarTercerprecio.Size = new System.Drawing.Size(71, 27);
            this.rbAgregarTercerprecio.TabIndex = 44;
            this.rbAgregarTercerprecio.TabStop = true;
            this.rbAgregarTercerprecio.Text = "Usar";
            this.rbAgregarTercerprecio.UseVisualStyleBackColor = true;
            this.rbAgregarTercerprecio.CheckedChanged += new System.EventHandler(this.rbAgregarTercerprecio_CheckedChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(1048, 383);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(119, 41);
            this.btnQuitar.TabIndex = 45;
            this.btnQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btnQuitar, "Quitar Producto Seleccionado");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.rbAgregarTercerprecio);
            this.Controls.Add(this.rbAgregarSegundoPrecio);
            this.Controls.Add(this.rbAgregarPrimerprecio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbProductosAgregados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbDescuento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtTercerprecio);
            this.Controls.Add(this.txtSegundoPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbTercerPrecio);
            this.Controls.Add(this.lbSegundoPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidadUsar);
            this.Controls.Add(this.txtCantidadUsar);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.lbcantidadDisponible);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.lbTipoProducto);
            this.Controls.Add(this.gbBuscarproductos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarProductos_FormClosing);
            this.Load += new System.EventHandler(this.AgregarProductos_Load);
            this.gbBuscarproductos.ResumeLayout(false);
            this.gbBuscarproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.gbListadoProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSeleccionarproducto)).EndInit();
            this.gbProductosAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductosAgregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarproductos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbCantidaRegistros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox ddlTipoProducto;
        private System.Windows.Forms.GroupBox gbListadoProductos;
        private System.Windows.Forms.DataGridView dtSeleccionarproducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.Label lbTipoProducto;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbcantidadDisponible;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.TextBox txtCantidadUsar;
        private System.Windows.Forms.Label lbCantidadUsar;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTercerprecio;
        private System.Windows.Forms.TextBox txtSegundoPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbTercerPrecio;
        private System.Windows.Forms.Label lbSegundoPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbProductosAgregados;
        private System.Windows.Forms.DataGridView dtProductosAgregados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RadioButton rbAgregarPrimerprecio;
        private System.Windows.Forms.RadioButton rbAgregarSegundoPrecio;
        private System.Windows.Forms.RadioButton rbAgregarTercerprecio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button btnQuitar;
    }
}