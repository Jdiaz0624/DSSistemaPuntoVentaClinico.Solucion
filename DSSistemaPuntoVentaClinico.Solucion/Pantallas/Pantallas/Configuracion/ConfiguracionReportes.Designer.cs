﻿namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    partial class ConfiguracionReportes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbClaveSeguridad = new System.Windows.Forms.Label();
            this.txtclaveSeguridad = new System.Windows.Forms.TextBox();
            this.btnGuardarCredenciales = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.cbCredenciales = new System.Windows.Forms.CheckBox();
            this.btnRestabelcer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.txtRutaReporte = new System.Windows.Forms.TextBox();
            this.txtNombreReporte = new System.Windows.Forms.TextBox();
            this.lbRutaReporte = new System.Windows.Forms.Label();
            this.lbNombreReporte = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 47);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(986, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cerrar Pantalla");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(13, 10);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(51, 20);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 322);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Reportes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lbClaveSeguridad);
            this.groupBox2.Controls.Add(this.txtclaveSeguridad);
            this.groupBox2.Controls.Add(this.btnGuardarCredenciales);
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.lbClave);
            this.groupBox2.Controls.Add(this.lbUsuario);
            this.groupBox2.Controls.Add(this.cbCredenciales);
            this.groupBox2.Controls.Add(this.btnRestabelcer);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnBuscarRuta);
            this.groupBox2.Controls.Add(this.txtRutaReporte);
            this.groupBox2.Controls.Add(this.txtNombreReporte);
            this.groupBox2.Controls.Add(this.lbRutaReporte);
            this.groupBox2.Controls.Add(this.lbNombreReporte);
            this.groupBox2.Location = new System.Drawing.Point(6, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 331);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración de Reporte";
            this.toolTip1.SetToolTip(this.groupBox2, "Guardar la Credenciales de base de datos");
            // 
            // lbClaveSeguridad
            // 
            this.lbClaveSeguridad.AutoSize = true;
            this.lbClaveSeguridad.Location = new System.Drawing.Point(14, 275);
            this.lbClaveSeguridad.Name = "lbClaveSeguridad";
            this.lbClaveSeguridad.Size = new System.Drawing.Size(157, 20);
            this.lbClaveSeguridad.TabIndex = 18;
            this.lbClaveSeguridad.Text = "Clave de Seguridad *";
            this.lbClaveSeguridad.Visible = false;
            // 
            // txtclaveSeguridad
            // 
            this.txtclaveSeguridad.Location = new System.Drawing.Point(218, 272);
            this.txtclaveSeguridad.MaxLength = 50;
            this.txtclaveSeguridad.Name = "txtclaveSeguridad";
            this.txtclaveSeguridad.Size = new System.Drawing.Size(344, 26);
            this.txtclaveSeguridad.TabIndex = 17;
            this.txtclaveSeguridad.Visible = false;
            // 
            // btnGuardarCredenciales
            // 
            this.btnGuardarCredenciales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCredenciales.Location = new System.Drawing.Point(568, 205);
            this.btnGuardarCredenciales.Name = "btnGuardarCredenciales";
            this.btnGuardarCredenciales.Size = new System.Drawing.Size(141, 66);
            this.btnGuardarCredenciales.TabIndex = 16;
            this.btnGuardarCredenciales.Text = "Guardar Credenciales";
            this.toolTip1.SetToolTip(this.btnGuardarCredenciales, "Guardar Registros");
            this.btnGuardarCredenciales.UseVisualStyleBackColor = true;
            this.btnGuardarCredenciales.Visible = false;
            this.btnGuardarCredenciales.Click += new System.EventHandler(this.btnGuardarCredenciales_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(112, 238);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(450, 26);
            this.txtClave.TabIndex = 15;
            this.txtClave.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(112, 205);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(450, 26);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Visible = false;
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(30, 241);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(58, 20);
            this.lbClave.TabIndex = 13;
            this.lbClave.Text = "Clave *";
            this.lbClave.Visible = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(14, 208);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(74, 20);
            this.lbUsuario.TabIndex = 12;
            this.lbUsuario.Text = "Usuario *";
            this.lbUsuario.Visible = false;
            // 
            // cbCredenciales
            // 
            this.cbCredenciales.AutoSize = true;
            this.cbCredenciales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCredenciales.Location = new System.Drawing.Point(19, 170);
            this.cbCredenciales.Name = "cbCredenciales";
            this.cbCredenciales.Size = new System.Drawing.Size(315, 24);
            this.cbCredenciales.TabIndex = 11;
            this.cbCredenciales.Text = "Modificar Credenciales de Base de datos";
            this.cbCredenciales.UseVisualStyleBackColor = true;
            this.cbCredenciales.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnRestabelcer
            // 
            this.btnRestabelcer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestabelcer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestabelcer.Location = new System.Drawing.Point(804, 119);
            this.btnRestabelcer.Name = "btnRestabelcer";
            this.btnRestabelcer.Size = new System.Drawing.Size(141, 49);
            this.btnRestabelcer.TabIndex = 10;
            this.btnRestabelcer.Text = "Restablecer";
            this.toolTip1.SetToolTip(this.btnRestabelcer, "Restablecer Pantalla");
            this.btnRestabelcer.UseVisualStyleBackColor = true;
            this.btnRestabelcer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(201, 119);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 49);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Registros");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRuta.Location = new System.Drawing.Point(951, 80);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(46, 33);
            this.btnBuscarRuta.TabIndex = 8;
            this.btnBuscarRuta.Text = "...";
            this.toolTip1.SetToolTip(this.btnBuscarRuta, "Seleccionar Reporte");
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtRutaReporte
            // 
            this.txtRutaReporte.Location = new System.Drawing.Point(205, 83);
            this.txtRutaReporte.Name = "txtRutaReporte";
            this.txtRutaReporte.Size = new System.Drawing.Size(740, 26);
            this.txtRutaReporte.TabIndex = 3;
            // 
            // txtNombreReporte
            // 
            this.txtNombreReporte.Location = new System.Drawing.Point(205, 47);
            this.txtNombreReporte.Name = "txtNombreReporte";
            this.txtNombreReporte.Size = new System.Drawing.Size(740, 26);
            this.txtNombreReporte.TabIndex = 2;
            // 
            // lbRutaReporte
            // 
            this.lbRutaReporte.AutoSize = true;
            this.lbRutaReporte.Location = new System.Drawing.Point(43, 88);
            this.lbRutaReporte.Name = "lbRutaReporte";
            this.lbRutaReporte.Size = new System.Drawing.Size(138, 20);
            this.lbRutaReporte.TabIndex = 1;
            this.lbRutaReporte.Text = "Ruta de Reporte *";
            // 
            // lbNombreReporte
            // 
            this.lbNombreReporte.AutoSize = true;
            this.lbNombreReporte.Location = new System.Drawing.Point(14, 50);
            this.lbNombreReporte.Name = "lbNombreReporte";
            this.lbNombreReporte.Size = new System.Drawing.Size(159, 20);
            this.lbNombreReporte.TabIndex = 0;
            this.lbNombreReporte.Text = "Nombre de Reporte *";
            // 
            // ConfiguracionReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1027, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracionReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionReportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfiguracionReportes_FormClosing);
            this.Load += new System.EventHandler(this.ConfiguracionReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNombreReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRutaReporte;
        private System.Windows.Forms.TextBox txtNombreReporte;
        private System.Windows.Forms.Label lbRutaReporte;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRestabelcer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.Label lbClaveSeguridad;
        private System.Windows.Forms.TextBox txtclaveSeguridad;
        private System.Windows.Forms.Button btnGuardarCredenciales;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.CheckBox cbCredenciales;
    }
}