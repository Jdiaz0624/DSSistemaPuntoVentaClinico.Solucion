namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad
{
    partial class ComisionMedico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lbLetrero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnControlApertura = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbPagada = new System.Windows.Forms.RadioButton();
            this.rbNoPagada = new System.Windows.Forms.RadioButton();
            this.cbNoAgregarRangoFecha = new System.Windows.Forms.CheckBox();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbTodo = new System.Windows.Forms.CheckBox();
            this.gbPagoComisiones = new System.Windows.Forms.GroupBox();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.txtComisionPagar = new System.Windows.Forms.TextBox();
            this.txtFechaCirugia = new System.Windows.Forms.TextBox();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbComisionPagadaTitulo = new System.Windows.Forms.Label();
            this.lbRespuesta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.gbPagoComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 44);
            this.panel1.TabIndex = 16;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(344, 10);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbUsuario.TabIndex = 15;
            this.lbUsuario.Text = "label6";
            this.lbUsuario.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1199, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(3, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(51, 20);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.lbLetrero);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnControlApertura);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbNoAgregarRangoFecha);
            this.groupBox1.Controls.Add(this.txtFechaHasta);
            this.groupBox1.Controls.Add(this.txtFechaDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 209);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comisiones Filtros";
            // 
            // btnPagar
            // 
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(481, 151);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(230, 47);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.toolTip1.SetToolTip(this.btnPagar, "Pagar Comisión seleccionada");
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lbLetrero
            // 
            this.lbLetrero.AutoSize = true;
            this.lbLetrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetrero.ForeColor = System.Drawing.Color.Red;
            this.lbLetrero.Location = new System.Drawing.Point(269, 117);
            this.lbLetrero.Name = "lbLetrero";
            this.lbLetrero.Size = new System.Drawing.Size(70, 25);
            this.lbLetrero.TabIndex = 8;
            this.lbLetrero.Text = "label3";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnControlApertura
            // 
            this.btnControlApertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlApertura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlApertura.Location = new System.Drawing.Point(8, 151);
            this.btnControlApertura.Name = "btnControlApertura";
            this.btnControlApertura.Size = new System.Drawing.Size(230, 47);
            this.btnControlApertura.TabIndex = 6;
            this.btnControlApertura.Text = "Consultar";
            this.btnControlApertura.UseVisualStyleBackColor = true;
            this.btnControlApertura.Click += new System.EventHandler(this.btnControlApertura_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAmbos);
            this.groupBox2.Controls.Add(this.rbPagada);
            this.groupBox2.Controls.Add(this.rbNoPagada);
            this.groupBox2.Location = new System.Drawing.Point(337, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Comision";
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAmbos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbAmbos.Location = new System.Drawing.Point(257, 29);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(76, 24);
            this.rbAmbos.TabIndex = 10;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.toolTip1.SetToolTip(this.rbAmbos, "Mostrar Ambas comisiones");
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbPagada
            // 
            this.rbPagada.AutoSize = true;
            this.rbPagada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPagada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPagada.Location = new System.Drawing.Point(150, 29);
            this.rbPagada.Name = "rbPagada";
            this.rbPagada.Size = new System.Drawing.Size(81, 24);
            this.rbPagada.TabIndex = 9;
            this.rbPagada.TabStop = true;
            this.rbPagada.Text = "Pagada";
            this.toolTip1.SetToolTip(this.rbPagada, "Mostrar las Comisiones Pagadas");
            this.rbPagada.UseVisualStyleBackColor = true;
            // 
            // rbNoPagada
            // 
            this.rbNoPagada.AutoSize = true;
            this.rbNoPagada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNoPagada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbNoPagada.Location = new System.Drawing.Point(13, 29);
            this.rbNoPagada.Name = "rbNoPagada";
            this.rbNoPagada.Size = new System.Drawing.Size(105, 24);
            this.rbNoPagada.TabIndex = 8;
            this.rbNoPagada.TabStop = true;
            this.rbNoPagada.Text = "No Pagada";
            this.toolTip1.SetToolTip(this.rbNoPagada, "Mostrar las comisiones que no estan pagadas");
            this.rbNoPagada.UseVisualStyleBackColor = true;
            // 
            // cbNoAgregarRangoFecha
            // 
            this.cbNoAgregarRangoFecha.AutoSize = true;
            this.cbNoAgregarRangoFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNoAgregarRangoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNoAgregarRangoFecha.Location = new System.Drawing.Point(20, 116);
            this.cbNoAgregarRangoFecha.Name = "cbNoAgregarRangoFecha";
            this.cbNoAgregarRangoFecha.Size = new System.Drawing.Size(207, 24);
            this.cbNoAgregarRangoFecha.TabIndex = 4;
            this.cbNoAgregarRangoFecha.Text = "No Usar Rango de Fecha";
            this.toolTip1.SetToolTip(this.cbNoAgregarRangoFecha, "No filtrar por rango de fecha");
            this.cbNoAgregarRangoFecha.UseVisualStyleBackColor = true;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(168, 75);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(155, 26);
            this.txtFechaHasta.TabIndex = 3;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(168, 39);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(155, 26);
            this.txtFechaDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde";
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(335, 569);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 26);
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
            this.lbNumeroRegistros.Location = new System.Drawing.Point(208, 571);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(101, 20);
            this.lbNumeroRegistros.TabIndex = 38;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(119, 571);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 26);
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
            this.lbNumeroPagina.Location = new System.Drawing.Point(13, 573);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(82, 20);
            this.lbNumeroPagina.TabIndex = 36;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dtListado);
            this.gbListado.Location = new System.Drawing.Point(12, 265);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(1214, 298);
            this.gbListado.TabIndex = 35;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Comisiones";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.GridColor = System.Drawing.Color.DimGray;
            this.dtListado.Location = new System.Drawing.Point(3, 22);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1208, 273);
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
            this.Select.Width = 60;
            // 
            // cbTodo
            // 
            this.cbTodo.AutoSize = true;
            this.cbTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTodo.Location = new System.Drawing.Point(355, 161);
            this.cbTodo.Name = "cbTodo";
            this.cbTodo.Size = new System.Drawing.Size(62, 24);
            this.cbTodo.TabIndex = 10;
            this.cbTodo.Text = "Todo";
            this.toolTip1.SetToolTip(this.cbTodo, "Pagar Todo");
            this.cbTodo.UseVisualStyleBackColor = true;
            this.cbTodo.CheckedChanged += new System.EventHandler(this.cbTodo_CheckedChanged);
            // 
            // gbPagoComisiones
            // 
            this.gbPagoComisiones.Controls.Add(this.cbTodo);
            this.gbPagoComisiones.Controls.Add(this.txtMontoPagar);
            this.gbPagoComisiones.Controls.Add(this.txtComisionPagar);
            this.gbPagoComisiones.Controls.Add(this.txtFechaCirugia);
            this.gbPagoComisiones.Controls.Add(this.txtNoFactura);
            this.gbPagoComisiones.Controls.Add(this.txtNombreMedico);
            this.gbPagoComisiones.Controls.Add(this.label7);
            this.gbPagoComisiones.Controls.Add(this.label6);
            this.gbPagoComisiones.Controls.Add(this.label5);
            this.gbPagoComisiones.Controls.Add(this.label4);
            this.gbPagoComisiones.Controls.Add(this.label3);
            this.gbPagoComisiones.Location = new System.Drawing.Point(737, 55);
            this.gbPagoComisiones.Name = "gbPagoComisiones";
            this.gbPagoComisiones.Size = new System.Drawing.Size(486, 204);
            this.gbPagoComisiones.TabIndex = 40;
            this.gbPagoComisiones.TabStop = false;
            this.gbPagoComisiones.Text = "Pago de Comisiones";
            this.gbPagoComisiones.Visible = false;
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(162, 162);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(187, 26);
            this.txtMontoPagar.TabIndex = 9;
            this.txtMontoPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPagar_KeyPress);
            // 
            // txtComisionPagar
            // 
            this.txtComisionPagar.Enabled = false;
            this.txtComisionPagar.Location = new System.Drawing.Point(163, 126);
            this.txtComisionPagar.Name = "txtComisionPagar";
            this.txtComisionPagar.Size = new System.Drawing.Size(286, 26);
            this.txtComisionPagar.TabIndex = 8;
            this.txtComisionPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPagar_KeyPress);
            // 
            // txtFechaCirugia
            // 
            this.txtFechaCirugia.Enabled = false;
            this.txtFechaCirugia.Location = new System.Drawing.Point(164, 92);
            this.txtFechaCirugia.Name = "txtFechaCirugia";
            this.txtFechaCirugia.Size = new System.Drawing.Size(286, 26);
            this.txtFechaCirugia.TabIndex = 7;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Enabled = false;
            this.txtNoFactura.Location = new System.Drawing.Point(164, 59);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(286, 26);
            this.txtNoFactura.TabIndex = 6;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Enabled = false;
            this.txtNombreMedico.Location = new System.Drawing.Point(164, 26);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(286, 26);
            this.txtNombreMedico.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Monto Pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Comisión Pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha Cirugia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "No. Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medico";
            // 
            // lbComisionPagadaTitulo
            // 
            this.lbComisionPagadaTitulo.AutoSize = true;
            this.lbComisionPagadaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComisionPagadaTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbComisionPagadaTitulo.Location = new System.Drawing.Point(416, 573);
            this.lbComisionPagadaTitulo.Name = "lbComisionPagadaTitulo";
            this.lbComisionPagadaTitulo.Size = new System.Drawing.Size(189, 25);
            this.lbComisionPagadaTitulo.TabIndex = 10;
            this.lbComisionPagadaTitulo.Text = "Comisión Pagada:";
            this.lbComisionPagadaTitulo.Visible = false;
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.AutoSize = true;
            this.lbRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRespuesta.ForeColor = System.Drawing.Color.Black;
            this.lbRespuesta.Location = new System.Drawing.Point(659, 573);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(44, 25);
            this.lbRespuesta.TabIndex = 41;
            this.lbRespuesta.Text = "NO";
            this.lbRespuesta.Visible = false;
            // 
            // ComisionMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 615);
            this.Controls.Add(this.lbRespuesta);
            this.Controls.Add(this.lbComisionPagadaTitulo);
            this.Controls.Add(this.gbPagoComisiones);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComisionMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComisionMedico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComisionMedico_FormClosing);
            this.Load += new System.EventHandler(this.ComisionMedico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.gbPagoComisiones.ResumeLayout(false);
            this.gbPagoComisiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbPagada;
        private System.Windows.Forms.RadioButton rbNoPagada;
        private System.Windows.Forms.CheckBox cbNoAgregarRangoFecha;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnControlApertura;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Label lbLetrero;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbPagoComisiones;
        private System.Windows.Forms.CheckBox cbTodo;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.TextBox txtComisionPagar;
        private System.Windows.Forms.TextBox txtFechaCirugia;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbComisionPagadaTitulo;
        private System.Windows.Forms.Label lbRespuesta;
    }
}