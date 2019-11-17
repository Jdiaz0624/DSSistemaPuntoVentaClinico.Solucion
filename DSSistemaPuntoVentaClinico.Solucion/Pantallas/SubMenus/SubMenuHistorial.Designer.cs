namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    partial class SubMenuHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuHistorial));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnHistorialFinanciamientos = new System.Windows.Forms.Button();
            this.HistorialCotizaciones = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnHistorialFinanciamientos);
            this.gbOpciones.Controls.Add(this.HistorialCotizaciones);
            this.gbOpciones.Controls.Add(this.btnHistorialVentas);
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(723, 111);
            this.gbOpciones.TabIndex = 10;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Historial - Seleccionar Opcion";
            // 
            // btnHistorialFinanciamientos
            // 
            this.btnHistorialFinanciamientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialFinanciamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialFinanciamientos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialFinanciamientos.Location = new System.Drawing.Point(478, 29);
            this.btnHistorialFinanciamientos.Name = "btnHistorialFinanciamientos";
            this.btnHistorialFinanciamientos.Size = new System.Drawing.Size(230, 68);
            this.btnHistorialFinanciamientos.TabIndex = 2;
            this.btnHistorialFinanciamientos.Text = "Historial de Financiamiento";
            this.toolTip1.SetToolTip(this.btnHistorialFinanciamientos, "Mostrar el Historial de Financiamientos");
            this.btnHistorialFinanciamientos.UseVisualStyleBackColor = true;
            // 
            // HistorialCotizaciones
            // 
            this.HistorialCotizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistorialCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistorialCotizaciones.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistorialCotizaciones.Location = new System.Drawing.Point(242, 29);
            this.HistorialCotizaciones.Name = "HistorialCotizaciones";
            this.HistorialCotizaciones.Size = new System.Drawing.Size(230, 68);
            this.HistorialCotizaciones.TabIndex = 1;
            this.HistorialCotizaciones.Text = "Historial de Cotizaciones";
            this.toolTip1.SetToolTip(this.HistorialCotizaciones, "Mostrar el Historial de Cotizaciones");
            this.HistorialCotizaciones.UseVisualStyleBackColor = true;
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialVentas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialVentas.Location = new System.Drawing.Point(6, 29);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Size = new System.Drawing.Size(230, 68);
            this.btnHistorialVentas.TabIndex = 0;
            this.btnHistorialVentas.Text = "Historial de Ventas";
            this.toolTip1.SetToolTip(this.btnHistorialVentas, "Mostrar el Historial de Ventas");
            this.btnHistorialVentas.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(18, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SubMenuHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(786, 200);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubMenuHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuHistorial";
            this.Load += new System.EventHandler(this.SubMenuHistorial_Load);
            this.gbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnHistorialFinanciamientos;
        private System.Windows.Forms.Button HistorialCotizaciones;
        private System.Windows.Forms.Button btnHistorialVentas;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}