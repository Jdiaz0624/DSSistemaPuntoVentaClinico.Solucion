namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    partial class SubMenuCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenuCaja));
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbirCerrarCaja = new System.Windows.Forms.Button();
            this.btnCuadreCaja = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbusuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.button2);
            this.gbOpciones.Controls.Add(this.button1);
            this.gbOpciones.Controls.Add(this.btnAbirCerrarCaja);
            this.gbOpciones.Controls.Add(this.btnCuadreCaja);
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(723, 181);
            this.gbOpciones.TabIndex = 2;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Caja - Seleccionar Opcion";
            this.gbOpciones.Enter += new System.EventHandler(this.gbOpciones_Enter);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(478, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 68);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cirugias";
            this.toolTip1.SetToolTip(this.button2, "Mostrar el Listado de las facturas sin cirugias programadas");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Monedas";
            this.toolTip1.SetToolTip(this.button1, "Mantenimiento de Monedas");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbirCerrarCaja
            // 
            this.btnAbirCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbirCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbirCerrarCaja.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbirCerrarCaja.Location = new System.Drawing.Point(6, 29);
            this.btnAbirCerrarCaja.Name = "btnAbirCerrarCaja";
            this.btnAbirCerrarCaja.Size = new System.Drawing.Size(230, 68);
            this.btnAbirCerrarCaja.TabIndex = 6;
            this.btnAbirCerrarCaja.Text = "Abrir / Cerrar";
            this.toolTip1.SetToolTip(this.btnAbirCerrarCaja, "Abrir y Cerrar Caja");
            this.btnAbirCerrarCaja.UseVisualStyleBackColor = true;
            this.btnAbirCerrarCaja.Click += new System.EventHandler(this.btnAbirCerrarCaja_Click);
            // 
            // btnCuadreCaja
            // 
            this.btnCuadreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadreCaja.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadreCaja.Location = new System.Drawing.Point(478, 29);
            this.btnCuadreCaja.Name = "btnCuadreCaja";
            this.btnCuadreCaja.Size = new System.Drawing.Size(230, 68);
            this.btnCuadreCaja.TabIndex = 5;
            this.btnCuadreCaja.Text = "Cuadre";
            this.toolTip1.SetToolTip(this.btnCuadreCaja, "Cuadre de Caja");
            this.btnCuadreCaja.UseVisualStyleBackColor = true;
            this.btnCuadreCaja.Click += new System.EventHandler(this.btnCuadreCaja_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(485, 10);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(51, 20);
            this.lbusuario.TabIndex = 10;
            this.lbusuario.Text = "label1";
            this.lbusuario.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lbusuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 44);
            this.panel1.TabIndex = 11;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(7, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(51, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DSSistemaPuntoVentaClinico.Solucion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(704, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SubMenuCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(745, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubMenuCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuCaja";
            this.Load += new System.EventHandler(this.SubMenuCaja_Load);
            this.gbOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnAbirCerrarCaja;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCuadreCaja;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button button2;
    }
}