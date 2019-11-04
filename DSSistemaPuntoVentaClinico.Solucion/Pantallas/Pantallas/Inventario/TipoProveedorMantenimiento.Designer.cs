namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    partial class TipoProveedorMantenimiento
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoProveedor = new System.Windows.Forms.TextBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cbEstatus);
            this.gbDatos.Controls.Add(this.txtTipoProveedor);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(509, 104);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Tipo de Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // txtTipoProveedor
            // 
            this.txtTipoProveedor.BackColor = System.Drawing.Color.Silver;
            this.txtTipoProveedor.Location = new System.Drawing.Point(138, 34);
            this.txtTipoProveedor.MaxLength = 100;
            this.txtTipoProveedor.Name = "txtTipoProveedor";
            this.txtTipoProveedor.Size = new System.Drawing.Size(358, 32);
            this.txtTipoProveedor.TabIndex = 1;
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstatus.Location = new System.Drawing.Point(138, 72);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(93, 27);
            this.cbEstatus.TabIndex = 7;
            this.cbEstatus.Text = "Estatus";
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(380, 122);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 49);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar Pantalla");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Location = new System.Drawing.Point(12, 122);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(187, 49);
            this.btnAccion.TabIndex = 6;
            this.btnAccion.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnAccion, "Guardar la operación");
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // TipoProveedorMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(534, 184);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoProveedorMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoProveedorMantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TipoProveedorMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.TipoProveedorMantenimiento_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtTipoProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnAccion;
    }
}