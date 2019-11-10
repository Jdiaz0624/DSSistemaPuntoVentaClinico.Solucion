namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Historial
{
    partial class Historial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.cbNoagregarRangofecha = new System.Windows.Forms.CheckBox();
            this.rbTipoPago = new System.Windows.Forms.RadioButton();
            this.rbTipoFacturacion = new System.Windows.Forms.RadioButton();
            this.rbEstatus = new System.Windows.Forms.RadioButton();
            this.rbNumeroFactura = new System.Windows.Forms.RadioButton();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.rbGenerar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlSeleccionar = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPaciente);
            this.groupBox1.Controls.Add(this.cbNoagregarRangofecha);
            this.groupBox1.Controls.Add(this.rbTipoPago);
            this.groupBox1.Controls.Add(this.rbTipoFacturacion);
            this.groupBox1.Controls.Add(this.rbEstatus);
            this.groupBox1.Controls.Add(this.rbNumeroFactura);
            this.groupBox1.Controls.Add(this.rbFactura);
            this.groupBox1.Controls.Add(this.rbGenerar);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Tipo de Filtros";
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPaciente.Location = new System.Drawing.Point(585, 32);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(117, 27);
            this.rbPaciente.TabIndex = 8;
            this.rbPaciente.TabStop = true;
            this.rbPaciente.Text = "Paciente";
            this.toolTip1.SetToolTip(this.rbPaciente, "Mostrar el historial mediante el nombre del paciente");
            this.rbPaciente.UseVisualStyleBackColor = true;
            this.rbPaciente.CheckedChanged += new System.EventHandler(this.rbPaciente_CheckedChanged);
            // 
            // cbNoagregarRangofecha
            // 
            this.cbNoagregarRangofecha.AutoSize = true;
            this.cbNoagregarRangofecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNoagregarRangofecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNoagregarRangofecha.Location = new System.Drawing.Point(418, 66);
            this.cbNoagregarRangofecha.Name = "cbNoagregarRangofecha";
            this.cbNoagregarRangofecha.Size = new System.Drawing.Size(313, 27);
            this.cbNoagregarRangofecha.TabIndex = 7;
            this.cbNoagregarRangofecha.Text = "No agregar Rango de Fecha";
            this.toolTip1.SetToolTip(this.cbNoagregarRangofecha, "Aregar o no agregar el rango de fecha");
            this.cbNoagregarRangofecha.UseVisualStyleBackColor = true;
            // 
            // rbTipoPago
            // 
            this.rbTipoPago.AutoSize = true;
            this.rbTipoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTipoPago.Location = new System.Drawing.Point(252, 65);
            this.rbTipoPago.Name = "rbTipoPago";
            this.rbTipoPago.Size = new System.Drawing.Size(159, 27);
            this.rbTipoPago.TabIndex = 5;
            this.rbTipoPago.TabStop = true;
            this.rbTipoPago.Text = "Tipo de Pago";
            this.toolTip1.SetToolTip(this.rbTipoPago, "Mostrar el historial mediante el tipo de pago");
            this.rbTipoPago.UseVisualStyleBackColor = true;
            this.rbTipoPago.CheckedChanged += new System.EventHandler(this.rbTipoPago_CheckedChanged);
            // 
            // rbTipoFacturacion
            // 
            this.rbTipoFacturacion.AutoSize = true;
            this.rbTipoFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTipoFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTipoFacturacion.Location = new System.Drawing.Point(22, 65);
            this.rbTipoFacturacion.Name = "rbTipoFacturacion";
            this.rbTipoFacturacion.Size = new System.Drawing.Size(224, 27);
            this.rbTipoFacturacion.TabIndex = 4;
            this.rbTipoFacturacion.TabStop = true;
            this.rbTipoFacturacion.Text = "Tipo de Facturación";
            this.toolTip1.SetToolTip(this.rbTipoFacturacion, "Mostrar el historial mediante el tipo de facturación\r\n");
            this.rbTipoFacturacion.UseVisualStyleBackColor = true;
            this.rbTipoFacturacion.CheckedChanged += new System.EventHandler(this.rbTipoFacturacion_CheckedChanged);
            // 
            // rbEstatus
            // 
            this.rbEstatus.AutoSize = true;
            this.rbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbEstatus.Location = new System.Drawing.Point(482, 32);
            this.rbEstatus.Name = "rbEstatus";
            this.rbEstatus.Size = new System.Drawing.Size(97, 27);
            this.rbEstatus.TabIndex = 3;
            this.rbEstatus.TabStop = true;
            this.rbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.rbEstatus, "Mostrar el historial mediante el estatus del registro\r\n");
            this.rbEstatus.UseVisualStyleBackColor = true;
            this.rbEstatus.CheckedChanged += new System.EventHandler(this.rbEstatus_CheckedChanged);
            // 
            // rbNumeroFactura
            // 
            this.rbNumeroFactura.AutoSize = true;
            this.rbNumeroFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNumeroFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbNumeroFactura.Location = new System.Drawing.Point(252, 32);
            this.rbNumeroFactura.Name = "rbNumeroFactura";
            this.rbNumeroFactura.Size = new System.Drawing.Size(223, 27);
            this.rbNumeroFactura.TabIndex = 2;
            this.rbNumeroFactura.TabStop = true;
            this.rbNumeroFactura.Text = "Numero de Factura";
            this.toolTip1.SetToolTip(this.rbNumeroFactura, "Mostrar el historial mediante el numero largo de factura");
            this.rbNumeroFactura.UseVisualStyleBackColor = true;
            this.rbNumeroFactura.CheckedChanged += new System.EventHandler(this.rbNumeroFactura_CheckedChanged);
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbFactura.Location = new System.Drawing.Point(139, 32);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(106, 27);
            this.rbFactura.TabIndex = 1;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Factura";
            this.toolTip1.SetToolTip(this.rbFactura, "Mostrar Historial mediante el numero corto de factura");
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbGenerar
            // 
            this.rbGenerar.AutoSize = true;
            this.rbGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbGenerar.Location = new System.Drawing.Point(22, 32);
            this.rbGenerar.Name = "rbGenerar";
            this.rbGenerar.Size = new System.Drawing.Size(110, 27);
            this.rbGenerar.TabIndex = 0;
            this.rbGenerar.TabStop = true;
            this.rbGenerar.Text = "General";
            this.toolTip1.SetToolTip(this.rbGenerar, "Mostrar listado general");
            this.rbGenerar.UseVisualStyleBackColor = true;
            this.rbGenerar.CheckedChanged += new System.EventHandler(this.rbGenerar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlSeleccionar);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Controls.Add(this.txtFechaHasta);
            this.groupBox2.Controls.Add(this.txtFechaDesde);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ddlSeleccionar
            // 
            this.ddlSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionar.FormattingEnabled = true;
            this.ddlSeleccionar.Location = new System.Drawing.Point(159, 96);
            this.ddlSeleccionar.Name = "ddlSeleccionar";
            this.ddlSeleccionar.Size = new System.Drawing.Size(471, 31);
            this.ddlSeleccionar.TabIndex = 7;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(159, 60);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(471, 32);
            this.txtParametro.TabIndex = 6;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(467, 25);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(163, 32);
            this.txtFechaHasta.TabIndex = 5;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(159, 25);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(163, 32);
            this.txtFechaDesde.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parametro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnFacturar);
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Controls.Add(this.btnConsultar);
            this.groupBox3.Location = new System.Drawing.Point(760, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Restablecer";
            this.toolTip1.SetToolTip(this.button1, "Restablecer la pantalla");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.Enabled = false;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(231, 31);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(219, 41);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Facturar";
            this.toolTip1.SetToolTip(this.btnFacturar, "Facturar una Cotización");
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(6, 79);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(219, 41);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.btnImprimir, "Imprimir Factura mediante registro seleccionado");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(6, 32);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(219, 41);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultar, "Consultar Registros");
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(231, 23);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(219, 41);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial";
            this.toolTip1.SetToolTip(this.btnHistorial, "Mostrar todo el historial de Facturacion segun parametro seleccioado");
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Visible = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 54);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1184, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar Pantalla");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHistorial);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Location = new System.Drawing.Point(760, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 115);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(447, 81);
            this.progressBar1.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtListado);
            this.groupBox5.Location = new System.Drawing.Point(12, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1210, 296);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 28);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1204, 265);
            this.dtListado.TabIndex = 0;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentClick);
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 77;
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRegistros.Location = new System.Drawing.Point(320, 607);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 32);
            this.txtNumeroRegistros.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtNumeroRegistros, "Numro de registros");
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
            this.lbNumeroRegistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroRegistros.Location = new System.Drawing.Point(184, 610);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(130, 23);
            this.lbNumeroRegistros.TabIndex = 18;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPagina.Location = new System.Drawing.Point(127, 607);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 32);
            this.txtNumeroPagina.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtNumeroPagina, "Numero de pagina");
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
            this.lbNumeroPagina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPagina.Location = new System.Drawing.Point(11, 610);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(111, 23);
            this.lbNumeroPagina.TabIndex = 16;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(12, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(72, 23);
            this.lbTitulo.TabIndex = 20;
            this.lbTitulo.Text = "label6";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1235, 652);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historial_FormClosing);
            this.Load += new System.EventHandler(this.Historial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNoagregarRangofecha;
        private System.Windows.Forms.RadioButton rbTipoPago;
        private System.Windows.Forms.RadioButton rbTipoFacturacion;
        private System.Windows.Forms.RadioButton rbEstatus;
        private System.Windows.Forms.RadioButton rbNumeroFactura;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.RadioButton rbGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddlSeleccionar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitulo;
    }
}