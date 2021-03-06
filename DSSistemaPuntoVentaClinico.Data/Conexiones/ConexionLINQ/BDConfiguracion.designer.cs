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
	public partial class BDConfiguracionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public BDConfiguracionDataContext() : 
				base(global::DSSistemaPuntoVentaClinico.Data.Properties.Settings.Default.SistemaFacturacionMedicoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BDConfiguracionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConfiguracionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConfiguracionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDConfiguracionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Configuracion.SP_SACAR_INFORMACION_EMPRESA")]
		public ISingleResult<SP_SACAR_INFORMACION_EMPRESAResult> SP_SACAR_INFORMACION_EMPRESA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdInformacionEmpresa", DbType="Decimal(18,0)")] System.Nullable<decimal> idInformacionEmpresa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idInformacionEmpresa);
			return ((ISingleResult<SP_SACAR_INFORMACION_EMPRESAResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Configuracion.ConfiguracionGeneralSistema")]
		public ISingleResult<ConfiguracionGeneralSistemaResult> ConfiguracionGeneralSistema([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdConfiguracionGeneral", DbType="Int")] System.Nullable<int> idConfiguracionGeneral)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idConfiguracionGeneral);
			return ((ISingleResult<ConfiguracionGeneralSistemaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Configuracion.SP_BUSCA_LISTAS")]
		public ISingleResult<SP_BUSCA_LISTASResult> SP_BUSCA_LISTAS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreLista", DbType="VarChar(150)")] string nombreLista, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrimerFiltro", DbType="VarChar(150)")] string primerFiltro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SegundoFiltro", DbType="VarChar(150)")] string segundoFiltro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TerceFiltro", DbType="VarChar(150)")] string terceFiltro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CuartoFiltro", DbType="VarChar(150)")] string cuartoFiltro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuintoFiltro", DbType="VarChar(150)")] string quintoFiltro)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreLista, primerFiltro, segundoFiltro, terceFiltro, cuartoFiltro, quintoFiltro);
			return ((ISingleResult<SP_BUSCA_LISTASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Configuracion.SP_MANTENIMIENTO_INFORMACION_EMPRESA")]
		public ISingleResult<SP_MANTENIMIENTO_INFORMACION_EMPRESAResult> SP_MANTENIMIENTO_INFORMACION_EMPRESA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdInformacionEmpresa", DbType="Decimal(18,0)")] System.Nullable<decimal> idInformacionEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodigoInformacionEmpresa", DbType="VarChar(100)")] string codigoInformacionEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreEmpresa", DbType="VarChar(100)")] string nombreEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RNC", DbType="VarChar(50)")] string rNC, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(8000)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email2", DbType="VarChar(50)")] string email2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Facebook", DbType="VarChar(50)")] string facebook, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Instagran", DbType="VarChar(50)")] string instagran, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefonos", DbType="VarChar(100)")] string telefonos, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fac", DbType="VarChar(50)")] string fac, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdLogoEmpresa", DbType="Decimal(18,0)")] System.Nullable<decimal> idLogoEmpresa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Accion", DbType="VarChar(150)")] string accion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idInformacionEmpresa, codigoInformacionEmpresa, nombreEmpresa, rNC, direccion, email, email2, facebook, instagran, telefonos, fac, idLogoEmpresa, accion);
			return ((ISingleResult<SP_MANTENIMIENTO_INFORMACION_EMPRESAResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_SACAR_INFORMACION_EMPRESAResult
	{
		
		private decimal _IdInformacionEmpresa;
		
		private string _CodigoInformacionEmpresa;
		
		private string _NombreEmpresa;
		
		private string _RNC;
		
		private string _Direccion;
		
		private string _Email;
		
		private string _Email2;
		
		private string _Facebook;
		
		private string _Instagran;
		
		private string _Telefonos;
		
		private string _Fac;
		
		private System.Nullable<decimal> _IdLogoEmpresa;
		
		private string _DescripcionLogo;
		
		private System.Data.Linq.Binary _LogoEmpresa;
		
		public SP_SACAR_INFORMACION_EMPRESAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdInformacionEmpresa", DbType="Decimal(18,0) NOT NULL")]
		public decimal IdInformacionEmpresa
		{
			get
			{
				return this._IdInformacionEmpresa;
			}
			set
			{
				if ((this._IdInformacionEmpresa != value))
				{
					this._IdInformacionEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoInformacionEmpresa", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string CodigoInformacionEmpresa
		{
			get
			{
				return this._CodigoInformacionEmpresa;
			}
			set
			{
				if ((this._CodigoInformacionEmpresa != value))
				{
					this._CodigoInformacionEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreEmpresa", DbType="VarChar(100)")]
		public string NombreEmpresa
		{
			get
			{
				return this._NombreEmpresa;
			}
			set
			{
				if ((this._NombreEmpresa != value))
				{
					this._NombreEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RNC", DbType="VarChar(50)")]
		public string RNC
		{
			get
			{
				return this._RNC;
			}
			set
			{
				if ((this._RNC != value))
				{
					this._RNC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(8000)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email2", DbType="VarChar(50)")]
		public string Email2
		{
			get
			{
				return this._Email2;
			}
			set
			{
				if ((this._Email2 != value))
				{
					this._Email2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Facebook", DbType="VarChar(50)")]
		public string Facebook
		{
			get
			{
				return this._Facebook;
			}
			set
			{
				if ((this._Facebook != value))
				{
					this._Facebook = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instagran", DbType="VarChar(50)")]
		public string Instagran
		{
			get
			{
				return this._Instagran;
			}
			set
			{
				if ((this._Instagran != value))
				{
					this._Instagran = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefonos", DbType="VarChar(100)")]
		public string Telefonos
		{
			get
			{
				return this._Telefonos;
			}
			set
			{
				if ((this._Telefonos != value))
				{
					this._Telefonos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fac", DbType="VarChar(50)")]
		public string Fac
		{
			get
			{
				return this._Fac;
			}
			set
			{
				if ((this._Fac != value))
				{
					this._Fac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLogoEmpresa", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> IdLogoEmpresa
		{
			get
			{
				return this._IdLogoEmpresa;
			}
			set
			{
				if ((this._IdLogoEmpresa != value))
				{
					this._IdLogoEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescripcionLogo", DbType="VarChar(50)")]
		public string DescripcionLogo
		{
			get
			{
				return this._DescripcionLogo;
			}
			set
			{
				if ((this._DescripcionLogo != value))
				{
					this._DescripcionLogo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogoEmpresa", DbType="Image")]
		public System.Data.Linq.Binary LogoEmpresa
		{
			get
			{
				return this._LogoEmpresa;
			}
			set
			{
				if ((this._LogoEmpresa != value))
				{
					this._LogoEmpresa = value;
				}
			}
		}
	}
	
	public partial class ConfiguracionGeneralSistemaResult
	{
		
		private int _IdConfiguracionGeneral;
		
		private System.Nullable<int> _CantidadIntentoLogin;
		
		private System.Nullable<bool> _LlevaComprobantes;
		
		public ConfiguracionGeneralSistemaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdConfiguracionGeneral", DbType="Int NOT NULL")]
		public int IdConfiguracionGeneral
		{
			get
			{
				return this._IdConfiguracionGeneral;
			}
			set
			{
				if ((this._IdConfiguracionGeneral != value))
				{
					this._IdConfiguracionGeneral = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CantidadIntentoLogin", DbType="Int")]
		public System.Nullable<int> CantidadIntentoLogin
		{
			get
			{
				return this._CantidadIntentoLogin;
			}
			set
			{
				if ((this._CantidadIntentoLogin != value))
				{
					this._CantidadIntentoLogin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LlevaComprobantes", DbType="Bit")]
		public System.Nullable<bool> LlevaComprobantes
		{
			get
			{
				return this._LlevaComprobantes;
			}
			set
			{
				if ((this._LlevaComprobantes != value))
				{
					this._LlevaComprobantes = value;
				}
			}
		}
	}
	
	public partial class SP_BUSCA_LISTASResult
	{
		
		private string _Descripcion;
		
		private string _PrimerValor;
		
		private string _SegundoValor;
		
		private string _TerceValor;
		
		public SP_BUSCA_LISTASResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrimerValor", DbType="VarChar(150)")]
		public string PrimerValor
		{
			get
			{
				return this._PrimerValor;
			}
			set
			{
				if ((this._PrimerValor != value))
				{
					this._PrimerValor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegundoValor", DbType="VarChar(150)")]
		public string SegundoValor
		{
			get
			{
				return this._SegundoValor;
			}
			set
			{
				if ((this._SegundoValor != value))
				{
					this._SegundoValor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TerceValor", DbType="VarChar(150)")]
		public string TerceValor
		{
			get
			{
				return this._TerceValor;
			}
			set
			{
				if ((this._TerceValor != value))
				{
					this._TerceValor = value;
				}
			}
		}
	}
	
	public partial class SP_MANTENIMIENTO_INFORMACION_EMPRESAResult
	{
		
		private System.Nullable<decimal> _IdInformacionEmpresa;
		
		private string _CodigoInformacionEmpresa;
		
		private string _NombreEmpresa;
		
		private string _RNC;
		
		private string _Direccion;
		
		private string _Email;
		
		private string _Email2;
		
		private string _Facebook;
		
		private string _Instagran;
		
		private string _Telefonos;
		
		private string _Fac;
		
		private System.Nullable<decimal> _IdLogoEmpresa;
		
		public SP_MANTENIMIENTO_INFORMACION_EMPRESAResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdInformacionEmpresa", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> IdInformacionEmpresa
		{
			get
			{
				return this._IdInformacionEmpresa;
			}
			set
			{
				if ((this._IdInformacionEmpresa != value))
				{
					this._IdInformacionEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoInformacionEmpresa", DbType="VarChar(100)")]
		public string CodigoInformacionEmpresa
		{
			get
			{
				return this._CodigoInformacionEmpresa;
			}
			set
			{
				if ((this._CodigoInformacionEmpresa != value))
				{
					this._CodigoInformacionEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreEmpresa", DbType="VarChar(100)")]
		public string NombreEmpresa
		{
			get
			{
				return this._NombreEmpresa;
			}
			set
			{
				if ((this._NombreEmpresa != value))
				{
					this._NombreEmpresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RNC", DbType="VarChar(50)")]
		public string RNC
		{
			get
			{
				return this._RNC;
			}
			set
			{
				if ((this._RNC != value))
				{
					this._RNC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(8000)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email2", DbType="VarChar(50)")]
		public string Email2
		{
			get
			{
				return this._Email2;
			}
			set
			{
				if ((this._Email2 != value))
				{
					this._Email2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Facebook", DbType="VarChar(50)")]
		public string Facebook
		{
			get
			{
				return this._Facebook;
			}
			set
			{
				if ((this._Facebook != value))
				{
					this._Facebook = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instagran", DbType="VarChar(50)")]
		public string Instagran
		{
			get
			{
				return this._Instagran;
			}
			set
			{
				if ((this._Instagran != value))
				{
					this._Instagran = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefonos", DbType="VarChar(100)")]
		public string Telefonos
		{
			get
			{
				return this._Telefonos;
			}
			set
			{
				if ((this._Telefonos != value))
				{
					this._Telefonos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fac", DbType="VarChar(50)")]
		public string Fac
		{
			get
			{
				return this._Fac;
			}
			set
			{
				if ((this._Fac != value))
				{
					this._Fac = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLogoEmpresa", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> IdLogoEmpresa
		{
			get
			{
				return this._IdLogoEmpresa;
			}
			set
			{
				if ((this._IdLogoEmpresa != value))
				{
					this._IdLogoEmpresa = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
