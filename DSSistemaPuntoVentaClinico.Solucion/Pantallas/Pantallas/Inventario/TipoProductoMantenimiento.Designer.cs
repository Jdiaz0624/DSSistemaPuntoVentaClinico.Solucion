namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    partial class TipoProductoMantenimiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.txtTipoProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Tipo de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.BackColor = System.Drawing.Color.Silver;
            this.txtTipoProducto.Location = new System.Drawing.Point(130, 43);
            this.txtTipoProducto.MaxLength = 100;
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(266, 30);
            this.txtTipoProducto.TabIndex = 1;
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstatus.Location = new System.Drawing.Point(130, 80);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(95, 29);
            this.cbEstatus.TabIndex = 2;
            this.cbEstatus.Text = "Estatus";
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(289, 139);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 49);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Location = new System.Drawing.Point(12, 139);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(187, 49);
            this.btnAccion.TabIndex = 11;
            this.btnAccion.Text = "Guardar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // TipoProductoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(444, 200);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TipoProductoMantenimiento";
            this.Text = "TipoProductoMantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TipoProductoMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.TipoProductoMantenimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnAccion;
    }
}