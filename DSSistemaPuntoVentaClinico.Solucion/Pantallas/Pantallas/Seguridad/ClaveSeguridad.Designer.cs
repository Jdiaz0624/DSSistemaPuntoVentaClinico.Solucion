namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad
{
    partial class ClaveSeguridad
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
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.lbClaveSeguridad = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMantenimiento.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.label3);
            this.gbMantenimiento.Controls.Add(this.txtConfirmarClave);
            this.gbMantenimiento.Controls.Add(this.cbEstatus);
            this.gbMantenimiento.Controls.Add(this.txtClave);
            this.gbMantenimiento.Controls.Add(this.txtUsuario);
            this.gbMantenimiento.Controls.Add(this.label2);
            this.gbMantenimiento.Controls.Add(this.label1);
            this.gbMantenimiento.Location = new System.Drawing.Point(13, 54);
            this.gbMantenimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMantenimiento.Size = new System.Drawing.Size(413, 144);
            this.gbMantenimiento.TabIndex = 0;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Controles";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(83, 50);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(319, 26);
            this.txtClave.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtUsuario.FormattingEnabled = true;
            this.txtUsuario.Location = new System.Drawing.Point(83, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(319, 28);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1004, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.lbClaveSeguridad);
            this.gbOpciones.Controls.Add(this.txtClaveSeguridad);
            this.gbOpciones.Controls.Add(this.btnDeshabilitar);
            this.gbOpciones.Controls.Add(this.btnModificar);
            this.gbOpciones.Controls.Add(this.btnRestablecer);
            this.gbOpciones.Controls.Add(this.btnNuevo);
            this.gbOpciones.Controls.Add(this.btnConsultar);
            this.gbOpciones.Location = new System.Drawing.Point(433, 54);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(612, 144);
            this.gbOpciones.TabIndex = 20;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // lbClaveSeguridad
            // 
            this.lbClaveSeguridad.AutoSize = true;
            this.lbClaveSeguridad.Location = new System.Drawing.Point(175, 96);
            this.lbClaveSeguridad.Name = "lbClaveSeguridad";
            this.lbClaveSeguridad.Size = new System.Drawing.Size(48, 20);
            this.lbClaveSeguridad.TabIndex = 4;
            this.lbClaveSeguridad.Text = "Clave";
            this.lbClaveSeguridad.Visible = false;
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Location = new System.Drawing.Point(227, 93);
            this.txtClaveSeguridad.MaxLength = 100;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.Size = new System.Drawing.Size(271, 26);
            this.txtClaveSeguridad.TabIndex = 4;
            this.txtClaveSeguridad.Visible = false;
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
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(336, 506);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 26);
            this.txtNumeroRegistros.TabIndex = 29;
            this.txtNumeroRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbNumeroRegistros
            // 
            this.lbNumeroRegistros.AutoSize = true;
            this.lbNumeroRegistros.Location = new System.Drawing.Point(231, 509);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(101, 20);
            this.lbNumeroRegistros.TabIndex = 28;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(120, 508);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 26);
            this.txtNumeroPagina.TabIndex = 27;
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Location = new System.Drawing.Point(34, 511);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(82, 20);
            this.lbNumeroPagina.TabIndex = 26;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dtListado);
            this.gbListado.Location = new System.Drawing.Point(13, 202);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(1032, 298);
            this.gbListado.TabIndex = 25;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Claves";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dtListado.Location = new System.Drawing.Point(3, 22);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1026, 273);
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
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Location = new System.Drawing.Point(83, 115);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(83, 24);
            this.cbEstatus.TabIndex = 4;
            this.cbEstatus.Text = "Estatus";
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.Visible = false;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
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
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(83, 79);
            this.txtConfirmarClave.MaxLength = 20;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(319, 26);
            this.txtConfirmarClave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar";
            // 
            // ClaveSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1055, 546);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbMantenimiento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClaveSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaveSeguridad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClaveSeguridad_FormClosing);
            this.Load += new System.EventHandler(this.ClaveSeguridad_Load);
            this.gbMantenimiento.ResumeLayout(false);
            this.gbMantenimiento.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Label lbClaveSeguridad;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarClave;
    }
}