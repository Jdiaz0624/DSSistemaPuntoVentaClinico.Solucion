namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja
{
    partial class MonedaMantenimiento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.cbPorDefecto = new System.Windows.Forms.CheckBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPorDefecto);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.txtTasa);
            this.groupBox1.Controls.Add(this.txtSigla);
            this.groupBox1.Controls.Add(this.txtMoneda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Moneda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.LightGray;
            this.txtMoneda.Location = new System.Drawing.Point(106, 25);
            this.txtMoneda.MaxLength = 100;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(342, 32);
            this.txtMoneda.TabIndex = 3;
            // 
            // txtSigla
            // 
            this.txtSigla.BackColor = System.Drawing.Color.LightGray;
            this.txtSigla.Location = new System.Drawing.Point(106, 61);
            this.txtSigla.MaxLength = 100;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(342, 32);
            this.txtSigla.TabIndex = 4;
            // 
            // txtTasa
            // 
            this.txtTasa.BackColor = System.Drawing.Color.LightGray;
            this.txtTasa.Location = new System.Drawing.Point(106, 97);
            this.txtTasa.MaxLength = 100;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(342, 32);
            this.txtTasa.TabIndex = 5;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasa_KeyPress);
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstatus.Location = new System.Drawing.Point(106, 136);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(93, 27);
            this.cbEstatus.TabIndex = 6;
            this.cbEstatus.Text = "Estatus";
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // cbPorDefecto
            // 
            this.cbPorDefecto.AutoSize = true;
            this.cbPorDefecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPorDefecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPorDefecto.Location = new System.Drawing.Point(205, 135);
            this.cbPorDefecto.Name = "cbPorDefecto";
            this.cbPorDefecto.Size = new System.Drawing.Size(142, 27);
            this.cbPorDefecto.TabIndex = 7;
            this.cbPorDefecto.Text = "Por Defecto";
            this.cbPorDefecto.UseVisualStyleBackColor = true;
            this.cbPorDefecto.CheckedChanged += new System.EventHandler(this.cbPorDefecto_CheckedChanged);
            // 
            // btnAccion
            // 
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Location = new System.Drawing.Point(12, 181);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(187, 49);
            this.btnAccion.TabIndex = 12;
            this.btnAccion.Text = "Guardar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(286, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonedaMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(483, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MonedaMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonedaMantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonedaMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.MonedaMantenimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPorDefecto;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAccion;
        public System.Windows.Forms.Button button1;
    }
}