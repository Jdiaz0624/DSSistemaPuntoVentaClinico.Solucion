namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    partial class SubMenuFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuFacturacion));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnFinanciamiento = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.lbUsuario);
            this.gbOpciones.Controls.Add(this.button1);
            this.gbOpciones.Controls.Add(this.btnCotizacion);
            this.gbOpciones.Controls.Add(this.btnFinanciamiento);
            this.gbOpciones.Controls.Add(this.btnFacturacion);
            this.gbOpciones.Location = new System.Drawing.Point(12, 44);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(722, 108);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Facturación - Seleccionar Opcion";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(610, 126);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 25);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "label1";
            this.lbUsuario.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tipo de Pago";
            this.toolTip1.SetToolTip(this.button1, "Cotización");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.Location = new System.Drawing.Point(478, 29);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(230, 68);
            this.btnCotizacion.TabIndex = 2;
            this.btnCotizacion.Text = "Historial de Facturación";
            this.toolTip1.SetToolTip(this.btnCotizacion, "Cotización");
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // btnFinanciamiento
            // 
            this.btnFinanciamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanciamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanciamiento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanciamiento.Location = new System.Drawing.Point(478, 103);
            this.btnFinanciamiento.Name = "btnFinanciamiento";
            this.btnFinanciamiento.Size = new System.Drawing.Size(230, 68);
            this.btnFinanciamiento.TabIndex = 1;
            this.btnFinanciamiento.Text = "Programación";
            this.toolTip1.SetToolTip(this.btnFinanciamiento, "Financiamiento de Equipos");
            this.btnFinanciamiento.UseVisualStyleBackColor = true;
            this.btnFinanciamiento.Visible = false;
            this.btnFinanciamiento.Click += new System.EventHandler(this.btnFinanciamiento_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(6, 29);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(230, 68);
            this.btnFacturacion.TabIndex = 0;
            this.btnFacturacion.Text = "Facturacion";
            this.toolTip1.SetToolTip(this.btnFacturacion, "Facturación");
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(705, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Salir del Sistema");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(3, 7);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(64, 25);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 38);
            this.panel1.TabIndex = 15;
            // 
            // SubMenuFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(744, 161);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubMenuFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuFacturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubMenuFacturacion_FormClosing);
            this.Load += new System.EventHandler(this.SubMenuFacturacion_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Button btnFinanciamiento;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
    }
}