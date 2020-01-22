﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SistemaFacturacionMedico")]
	public partial class BDListasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public BDListasDataContext() : 
				base(global::DSSistemaPuntoVentaClinico.Data.Properties.Settings.Default.SistemaFacturacionMedicoConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public BDListasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDListasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDListasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDListasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_BUSCA_TIPO_PROVEEDORES")]
		public ISingleResult<SP_BUSCA_TIPO_PROVEEDORESResult> SP_BUSCA_TIPO_PROVEEDORES()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_BUSCA_TIPO_PROVEEDORESResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_ALMACEN")]
		public ISingleResult<SP_LISTA_ALMACENResult> SP_LISTA_ALMACEN()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_ALMACENResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_TIPO_EMPAQUE")]
		public ISingleResult<SP_LISTA_TIPO_EMPAQUEResult> SP_LISTA_TIPO_EMPAQUE()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_TIPO_EMPAQUEResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_PROVEEDOR")]
		public ISingleResult<SP_LISTA_PROVEEDORResult> SP_LISTA_PROVEEDOR([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdTipoProveedor", DbType="Decimal(18,0)")] System.Nullable<decimal> idTipoProveedor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idTipoProveedor);
			return ((ISingleResult<SP_LISTA_PROVEEDORResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_TIPO_PRODUCTO")]
		public ISingleResult<SP_LISTA_TIPO_PRODUCTOResult> SP_LISTA_TIPO_PRODUCTO()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_TIPO_PRODUCTOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_CENTRO_SALUD")]
		public ISingleResult<SP_LISTA_CENTRO_SALUDResult> SP_LISTA_CENTRO_SALUD()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_CENTRO_SALUDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_COMPROBANTES_FISCALES")]
		public ISingleResult<SP_LISTA_COMPROBANTES_FISCALESResult> SP_LISTA_COMPROBANTES_FISCALES()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_COMPROBANTES_FISCALESResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_SEXO")]
		public ISingleResult<SP_CARGAR_LISTA_SEXOResult> SP_CARGAR_LISTA_SEXO()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CARGAR_LISTA_SEXOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_TIPO_IDENTIFICACION")]
		public ISingleResult<SP_CARGAR_LISTA_TIPO_IDENTIFICACIONResult> SP_CARGAR_LISTA_TIPO_IDENTIFICACION()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CARGAR_LISTA_TIPO_IDENTIFICACIONResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_MEDICOS")]
		public ISingleResult<SP_CARGAR_LISTA_MEDICOSResult> SP_CARGAR_LISTA_MEDICOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdCentroSalud", DbType="Decimal(20,0)")] System.Nullable<decimal> idCentroSalud)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idCentroSalud);
			return ((ISingleResult<SP_CARGAR_LISTA_MEDICOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_TIPO_PAGO")]
		public ISingleResult<SP_CARGAR_LISTA_TIPO_PAGOResult> SP_CARGAR_LISTA_TIPO_PAGO()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CARGAR_LISTA_TIPO_PAGOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTA_ESTATUS_FACTURACION")]
		public ISingleResult<SP_CARGAR_LISTA_ESTATUS_FACTURACIONResult> SP_CARGAR_LISTA_ESTATUS_FACTURACION()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CARGAR_LISTA_ESTATUS_FACTURACIONResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_USUARIOS")]
		public ISingleResult<SP_LISTA_USUARIOSResult> SP_LISTA_USUARIOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_USUARIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_ESTATUS_CIRUGIA")]
		public ISingleResult<SP_LISTA_ESTATUS_CIRUGIAResult> SP_LISTA_ESTATUS_CIRUGIA()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_ESTATUS_CIRUGIAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTAS_HORAS")]
		public ISingleResult<SP_LISTAS_HORASResult> SP_LISTAS_HORAS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdHora", DbType="Decimal(20,0)")] System.Nullable<decimal> idHora, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hora", DbType="VarChar(20)")] string hora)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idHora, hora);
			return ((ISingleResult<SP_LISTAS_HORASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_CARGAR_LISTAS_ASISTENTE_CIRUGIA")]
		public ISingleResult<SP_CARGAR_LISTAS_ASISTENTE_CIRUGIAResult> SP_CARGAR_LISTAS_ASISTENTE_CIRUGIA()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_CARGAR_LISTAS_ASISTENTE_CIRUGIAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTADO_TIPO_VENTA")]
		public ISingleResult<SP_LISTADO_TIPO_VENTAResult> SP_LISTADO_TIPO_VENTA()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTADO_TIPO_VENTAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Listas.SP_LISTA_CANTIDAD_DIAS")]
		public ISingleResult<SP_LISTA_CANTIDAD_DIASResult> SP_LISTA_CANTIDAD_DIAS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTA_CANTIDAD_DIASResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_BUSCA_TIPO_PROVEEDORESResult
	{
		
		private decimal _IdTipoProveedor;
		
		private string _Descripcion;
		
		public SP_BUSCA_TIPO_PROVEEDORESResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoProveedor", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdTipoProveedor
		{
			get
			{
				return this._IdTipoProveedor;
			}
			set
			{
				if ((this._IdTipoProveedor != value))
				{
					this._IdTipoProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_ALMACENResult
	{
		
		private decimal _IdAlmacen;
		
		private string _Nombre;
		
		public SP_LISTA_ALMACENResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAlmacen", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdAlmacen
		{
			get
			{
				return this._IdAlmacen;
			}
			set
			{
				if ((this._IdAlmacen != value))
				{
					this._IdAlmacen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_TIPO_EMPAQUEResult
	{
		
		private decimal _IdTipoEmpaque;
		
		private string _Descripcion;
		
		public SP_LISTA_TIPO_EMPAQUEResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoEmpaque", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdTipoEmpaque
		{
			get
			{
				return this._IdTipoEmpaque;
			}
			set
			{
				if ((this._IdTipoEmpaque != value))
				{
					this._IdTipoEmpaque = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_PROVEEDORResult
	{
		
		private System.Nullable<decimal> _IdProveedor;
		
		private string _Nombre;
		
		public SP_LISTA_PROVEEDORResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProveedor", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> IdProveedor
		{
			get
			{
				return this._IdProveedor;
			}
			set
			{
				if ((this._IdProveedor != value))
				{
					this._IdProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_TIPO_PRODUCTOResult
	{
		
		private decimal _IdTipoProducto;
		
		private string _Descripcion;
		
		public SP_LISTA_TIPO_PRODUCTOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoProducto", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdTipoProducto
		{
			get
			{
				return this._IdTipoProducto;
			}
			set
			{
				if ((this._IdTipoProducto != value))
				{
					this._IdTipoProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_CENTRO_SALUDResult
	{
		
		private decimal _IdCentroSalud;
		
		private string _Nombre;
		
		public SP_LISTA_CENTRO_SALUDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCentroSalud", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdCentroSalud
		{
			get
			{
				return this._IdCentroSalud;
			}
			set
			{
				if ((this._IdCentroSalud != value))
				{
					this._IdCentroSalud = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(200)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_COMPROBANTES_FISCALESResult
	{
		
		private decimal _IdComprobante;
		
		private string _Descripcion;
		
		public SP_LISTA_COMPROBANTES_FISCALESResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdComprobante", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdComprobante
		{
			get
			{
				return this._IdComprobante;
			}
			set
			{
				if ((this._IdComprobante != value))
				{
					this._IdComprobante = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_LISTA_SEXOResult
	{
		
		private decimal _IdSexo;
		
		private string _Descripcion;
		
		public SP_CARGAR_LISTA_SEXOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSexo", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdSexo
		{
			get
			{
				return this._IdSexo;
			}
			set
			{
				if ((this._IdSexo != value))
				{
					this._IdSexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_LISTA_TIPO_IDENTIFICACIONResult
	{
		
		private decimal _IdTipoIdentificacion;
		
		private string _Descripcion;
		
		public SP_CARGAR_LISTA_TIPO_IDENTIFICACIONResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoIdentificacion", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdTipoIdentificacion
		{
			get
			{
				return this._IdTipoIdentificacion;
			}
			set
			{
				if ((this._IdTipoIdentificacion != value))
				{
					this._IdTipoIdentificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_LISTA_MEDICOSResult
	{
		
		private decimal _IdMedico;
		
		private string _NombreMedico;
		
		public SP_CARGAR_LISTA_MEDICOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMedico", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdMedico
		{
			get
			{
				return this._IdMedico;
			}
			set
			{
				if ((this._IdMedico != value))
				{
					this._IdMedico = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreMedico", DbType="VarChar(100)")]
		public string NombreMedico
		{
			get
			{
				return this._NombreMedico;
			}
			set
			{
				if ((this._NombreMedico != value))
				{
					this._NombreMedico = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_LISTA_TIPO_PAGOResult
	{
		
		private System.Nullable<decimal> _IdTipoPago;
		
		private string _Descripcion;
		
		public SP_CARGAR_LISTA_TIPO_PAGOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoPago", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> IdTipoPago
		{
			get
			{
				return this._IdTipoPago;
			}
			set
			{
				if ((this._IdTipoPago != value))
				{
					this._IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_LISTA_ESTATUS_FACTURACIONResult
	{
		
		private decimal _IdEstatusFacturacion;
		
		private string _Estatus;
		
		public SP_CARGAR_LISTA_ESTATUS_FACTURACIONResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstatusFacturacion", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdEstatusFacturacion
		{
			get
			{
				return this._IdEstatusFacturacion;
			}
			set
			{
				if ((this._IdEstatusFacturacion != value))
				{
					this._IdEstatusFacturacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="VarChar(100)")]
		public string Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_USUARIOSResult
	{
		
		private decimal _IdUsuario;
		
		private string _Persona;
		
		private string _Usuario;
		
		public SP_LISTA_USUARIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this._IdUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Persona", DbType="VarChar(1000)")]
		public string Persona
		{
			get
			{
				return this._Persona;
			}
			set
			{
				if ((this._Persona != value))
				{
					this._Persona = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(20)")]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this._Usuario = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_ESTATUS_CIRUGIAResult
	{
		
		private decimal _IdEstatusCirugia;
		
		private string _Descripcion;
		
		private System.Nullable<bool> _Estatus;
		
		public SP_LISTA_ESTATUS_CIRUGIAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstatusCirugia", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdEstatusCirugia
		{
			get
			{
				return this._IdEstatusCirugia;
			}
			set
			{
				if ((this._IdEstatusCirugia != value))
				{
					this._IdEstatusCirugia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit")]
		public System.Nullable<bool> Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
	}
	
	public partial class SP_LISTAS_HORASResult
	{
		
		private decimal _IdHora;
		
		private string _Hora;
		
		private System.Nullable<bool> _Estatus0;
		
		private string _Estatus;
		
		public SP_LISTAS_HORASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdHora", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdHora
		{
			get
			{
				return this._IdHora;
			}
			set
			{
				if ((this._IdHora != value))
				{
					this._IdHora = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hora", DbType="VarChar(20)")]
		public string Hora
		{
			get
			{
				return this._Hora;
			}
			set
			{
				if ((this._Hora != value))
				{
					this._Hora = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus0", DbType="Bit")]
		public System.Nullable<bool> Estatus0
		{
			get
			{
				return this._Estatus0;
			}
			set
			{
				if ((this._Estatus0 != value))
				{
					this._Estatus0 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this._Estatus = value;
				}
			}
		}
	}
	
	public partial class SP_CARGAR_LISTAS_ASISTENTE_CIRUGIAResult
	{
		
		private decimal _IdAsistenteCirugia;
		
		private string _Nombre;
		
		public SP_CARGAR_LISTAS_ASISTENTE_CIRUGIAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAsistenteCirugia", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdAsistenteCirugia
		{
			get
			{
				return this._IdAsistenteCirugia;
			}
			set
			{
				if ((this._IdAsistenteCirugia != value))
				{
					this._IdAsistenteCirugia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
	}
	
	public partial class SP_LISTADO_TIPO_VENTAResult
	{
		
		private decimal _IdTipoVenta;
		
		private string _TipoVenta;
		
		public SP_LISTADO_TIPO_VENTAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoVenta", DbType="Decimal(20,0) NOT NULL")]
		public decimal IdTipoVenta
		{
			get
			{
				return this._IdTipoVenta;
			}
			set
			{
				if ((this._IdTipoVenta != value))
				{
					this._IdTipoVenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoVenta", DbType="VarChar(20)")]
		public string TipoVenta
		{
			get
			{
				return this._TipoVenta;
			}
			set
			{
				if ((this._TipoVenta != value))
				{
					this._TipoVenta = value;
				}
			}
		}
	}
	
	public partial class SP_LISTA_CANTIDAD_DIASResult
	{
		
		private System.Nullable<decimal> _IdCantidadDias;
		
		private System.Nullable<int> _CantidadDias;
		
		public SP_LISTA_CANTIDAD_DIASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCantidadDias", DbType="Decimal(20,0)")]
		public System.Nullable<decimal> IdCantidadDias
		{
			get
			{
				return this._IdCantidadDias;
			}
			set
			{
				if ((this._IdCantidadDias != value))
				{
					this._IdCantidadDias = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CantidadDias", DbType="Int")]
		public System.Nullable<int> CantidadDias
		{
			get
			{
				return this._CantidadDias;
			}
			set
			{
				if ((this._CantidadDias != value))
				{
					this._CantidadDias = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
