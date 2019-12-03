namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa
{
    partial class ARSMantenimiento
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.txtdESCRIPCION = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(380, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 49);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Location = new System.Drawing.Point(12, 396);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(187, 49);
            this.btnAccion.TabIndex = 12;
            this.btnAccion.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnAccion, "Guardar la Operación");
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtcorreo);
            this.gbDatos.Controls.Add(this.txttelefono);
            this.gbDatos.Controls.Add(this.txtRNC);
            this.gbDatos.Controls.Add(this.txtRepresentante);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.cbEstatus);
            this.gbDatos.Controls.Add(this.txtdESCRIPCION);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(509, 378);
            this.gbDatos.TabIndex = 11;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Mantenimiento de ARS";
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstatus.Location = new System.Drawing.Point(228, 333);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(93, 27);
            this.cbEstatus.TabIndex = 7;
            this.cbEstatus.Text = "Estatus";
            this.cbEstatus.UseVisualStyleBackColor = true;
            // 
            // txtdESCRIPCION
            // 
            this.txtdESCRIPCION.BackColor = System.Drawing.Color.Silver;
            this.txtdESCRIPCION.Location = new System.Drawing.Point(185, 34);
            this.txtdESCRIPCION.MaxLength = 100;
            this.txtdESCRIPCION.Name = "txtdESCRIPCION";
            this.txtdESCRIPCION.Size = new System.Drawing.Size(311, 32);
            this.txtdESCRIPCION.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Representante *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "RNC *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Direccion";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.BackColor = System.Drawing.Color.Silver;
            this.txtRepresentante.Location = new System.Drawing.Point(185, 72);
            this.txtRepresentante.MaxLength = 100;
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(311, 32);
            this.txtRepresentante.TabIndex = 13;
            // 
            // txtRNC
            // 
            this.txtRNC.BackColor = System.Drawing.Color.Silver;
            this.txtRNC.Location = new System.Drawing.Point(185, 110);
            this.txtRNC.MaxLength = 100;
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(311, 32);
            this.txtRNC.TabIndex = 14;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.Silver;
            this.txttelefono.Location = new System.Drawing.Point(185, 148);
            this.txttelefono.Mask = "(000)-000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(311, 32);
            this.txttelefono.TabIndex = 15;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.Silver;
            this.txtcorreo.Location = new System.Drawing.Point(185, 186);
            this.txtcorreo.MaxLength = 100;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(311, 32);
            this.txtcorreo.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(185, 224);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(311, 103);
            this.txtDireccion.TabIndex = 17;
            // 
            // ARSMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(531, 457);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ARSMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARSMantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ARSMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.ARSMantenimiento_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.TextBox txtdESCRIPCION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}