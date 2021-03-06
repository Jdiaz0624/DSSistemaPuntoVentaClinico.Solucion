﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class ConfiguracionReportes : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjdataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

#region SACAR LA INFORMACION DE LA EMPRESA
     private void SacarinformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region SACAR LAS RUTAS DE LOS REPORTES
        private void SacarRutasReportes()
        {
            var SacarRutaReportes = ObjdataHistorial.Value.SacarRutaReporte(
                new Nullable<decimal>());
            dataGridView1.DataSource = SacarRutaReportes;
        }
        #endregion
        #region MANTENIMIENTO DE RUTA DE REPORTE
        private void MANRutaReportes(string Accion)
        {
            try
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EMantenimientoRutaReporte Mantenimiento = new Logica.Entidades.EntidadReporte.EMantenimientoRutaReporte();

                Mantenimiento.IdReporte = VariablesGlobales.IdMantenimiento;
                Mantenimiento.DescripcionReporte = txtNombreReporte.Text;
                Mantenimiento.RutaReporte = txtRutaReporte.Text;

                var MAN = ObjdataHistorial.Value.MantenimientoRutaReporte(Mantenimiento, Accion);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);}
            
        }
        #endregion
        #region RESTABLCER LA PANTALLA
        private void Restablecerpantalla()
        {
            SacarRutasReportes();
            txtRutaReporte.Text = string.Empty;
            txtNombreReporte.Text = string.Empty;
            DesactivarControles();
        }
        #endregion
        #region MODIFICAR CREDENCIALES DE LA BASE DE DATOS
        private void ModificarCredencialesBD()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EModificarLogonReporte Modificar = new Logica.Entidades.EntidadSeguridad.EModificarLogonReporte();

            Modificar.IdLogonBd = 1;
            Modificar.Usuario = txtUsuario.Text;
            Modificar.Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);

            var MAN = ObjdataSeguridad.Value.Credenciales(Modificar, "UPDATE");
        }
        #endregion
        #region ACTIVAR Y DESACTIVAR CONTROLES
        private void ActivarControles()
        {
            lbNombreReporte.Enabled = true;
            txtNombreReporte.Enabled = true;
            lbRutaReporte.Enabled = true;
            txtRutaReporte.Enabled = true;
            btnGuardar.Enabled = true;
            btnRestabelcer.Enabled = true;
            btnBuscarRuta.Enabled = true;
           // cbCredenciales.Enabled = true;
        }
        private void DesactivarControles()
        {
            lbNombreReporte.Enabled = false;
            txtNombreReporte.Enabled = false;
            lbRutaReporte.Enabled = false;
            txtRutaReporte.Enabled = false;
            btnGuardar.Enabled = false;
            btnRestabelcer.Enabled = false;
            btnBuscarRuta.Enabled = false;
           // cbCredenciales.Enabled = false;
        }
        #endregion
        public ConfiguracionReportes()
        {
            InitializeComponent();
        }

        private void ConfiguracionReportes_Load(object sender, EventArgs e)
        {
            SacarinformacionEmpresa(1);
            SacarRutasReportes();
            lbTitulo.Text = "Configuración de ruta de reportes";
            lbTitulo.ForeColor = Color.White;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            txtClave.PasswordChar = '•';
            txtclaveSeguridad.PasswordChar = '•';
            DesactivarControles();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["IdReporte"].Value.ToString());

                    var SacarDatosReporte = ObjdataHistorial.Value.SacarRutaReporte(VariablesGlobales.IdMantenimiento);
                    dataGridView1.DataSource = SacarDatosReporte;
                    foreach (var n in SacarDatosReporte)
                    {
                        txtNombreReporte.Text = n.DescripcionReporte;
                        txtRutaReporte.Text = n.RutaReporte;
                    }
                    ActivarControles();
                }
            }
            catch (Exception) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfiguracionReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreReporte.Text.Trim()) || string.IsNullOrEmpty(txtRutaReporte.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para modificar el reporte seleccionado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MANRutaReportes("UPDATE");
                MessageBox.Show("Registro modificado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restablecerpantalla();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtRutaReporte.Text = openFileDialog1.FileName;
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCredenciales.Checked)
            {
                lbUsuario.Visible = true;
                txtUsuario.Visible = true;
                lbClave.Visible = true;
                txtClave.Visible = true;
                lbClaveSeguridad.Visible = true;
                txtclaveSeguridad.Visible = true;
                btnGuardarCredenciales.Visible = true;
                //SACAMOS LOS DATOS DEL LOGON DE LA BASE DE DATOS
                var SacarLogon = ObjdataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarLogon)
                {
                    txtUsuario.Text = n.Usuario;
                    txtClave.Text = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }
            }
            else
            {
                lbUsuario.Visible = false;
                txtUsuario.Visible = false;
                lbClave.Visible = false;
                txtClave.Visible = false;
                lbClaveSeguridad.Visible = false;
                txtclaveSeguridad.Visible = false;
                btnGuardarCredenciales.Visible = false;
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
                txtclaveSeguridad.Text = string.Empty;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restablecerpantalla();
        }

        private void btnGuardarCredenciales_Click(object sender, EventArgs e)
        {
            //VALIDAMOS LOS CONTROLES DE USUARIO
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                MessageBox.Show("Los campos Usuario o Clave no pueden estar vacios, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS SI EL CAMPO CLAVE DE SEGURIDAD ESTA VACIO
                if (string.IsNullOrEmpty(txtclaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguriad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //VALIDAMOS SI LA CLAVE DE SEGURIDAD INGRESADA ES VALIDA
                    var ValidarClave = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                        DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtclaveSeguridad.Text),
                        null, 1, 1);
                    if (ValidarClave.Count < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtclaveSeguridad.Text = string.Empty;
                        txtclaveSeguridad.Focus();
                    }
                    else
                    {
                        //REALIZAMOS LA MODIFICACION
                        ModificarCredencialesBD();
                        MessageBox.Show("Credenciales de base de datos modificadas exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbCredenciales.Checked = false;
                    }
                }
            }
        }
    }
}
