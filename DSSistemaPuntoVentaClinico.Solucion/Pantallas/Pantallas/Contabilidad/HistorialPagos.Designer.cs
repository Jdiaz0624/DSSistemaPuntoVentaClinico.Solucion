namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad
{
    partial class HistorialPagos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.cbRangoFecha = new System.Windows.Forms.CheckBox();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.Recibo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 42);
            this.panel1.TabIndex = 3;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(22, 14);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(64, 25);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(613, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 34);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFactura);
            this.groupBox1.Controls.Add(this.txtRecibo);
            this.groupBox1.Controls.Add(this.cbRangoFecha);
            this.groupBox1.Controls.Add(this.txtFechaHasta);
            this.groupBox1.Controls.Add(this.txtFechaDesde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRNC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recibos - Filtros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Recibo";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(76, 89);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(246, 30);
            this.txtFactura.TabIndex = 11;
            this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibo_KeyPress);
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(76, 61);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(246, 30);
            this.txtRecibo.TabIndex = 10;
            this.txtRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibo_KeyPress);
            // 
            // cbRangoFecha
            // 
            this.cbRangoFecha.AutoSize = true;
            this.cbRangoFecha.Location = new System.Drawing.Point(115, 174);
            this.cbRangoFecha.Name = "cbRangoFecha";
            this.cbRangoFecha.Size = new System.Drawing.Size(178, 29);
            this.cbRangoFecha.TabIndex = 9;
            this.cbRangoFecha.Text = "Rango de Fecha";
            this.cbRangoFecha.UseVisualStyleBackColor = true;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(115, 145);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(123, 30);
            this.txtFechaHasta.TabIndex = 8;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(115, 117);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(123, 30);
            this.txtFechaDesde.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Desde";
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(76, 33);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(246, 30);
            this.txtRNC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RNC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Location = new System.Drawing.Point(349, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 199);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(153, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(6, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(141, 49);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtListado);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 285);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recibo});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 26);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.Size = new System.Drawing.Size(638, 256);
            this.dtListado.TabIndex = 0;
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(336, 542);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 30);
            this.txtNumeroRegistros.TabIndex = 22;
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
            this.lbNumeroRegistros.Location = new System.Drawing.Point(209, 544);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(123, 25);
            this.lbNumeroRegistros.TabIndex = 21;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(120, 544);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 30);
            this.txtNumeroPagina.TabIndex = 20;
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
            this.lbNumeroPagina.Location = new System.Drawing.Point(14, 546);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(103, 25);
            this.lbNumeroPagina.TabIndex = 19;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // Recibo
            // 
            this.Recibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Recibo.HeaderText = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.ReadOnly = true;
            this.Recibo.Text = "Recibo";
            this.Recibo.ToolTipText = "Recibo";
            this.Recibo.Width = 78;
            // 
            // HistorialPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(668, 578);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistorialPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialPagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistorialPagos_FormClosing);
            this.Load += new System.EventHandler(this.HistorialPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRangoFecha;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.DataGridViewButtonColumn Recibo;
    }
}