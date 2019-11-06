namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    partial class SubMenuConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuConfiguracion));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnInformacionEmpresa = new System.Windows.Forms.Button();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.btnComprobantes = new System.Windows.Forms.Button();
            this.btnCorreos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnInformacionEmpresa);
            this.gbOpciones.Controls.Add(this.btnSecuencial);
            this.gbOpciones.Controls.Add(this.btnComprobantes);
            this.gbOpciones.Controls.Add(this.btnCorreos);
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(723, 181);
            this.gbOpciones.TabIndex = 14;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Configuración - Seleccionar Opcion";
            // 
            // btnInformacionEmpresa
            // 
            this.btnInformacionEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacionEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionEmpresa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacionEmpresa.Location = new System.Drawing.Point(6, 103);
            this.btnInformacionEmpresa.Name = "btnInformacionEmpresa";
            this.btnInformacionEmpresa.Size = new System.Drawing.Size(230, 68);
            this.btnInformacionEmpresa.TabIndex = 3;
            this.btnInformacionEmpresa.Text = "Información de Empresa";
            this.toolTip1.SetToolTip(this.btnInformacionEmpresa, "Configuración de la Informacion de la Empresa");
            this.btnInformacionEmpresa.UseVisualStyleBackColor = true;
            this.btnInformacionEmpresa.Click += new System.EventHandler(this.btnInformacionEmpresa_Click);
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecuencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecuencial.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecuencial.Location = new System.Drawing.Point(478, 29);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(230, 68);
            this.btnSecuencial.TabIndex = 2;
            this.btnSecuencial.Text = "Secuencial";
            this.toolTip1.SetToolTip(this.btnSecuencial, "Mostrar el Secuencial de las pantallas");
            this.btnSecuencial.UseVisualStyleBackColor = true;
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobantes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantes.Location = new System.Drawing.Point(242, 29);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Size = new System.Drawing.Size(230, 68);
            this.btnComprobantes.TabIndex = 1;
            this.btnComprobantes.Text = "Comprobantes";
            this.toolTip1.SetToolTip(this.btnComprobantes, "Configuración de Comprobantes Fiscales");
            this.btnComprobantes.UseVisualStyleBackColor = true;
            // 
            // btnCorreos
            // 
            this.btnCorreos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorreos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorreos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreos.Location = new System.Drawing.Point(6, 29);
            this.btnCorreos.Name = "btnCorreos";
            this.btnCorreos.Size = new System.Drawing.Size(230, 68);
            this.btnCorreos.TabIndex = 0;
            this.btnCorreos.Text = "Correos";
            this.toolTip1.SetToolTip(this.btnCorreos, "Configuración de Correos Electronicos");
            this.btnCorreos.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SubMenuConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(756, 260);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubMenuConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuConfiguracion";
            this.Load += new System.EventHandler(this.SubMenuConfiguracion_Load);
            this.gbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnInformacionEmpresa;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.Button btnComprobantes;
        private System.Windows.Forms.Button btnCorreos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}