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
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjdataReporte = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS COMISIONES
        private void MostrarComisiones()
        {
            try {
                //VALIDAMOS EL TIPO DE COMISION QUE SE VA A GENERAR

                //MOSTRAMOS LA COMISION NO PAGADA
                if (rbNoPagada.Checked)
                {
                    //PREGUNTAMOS SI LA CONSULTA LLEVA RANGO DE FECHA

                    //EN CASO NEGATIVO
                    if (cbNoAgregarRangoFecha.Checked ==true)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked==true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    null,

                                    null,
                                    false,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                    null,
                                    null,
                                    null,
                                    null,
                                    false,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
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
                                   false,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarComision;
                        }



                    }

                    //EN CASO POSITIVO
                    else if (cbNoAgregarRangoFecha.Checked == false) {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text),
                                    false,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
                                   null,
                                   null,
                                   null,
                                   Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                   null,
                                   null,
                                   Convert.ToDateTime(txtFechaDesde.Text),
                                   Convert.ToDateTime(txtFechaHasta.Text),
                                   false,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                  new Nullable<decimal>(),
                                  null,
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
                            dtListado.DataSource = BuscarComision;
                        }
                    }
                }


                //MOSTRAMOS LA COMISION PAGADA
                else if (rbPagada.Checked)
                {
                    //PREGUNTAMOS SI LA CONSULTA LLEVA RANGO DE FECHA

                    //EN CASO NEGATIVO
                    if (cbNoAgregarRangoFecha.Checked == true)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    null,
                                    null,
                                    true,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                  new Nullable<decimal>(),
                                  null,
                                  null,
                                  null,
                                  null,
                                  Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                  null,
                                  null,
                                  null,
                                  null,
                                  true,
                                  Convert.ToInt32(txtNumeroPagina.Value),
                                  Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
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
                                true,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarComision;
                        }
                    }


                    //EN CASO POSITIVO
                    else if (cbNoAgregarRangoFecha.Checked == false)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text),
                                    true,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
                                   null,
                                   null,
                                   null,
                                   Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                   null,
                                   null,
                                   Convert.ToDateTime(txtFechaDesde.Text),
                                   Convert.ToDateTime(txtFechaHasta.Text),
                                   true,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                new Nullable<decimal>(),
                                null,
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
                            dtListado.DataSource = BuscarComision;
                        }
                    }
                }


                //MOSTRAMOS AMBAS COMISIONES
                else if (rbAmbos.Checked) {
                    //PREGUNTAMOS SI LA CONSULTA LLEVA RANGO DE FECHA

                    //EN CASO NEGATIVO
                    if (cbNoAgregarRangoFecha.Checked == true)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    null,
                                    null,
                                    null,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                  new Nullable<decimal>(),
                                  null,
                                  null,
                                  null,
                                  null,
                                  Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                  null,
                                  null,
                                  null,
                                  null,
                                  null,
                                  Convert.ToInt32(txtNumeroPagina.Value),
                                  Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTANOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
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
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarComision;
                        }
                    }


                    //EN CASO POSITIVO
                    else if (cbNoAgregarRangoFecha.Checked == false)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text),
                                    null,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
                                   null,
                                   null,
                                   null,
                                   Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                   null,
                                   null,
                                   Convert.ToDateTime(txtFechaDesde.Text),
                                   Convert.ToDateTime(txtFechaHasta.Text),
                                   null,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = BuscarComision;
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
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
                            dtListado.DataSource = BuscarComision;
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la consulta", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormatoGrid();
        }
        private void Consultar()
        {
            lbLetrero.Text = "Comisión Detalle";
            MostrarComisiones();
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            gbPagoComisiones.Visible = false;
            btnPagar.Enabled = false;
            lbComisionPagadaTitulo.Visible = false;
            lbRespuesta.Visible = false;
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
        private void SacarNombreEmpresa() {
            var SacarInformacionEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(1);
            foreach (var n in SacarInformacionEmpresa) {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region APLICAR PAGO DE COMISION
        private void AplicarPagoComision()
        {
            if (lbRespuesta.Text == "SI")
            {
                MessageBox.Show("Esta comisión ya fue pagada, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Quieres aplicar este pago?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarComisionesMedico Pagar = new Logica.Entidades.EntidadesContabilidad.EGuardarComisionesMedico();

                    Pagar.IDComision = VariablesGlobales.IDComisionPagar;
                    Pagar.IdProgramacionCirugia = VariablesGlobales.IdProgramacionCirugiaPagar;
                    Pagar.NumeroFactura = VariablesGlobales.NumeroFacturaPagar;
                    Pagar.NumeroReferencia = VariablesGlobales.NumeroReferenciaPagar;
                    Pagar.ComisionPagada = true;
                    Pagar.FechapagoComision = DateTime.Now;
                    Pagar.MontoPagado = Convert.ToDecimal(txtMontoPagar.Text);

                    var MAn = ObjData.Value.GuardarComisionesMedicos(Pagar, "UPDATE");
                    Consultar();
                    MessageBox.Show("Pago aplicado Exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
        #region GENERAR REPORTE DETALLE
        private void GenerarReporteDetalle()
        {
            try
            {
                //VALIDAMOS EL TIPO DE COMISION QUE SE VA A GENERAR

                //MOSTRAMOS LA COMISION NO PAGADA
                if (rbNoPagada.Checked)
                {
                    //PREGUNTAMOS SI LA CONSULTA LLEVA RANGO DE FECHA

                    //EN CASO NEGATIVO
                    if (cbNoAgregarRangoFecha.Checked == true)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    null,

                                    null,
                                    false,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                    null,
                                    null,
                                    null,
                                    null,
                                    false,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
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
                                   false,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                            //ELIMINAMOS LOS DATOS 
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                            Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                            var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                            //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                            foreach (var n in BuscarComision)
                            {
                                //PROCEDEMOS A GUARDAR LOS DATOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                Guardar.CentroSalud = n.CentroSalud;
                                Guardar.Medico = n.Medico;
                                Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                Guardar.FechaCirugia = n.FechaCirugia;
                                Guardar.Hora = n.Hora;
                                Guardar.ComisionPagada = n.ComisionPagada;
                                Guardar.FechaPagoComision = n.FechapagoComision;
                                Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                            }

                            //INVOCAMOS EL REPORTE DETALLE
                            InvicarReporteDetalle();
                        }



                    }

                    //EN CASO POSITIVO
                    else if (cbNoAgregarRangoFecha.Checked == false)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text),
                                    false,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
                                   null,
                                   null,
                                   null,
                                   Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                   null,
                                   null,
                                   Convert.ToDateTime(txtFechaDesde.Text),
                                   Convert.ToDateTime(txtFechaHasta.Text),
                                   false,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                  new Nullable<decimal>(),
                                  null,
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
                            //ELIMINAMOS LOS DATOS 
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                            Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                            var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                            //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                            foreach (var n in BuscarComision)
                            {
                                //PROCEDEMOS A GUARDAR LOS DATOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                Guardar.CentroSalud = n.CentroSalud;
                                Guardar.Medico = n.Medico;
                                Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                Guardar.FechaCirugia = n.FechaCirugia;
                                Guardar.Hora = n.Hora;
                                Guardar.ComisionPagada = n.ComisionPagada;
                                Guardar.FechaPagoComision = n.FechapagoComision;
                                Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                            }

                            //INVOCAMOS EL REPORTE DETALLE
                            InvicarReporteDetalle();
                        }
                    }
                }


                //MOSTRAMOS LA COMISION PAGADA
                else if (rbPagada.Checked)
                {
                    //PREGUNTAMOS SI LA CONSULTA LLEVA RANGO DE FECHA

                    //EN CASO NEGATIVO
                    if (cbNoAgregarRangoFecha.Checked == true)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    null,
                                    null,
                                    true,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                  new Nullable<decimal>(),
                                  null,
                                  null,
                                  null,
                                  null,
                                  Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                  null,
                                  null,
                                  null,
                                  null,
                                  true,
                                  Convert.ToInt32(txtNumeroPagina.Value),
                                  Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
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
                                true,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            //ELIMINAMOS LOS DATOS 
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                            Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                            var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                            //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                            foreach (var n in BuscarComision)
                            {
                                //PROCEDEMOS A GUARDAR LOS DATOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                Guardar.CentroSalud = n.CentroSalud;
                                Guardar.Medico = n.Medico;
                                Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                Guardar.FechaCirugia = n.FechaCirugia;
                                Guardar.Hora = n.Hora;
                                Guardar.ComisionPagada = n.ComisionPagada;
                                Guardar.FechaPagoComision = n.FechapagoComision;
                                Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                            }

                            //INVOCAMOS EL REPORTE DETALLE
                            InvicarReporteDetalle();
                        }
                    }


                    //EN CASO POSITIVO
                    else if (cbNoAgregarRangoFecha.Checked == false)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text),
                                    true,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
                                   null,
                                   null,
                                   null,
                                   Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                   null,
                                   null,
                                   Convert.ToDateTime(txtFechaDesde.Text),
                                   Convert.ToDateTime(txtFechaHasta.Text),
                                   true,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                new Nullable<decimal>(),
                                null,
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
                            //ELIMINAMOS LOS DATOS 
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                            Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                            var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                            //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                            foreach (var n in BuscarComision)
                            {
                                //PROCEDEMOS A GUARDAR LOS DATOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                Guardar.CentroSalud = n.CentroSalud;
                                Guardar.Medico = n.Medico;
                                Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                Guardar.FechaCirugia = n.FechaCirugia;
                                Guardar.Hora = n.Hora;
                                Guardar.ComisionPagada = n.ComisionPagada;
                                Guardar.FechaPagoComision = n.FechapagoComision;
                                Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                            }

                            //INVOCAMOS EL REPORTE DETALLE
                            InvicarReporteDetalle();
                        }
                    }
                }


                //MOSTRAMOS AMBAS COMISIONES
                else if (rbAmbos.Checked)
                {
                    //PREGUNTAMOS SI LA CONSULTA LLEVA RANGO DE FECHA

                    //EN CASO NEGATIVO
                    if (cbNoAgregarRangoFecha.Checked == true)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    null,
                                    null,
                                    null,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                  new Nullable<decimal>(),
                                  null,
                                  null,
                                  null,
                                  null,
                                  Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                  null,
                                  null,
                                  null,
                                  null,
                                  null,
                                  Convert.ToInt32(txtNumeroPagina.Value),
                                  Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTANOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
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
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            //ELIMINAMOS LOS DATOS 
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                            Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                            var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                            //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                            foreach (var n in BuscarComision)
                            {
                                //PROCEDEMOS A GUARDAR LOS DATOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                Guardar.CentroSalud = n.CentroSalud;
                                Guardar.Medico = n.Medico;
                                Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                Guardar.FechaCirugia = n.FechaCirugia;
                                Guardar.Hora = n.Hora;
                                Guardar.ComisionPagada = n.ComisionPagada;
                                Guardar.FechaPagoComision = n.FechapagoComision;
                                Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                            }

                            //INVOCAMOS EL REPORTE DETALLE
                            InvicarReporteDetalle();
                        }
                    }


                    //EN CASO POSITIVO
                    else if (cbNoAgregarRangoFecha.Checked == false)
                    {
                        //PREGUNTAMOS SI LA CONSULTA LLEVA EL MEDICO


                        //EN CASO DE QUE SEA POSITIVO
                        if (cbFiltrarPorMedico.Checked == true)
                        {
                            //PREGUNTAMS EL TIPO DE FILTRO PARA EL MEDICO

                            //CONSULTA ESCRITA
                            if (rbEscrito.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO ESCRITO
                                string _Medico = string.IsNullOrEmpty(txtParametrotxt.Text.Trim()) ? null : txtParametrotxt.Text.Trim();

                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                    new Nullable<decimal>(),
                                    null,
                                    null,
                                    null,
                                    null,
                                    null,
                                    _Medico,
                                    null,
                                    Convert.ToDateTime(txtFechaDesde.Text),
                                    Convert.ToDateTime(txtFechaHasta.Text),
                                    null,
                                    Convert.ToInt32(txtNumeroPagina.Value),
                                    Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }

                            //CONSULTA SELECCIONADA
                            else if (rbSeleccionado.Checked == true)
                            {
                                //CONSULTAMOS CON MEDICO SELECCIONADO
                                var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
                                   null,
                                   null,
                                   null,
                                   Convert.ToDecimal(ddlSeleccionarMedico.SelectedValue),
                                   null,
                                   null,
                                   Convert.ToDateTime(txtFechaDesde.Text),
                                   Convert.ToDateTime(txtFechaHasta.Text),
                                   null,
                                   Convert.ToInt32(txtNumeroPagina.Value),
                                   Convert.ToInt32(txtNumeroRegistros.Value));
                                //ELIMINAMOS LOS DATOS 
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                                Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                                //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                                foreach (var n in BuscarComision)
                                {
                                    //PROCEDEMOS A GUARDAR LOS DATOS
                                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                    Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                    Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                    Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                    Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                    Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                    Guardar.CentroSalud = n.CentroSalud;
                                    Guardar.Medico = n.Medico;
                                    Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                    Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                    Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                    Guardar.FechaCirugia = n.FechaCirugia;
                                    Guardar.Hora = n.Hora;
                                    Guardar.ComisionPagada = n.ComisionPagada;
                                    Guardar.FechaPagoComision = n.FechapagoComision;
                                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                    var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                                }

                                //INVOCAMOS EL REPORTE DETALLE
                                InvicarReporteDetalle();
                            }
                        }

                        //EN CASO DE QUE SEA NEGATIVO
                        else if (cbFiltrarPorMedico.Checked == false)
                        {
                            //CONSULTAMOS SIN EL MEDICO
                            var BuscarComision = ObjData.Value.BuscaComisionesMedicos(
                                   new Nullable<decimal>(),
                                   null,
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
                            //ELIMINAMOS LOS DATOS 
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Eliminar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();
                            Eliminar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                            var Delete = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Eliminar, "DELETE");

                            //SACAMOS LOS DATOS NECESARIOS PARA GUARDAR LOS DATOS
                            foreach (var n in BuscarComision)
                            {
                                //PROCEDEMOS A GUARDAR LOS DATOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = new Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle();

                                Guardar.IdUsuario = Convert.ToDecimal(VariablesGlobales.IdUsuario);
                                Guardar.IDComision = Convert.ToDecimal(n.IDComision);
                                Guardar.IdProgramacionCirugia = Convert.ToDecimal(n.IdProgramacionCirugia);
                                Guardar.NumeroFactura = Convert.ToDecimal(n.NumeroFactura);
                                Guardar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                                Guardar.CentroSalud = n.CentroSalud;
                                Guardar.Medico = n.Medico;
                                Guardar.PorcComisionMedico = Convert.ToDecimal(n.PorcComisionMedico);
                                Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                                Guardar.MontoFacturaNeta = Convert.ToDecimal(n.MontoFacturaNeta);
                                Guardar.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                                Guardar.FechaCirugia = n.FechaCirugia;
                                Guardar.Hora = n.Hora;
                                Guardar.ComisionPagada = n.ComisionPagada;
                                Guardar.FechaPagoComision = n.FechapagoComision;
                                Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);

                                var Save = ObjdataReporte.Value.GuardarComisionMedicoDetalle(Guardar, "INSERT");


                            }

                            //INVOCAMOS EL REPORTE DETALLE
                            InvicarReporteDetalle();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del reporte, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region INVICAR LOS REPORTES
        private void InvicarReporteDetalle()
        {

        }
        private void InvicarReporteunico() { }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS CENTROS DE SALUD
        private void MostrarListadoCentroSalud() {
            var MostrarListadoCentroSalud = ObjDataListas.Value.ListaCentrosalud();
            ddlSeleccionarCentroSalud.DataSource = MostrarListadoCentroSalud;
            ddlSeleccionarCentroSalud.DisplayMember = "Nombre";
            ddlSeleccionarCentroSalud.ValueMember = "IdCentroSalud";
        }
        #endregion
        #region MOSTRAR LOS MEDICOS
        private void Mostrarmedicos() {
            try {
                var Mostrarmedicos = ObjDataListas.Value.ListaMedicos(
               Convert.ToDecimal(ddlSeleccionarCentroSalud.SelectedValue));
                ddlSeleccionarMedico.DataSource = Mostrarmedicos;
                ddlSeleccionarMedico.DisplayMember = "NombreMedico";
                ddlSeleccionarMedico.ValueMember = "IdMedico";
            }
            catch (Exception) { }
        }
        #endregion
        public ComisionMedico()
        {
            InitializeComponent();
        }

        private void ComisionMedico_Load(object sender, EventArgs e)
        {
            SacarNombreEmpresa();
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            rbNoPagada.Checked = true;
            lbLetrero.Text = "Comisión Detalle";
            lbTitulo.Text = "Generar Comisión a Medicos";
            lbTitulo.ForeColor = Color.White;
            MostrarListadoCentroSalud();
           Mostrarmedicos();
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
            Consultar();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    /*	WHERE IDComision = @IDComision
                          AND IdProgramacionCirugia = @IdProgramacionCirugia
                          AND NumeroFactura = @NumeroFactura
                          AND NumeroReferencia = @NumeroReferencia*/
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IDComision"].Value.ToString());

                var Buscar = ObjData.Value.BuscaComisionesMedicos(
                    VariablesGlobales.IdMantenimiento,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    1, 1);
                foreach (var n in Buscar)
                {
                    VariablesGlobales.IDComisionPagar = Convert.ToDecimal(n.IDComision);
                    VariablesGlobales.IdProgramacionCirugiaPagar = Convert.ToDecimal(n.IdProgramacionCirugia);
                    VariablesGlobales.NumeroFacturaPagar = Convert.ToDecimal(n.NumeroFactura);
                    VariablesGlobales.NumeroReferenciaPagar = Convert.ToDecimal(n.NumeroReferencia);

                    txtNombreMedico.Text = n.Medico;
                    txtNoFactura.Text = n.NumeroFactura.ToString();
                    txtFechaCirugia.Text = n.FechaCirugia;
                    VariablesGlobales.ComisionPagar = Convert.ToDecimal(n.ComisionPagar);
                    txtComisionPagar.Text = VariablesGlobales.ComisionPagar.ToString("N2");
                    txtMontoPagar.Text = VariablesGlobales.ComisionPagar.ToString("N2");
                    lbRespuesta.Text = n.ComisionPagada;
                    if (lbRespuesta.Text == "SI")
                    {
                        lbRespuesta.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbRespuesta.ForeColor = Color.Green;
                    }
                }
                dtListado.DataSource = Buscar;
                FormatoGrid();
                lbLetrero.Text = "Comisión Unica";
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                cbTodo.Checked = true;
                gbPagoComisiones.Visible = true;
                btnPagar.Enabled = true;
                lbComisionPagadaTitulo.Visible = true;
                lbRespuesta.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DatoLetrero = lbLetrero.Text;
            if (DatoLetrero == "Comisión Detalle")
            {
                GenerarReporteDetalle();

                //SACAMOS LA RUTA DEL REPORTE
                var SacarRuta = ObjdataReporte.Value.SacarRutaReporte(11);
                foreach (var n in SacarRuta)
                {
                    VariablesGlobales.RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarCredenciales)
                {
                    VariablesGlobales.UsuarioBD = n.Usuario;
                    VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }
                //INVOCAMOS EL REPORTE
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Reporte = new Reporte.Reportes();
              //  Reporte.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                Reporte.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                Reporte.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                Reporte.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                Reporte.GenerarReporteComisionMedicoDetalle(VariablesGlobales.IdUsuario);
                Reporte.ShowDialog();
            }
            else
            {
                //SACAMOS LA RUTA DEL REPORTE
                var SacarRuta = ObjdataReporte.Value.SacarRutaReporte(12);
                foreach (var n in SacarRuta)
                {
                    VariablesGlobales.RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarCredenciales)
                {
                    VariablesGlobales.UsuarioBD = n.Usuario;
                    VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }
                //INVICAMOS EL REPORTE
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes ReporteUnico = new Reporte.Reportes();
                ReporteUnico.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                ReporteUnico.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                ReporteUnico.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                ReporteUnico.GenerarReporteComisionUnico(VariablesGlobales.IdMantenimiento);
                ReporteUnico.ShowDialog();
            }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarComisiones();
                MessageBox.Show("Comision detalle");
            }
            else
            {
                MostrarComisiones();
                MessageBox.Show("Comision detalle");
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarComisiones();
                MessageBox.Show("Comision detalle");
            }
            else
            {
                MostrarComisiones();
                MessageBox.Show("Comision detalle");
            }
        }

        private void cbTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodo.Checked == true)
            {
                txtMontoPagar.Enabled = false;
                txtMontoPagar.Text = VariablesGlobales.ComisionPagar.ToString("N2");
            }
            else
            {
                txtMontoPagar.Text = string.Empty;
                txtMontoPagar.Enabled = true;
              
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cbTodo.Checked == true)
            {
                AplicarPagoComision();
            }
            else
            {
                try {
                    //VALIDAMOS SI EL CAMPO MONTO ESTA VACIO
                    if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                    {
                        MessageBox.Show("El campo monto no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //PAGAR
                    }
                    else
                    {
                        //VALIDAMOS QUE EL MONTO INGRESADO NO SUPERE EL MONTO A PAGAR
                        decimal ComisionPagar, MontoPagar;
                        ComisionPagar = Convert.ToDecimal(txtComisionPagar.Text);
                        MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                        if (MontoPagar > ComisionPagar)
                        {
                            MessageBox.Show("El monto ingresado supera a la comisión a pagar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            AplicarPagoComision();
                        }
                    }
                }
                catch (Exception) {
                    MessageBox.Show("Error al aplicar el pago de comisiones, favor de verificar si el monto ingresado tiene el formato correcto", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void txtMontoPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbFiltrarPorMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiltrarPorMedico.Checked)
            {
                rbEscrito.Visible = true;
                rbSeleccionado.Visible = true;
                rbEscrito.Checked = true;
            }
            else
            {
                rbEscrito.Visible = false;
                rbSeleccionado.Visible = false;
                rbEscrito.Checked = false;
                rbSeleccionado.Checked = false;
            }
        }

        private void rbEscrito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEscrito.Checked)
            {
                lbNombreMedico.Visible = true;
                txtParametrotxt.Visible = true;
                txtParametrotxt.Text = string.Empty;
                lbSeleccionarCentroSalud.Visible = false;
                ddlSeleccionarCentroSalud.Visible = false;
                lbSeleccionarMedico.Visible = false;
                ddlSeleccionarMedico.Visible = false;
            }
            else
            {
                lbNombreMedico.Visible = false;
                txtParametrotxt.Visible = false;
                txtParametrotxt.Text = string.Empty;
                lbSeleccionarCentroSalud.Visible = false;
                ddlSeleccionarCentroSalud.Visible = false;
                lbSeleccionarMedico.Visible = false;
                ddlSeleccionarMedico.Visible = false;
            }
        }

        private void rbSeleccionado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeleccionado.Checked)
            {
                lbNombreMedico.Visible = false;
                txtParametrotxt.Visible = false;
                txtParametrotxt.Text = string.Empty;
                lbSeleccionarCentroSalud.Visible = true;
                ddlSeleccionarCentroSalud.Visible = true;
                lbSeleccionarMedico.Visible = true;
                ddlSeleccionarMedico.Visible = true;

            }
            else
            {
                lbNombreMedico.Visible = false;
                txtParametrotxt.Visible = false;
                txtParametrotxt.Text = string.Empty;
                lbSeleccionarCentroSalud.Visible = false;
                ddlSeleccionarCentroSalud.Visible = false;
                lbSeleccionarMedico.Visible = false;
                ddlSeleccionarMedico.Visible = false;
            }
        }

        private void ddlSeleccionarCentroSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarmedicos();
        }
    }
}
