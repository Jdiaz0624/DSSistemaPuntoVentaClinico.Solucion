﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class EReporteHistorialFacturacionCotizacion
    {
        public System.Nullable<decimal> IdUsuario {get;set;}

        public System.Nullable<decimal> NumeroFactura {get;set;}

        public string NombrePaciente {get;set;}

        public System.Nullable<decimal> IdTipoIdentificacion {get;set;}

        public string TipoIdentificacion {get;set;}

        public string NumeroIdentificacion {get;set;}

        public System.Nullable<decimal> IdEstatusFacturacion {get;set;}

        public string Estatus {get;set;}

        public string CodigoFacturacion {get;set;}

        public System.Nullable<decimal> NumeroConector {get;set;}

        public System.Nullable<decimal> IdTipoFacturacion {get;set;}

        public string TipoComprobante {get;set;}

        public string ValidoHasta {get;set;}

        public string Comprobante {get;set;}

        public string Telefono {get;set;}

        public System.Nullable<decimal> IdCentroSalud {get;set;}

        public string CentroSalud {get;set;}

        public string Sala {get;set;}

        public System.Nullable<decimal> IdMedico {get;set;}

        public string Medico {get;set;}

        public string Direccion {get;set;}

        public System.Nullable<decimal> IdSexo {get;set;}

        public string Sexo {get;set;}

        public string Email {get;set;}

        public string ComentarioPaciente {get;set;}

        public System.Nullable<System.DateTime> FechaFacturacion0 {get;set;}

        public string FechaFacturacion {get;set;}

        public System.Nullable<decimal> IdUsuarioCrea {get;set;}

        public string Creadopor {get;set;}

        public System.Nullable<decimal> IdProducto {get;set;}

        public string TipoProducto {get;set;}

        public string ProDucto {get;set;}

        public System.Nullable<decimal> Cantidad {get;set;}

        public System.Nullable<decimal> Precio {get;set;}

        public System.Nullable<decimal> DescuentoAplicado {get;set;}

        public System.Nullable<decimal> Total {get;set;}

        public System.Nullable<decimal> CantidadArticulos {get;set;}

        public System.Nullable<decimal> TotalDescuento {get;set;}

        public System.Nullable<decimal> Subtotal {get;set;}

        public System.Nullable<decimal> Impuesto {get;set;}

        public System.Nullable<decimal> TotalGeneral {get;set;}

        public System.Nullable<decimal> IdTipoPago {get;set;}

        public string TipoPago {get;set;}

        public System.Nullable<decimal> MontoPagado {get;set;}
    }
}
