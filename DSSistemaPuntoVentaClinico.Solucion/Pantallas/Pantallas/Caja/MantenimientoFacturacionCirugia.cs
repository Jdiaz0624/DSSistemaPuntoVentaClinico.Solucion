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
    public partial class MantenimientoFacturacionCirugia : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region SACAMOS LOS DATOS DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEMpresA)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEMpresA);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MANTENIMIENTO DE CIRUGIAS
        private void MAnCirugias(string Accion)
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EProcesarMantenimientoProgramacionCirugia Procesar = new Logica.Entidades.EntidadReporte.EProcesarMantenimientoProgramacionCirugia();

            Procesar.IdUsuarioImprime = VariablesGlobales.IdUsuario;
            Procesar.NumeroFactura = VariablesGlobales.IdMantenimiento;

            var MAN = ObjDataHistorial.Value.MantenimientoFacturacionCirugia(Procesar, Accion);
        }
        #endregion
        public MantenimientoFacturacionCirugia()
        {
            InitializeComponent();
        }

        private void MantenimientoFacturacionCirugia_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Generar Reporte de Cirugias";
            rbFacturasConCirugias.Checked = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (cbFiltrarPorRangoFecha.Checked)
                {
                    if (rbFacturasSinCirugias.Checked)
                    {
                        MAnCirugias("DELETE");
                        var Buscar = ObjDataHistorial.Value.SacarDatosFacturacionCirugia(
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            false);
                        foreach (var n in Buscar)
                        {
                            VariablesGlobales.IdMantenimiento = Convert.ToDecimal(n.NumeroFactura);
                            MAnCirugias("INSERT");
                        }
                    }
                    else if (rbFacturasConCirugias.Checked)
                    {
                        MAnCirugias("DELETE");
                        var Buscar = ObjDataHistorial.Value.SacarDatosFacturacionCirugia(
                           Convert.ToDateTime(txtFechaDesde.Text),
                           Convert.ToDateTime(txtFechaHasta.Text),
                           true);
                        foreach (var n in Buscar)
                        {
                            VariablesGlobales.IdMantenimiento = Convert.ToDecimal(n.NumeroFactura);
                            MAnCirugias("INSERT");
                        }
                    }
                    else if (rbAmbosTiposFacturas.Checked)
                    {
                        MAnCirugias("DELETE");
                        var Buscar = ObjDataHistorial.Value.SacarDatosFacturacionCirugia(
                           Convert.ToDateTime(txtFechaDesde.Text),
                           Convert.ToDateTime(txtFechaHasta.Text),
                           null);
                        foreach (var n in Buscar)
                        {
                            VariablesGlobales.IdMantenimiento = Convert.ToDecimal(n.NumeroFactura);
                            MAnCirugias("INSERT");
                        }
                    }
                }
                else
                {
                    if (rbFacturasSinCirugias.Checked)
                    {
                        MAnCirugias("DELETE");
                        var Buscar = ObjDataHistorial.Value.SacarDatosFacturacionCirugia(
                           null,
                           null,
                           true);
                        foreach (var n in Buscar)
                        {
                            VariablesGlobales.IdMantenimiento = Convert.ToDecimal(n.NumeroFactura);
                            MAnCirugias("INSERT");
                        }
                    }
                    else if (rbFacturasConCirugias.Checked)
                    {
                        MAnCirugias("DELETE");
                        var Buscar = ObjDataHistorial.Value.SacarDatosFacturacionCirugia(
                         null,
                         null,
                         false);
                        foreach (var n in Buscar)
                        {
                            VariablesGlobales.IdMantenimiento = Convert.ToDecimal(n.NumeroFactura);
                            MAnCirugias("INSERT");
                        }
                    }
                    else if (rbAmbosTiposFacturas.Checked)
                    {
                        MAnCirugias("DELETE");
                        var Buscar = ObjDataHistorial.Value.SacarDatosFacturacionCirugia(
                         null,
                         null,
                         null);
                        foreach (var n in Buscar)
                        {
                            VariablesGlobales.IdMantenimiento = Convert.ToDecimal(n.NumeroFactura);
                            MAnCirugias("INSERT");
                        }
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("Error al generar el reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
