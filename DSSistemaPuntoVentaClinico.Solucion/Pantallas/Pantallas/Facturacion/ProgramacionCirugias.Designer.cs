namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion
{
    partial class ProgramacionCirugias
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
            this.gbProgramacionCirugia = new System.Windows.Forms.GroupBox();
            this.gbReferencia = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbNumeroReferencia = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbNumeroFactura = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rbBuscarPorNumeroReferencia = new System.Windows.Forms.RadioButton();
            this.rbBuscarPorNumeroFactura = new System.Windows.Forms.RadioButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCompletarRegistro = new System.Windows.Forms.Button();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.ddlEstatusCirugia = new System.Windows.Forms.ComboBox();
            this.gbProductosAgregados = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.gbDatosPaciente = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNoIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.txtTipoIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoFacturacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlMedico = new System.Windows.Forms.ComboBox();
            this.ddlCentroSalud = new System.Windows.Forms.ComboBox();
            this.txtFechaCirugia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbProgramacionCirugia.SuspendLayout();
            this.gbReferencia.SuspendLayout();
            this.gbProductosAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.gbDatosPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProgramacionCirugia
            // 
            this.gbProgramacionCirugia.AutoSize = true;
            this.gbProgramacionCirugia.Controls.Add(this.gbReferencia);
            this.gbProgramacionCirugia.Controls.Add(this.rbBuscarPorNumeroReferencia);
            this.gbProgramacionCirugia.Controls.Add(this.rbBuscarPorNumeroFactura);
            this.gbProgramacionCirugia.Controls.Add(this.btnCerrar);
            this.gbProgramacionCirugia.Controls.Add(this.btnCompletarRegistro);
            this.gbProgramacionCirugia.Controls.Add(this.lbEstatus);
            this.gbProgramacionCirugia.Controls.Add(this.ddlEstatusCirugia);
            this.gbProgramacionCirugia.Controls.Add(this.gbProductosAgregados);
            this.gbProgramacionCirugia.Controls.Add(this.gbDatosPaciente);
            this.gbProgramacionCirugia.Controls.Add(this.btnBuscar);
            this.gbProgramacionCirugia.Controls.Add(this.txtReferencia);
            this.gbProgramacionCirugia.Controls.Add(this.label5);
            this.gbProgramacionCirugia.Controls.Add(this.txtNumeroFactura);
            this.gbProgramacionCirugia.Controls.Add(this.label4);
            this.gbProgramacionCirugia.Controls.Add(this.label3);
            this.gbProgramacionCirugia.Controls.Add(this.label2);
            this.gbProgramacionCirugia.Controls.Add(this.ddlMedico);
            this.gbProgramacionCirugia.Controls.Add(this.ddlCentroSalud);
            this.gbProgramacionCirugia.Controls.Add(this.txtFechaCirugia);
            this.gbProgramacionCirugia.Controls.Add(this.label1);
            this.gbProgramacionCirugia.Location = new System.Drawing.Point(12, 12);
            this.gbProgramacionCirugia.Name = "gbProgramacionCirugia";
            this.gbProgramacionCirugia.Size = new System.Drawing.Size(1096, 647);
            this.gbProgramacionCirugia.TabIndex = 0;
            this.gbProgramacionCirugia.TabStop = false;
            this.gbProgramacionCirugia.Text = "Programación de Cirugia";
            this.gbProgramacionCirugia.Enter += new System.EventHandler(this.gbProgramacionCirugia_Enter);
            // 
            // gbReferencia
            // 
            this.gbReferencia.Controls.Add(this.button2);
            this.gbReferencia.Controls.Add(this.button1);
            this.gbReferencia.Controls.Add(this.lbNumeroReferencia);
            this.gbReferencia.Controls.Add(this.label19);
            this.gbReferencia.Controls.Add(this.lbNumeroFactura);
            this.gbReferencia.Controls.Add(this.label16);
            this.gbReferencia.Location = new System.Drawing.Point(890, 70);
            this.gbReferencia.Name = "gbReferencia";
            this.gbReferencia.Size = new System.Drawing.Size(200, 267);
            this.gbReferencia.TabIndex = 18;
            this.gbReferencia.TabStop = false;
            this.gbReferencia.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = "Factura";
            this.toolTip1.SetToolTip(this.button2, "Re-Imprimir Factura");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculos";
            this.toolTip1.SetToolTip(this.button1, "Mostrar los calculos realizados");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbNumeroReferencia
            // 
            this.lbNumeroReferencia.AutoSize = true;
            this.lbNumeroReferencia.Location = new System.Drawing.Point(8, 92);
            this.lbNumeroReferencia.Name = "lbNumeroReferencia";
            this.lbNumeroReferencia.Size = new System.Drawing.Size(105, 25);
            this.lbNumeroReferencia.TabIndex = 3;
            this.lbNumeroReferencia.Text = "Referencia";
            this.lbNumeroReferencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.lbNumeroReferencia, "Numero de referencia");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "No. Referencia";
            // 
            // lbNumeroFactura
            // 
            this.lbNumeroFactura.AutoSize = true;
            this.lbNumeroFactura.Location = new System.Drawing.Point(6, 42);
            this.lbNumeroFactura.Name = "lbNumeroFactura";
            this.lbNumeroFactura.Size = new System.Drawing.Size(78, 25);
            this.lbNumeroFactura.TabIndex = 1;
            this.lbNumeroFactura.Text = "Factura";
            this.lbNumeroFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.lbNumeroFactura, "Numero de Factura");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "No. Factura";
            // 
            // rbBuscarPorNumeroReferencia
            // 
            this.rbBuscarPorNumeroReferencia.AutoSize = true;
            this.rbBuscarPorNumeroReferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBuscarPorNumeroReferencia.Location = new System.Drawing.Point(355, 67);
            this.rbBuscarPorNumeroReferencia.Name = "rbBuscarPorNumeroReferencia";
            this.rbBuscarPorNumeroReferencia.Size = new System.Drawing.Size(328, 29);
            this.rbBuscarPorNumeroReferencia.TabIndex = 17;
            this.rbBuscarPorNumeroReferencia.TabStop = true;
            this.rbBuscarPorNumeroReferencia.Text = "Buscar Por Numero de Referencia";
            this.rbBuscarPorNumeroReferencia.UseVisualStyleBackColor = true;
            this.rbBuscarPorNumeroReferencia.CheckedChanged += new System.EventHandler(this.rbBuscarPorNumeroReferencia_CheckedChanged);
            // 
            // rbBuscarPorNumeroFactura
            // 
            this.rbBuscarPorNumeroFactura.AutoSize = true;
            this.rbBuscarPorNumeroFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBuscarPorNumeroFactura.Location = new System.Drawing.Point(54, 67);
            this.rbBuscarPorNumeroFactura.Name = "rbBuscarPorNumeroFactura";
            this.rbBuscarPorNumeroFactura.Size = new System.Drawing.Size(301, 29);
            this.rbBuscarPorNumeroFactura.TabIndex = 16;
            this.rbBuscarPorNumeroFactura.TabStop = true;
            this.rbBuscarPorNumeroFactura.Text = "Buscar Por Numero de Factura";
            this.rbBuscarPorNumeroFactura.UseVisualStyleBackColor = true;
            this.rbBuscarPorNumeroFactura.CheckedChanged += new System.EventHandler(this.rbBuscarPorNumeroFactura_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(844, 582);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(227, 36);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar Pantalla");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCompletarRegistro
            // 
            this.btnCompletarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompletarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarRegistro.Location = new System.Drawing.Point(242, 582);
            this.btnCompletarRegistro.Name = "btnCompletarRegistro";
            this.btnCompletarRegistro.Size = new System.Drawing.Size(227, 36);
            this.btnCompletarRegistro.TabIndex = 14;
            this.btnCompletarRegistro.Text = "Completar Registro";
            this.toolTip1.SetToolTip(this.btnCompletarRegistro, "Completar registros");
            this.btnCompletarRegistro.UseVisualStyleBackColor = true;
            this.btnCompletarRegistro.Visible = false;
            this.btnCompletarRegistro.Click += new System.EventHandler(this.btnCompletarRegistro_Click);
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Location = new System.Drawing.Point(520, 105);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(77, 25);
            this.lbEstatus.TabIndex = 13;
            this.lbEstatus.Text = "Estatus";
            this.lbEstatus.Visible = false;
            // 
            // ddlEstatusCirugia
            // 
            this.ddlEstatusCirugia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlEstatusCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEstatusCirugia.FormattingEnabled = true;
            this.ddlEstatusCirugia.Location = new System.Drawing.Point(588, 101);
            this.ddlEstatusCirugia.Name = "ddlEstatusCirugia";
            this.ddlEstatusCirugia.Size = new System.Drawing.Size(245, 33);
            this.ddlEstatusCirugia.TabIndex = 12;
            this.ddlEstatusCirugia.Visible = false;
            // 
            // gbProductosAgregados
            // 
            this.gbProductosAgregados.Controls.Add(this.dtListado);
            this.gbProductosAgregados.Location = new System.Drawing.Point(6, 342);
            this.gbProductosAgregados.Name = "gbProductosAgregados";
            this.gbProductosAgregados.Size = new System.Drawing.Size(1068, 235);
            this.gbProductosAgregados.TabIndex = 11;
            this.gbProductosAgregados.TabStop = false;
            this.gbProductosAgregados.Text = "Productos Agregados";
            this.gbProductosAgregados.Visible = false;
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 26);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.Size = new System.Drawing.Size(1062, 206);
            this.dtListado.TabIndex = 0;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentClick);
            // 
            // gbDatosPaciente
            // 
            this.gbDatosPaciente.Controls.Add(this.label15);
            this.gbDatosPaciente.Controls.Add(this.txtComentario);
            this.gbDatosPaciente.Controls.Add(this.txtDireccion);
            this.gbDatosPaciente.Controls.Add(this.label14);
            this.gbDatosPaciente.Controls.Add(this.txtEmail);
            this.gbDatosPaciente.Controls.Add(this.label13);
            this.gbDatosPaciente.Controls.Add(this.txtSexo);
            this.gbDatosPaciente.Controls.Add(this.label12);
            this.gbDatosPaciente.Controls.Add(this.label11);
            this.gbDatosPaciente.Controls.Add(this.txtNoIdentificacion);
            this.gbDatosPaciente.Controls.Add(this.txtTipoIdentificacion);
            this.gbDatosPaciente.Controls.Add(this.label10);
            this.gbDatosPaciente.Controls.Add(this.label9);
            this.gbDatosPaciente.Controls.Add(this.txtSala);
            this.gbDatosPaciente.Controls.Add(this.txtTelefono);
            this.gbDatosPaciente.Controls.Add(this.label8);
            this.gbDatosPaciente.Controls.Add(this.txtNombrePaciente);
            this.gbDatosPaciente.Controls.Add(this.label7);
            this.gbDatosPaciente.Controls.Add(this.txtTipoFacturacion);
            this.gbDatosPaciente.Controls.Add(this.label6);
            this.gbDatosPaciente.Location = new System.Drawing.Point(6, 130);
            this.gbDatosPaciente.Name = "gbDatosPaciente";
            this.gbDatosPaciente.Size = new System.Drawing.Size(878, 207);
            this.gbDatosPaciente.TabIndex = 10;
            this.gbDatosPaciente.TabStop = false;
            this.gbDatosPaciente.Text = "Datos del Paciente";
            this.gbDatosPaciente.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(81, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 25);
            this.label15.TabIndex = 50;
            this.label15.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.Silver;
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(176, 172);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(690, 30);
            this.txtComentario.TabIndex = 49;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(176, 143);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(690, 30);
            this.txtDireccion.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(98, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 25);
            this.label14.TabIndex = 47;
            this.label14.Text = "Dirección";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(571, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 30);
            this.txtEmail.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "Email";
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.Color.Silver;
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(175, 114);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(231, 30);
            this.txtSexo.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "No. Identificación";
            // 
            // txtNoIdentificacion
            // 
            this.txtNoIdentificacion.BackColor = System.Drawing.Color.Silver;
            this.txtNoIdentificacion.Enabled = false;
            this.txtNoIdentificacion.Location = new System.Drawing.Point(571, 84);
            this.txtNoIdentificacion.Name = "txtNoIdentificacion";
            this.txtNoIdentificacion.Size = new System.Drawing.Size(295, 30);
            this.txtNoIdentificacion.TabIndex = 41;
            // 
            // txtTipoIdentificacion
            // 
            this.txtTipoIdentificacion.BackColor = System.Drawing.Color.Silver;
            this.txtTipoIdentificacion.Enabled = false;
            this.txtTipoIdentificacion.Location = new System.Drawing.Point(175, 84);
            this.txtTipoIdentificacion.Name = "txtTipoIdentificacion";
            this.txtTipoIdentificacion.Size = new System.Drawing.Size(231, 30);
            this.txtTipoIdentificacion.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tipo de Identificacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Sala";
            // 
            // txtSala
            // 
            this.txtSala.BackColor = System.Drawing.Color.Silver;
            this.txtSala.Enabled = false;
            this.txtSala.Location = new System.Drawing.Point(571, 54);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(295, 30);
            this.txtSala.TabIndex = 37;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(175, 54);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(231, 30);
            this.txtTelefono.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefono";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.BackColor = System.Drawing.Color.Silver;
            this.txtNombrePaciente.Enabled = false;
            this.txtNombrePaciente.Location = new System.Drawing.Point(571, 25);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(295, 30);
            this.txtNombrePaciente.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nombre de Paciente";
            // 
            // txtTipoFacturacion
            // 
            this.txtTipoFacturacion.Enabled = false;
            this.txtTipoFacturacion.Location = new System.Drawing.Point(175, 25);
            this.txtTipoFacturacion.Name = "txtTipoFacturacion";
            this.txtTipoFacturacion.Size = new System.Drawing.Size(231, 30);
            this.txtTipoFacturacion.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tipo de Facturación";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(9, 582);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(227, 36);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Registros");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(411, 102);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(105, 30);
            this.txtReferencia.TabIndex = 9;
            this.txtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferencia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Referencia";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(171, 102);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(105, 30);
            this.txtNumeroFactura.TabIndex = 7;
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferencia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero de Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Centro de Salud";
            // 
            // ddlMedico
            // 
            this.ddlMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMedico.FormattingEnabled = true;
            this.ddlMedico.Location = new System.Drawing.Point(800, 31);
            this.ddlMedico.Name = "ddlMedico";
            this.ddlMedico.Size = new System.Drawing.Size(274, 33);
            this.ddlMedico.TabIndex = 3;
            this.ddlMedico.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ddlCentroSalud
            // 
            this.ddlCentroSalud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlCentroSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCentroSalud.FormattingEnabled = true;
            this.ddlCentroSalud.Location = new System.Drawing.Point(411, 29);
            this.ddlCentroSalud.Name = "ddlCentroSalud";
            this.ddlCentroSalud.Size = new System.Drawing.Size(317, 33);
            this.ddlCentroSalud.TabIndex = 2;
            this.ddlCentroSalud.SelectedIndexChanged += new System.EventHandler(this.ddlCentroSalud_SelectedIndexChanged);
            // 
            // txtFechaCirugia
            // 
            this.txtFechaCirugia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaCirugia.Location = new System.Drawing.Point(152, 30);
            this.txtFechaCirugia.Name = "txtFechaCirugia";
            this.txtFechaCirugia.Size = new System.Drawing.Size(125, 30);
            this.txtFechaCirugia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Cirugia";
            // 
            // ProgramacionCirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1108, 672);
            this.Controls.Add(this.gbProgramacionCirugia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramacionCirugias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramacionCirugias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramacionCirugias_FormClosing);
            this.Load += new System.EventHandler(this.ProgramacionCirugias_Load);
            this.gbProgramacionCirugia.ResumeLayout(false);
            this.gbProgramacionCirugia.PerformLayout();
            this.gbReferencia.ResumeLayout(false);
            this.gbReferencia.PerformLayout();
            this.gbProductosAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.gbDatosPaciente.ResumeLayout(false);
            this.gbDatosPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProgramacionCirugia;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlMedico;
        private System.Windows.Forms.ComboBox ddlCentroSalud;
        private System.Windows.Forms.DateTimePicker txtFechaCirugia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbEstatus;
        private System.Windows.Forms.ComboBox ddlEstatusCirugia;
        private System.Windows.Forms.GroupBox gbProductosAgregados;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.GroupBox gbDatosPaciente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtComentario;
        private System.Windows.Forms.MaskedTextBox txtDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtSexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtNoIdentificacion;
        private System.Windows.Forms.MaskedTextBox txtTipoIdentificacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoFacturacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCompletarRegistro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbBuscarPorNumeroReferencia;
        private System.Windows.Forms.RadioButton rbBuscarPorNumeroFactura;
        private System.Windows.Forms.GroupBox gbReferencia;
        private System.Windows.Forms.Label lbNumeroReferencia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbNumeroFactura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNumeroFactura;
    }
}