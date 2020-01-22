namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    partial class SubMenuContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuContabilidad));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnControlApertura = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(696, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnControlApertura);
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(723, 261);
            this.gbOpciones.TabIndex = 10;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Contabilidad - Seleccionar Opcion";
            // 
            // btnControlApertura
            // 
            this.btnControlApertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlApertura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlApertura.Location = new System.Drawing.Point(6, 29);
            this.btnControlApertura.Name = "btnControlApertura";
            this.btnControlApertura.Size = new System.Drawing.Size(230, 68);
            this.btnControlApertura.TabIndex = 0;
            this.btnControlApertura.Text = "Control de Apertura";
            this.toolTip1.SetToolTip(this.btnControlApertura, "Mantenimiento de Control de Apertura");
            this.btnControlApertura.UseVisualStyleBackColor = true;
            this.btnControlApertura.Click += new System.EventHandler(this.btnControlApertura_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(3, 9);
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
            this.panel1.Size = new System.Drawing.Size(752, 44);
            this.panel1.TabIndex = 15;
            // 
            // SubMenuContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(752, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubMenuContabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuContabilidad";
            this.Load += new System.EventHandler(this.SubMenuContabilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnControlApertura;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
    }
}