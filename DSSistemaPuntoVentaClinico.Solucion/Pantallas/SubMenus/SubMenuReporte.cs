using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    public partial class SubMenuReporte : Form
    {
        public SubMenuReporte()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjdataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR REPORTE DE VENTAS
        private void CargarReporteVentas(decimal IdUsuario)
        {
            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(10);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
            var SacarCredencialesBD = ObjdataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredencialesBD)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            //INVOCAMOS EL REPORTE
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes ReporteVentas = new Pantallas.Reporte.Reportes();
            ReporteVentas.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            ReporteVentas.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            ReporteVentas.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            ReporteVentas.MostrarReporteVentas(VariablesGlobales.IdUsuario);
            ReporteVentas.ShowDialog();
        }
        #endregion


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuReporte_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
        }

        private void btnReporteInventario_Click(object sender, EventArgs e)
        {
            try
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte EliminarRegistros = new Logica.Entidades.EntidadReporte.EmantenimientoReporte();

                EliminarRegistros.IdUsuarioImprime = VariablesGlobales.IdUsuario;

                var MAN = ObjDataHistorial.Value.MantenimientoReporteProducto(EliminarRegistros, "DELETE");

           

                var Listado = ObjdataInventario.Value.BuscaProducto(
                    new Nullable<decimal>(),
                    null,
                    null, null, null, null, null,
                    null,
                    null, null,
                    1,
                    999999999);
                foreach (var n in Listado)
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte Guardar = new Logica.Entidades.EntidadReporte.EmantenimientoReporte();

                    Guardar.IdUsuarioImprime = VariablesGlobales.IdUsuario;
                    Guardar.IdProducto = Convert.ToDecimal(n.IdProducto);
                    Guardar.CodigoProducto = n.CodigoProducto;
                    Guardar.Almacen = n.Almacen;
                    Guardar.TipoProveedor = n.TipoProveedor;
                    Guardar.Proveedor = n.Proveedor;
                    Guardar.TipoEmpaque = n.TipoEmpaque;
                    Guardar.TipoProducto = n.TipoProducto;
                    Guardar.Producto = n.Producto;
                    Guardar.Estatus = n.Estatus;
                    Guardar.CantidadAlmacen = Convert.ToInt32(n.CantidadAlmacen);
                    Guardar.PrecioCompra = Convert.ToDecimal(n.PrecioCompra);
                    Guardar.PrecioVenta = Convert.ToDecimal(n.PrecioVenta);
                    Guardar.SegundoPrecio = Convert.ToDecimal(n.SegundoPrecio);
                    Guardar.TercerPrecio = Convert.ToDecimal(n.TercerPrecio);
                    Guardar.FechaEntrada = n.FechaEntrada;
                    Guardar.LlevaDescuento = n.LlevaDescuento;
                    Guardar.PorcientoDescuento = Convert.ToInt32(n.PorcientoDescuento);
                    Guardar.CreadoPor = n.CreadoPor;
                    Guardar.FechaAdiciona = n.FechaAdiciona;
                    Guardar.ModificadoPor = n.ModificadoPor;
                    Guardar.FechaModifica = n.FechaModifica;

                    var MANf = ObjDataHistorial.Value.MantenimientoReporteProducto(Guardar, "INSERT");

                }

                //COMENZAMOS EL PROCESO PARA MOSTRAR EL REPORTE
                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(5);
                foreach (var n in SacarRutaReporte)
                {
                    VariablesGlobales.RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE LA BASE DE DATOS
                var SacarCredenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarCredenciales)
                {
                    VariablesGlobales.UsuarioBD = n.Usuario;
                    VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                //CARGAMOS EL REPORTE
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes cargar = new Pantallas.Reporte.Reportes();

                cargar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                cargar.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                cargar.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                cargar.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                cargar.GenerarReporteProductos(VariablesGlobales.IdUsuario);
                cargar.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realiar este proceso", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReporteCotizaciones_Click(object sender, EventArgs e)
        {
            //LEEMOS DESDE EL PROCEDURE [Caja].[SP_MOSTRAR_HISTORIAL_CAJA]
            try
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja Borrar = new Logica.Entidades.EntidadReporte.ECuadreCaja();
                Borrar.IdUsuario = VariablesGlobales.IdUsuario;
                var MAN2 = ObjDataHistorial.Value.CuadreCaja(Borrar, "DELETE");

                //SACAMOS LOS DATOS QUE SE VAN A GRABAR
                var SacarDatos = ObjdataCaja.Value.MostrarHistorialCaja(
                    DateTime.Now,
                    DateTime.Now);
                foreach (var n in SacarDatos)
                {
                    //GUARDAMOS LOS DATOS UTILIZANDO EL PROCEDURE SP_MANTENIMIENTO_CUADRE_CAJA
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja Cuadrar = new Logica.Entidades.EntidadReporte.ECuadreCaja();

                    Cuadrar.IdUsuario = VariablesGlobales.IdUsuario;
                    Cuadrar.Caja = n.Caja;
                    Cuadrar.CantidadFacturado = Convert.ToInt32(n.CantidadFacturado);
                    Cuadrar.Anuladas = Convert.ToInt32(n.Anuladas);
                    Cuadrar.TotalCantidadFacturado = Convert.ToInt32(n.TotalCantidadFacturado);
                    Cuadrar.CantidadCotizaciones = Convert.ToInt32(n.CantidadCotizaciones);
                    Cuadrar.CantidadCirugiasProgramadas = Convert.ToInt32(n.CantidadCirugiasProgramadas);
                    Cuadrar.Monto = Convert.ToDecimal(n.Monto);
                    Cuadrar.Concepto = n.Concepto;
                    Cuadrar.Fecha = n.Fecha;
                    Cuadrar.CreadoPor = n.CreadoPor;
                    Cuadrar.NumeroReferencia = n.NumeroReferencia;
                    Cuadrar.TipoPago = n.TipoPago;
                    Cuadrar.FechaDesde = DateTime.Now;
                    Cuadrar.FechaHasta = DateTime.Now;

                    var MAN = ObjDataHistorial.Value.CuadreCaja(Cuadrar, "INSERT");
                }

                //MOSTRAMOS EL REPORTE EN PANTALLA
                //SACAMOS LAS CREDENCIALES DEL SISTEMA
                var SacarCredenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarCredenciales)
                {
                    VariablesGlobales.UsuarioBD = n.Usuario;
                    VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }
                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(2);
                foreach (var n in SacarRutaReporte)
                {
                    VariablesGlobales.RutaReporte = n.RutaReporte;
                }
                //MANDAMOS LOS PARAMETROS E INVOCAMOS EL REPORTE
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Cuadre = new Pantallas.Reporte.Reportes();

                Cuadre.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                Cuadre.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                Cuadre.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                Cuadre.GenerarCuadreCaja(VariablesGlobales.IdUsuario);
                Cuadre.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte" + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteVentas Eliminar = new Logica.Entidades.EntidadHistorial.EGuardarReporteVentas();
                Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
                var Delete = ObjDataHistorial.Value.GuardarReporteVentas(Eliminar, "DELETE");

                //BUSQUEDA GENERAL AGREGANDO RANGO DE FECHA
                var Consultar = ObjDataHistorial.Value.HistorialFacturacionCotizacion(
                    new Nullable<decimal>(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    DateTime.Now,
                    DateTime.Now,
                    null,
                    1,
                    999999999);
                foreach (var n in Consultar)
                {

                    //GUARDAMOS

                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteVentas Guardar = new Logica.Entidades.EntidadHistorial.EGuardarReporteVentas();

                    Guardar.IdUsuario = VariablesGlobales.IdUsuario;
                    Guardar.NumeroFactura = n.NumeroFactura;
                    Guardar.NombrePaciente = n.NombrePaciente;
                    Guardar.TipoIdentificacion = n.TipoIdentificacion;
                    Guardar.Numeroidentificacion = n.NumeroIdentificacion;
                    Guardar.Estatus = n.Estatus;
                    Guardar.TipoComprobante = n.TipoComprobante;
                    Guardar.Telefono = n.Telefono;
                    Guardar.CentroSalud = n.CentroSalud;
                    Guardar.Sala = n.Sala;
                    Guardar.Medico = n.Medico;
                    Guardar.Direccion = n.Direccion;
                    Guardar.Sexo = n.Sexo;
                    Guardar.Email = n.Email;
                    Guardar.ComentarioPaciente = n.ComentarioPaciente;
                    Guardar.FechaFacturacion = n.FechaFacturacion;
                    Guardar.FechaVencimiento = n.FechaVencimiento;
                    Guardar.CantidadDias = n.CantidadDias;
                    Guardar.DiasDiferencia = n.DiasDiferencia;
                    Guardar.EstatusDias = n.EstatusDias;
                    Guardar.CreadoPor = n.Creadopor;
                    Guardar.TipoProducto = n.TipoProducto;
                    Guardar.Producto = n.ProDucto;
                    Guardar.Cantidad = Convert.ToInt32(n.Cantidad);
                    Guardar.Precio = n.Precio;
                    Guardar.DescuentoAplicado = n.DescuentoAplicado;
                    Guardar.Total = n.Total;
                    Guardar.TotalDescuento = n.TotalDescuento;
                    Guardar.SubTotal = n.Subtotal;
                    Guardar.Impuesto = n.Impuesto;
                    Guardar.TotalGeneral = n.TotalGeneral;
                    Guardar.TipoPago = n.TipoPago;
                    Guardar.MontoPagado = n.MontoPagado;
                    Guardar.EstatusCirugia = n.EstatusCirugia;
                    Guardar.TipoVenta = n.TipoVenta;
                    Guardar.Balance = n.Balance;

                    var MAN = ObjDataHistorial.Value.GuardarReporteVentas(Guardar, "INSERT");
                }
                //CARGAMOS EL REPORTE
                CargarReporteVentas(VariablesGlobales.IdUsuario);


            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar el reporte, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReporteMonedas_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja.MantenimientoFacturacionCirugia FacturacionCirugia = new Pantallas.Caja.MantenimientoFacturacionCirugia();
            FacturacionCirugia.VariablesGlobales.IdUsuario = 0;
            FacturacionCirugia.ShowDialog();
        }
    }
}
