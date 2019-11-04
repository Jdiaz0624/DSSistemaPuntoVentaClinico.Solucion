namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad
{
    partial class MantenimientoUsuarios
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
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPerfil = new System.Windows.Forms.ComboBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(439, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClaveSeguridad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPersona);
            this.groupBox1.Controls.Add(this.txtConfirmar);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtPerfil);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.Location = new System.Drawing.Point(196, 234);
            this.txtClaveSeguridad.MaxLength = 20;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.Size = new System.Drawing.Size(256, 30);
            this.txtClaveSeguridad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Clave de seguridad";
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(139, 168);
            this.txtPersona.MaxLength = 100;
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(313, 30);
            this.txtPersona.TabIndex = 10;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(139, 134);
            this.txtConfirmar.MaxLength = 20;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(313, 30);
            this.txtConfirmar.TabIndex = 9;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(139, 101);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(313, 30);
            this.txtClave.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(139, 68);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(313, 30);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtPerfil
            // 
            this.txtPerfil.FormattingEnabled = true;
            this.txtPerfil.Location = new System.Drawing.Point(139, 32);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(313, 33);
            this.txtPerfil.TabIndex = 6;
            this.txtPerfil.Visible = false;
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatus.Location = new System.Drawing.Point(139, 204);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(96, 29);
            this.cbEstatus.TabIndex = 5;
            this.cbEstatus.Text = "Estatus";
            this.cbEstatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            this.label1.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(12, 343);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(466, 49);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Completar Operación";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(491, 404);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MantenimientoUsuarios";
            this.Text = "MantenimientoUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox txtPerfil;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
    }
}