namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion
{
    partial class GastoCirugia
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbDatosGastos = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.ddlEstatusCirugia = new System.Windows.Forms.ComboBox();
            this.lbEstatusCirugia = new System.Windows.Forms.Label();
            this.cbModificarEsatusCirugia = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.txtcantodad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbDatosGastos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 43);
            this.panel1.TabIndex = 48;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(12, 19);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(64, 25);
            this.lbTitulo.TabIndex = 48;
            this.lbTitulo.Text = "label6";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(860, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbDatosGastos
            // 
            this.gbDatosGastos.Controls.Add(this.btnCambiar);
            this.gbDatosGastos.Controls.Add(this.ddlEstatusCirugia);
            this.gbDatosGastos.Controls.Add(this.lbEstatusCirugia);
            this.gbDatosGastos.Controls.Add(this.cbModificarEsatusCirugia);
            this.gbDatosGastos.Controls.Add(this.button2);
            this.gbDatosGastos.Controls.Add(this.btnRestablecer);
            this.gbDatosGastos.Controls.Add(this.btnQuitar);
            this.gbDatosGastos.Controls.Add(this.btnModificar);
            this.gbDatosGastos.Controls.Add(this.btnGuardar);
            this.gbDatosGastos.Controls.Add(this.txtcomentario);
            this.gbDatosGastos.Controls.Add(this.txtcantodad);
            this.gbDatosGastos.Controls.Add(this.txtDescripcion);
            this.gbDatosGastos.Controls.Add(this.label3);
            this.gbDatosGastos.Controls.Add(this.label2);
            this.gbDatosGastos.Controls.Add(this.label1);
            this.gbDatosGastos.Location = new System.Drawing.Point(12, 78);
            this.gbDatosGastos.Name = "gbDatosGastos";
            this.gbDatosGastos.Size = new System.Drawing.Size(888, 204);
            this.gbDatosGastos.TabIndex = 49;
            this.gbDatosGastos.TabStop = false;
            this.gbDatosGastos.Text = "Dato de Gastos";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Location = new System.Drawing.Point(736, 143);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(141, 49);
            this.btnCambiar.TabIndex = 14;
            this.btnCambiar.Text = "Cambiar";
            this.toolTip1.SetToolTip(this.btnCambiar, "Modificar Estatus de Cirugia");
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Visible = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // ddlEstatusCirugia
            // 
            this.ddlEstatusCirugia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlEstatusCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEstatusCirugia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlEstatusCirugia.FormattingEnabled = true;
            this.ddlEstatusCirugia.Location = new System.Drawing.Point(404, 151);
            this.ddlEstatusCirugia.Name = "ddlEstatusCirugia";
            this.ddlEstatusCirugia.Size = new System.Drawing.Size(326, 33);
            this.ddlEstatusCirugia.TabIndex = 13;
            this.ddlEstatusCirugia.Visible = false;
            // 
            // lbEstatusCirugia
            // 
            this.lbEstatusCirugia.AutoSize = true;
            this.lbEstatusCirugia.Location = new System.Drawing.Point(213, 155);
            this.lbEstatusCirugia.Name = "lbEstatusCirugia";
            this.lbEstatusCirugia.Size = new System.Drawing.Size(185, 25);
            this.lbEstatusCirugia.TabIndex = 12;
            this.lbEstatusCirugia.Text = "Seleccionar Estatus";
            this.lbEstatusCirugia.Visible = false;
            // 
            // cbModificarEsatusCirugia
            // 
            this.cbModificarEsatusCirugia.AutoSize = true;
            this.cbModificarEsatusCirugia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbModificarEsatusCirugia.Location = new System.Drawing.Point(25, 151);
            this.cbModificarEsatusCirugia.Name = "cbModificarEsatusCirugia";
            this.cbModificarEsatusCirugia.Size = new System.Drawing.Size(180, 29);
            this.cbModificarEsatusCirugia.TabIndex = 11;
            this.cbModificarEsatusCirugia.Text = "Modificar Estatus";
            this.cbModificarEsatusCirugia.UseVisualStyleBackColor = true;
            this.cbModificarEsatusCirugia.CheckedChanged += new System.EventHandler(this.cbModificarEsatusCirugia_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(589, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reporte";
            this.toolTip1.SetToolTip(this.button2, "Imprimir la hoja de gastos");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.Enabled = false;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Location = new System.Drawing.Point(442, 82);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(141, 49);
            this.btnRestablecer.TabIndex = 9;
            this.btnRestablecer.Text = "Restablecer";
            this.toolTip1.SetToolTip(this.btnRestablecer, "Restablecer Pantalla");
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(736, 27);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(141, 49);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btnQuitar, "Quitar Registros Seleccionado");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(589, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 49);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar Registros Seleccionado");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(442, 27);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 49);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar los datos ");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtcomentario
            // 
            this.txtcomentario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcomentario.Location = new System.Drawing.Point(136, 97);
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(279, 30);
            this.txtcomentario.TabIndex = 5;
            // 
            // txtcantodad
            // 
            this.txtcantodad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcantodad.Location = new System.Drawing.Point(136, 63);
            this.txtcantodad.Name = "txtcantodad";
            this.txtcantodad.Size = new System.Drawing.Size(279, 30);
            this.txtcantodad.TabIndex = 4;
            this.txtcantodad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantodad_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescripcion.Location = new System.Drawing.Point(136, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(279, 30);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 219);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Tipo de Pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(334, 506);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 30);
            this.txtNumeroRegistros.TabIndex = 54;
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
            this.lbNumeroRegistros.Location = new System.Drawing.Point(207, 508);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(123, 25);
            this.lbNumeroRegistros.TabIndex = 53;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(118, 508);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 30);
            this.txtNumeroPagina.TabIndex = 52;
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
            this.lbNumeroPagina.Location = new System.Drawing.Point(12, 510);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(103, 25);
            this.lbNumeroPagina.TabIndex = 51;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estatus de Cirugia";
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Location = new System.Drawing.Point(596, 513);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(171, 25);
            this.lbEstatus.TabIndex = 55;
            this.lbEstatus.Text = "Estatus de Cirugia";
            // 
            // GastoCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(911, 553);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDatosGastos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GastoCirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastoCirugia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GastoCirugia_FormClosing);
            this.Load += new System.EventHandler(this.GastoCirugia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbDatosGastos.ResumeLayout(false);
            this.gbDatosGastos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbDatosGastos;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.TextBox txtcantodad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.ComboBox ddlEstatusCirugia;
        private System.Windows.Forms.Label lbEstatusCirugia;
        private System.Windows.Forms.CheckBox cbModificarEsatusCirugia;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEstatus;
    }
}