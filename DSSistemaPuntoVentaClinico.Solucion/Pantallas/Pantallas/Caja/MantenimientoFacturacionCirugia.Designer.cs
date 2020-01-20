namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja
{
    partial class MantenimientoFacturacionCirugia
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
            this.lbusuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFacturasSinCirugias = new System.Windows.Forms.RadioButton();
            this.rbFacturasConCirugias = new System.Windows.Forms.RadioButton();
            this.rbAmbosTiposFacturas = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbFiltrarPorRangoFecha = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lbusuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 69);
            this.panel1.TabIndex = 12;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(10, 14);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(64, 25);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(502, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 50);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(728, 16);
            this.lbusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(64, 25);
            this.lbusuario.TabIndex = 10;
            this.lbusuario.Text = "label1";
            this.lbusuario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAmbosTiposFacturas);
            this.groupBox1.Controls.Add(this.rbFacturasConCirugias);
            this.groupBox1.Controls.Add(this.rbFacturasSinCirugias);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Datos";
            // 
            // rbFacturasSinCirugias
            // 
            this.rbFacturasSinCirugias.AutoSize = true;
            this.rbFacturasSinCirugias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFacturasSinCirugias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbFacturasSinCirugias.Location = new System.Drawing.Point(7, 30);
            this.rbFacturasSinCirugias.Name = "rbFacturasSinCirugias";
            this.rbFacturasSinCirugias.Size = new System.Drawing.Size(205, 29);
            this.rbFacturasSinCirugias.TabIndex = 0;
            this.rbFacturasSinCirugias.TabStop = true;
            this.rbFacturasSinCirugias.Text = "Facturas sin Cirugia";
            this.toolTip1.SetToolTip(this.rbFacturasSinCirugias, "Mostrar el listado de las facturas que no tienen cirugias programadas");
            this.rbFacturasSinCirugias.UseVisualStyleBackColor = true;
            // 
            // rbFacturasConCirugias
            // 
            this.rbFacturasConCirugias.AutoSize = true;
            this.rbFacturasConCirugias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFacturasConCirugias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbFacturasConCirugias.Location = new System.Drawing.Point(218, 30);
            this.rbFacturasConCirugias.Name = "rbFacturasConCirugias";
            this.rbFacturasConCirugias.Size = new System.Drawing.Size(222, 29);
            this.rbFacturasConCirugias.TabIndex = 1;
            this.rbFacturasConCirugias.TabStop = true;
            this.rbFacturasConCirugias.Text = "Facturas con Cirugias";
            this.toolTip1.SetToolTip(this.rbFacturasConCirugias, "Mostrar el listado de las facturas con cirugias programadas");
            this.rbFacturasConCirugias.UseVisualStyleBackColor = true;
            // 
            // rbAmbosTiposFacturas
            // 
            this.rbAmbosTiposFacturas.AutoSize = true;
            this.rbAmbosTiposFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAmbosTiposFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbAmbosTiposFacturas.Location = new System.Drawing.Point(446, 30);
            this.rbAmbosTiposFacturas.Name = "rbAmbosTiposFacturas";
            this.rbAmbosTiposFacturas.Size = new System.Drawing.Size(94, 29);
            this.rbAmbosTiposFacturas.TabIndex = 2;
            this.rbAmbosTiposFacturas.TabStop = true;
            this.rbAmbosTiposFacturas.Text = "Ambos";
            this.toolTip1.SetToolTip(this.rbAmbosTiposFacturas, "Mostrar el listado de todas las facturas");
            this.rbAmbosTiposFacturas.UseVisualStyleBackColor = true;
            // 
            // cbFiltrarPorRangoFecha
            // 
            this.cbFiltrarPorRangoFecha.AutoSize = true;
            this.cbFiltrarPorRangoFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarPorRangoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFiltrarPorRangoFecha.Location = new System.Drawing.Point(22, 154);
            this.cbFiltrarPorRangoFecha.Name = "cbFiltrarPorRangoFecha";
            this.cbFiltrarPorRangoFecha.Size = new System.Drawing.Size(247, 29);
            this.cbFiltrarPorRangoFecha.TabIndex = 14;
            this.cbFiltrarPorRangoFecha.Text = "Filtrar por rango de fecha";
            this.toolTip1.SetToolTip(this.cbFiltrarPorRangoFecha, "Filtrar por rango de fecha");
            this.cbFiltrarPorRangoFecha.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 92);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(141, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(166, 30);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Generar";
            this.toolTip1.SetToolTip(this.button2, "Generar Reporte");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MantenimientoFacturacionCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(573, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbFiltrarPorRangoFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MantenimientoFacturacionCirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoFacturacionCirugia";
            this.Load += new System.EventHandler(this.MantenimientoFacturacionCirugia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAmbosTiposFacturas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbFacturasConCirugias;
        private System.Windows.Forms.RadioButton rbFacturasSinCirugias;
        private System.Windows.Forms.CheckBox cbFiltrarPorRangoFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}