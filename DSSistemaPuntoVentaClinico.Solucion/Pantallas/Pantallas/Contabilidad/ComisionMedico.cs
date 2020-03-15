using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad
{
    public partial class ComisionMedico : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaContabilidad> ObjData = new Lazy<Logica.Logica.LogicaContabilidad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS COMISIONES
        private void MostrarComisiones()
        {
            if (cbNoAgregarRangoFecha.Checked)
            {
                if (rbNoPagada.Checked == true)
                {
                    var MostrarListado = ObjData.Value.BuscaComisionesMedicos(
                        new Nullable<decimal>(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        false,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                    dtListado.DataSource = MostrarListado;
                }
                else if (rbPagada.Checked == true)
                {
                    var MostrarListado = ObjData.Value.BuscaComisionesMedicos(
                       new Nullable<decimal>(),
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       true,
                       Convert.ToInt32(txtNumeroPagina.Value),
                       Convert.ToInt32(txtNumeroRegistros.Value));
                    dtListado.DataSource = MostrarListado;
                }
                else if (rbAmbos.Checked == true)
                {
                    var MostrarListado = ObjData.Value.BuscaComisionesMedicos(
                       new Nullable<decimal>(),
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       null,
                       Convert.ToInt32(txtNumeroPagina.Value),
                       Convert.ToInt32(txtNumeroRegistros.Value));
                    dtListado.DataSource = MostrarListado;
                }
                else
                {
                    MessageBox.Show("Error al realizar la consulta", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (rbNoPagada.Checked == true)
                {
                    var MostrarListado = ObjData.Value.BuscaComisionesMedicos(
                        new Nullable<decimal>(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text),
                        false,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                    dtListado.DataSource = MostrarListado;
                }
                else if (rbPagada.Checked == true)
                {
                    var MostrarListado = ObjData.Value.BuscaComisionesMedicos(
                      new Nullable<decimal>(),
                      null,
                      null,
                      null,
                      null,
                      null,
                      null,
                      Convert.ToDateTime(txtFechaDesde.Text),
                      Convert.ToDateTime(txtFechaHasta.Text),
                      true,
                      Convert.ToInt32(txtNumeroPagina.Value),
                      Convert.ToInt32(txtNumeroRegistros.Value));
                    dtListado.DataSource = MostrarListado;
                }
                else if (rbAmbos.Checked == true)
                {
                    var MostrarListado = ObjData.Value.BuscaComisionesMedicos(
                      new Nullable<decimal>(),
                      null,
                      null,
                      null,
                      null,
                      null,
                      null,
                      Convert.ToDateTime(txtFechaDesde.Text),
                      Convert.ToDateTime(txtFechaHasta.Text),
                      null,
                      Convert.ToInt32(txtNumeroPagina.Value),
                      Convert.ToInt32(txtNumeroRegistros.Value));
                    dtListado.DataSource = MostrarListado;
                }
                else
                {
                    MessageBox.Show("Error al realizar la consulta", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            FormatoGrid();
        }
        #endregion
        #region FORMATO DEL GRID
        private void FormatoGrid()
        {
            //OCULTAMOS LAS COLUMNAS QUE NO NECESITAMOS
            this.dtListado.Columns["IDComision"].Visible = false;
            this.dtListado.Columns["IdProgramacionCirugia"].Visible = false;
            this.dtListado.Columns["Cliente"].Visible = false;
            this.dtListado.Columns["Paciente"].Visible = false;
            this.dtListado.Columns["NumeroReferencia"].Visible = false;
            this.dtListado.Columns["IdCentroSalud"].Visible = false;
            this.dtListado.Columns["Telefonos"].Visible = false;
            this.dtListado.Columns["Direccion"].Visible = false;
            this.dtListado.Columns["Idmedico"].Visible = false;
            this.dtListado.Columns["Impuesto"].Visible = false;
            this.dtListado.Columns["TipoVenta0"].Visible = false;
            this.dtListado.Columns["TipoVenta"].Visible = false;
            this.dtListado.Columns["IdAsistente"].Visible = false;
            this.dtListado.Columns["FechaCirugia0"].Visible = false;
            this.dtListado.Columns["ComisionPagada0"].Visible = false;
            this.dtListado.Columns["FechapagoComision0"].Visible = false;
            //this.dtListado.Columns["FechapagoComision"].Visible = false;
            //this.dtListado.Columns["MontoPagado"].Visible = false;


            //FORMATEAMOS LOS CAMPOS NUMERICOS
            this.dtListado.Columns["MontoFactura"].DefaultCellStyle.Format = "N2";
            this.dtListado.Columns["MontoFacturaNeta"].DefaultCellStyle.Format = "N2";
            this.dtListado.Columns["ComisionPagar"].DefaultCellStyle.Format = "N2";
            this.dtListado.Columns["MontoPagado"].DefaultCellStyle.Format = "N2";
        }
        #endregion
        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarNombreEmpresa() { }
        #endregion

        public ComisionMedico()
        {
            InitializeComponent();
        }

        private void ComisionMedico_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            rbNoPagada.Checked = true;
        }

        private void ComisionMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnControlApertura_Click(object sender, EventArgs e)
        {
            MostrarComisiones();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }
    }
}
