namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    partial class SecuencialComprobantes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtComprobantes = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gnConfiguracion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.txtSecuencial = new System.Windows.Forms.TextBox();
            this.txtSecuenciaInicial = new System.Windows.Forms.TextBox();
            this.txtSecuenciaFinal = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtValidoHasta = new System.Windows.Forms.TextBox();
            this.txtPociciones = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRestabelcer = new System.Windows.Forms.Button();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.cbPorDefecto = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtComprobantes)).BeginInit();
            this.gnConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(933, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(13, 10);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(64, 25);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtComprobantes);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Comprobantes";
            // 
            // dtComprobantes
            // 
            this.dtComprobantes.AllowUserToAddRows = false;
            this.dtComprobantes.AllowUserToDeleteRows = false;
            this.dtComprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtComprobantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtComprobantes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtComprobantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtComprobantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtComprobantes.Location = new System.Drawing.Point(3, 26);
            this.dtComprobantes.Name = "dtComprobantes";
            this.dtComprobantes.ReadOnly = true;
            this.dtComprobantes.RowTemplate.Height = 24;
            this.dtComprobantes.Size = new System.Drawing.Size(953, 300);
            this.dtComprobantes.TabIndex = 0;
            this.dtComprobantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtComprobantes_CellContentClick);
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
            this.Select.Width = 73;
            // 
            // gnConfiguracion
            // 
            this.gnConfiguracion.Controls.Add(this.label10);
            this.gnConfiguracion.Controls.Add(this.txtClaveSeguridad);
            this.gnConfiguracion.Controls.Add(this.cbPorDefecto);
            this.gnConfiguracion.Controls.Add(this.cbEstatus);
            this.gnConfiguracion.Controls.Add(this.btnRestabelcer);
            this.gnConfiguracion.Controls.Add(this.btnGuardar);
            this.gnConfiguracion.Controls.Add(this.txtPociciones);
            this.gnConfiguracion.Controls.Add(this.txtValidoHasta);
            this.gnConfiguracion.Controls.Add(this.txtLimite);
            this.gnConfiguracion.Controls.Add(this.txtSecuenciaFinal);
            this.gnConfiguracion.Controls.Add(this.txtSecuenciaInicial);
            this.gnConfiguracion.Controls.Add(this.txtSecuencial);
            this.gnConfiguracion.Controls.Add(this.txtTipoComprobante);
            this.gnConfiguracion.Controls.Add(this.txtSerie);
            this.gnConfiguracion.Controls.Add(this.txtDescripcion);
            this.gnConfiguracion.Controls.Add(this.label9);
            this.gnConfiguracion.Controls.Add(this.label8);
            this.gnConfiguracion.Controls.Add(this.label7);
            this.gnConfiguracion.Controls.Add(this.label6);
            this.gnConfiguracion.Controls.Add(this.label5);
            this.gnConfiguracion.Controls.Add(this.label4);
            this.gnConfiguracion.Controls.Add(this.label3);
            this.gnConfiguracion.Controls.Add(this.label2);
            this.gnConfiguracion.Controls.Add(this.label1);
            this.gnConfiguracion.Location = new System.Drawing.Point(12, 387);
            this.gnConfiguracion.Name = "gnConfiguracion";
            this.gnConfiguracion.Size = new System.Drawing.Size(956, 365);
            this.gnConfiguracion.TabIndex = 2;
            this.gnConfiguracion.TabStop = false;
            this.gnConfiguracion.Text = "Configuración De Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Comprobante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secuencial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Secuencia Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Secuencia Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Limite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valido Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pocisiones";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.LightGray;
            this.txtDescripcion.Location = new System.Drawing.Point(220, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(463, 30);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.LightGray;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(220, 61);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(463, 30);
            this.txtSerie.TabIndex = 10;
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.BackColor = System.Drawing.Color.LightGray;
            this.txtTipoComprobante.Enabled = false;
            this.txtTipoComprobante.Location = new System.Drawing.Point(220, 93);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(463, 30);
            this.txtTipoComprobante.TabIndex = 11;
            // 
            // txtSecuencial
            // 
            this.txtSecuencial.BackColor = System.Drawing.Color.LightGray;
            this.txtSecuencial.Location = new System.Drawing.Point(220, 126);
            this.txtSecuencial.Name = "txtSecuencial";
            this.txtSecuencial.Size = new System.Drawing.Size(463, 30);
            this.txtSecuencial.TabIndex = 12;
            this.txtSecuencial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencial_KeyPress);
            // 
            // txtSecuenciaInicial
            // 
            this.txtSecuenciaInicial.BackColor = System.Drawing.Color.LightGray;
            this.txtSecuenciaInicial.Location = new System.Drawing.Point(220, 159);
            this.txtSecuenciaInicial.Name = "txtSecuenciaInicial";
            this.txtSecuenciaInicial.Size = new System.Drawing.Size(463, 30);
            this.txtSecuenciaInicial.TabIndex = 13;
            this.txtSecuenciaInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencial_KeyPress);
            // 
            // txtSecuenciaFinal
            // 
            this.txtSecuenciaFinal.BackColor = System.Drawing.Color.LightGray;
            this.txtSecuenciaFinal.Location = new System.Drawing.Point(220, 192);
            this.txtSecuenciaFinal.Name = "txtSecuenciaFinal";
            this.txtSecuenciaFinal.Size = new System.Drawing.Size(463, 30);
            this.txtSecuenciaFinal.TabIndex = 14;
            this.txtSecuenciaFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencial_KeyPress);
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.LightGray;
            this.txtLimite.Location = new System.Drawing.Point(220, 225);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(463, 30);
            this.txtLimite.TabIndex = 15;
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencial_KeyPress);
            // 
            // txtValidoHasta
            // 
            this.txtValidoHasta.BackColor = System.Drawing.Color.LightGray;
            this.txtValidoHasta.Location = new System.Drawing.Point(220, 258);
            this.txtValidoHasta.Name = "txtValidoHasta";
            this.txtValidoHasta.Size = new System.Drawing.Size(463, 30);
            this.txtValidoHasta.TabIndex = 16;
            // 
            // txtPociciones
            // 
            this.txtPociciones.BackColor = System.Drawing.Color.LightGray;
            this.txtPociciones.Enabled = false;
            this.txtPociciones.Location = new System.Drawing.Point(220, 291);
            this.txtPociciones.Name = "txtPociciones";
            this.txtPociciones.Size = new System.Drawing.Size(463, 30);
            this.txtPociciones.TabIndex = 17;
            this.txtPociciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencial_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(809, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 49);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Registro");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRestabelcer
            // 
            this.btnRestabelcer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestabelcer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestabelcer.Location = new System.Drawing.Point(809, 75);
            this.btnRestabelcer.Name = "btnRestabelcer";
            this.btnRestabelcer.Size = new System.Drawing.Size(141, 49);
            this.btnRestabelcer.TabIndex = 19;
            this.btnRestabelcer.Text = "Restablecer";
            this.toolTip1.SetToolTip(this.btnRestabelcer, "Restablecer Pantalla");
            this.btnRestabelcer.UseVisualStyleBackColor = true;
            this.btnRestabelcer.Click += new System.EventHandler(this.btnRestabelcer_Click);
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatus.Location = new System.Drawing.Point(220, 326);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(96, 29);
            this.cbEstatus.TabIndex = 20;
            this.cbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.cbEstatus, "Estatus de Comprobante");
            this.cbEstatus.UseVisualStyleBackColor = true;
            // 
            // cbPorDefecto
            // 
            this.cbPorDefecto.AutoSize = true;
            this.cbPorDefecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPorDefecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPorDefecto.Location = new System.Drawing.Point(322, 326);
            this.cbPorDefecto.Name = "cbPorDefecto";
            this.cbPorDefecto.Size = new System.Drawing.Size(133, 29);
            this.cbPorDefecto.TabIndex = 21;
            this.cbPorDefecto.Text = "Por Defecto";
            this.toolTip1.SetToolTip(this.cbPorDefecto, "Asignar un Comprobante por defecto");
            this.cbPorDefecto.UseVisualStyleBackColor = true;
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.LightGray;
            this.txtClaveSeguridad.Location = new System.Drawing.Point(689, 289);
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.Size = new System.Drawing.Size(261, 30);
            this.txtClaveSeguridad.TabIndex = 22;
            this.txtClaveSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveSeguridad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Clave de Seguridad";
            // 
            // SecuencialComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 764);
            this.Controls.Add(this.gnConfiguracion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecuencialComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecuencialComprobantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecuencialComprobantes_FormClosing);
            this.Load += new System.EventHandler(this.SecuencialComprobantes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtComprobantes)).EndInit();
            this.gnConfiguracion.ResumeLayout(false);
            this.gnConfiguracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtComprobantes;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.GroupBox gnConfiguracion;
        private System.Windows.Forms.TextBox txtPociciones;
        private System.Windows.Forms.TextBox txtValidoHasta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSecuenciaFinal;
        private System.Windows.Forms.TextBox txtSecuenciaInicial;
        private System.Windows.Forms.TextBox txtSecuencial;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestabelcer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbPorDefecto;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
    }
}