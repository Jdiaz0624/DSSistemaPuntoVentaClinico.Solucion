﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion
{
    public partial class GastoCirugia : Form
    {
        public GastoCirugia()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugiaConsulta Prograacion = new ProgramacionCirugiaConsulta();
            Prograacion.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Prograacion.ShowDialog();
        }
        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
                lbTitulo.Text = "Gastos de Cirugia";
                lbTitulo.ForeColor = Color.White;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS GASTOS
        private void MostrarListadoGastos(decimal IdProgramacionCirugia)
        {
            var MostrarListado = ObjDataFacturacion.Value.BuscaGastoCirugia(
                new Nullable<decimal>(),
                IdProgramacionCirugia,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dataGridView1.DataSource = MostrarListado;
        }
        #endregion
        #region MANTENIMIENTO DE GASTOS DE CIRUGIA
        private void MAnGastosCirugias(string Accion)
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia Mantenimiento = new Logica.Entidades.EntidadFacturacion.EGastosCirugia();

                Mantenimiento.IdGastosCirugia = VariablesGlobales.IdMantenimiento2;
                Mantenimiento.IdProgramacionCirugia = VariablesGlobales.IdMantenimiento;
                Mantenimiento.Descripcion = txtDescripcion.Text;
                Mantenimiento.Cantidad = Convert.ToInt32(txtcantodad.Text);
                Mantenimiento.Comentario = txtcomentario.Text;
                var MAn = ObjDataFacturacion.Value.MantenimientoGastosCirugia(Mantenimiento, Accion);
            }
            catch (Exception) {
                MessageBox.Show("Error al realizar el mantenimiento", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region RESTABLECER PANTALLA
        private void RestablecerPantalla()
        {
            txtcantodad.Text = string.Empty;
            txtcomentario.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnQuitar.Enabled = true;
            btnRestablecer.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtDescripcion.Text = string.Empty;
            txtcantodad.Text = string.Empty;
            txtcomentario.Text = string.Empty;
            MostrarListadoGastos(VariablesGlobales.IdMantenimiento);
        }
        #endregion
        #region CARGAR EL ESTATUS DE CIRUGIA
        private void CargarEstatusCirugia()
        {
            var Estatus = ObjDataListas.Value.BuscaEstatusCirugia();
            ddlEstatusCirugia.DataSource = Estatus;
            ddlEstatusCirugia.DisplayMember = "Descripcion";
            ddlEstatusCirugia.ValueMember = "IdEstatusCirugia";
        }
        #endregion
        private void SacaEstatus()
        {
            var SacarEstatusCirugia = ObjDataFacturacion.Value.BuscaProgramacionCirugia(
              VariablesGlobales.IdMantenimiento,
              null, null, null, null, null, null, 1, 1);
            foreach (var n in SacarEstatusCirugia)
            {
                ddlEstatusCirugia.Text = n.Estatus;
                lbEstatus.Text = n.Estatus;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void GastoCirugia_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
            MostrarListadoGastos(VariablesGlobales.IdMantenimiento);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            CargarEstatusCirugia();
            //SACAMOS EL ESTATUS DE LA CIRUGIA
            SacaEstatus();
            DSSistemaPuntoVentaClinico.Logica.Comunes.AutoCompletarControles.AutoCompletarProductos(txtDescripcion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtcantodad.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para guardar un nuevo registro, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VariablesGlobales.IdMantenimiento2 = 0;
                MAnGastosCirugias("INSERT");
                RestablecerPantalla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtcantodad.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para modificar el registro seleccionado, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MAnGastosCirugias("UPDATE");
                RestablecerPantalla();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            MAnGastosCirugias("DELETE");
            RestablecerPantalla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void GastoCirugia_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void txtcantodad_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListadoGastos(VariablesGlobales.IdMantenimiento);
            }
            else
            {
                MostrarListadoGastos(VariablesGlobales.IdMantenimiento);
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListadoGastos(VariablesGlobales.IdMantenimiento);
            }
            else
            {
                MostrarListadoGastos(VariablesGlobales.IdMantenimiento);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento2 = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["IdGastosCirugia"].Value.ToString());

                var Buscar = ObjDataFacturacion.Value.BuscaGastoCirugia(
                    VariablesGlobales.IdMantenimiento2,
                    VariablesGlobales.IdMantenimiento,
                    1, 1);
                foreach (var n in Buscar)
                {
                    txtDescripcion.Text = n.Descripcion;
                    txtcantodad.Text = n.Cantidad.ToString();
                    txtcomentario.Text = n.Comentario;
                }
                dataGridView1.DataSource = Buscar;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnQuitar.Enabled = true;
                btnRestablecer.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SACAMOS EL USUARIO Y LA CLAVE DE LA BASE DE DATOS
            var SacarCredenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredenciales)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(4);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //MOSTRAMOS EL REPORTE
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reporte ReporteGastoCirugia = new Reporte.Reporte();
            ReporteGastoCirugia.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            ReporteGastoCirugia.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            ReporteGastoCirugia.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            ReporteGastoCirugia.GenerarReorteGastosCirugia(VariablesGlobales.IdMantenimiento);
            ReporteGastoCirugia.ShowDialog();


        }

        private void cbModificarEsatusCirugia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModificarEsatusCirugia.Checked)
            {
                lbEstatusCirugia.Visible = true;
                ddlEstatusCirugia.Visible = true;
                btnCambiar.Visible = true;
            }
            else
            {
                lbEstatusCirugia.Visible = false;
                ddlEstatusCirugia.Visible = false;
                btnCambiar.Visible = false;
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //CAMBIAMOS EL REGISTRO
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia ModificarEstatus = new Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia();

            ModificarEstatus.IdProgramacionCirugia = VariablesGlobales.IdMantenimiento;
            ModificarEstatus.IdEstatusCirugia = Convert.ToDecimal(ddlEstatusCirugia.SelectedValue);

            var MAn = ObjDataFacturacion.Value.MantenimientoProgramacionCirugia(ModificarEstatus, "CHANGESTATUS");
            MessageBox.Show("Estatus cambiado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
           SacaEstatus();
        }

        private void ddlEstatusCirugia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
