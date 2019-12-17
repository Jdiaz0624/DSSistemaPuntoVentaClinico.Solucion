using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Comunes
{
    public class VariablesGlobales
    {
        public string RutaImagen { get; set; }
        public decimal NumeroFacturaMantenimiento { get; set; }
        public bool DescuentoAplicado { get; set; }
        public decimal PrecioOriginal { get; set; }
        public string NombreSistema { get; set; }
        public decimal IdUsuario { get; set; }
        public decimal IdPerfil { get; set; }
        public int Contador { get; set; }
        public int CantidadIntentos { get; set; }
        public decimal IdMantenimiento { get; set; }
        public string CodigoMantenimiento { get; set; }
        public string AccionTomar { get; set; }
        public decimal NumeroFacturacion { get; set; }
        public decimal IdEstatusFacturacion { get; set; }
        public decimal NumeroConector { get; set; }
        public bool EstatusProducto { get; set; }
        public bool GuardarCliente { get; set; }
        public bool TipoProceso { get; set; }
        public bool GenerarConector { get; set; }
        public bool SacarDatosEspejo { get; set; }
        public decimal Secuencial { get; set; }
        public bool ModoCotizacion { get; set; }
        public string UsuarioBD { get; set; }
        public string ClaveBD { get; set; }
        public string RutaReporte { get; set; }
        public decimal Numerofactura { get; set; }


        #region VARIABLES PARA EL PROCESO DE HISTORIAL DE FACTURACION Y COTIZACION
        public decimal IdUsuarioHis { get; set; }
        public decimal NumeroFacturaHis { get; set; }
        public string NombrePacienteHis { get; set; }
        public decimal IdTipoIdentificacionHis { get; set; }
        public string TipoIdentificacionHis { get; set; }
        public string NumeroIdentificacionHis { get; set; }
        public decimal IdEstatusFacturacionHis { get; set; }
        public string EstatusHis { get; set; }
        public string CodigoFacturacionHis { get; set; }
        public decimal NumeroConectorHis { get; set; }
        public decimal IdTipoFacturacionHis { get; set; }
        public string TipoComprobanteHis { get; set; }
        public string ValidoHastaHis { get; set; }
        public string ComprobanteHis { get; set; }
        public string TelefonoHis { get; set; }
        public decimal IdCentroSaludHis { get; set; }
        public string CentroSaludHis { get; set; }
        public string SalaHis { get; set; }
        public decimal IdMedicoHis { get; set; }
        public string MedicoHis { get; set; }
        public string DireccionHis { get; set; }
        public decimal IdSexoHis { get; set; }
        public string SexoHis { get; set; }
        public string EmailHis { get; set; }
        public string ComentarioPacienteHis { get; set; }
        public DateTime FechaFacturacion0His { get; set; }
        public string FechaFacturacionHis { get; set; }
        public decimal IdUsuarioCreaHis { get; set; }
        public string CreadoporHis { get; set; } 
        public decimal IdProductoHis { get; set; }
        public string TipoProductoHis { get; set; }
        public string ProDuctoHis { get; set; }
        public decimal CantidadHis { get; set; }
        public decimal PrecioHis { get; set; }
        public decimal DescuentoAplicadoHis { get; set; }
        public decimal TotalHis { get; set; }
        public decimal CantidadArticulosHis { get; set; }
        public decimal TotalDescuentoHis { get; set; }
        public decimal SubtotalHis { get; set; }
        public decimal ImpuestoHis { get; set; }
        public decimal TotalGeneralHis { get; set; }
        public decimal IdTipoPagoHis { get; set; }
        public string TipoPagoHis { get; set; }
        public decimal MontoPagadoHis { get; set; }
        public bool EstatusUsuario { get; set; }
        #endregion
    }
}
