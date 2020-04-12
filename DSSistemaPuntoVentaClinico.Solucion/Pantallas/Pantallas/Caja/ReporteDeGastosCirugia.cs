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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReporteDeGastosCirugia_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Generar Reporte de Gastos de Cirugia";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarListadoCirugias();
        }
    }
}
