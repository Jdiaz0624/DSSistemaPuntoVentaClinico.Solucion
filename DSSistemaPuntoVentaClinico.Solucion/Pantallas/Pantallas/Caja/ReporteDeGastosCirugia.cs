using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja
{
    public partial class ReporteDeGastosCirugia : Form
    {
        public ReporteDeGastosCirugia()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE CIRUGIAS
        private void MostrarListadoCirugias()
        {
            string _NumeroFactura = string.IsNullOrEmpty(txtNumeroFactura.Text.Trim()) ? null : txtNumeroFactura.Text.Trim();
            if (cbAgregarRangoFecha.Checked==true)
            {
                var MostrarListado = ObjDataFacturacion.Value.BuscaProgramacionCirugia(
              new Nullable<decimal>(),
              Convert.ToDateTime(txtFechaDesde.Text),
              Convert.ToDateTime(txtFechaHasta.Text),
              null, null, null, _NumeroFactura,
              Convert.ToInt32(txtNumeroPagina.Value),
              Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarListado;
                OcultarColumnas();
            }
            else if(cbAgregarRangoFecha.Checked==false)
            {
                var MostrarListado = ObjDataFacturacion.Value.BuscaProgramacionCirugia(
            new Nullable<decimal>(),
            null,
            null,
            null, null, null,_NumeroFactura,
            Convert.ToInt32(txtNumeroPagina.Value),
            Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarListado;
                OcultarColumnas();
            }
        }
        #endregion
        #region OCULTAR REGISTROS
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdProgramacionCirugia"].Visible = false;
            this.dtListado.Columns["IdCentroSalud"].Visible = false;
            this.dtListado.Columns["IdMedico"].Visible = false;
            this.dtListado.Columns["IdAuxiliarCirugia"].Visible = false;
            this.dtListado.Columns["IdHoraCirugia"].Visible = false;
            this.dtListado.Columns["IdEstatusCirugia"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["IdTipoFacturacion"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["IdCentroSaludAnterior"].Visible = false;
            this.dtListado.Columns["IdMedicoAnterior"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdSexo"].Visible = false;
            this.dtListado.Columns["Email"].Visible = false;
            this.dtListado.Columns["ComentarioPaciente"].Visible = false;
            this.dtListado.Columns["FechaFacturacion0"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["FechaCirugia0"].Visible = false;
        }
        #endregion
        #region MOSTRAR LA INFORMACION DE EMPRES
        private void MostrarInformacioNEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReporteDeGastosCirugia_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Generar Reporte de Gastos de Cirugia";
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            MostrarInformacioNEmpresa(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                MostrarListadoCirugias();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el listado, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres ver los gastos realizados a esta cirugia?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdProgramacionCirugia"].Value.ToString());

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

              //  MOSTRAMOS EL REPORTE
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reporte ReporteGastoCirugia = new Reporte.Reporte();
                ReporteGastoCirugia.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                ReporteGastoCirugia.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                ReporteGastoCirugia.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                ReporteGastoCirugia.GenerarReorteGastosCirugia(VariablesGlobales.IdMantenimiento);
                ReporteGastoCirugia.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string _NumeroFactura = string.IsNullOrEmpty(txtNumeroFactura.Text.Trim()) ? null : txtNumeroFactura.Text.Trim();
                if (cbAgregarRangoFecha.Checked == true)
                {
                    //ELIMINAMOS TODOS LOS REGISTROS DEL USUARIO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia Eliminar = new Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia();
                    Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
                    var MEN = ObjDataHistorial.Value.GuardarReorteGastosCirugia(Eliminar, "DELETE");

                    var MostrarListado = ObjDataFacturacion.Value.BuscaProgramacionCirugia(
                  new Nullable<decimal>(),
                  Convert.ToDateTime(txtFechaDesde.Text),
                  Convert.ToDateTime(txtFechaHasta.Text),
                  null, null, null, _NumeroFactura,
                  Convert.ToInt32(txtNumeroPagina.Value),
                  Convert.ToInt32(txtNumeroRegistros.Value));
                    foreach (var n in MostrarListado)
                    {
                        //BUSCAMOS TODOS LOS GASTOS DE CIRUGIA MEDIANTE EL ID
                        var BucarGastosCirugia = ObjDataFacturacion.Value.BuscaGastoCirugia(
                            new Nullable<decimal>(),
                            Convert.ToDecimal(n.IdProgramacionCirugia),
                            1, 999999999);
                        foreach (var n2 in BucarGastosCirugia)
                        {
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia Guardar = new Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia();

                            Guardar.IdUsuario = VariablesGlobales.IdUsuario;
                            Guardar.IdProgramacionCirugia = Convert.ToDecimal(n2.IdProgramacionCirugia);
                            Guardar.Descripcion = n2.Descripcion;
                            Guardar.Cantidad = Convert.ToInt32(n2.Cantidad);
                            Guardar.Comentario = n2.Comentario;

                            var MAN = ObjDataHistorial.Value.GuardarReorteGastosCirugia(Guardar, "INSERT");
                        }
                    }
                    //GENERAMOS EL REPORTE

                    //SACAMOS LA RUTA DEL REPORTE
                    var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(13);
                    foreach (var n in SacarRutaReporte)
                    {
                        VariablesGlobales.RutaReporte = n.RutaReporte;
                    }

                    //SACAMOS LAS CREDENCIALES DE BD
                    var SacarCrdenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
                    foreach (var n in SacarCrdenciales)
                    {
                        VariablesGlobales.UsuarioBD = n.Usuario;
                        VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                    }

                    //INVOCAMOS EL REPORTE
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reporte ReporteGastos = new Reporte.Reporte();

                     ReporteGastos.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                    ReporteGastos.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                    ReporteGastos.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                    ReporteGastos.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                    ReporteGastos.GenerarReporteGastosGeneral(VariablesGlobales.IdUsuario);
                    ReporteGastos.ShowDialog();



                }
                else if (cbAgregarRangoFecha.Checked == false)
                {
                    //ELIMINAMOS TODOS LOS REGISTROS DEL USUARIO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia Eliminar = new Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia();
                    Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
                    var MEN = ObjDataHistorial.Value.GuardarReorteGastosCirugia(Eliminar, "DELETE");

                    var MostrarListado = ObjDataFacturacion.Value.BuscaProgramacionCirugia(
                new Nullable<decimal>(),
                null,
                null,
                null, null, null, _NumeroFactura,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
                    foreach (var n in MostrarListado) {
                        //BUSCAMOS TODOS LOS GASTOS DE CIRUGIA MEDIANTE EL ID
                        //BUSCAMOS TODOS LOS GASTOS DE CIRUGIA MEDIANTE EL ID
                        var BucarGastosCirugia = ObjDataFacturacion.Value.BuscaGastoCirugia(
                            new Nullable<decimal>(),
                            Convert.ToDecimal(n.IdProgramacionCirugia),
                            1, 999999999);
                        foreach (var n2 in BucarGastosCirugia)
                        {
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia Guardar = new Logica.Entidades.EntidadHistorial.EGuardarReporteGastosCirugia();

                            Guardar.IdUsuario = VariablesGlobales.IdUsuario;
                            Guardar.IdProgramacionCirugia = Convert.ToDecimal(n2.IdProgramacionCirugia);
                            Guardar.Descripcion = n2.Descripcion;
                            Guardar.Cantidad = Convert.ToInt32(n2.Cantidad);
                            Guardar.Comentario = n2.Comentario;

                            var MAN = ObjDataHistorial.Value.GuardarReorteGastosCirugia(Guardar, "INSERT");
                        }
                    }
                    //GENERAMOS EL REPORTE

                    //SACAMOS LA RUTA DEL REPORTE
                    var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(13);
                    foreach (var n in SacarRutaReporte)
                    {
                        VariablesGlobales.RutaReporte = n.RutaReporte;
                    }

                    //SACAMOS LAS CREDENCIALES DE BD
                    var SacarCrdenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
                    foreach (var n in SacarCrdenciales)
                    {
                        VariablesGlobales.UsuarioBD = n.Usuario;
                        VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                    }

                    //INVOCAMOS EL REPORTE
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reporte ReporteGastos = new Reporte.Reporte();

                    // ReporteGastos.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                    ReporteGastos.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                    ReporteGastos.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                    ReporteGastos.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                    ReporteGastos.GenerarReporteGastosGeneral(VariablesGlobales.IdUsuario);
                    ReporteGastos.ShowDialog();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte de gastos general, codigo de error" + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void ReporteDeGastosCirugia_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                try
                {
                    MostrarListadoCirugias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el listado, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    MostrarListadoCirugias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el listado, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                try
                {
                    MostrarListadoCirugias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el listado, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    MostrarListadoCirugias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el listado, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
