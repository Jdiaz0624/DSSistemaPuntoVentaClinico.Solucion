USE [SistemaFacturacionMedico]
GO
/****** Object:  Schema [Caja]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Caja]
GO
/****** Object:  Schema [Configuracion]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Configuracion]
GO
/****** Object:  Schema [Contabilidad]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Contabilidad]
GO
/****** Object:  Schema [Empresa]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Empresa]
GO
/****** Object:  Schema [Facturacion]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Facturacion]
GO
/****** Object:  Schema [GestionCobro]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [GestionCobro]
GO
/****** Object:  Schema [Historial]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Historial]
GO
/****** Object:  Schema [Inventario]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Inventario]
GO
/****** Object:  Schema [Listas]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Listas]
GO
/****** Object:  Schema [Nomina]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Nomina]
GO
/****** Object:  Schema [Reporte]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Reporte]
GO
/****** Object:  Schema [Seguridad]    Script Date: 11/17/2019 3:24:44 PM ******/
CREATE SCHEMA [Seguridad]
GO
/****** Object:  Table [Caja].[Caja]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Caja].[Caja](
	[IdCaja] [decimal](20, 0) NULL,
	[CodigoCaja] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[MontoActual] [decimal](20, 2) NULL,
	[Estatus] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Caja].[CuadreCaja]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Caja].[CuadreCaja](
	[IdUsuario] [decimal](20, 0) NULL,
	[Caja] [varchar](100) NULL,
	[Monto] [decimal](20, 2) NULL,
	[Concepto] [varchar](8000) NULL,
	[Fecha] [varchar](100) NULL,
	[CreadoPor] [varchar](100) NULL,
	[NumeroReferencia] [decimal](20, 0) NULL,
	[TipoPago] [varchar](100) NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Caja].[HistorialCaja]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Caja].[HistorialCaja](
	[IdistorialCaja] [decimal](20, 0) NOT NULL,
	[IdCaja] [decimal](20, 0) NULL,
	[Monto] [decimal](20, 2) NULL,
	[Concepto] [varchar](8000) NULL,
	[Fecha] [date] NULL,
	[IdUsuario] [decimal](20, 0) NULL,
	[NumeroReferencia] [decimal](20, 0) NULL,
	[IdTipoPago] [decimal](20, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdistorialCaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Caja].[Moneda]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Caja].[Moneda](
	[IdMoneda] [decimal](20, 0) NULL,
	[CodigoMoneda] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[Sigla] [varchar](100) NULL,
	[Tasa] [decimal](20, 2) NULL,
	[Estatus] [bit] NULL,
	[PorDefault] [bit] NULL,
	[UsuarioAdiciona] [decimal](20, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](20, 0) NULL,
	[FechaModifica] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Configuracion].[ConfiguracionGeneral]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Configuracion].[ConfiguracionGeneral](
	[IdConfiguracionGeneral] [int] NOT NULL,
	[CantidadIntentoLogin] [int] NULL,
	[LlevaComprobantes] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdConfiguracionGeneral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Configuracion].[InformacionEmpresa]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Configuracion].[InformacionEmpresa](
	[IdInformacionEmpresa] [decimal](18, 0) NOT NULL,
	[CodigoInformacionEmpresa] [varchar](100) NOT NULL,
	[NombreEmpresa] [varchar](100) NULL,
	[RNC] [varchar](50) NULL,
	[Direccion] [varchar](8000) NULL,
	[Email] [varchar](50) NULL,
	[Email2] [varchar](50) NULL,
	[Facebook] [varchar](50) NULL,
	[Instagran] [varchar](50) NULL,
	[Telefonos] [varchar](100) NULL,
	[Fac] [varchar](50) NULL,
	[IdLogoEmpresa] [decimal](18, 0) NULL,
 CONSTRAINT [PK_InformacionEmpresa] PRIMARY KEY CLUSTERED 
(
	[IdInformacionEmpresa] ASC,
	[CodigoInformacionEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Configuracion].[LogoEmpresa]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Configuracion].[LogoEmpresa](
	[IdLogoEmpresa] [decimal](18, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[LogoEmpresa] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLogoEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Configuracion].[Secuencial]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Configuracion].[Secuencial](
	[IdSecuencial] [decimal](18, 0) NOT NULL,
	[IdModulo] [decimal](18, 0) NOT NULL,
	[Pantalla] [varchar](100) NULL,
	[Sigla] [varchar](5) NULL,
	[Secuencia] [decimal](18, 0) NULL,
	[Estatus] [bit] NULL,
 CONSTRAINT [PK_Secuencial] PRIMARY KEY CLUSTERED 
(
	[IdSecuencial] ASC,
	[IdModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Contabilidad].[ComprobantesFiscales]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Contabilidad].[ComprobantesFiscales](
	[IdComprobante] [decimal](20, 0) NULL,
	[Descripcion] [varchar](100) NULL,
	[Serie] [varchar](1) NULL,
	[TipoComprobante] [varchar](2) NULL,
	[Secuencial] [bigint] NULL,
	[SecuenciaInicial] [bigint] NULL,
	[SecuenciaFinal] [bigint] NULL,
	[Limite] [bigint] NULL,
	[Estatus] [bit] NULL,
	[ValidoHasta] [varchar](50) NULL,
	[PorDefecto] [bit] NULL,
	[Posiciones] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Contabilidad].[Impuesto]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Contabilidad].[Impuesto](
	[IdImpuesto] [decimal](20, 0) NOT NULL,
	[Impuesto] [decimal](20, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdImpuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[ARS]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[ARS](
	[IdArs] [decimal](18, 0) NULL,
	[CodigoARS] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[CentroSalud]    Script Date: 11/17/2019 3:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[CentroSalud](
	[IdCentroSalud] [decimal](18, 0) NOT NULL,
	[CodigoCentroSalud] [varchar](100) NOT NULL,
	[Nombre] [varchar](200) NULL,
	[Direccion] [varchar](8000) NULL,
	[Telefonos] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_CentroSalud] PRIMARY KEY CLUSTERED 
(
	[IdCentroSalud] ASC,
	[CodigoCentroSalud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Cliente]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Cliente](
	[IdCliente] [decimal](18, 0) NOT NULL,
	[CodigoCliente] [varchar](100) NOT NULL,
	[IdTipoCliente] [decimal](18, 0) NULL,
	[TipoIdentificacion] [varchar](50) NULL,
	[Identificacion] [varchar](50) NULL,
	[IdSala] [decimal](18, 0) NULL,
	[Apellido] [varchar](100) NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[IdOcupacion] [decimal](18, 0) NULL,
	[IdSexo] [decimal](18, 0) NULL,
	[IdEstadoCivil] [decimal](18, 0) NULL,
	[IdNacionalidad] [decimal](18, 0) NULL,
	[Telefonos] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[OtroTipoComunicacion] [varchar](500) NULL,
	[Comentario] [varchar](8000) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC,
	[CodigoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[EstadoCivil]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[EstadoCivil](
	[IdEstadoCivil] [decimal](18, 0) NOT NULL,
	[CodigoEstadoCivil] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[IdEstadoCivil] ASC,
	[CodigoEstadoCivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Medico]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Medico](
	[IdMedico] [decimal](18, 0) NOT NULL,
	[CodigoMedico] [varchar](100) NOT NULL,
	[NombreMedico] [varchar](100) NULL,
	[IdCentroSalud] [decimal](18, 0) NULL,
	[Email] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Medico] PRIMARY KEY CLUSTERED 
(
	[IdMedico] ASC,
	[CodigoMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Nacionalidad]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Nacionalidad](
	[IdNacionalidad] [decimal](18, 0) NOT NULL,
	[CodigoNacionalidad] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Nacionalidad] PRIMARY KEY CLUSTERED 
(
	[IdNacionalidad] ASC,
	[CodigoNacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Ocupacion]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Ocupacion](
	[IdOcupacion] [decimal](18, 0) NOT NULL,
	[CodigoOcupacion] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [int] NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [int] NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Ocupacion] PRIMARY KEY CLUSTERED 
(
	[IdOcupacion] ASC,
	[CodigoOcupacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Paciente]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Paciente](
	[IdPaciente] [decimal](20, 0) NOT NULL,
	[CodigoPaciente] [varchar](100) NOT NULL,
	[IdComprobante] [decimal](20, 0) NULL,
	[Nombre] [varchar](500) NULL,
	[Telefono] [varchar](50) NULL,
	[IdCentroSalud] [decimal](20, 0) NULL,
	[Sala] [varchar](100) NULL,
	[IdMedico] [decimal](20, 0) NULL,
	[IdTipoIdentificacion] [decimal](20, 0) NULL,
	[TipoIdentificacion] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[IdSexo] [decimal](20, 0) NULL,
	[Email] [varchar](100) NULL,
	[Comentario] [varchar](8000) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](20, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](20, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[IdPaciente] ASC,
	[CodigoPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Sala]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Sala](
	[IdSala] [decimal](18, 0) NULL,
	[CodigoSala] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[Sexo]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[Sexo](
	[IdSexo] [decimal](20, 0) NOT NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[TipoCliente]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[TipoCliente](
	[IdTipoCliente] [decimal](18, 0) NOT NULL,
	[CodigoTipoCliente] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[usuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_TipoCliente] PRIMARY KEY CLUSTERED 
(
	[IdTipoCliente] ASC,
	[CodigoTipoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Empresa].[TipoIdentificacion]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Empresa].[TipoIdentificacion](
	[IdTipoIdentificacion] [decimal](20, 0) NOT NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[DatosFacturacionEspejo]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[DatosFacturacionEspejo](
	[NumeroConector] [decimal](20, 0) NULL,
	[IdUsuario] [decimal](20, 0) NULL,
	[IdTipoFacturacion] [decimal](20, 0) NULL,
	[NombrePaciente] [varchar](500) NULL,
	[Telefono] [varchar](100) NULL,
	[IdCentroSalud] [decimal](20, 0) NULL,
	[Sala] [varchar](500) NULL,
	[IdMedico] [decimal](20, 0) NULL,
	[IdTipoIdentificacion] [decimal](20, 0) NULL,
	[NumeroIdentificacion] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[IdSexo] [decimal](20, 0) NULL,
	[Email] [varchar](100) NULL,
	[Comentario] [varchar](8000) NULL,
	[GuardarCliente] [bit] NULL,
	[TipoProceso] [bit] NULL,
	[IdTipoPago] [decimal](20, 0) NULL,
	[IdEstatusirugia] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[EstatusCirugia]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[EstatusCirugia](
	[IdEstatusCirugia] [decimal](20, 0) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstatusCirugia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[EstatusFacturacion]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[EstatusFacturacion](
	[IdEstatusFacturacion] [decimal](20, 0) NOT NULL,
	[Estatus] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstatusFacturacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[FacturacionCalculos]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[FacturacionCalculos](
	[NumeroConector] [decimal](20, 0) NULL,
	[CantidadArticulos] [decimal](20, 0) NULL,
	[TotalDescuento] [decimal](20, 2) NULL,
	[Subtotal] [decimal](20, 2) NULL,
	[Impuesto] [decimal](20, 2) NULL,
	[Total] [decimal](20, 2) NULL,
	[IdTipoPago] [decimal](20, 0) NULL,
	[MontoPagado] [decimal](20, 2) NULL,
	[IdEstatusCirugia] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[FacturacionCliente]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[FacturacionCliente](
	[NumeroFactura] [decimal](20, 0) NULL,
	[IdEstatusFacturacion] [decimal](20, 0) NULL,
	[CodigoFacturacion] [varchar](100) NULL,
	[NumeroConector] [decimal](20, 0) NULL,
	[IdTipoFacturacion] [decimal](20, 0) NULL,
	[NombrePaciente] [varchar](100) NULL,
	[Telefono] [varchar](30) NULL,
	[IdCentroSalud] [decimal](20, 0) NULL,
	[Sala] [varchar](200) NULL,
	[IdMedico] [decimal](20, 0) NULL,
	[IdTipoIdentificacion] [decimal](20, 0) NULL,
	[NumeroIdentificacion] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[IdSexo] [decimal](20, 0) NULL,
	[Email] [varchar](100) NULL,
	[ComentarioPaciente] [varchar](8000) NULL,
	[FechaFacturacion] [date] NULL,
	[IdUsuario] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[FacturacionComprobante]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[FacturacionComprobante](
	[IdFacturacion] [decimal](20, 0) NULL,
	[CodigoFacturacion] [varchar](100) NULL,
	[NumeroConector] [decimal](20, 0) NULL,
	[TipoComprobante] [varchar](100) NULL,
	[Comprobante] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[FacturacionpProducto]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[FacturacionpProducto](
	[NumeroConector] [decimal](20, 0) NULL,
	[IdProducto] [decimal](20, 0) NULL,
	[Precio] [decimal](20, 2) NULL,
	[Cantidad] [decimal](20, 0) NULL,
	[DescuentoAplicado] [decimal](20, 2) NULL,
	[Total] [decimal](20, 2) NULL,
	[Secuencial] [decimal](38, 0) NULL,
	[NumeroPago] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[ProgramacionCirugia]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[ProgramacionCirugia](
	[IdProgramacionCirugia] [decimal](20, 0) NOT NULL,
	[FechaCirugia] [date] NULL,
	[IdCentroSalud] [decimal](20, 0) NULL,
	[IdMedico] [decimal](20, 0) NULL,
	[IdEstatusCirugia] [decimal](20, 0) NULL,
	[NoFactura] [decimal](20, 0) NULL,
	[NoReferencia] [decimal](20, 0) NULL,
	[UsuarioAdiciona] [decimal](20, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](20, 0) NULL,
	[FechaModifica] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProgramacionCirugia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Facturacion].[TipoPago]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[TipoPago](
	[IdTipoPago] [decimal](20, 0) NULL,
	[CodigoTipoPago] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](20, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](20, 0) NULL,
	[FechaModifica] [date] NULL,
	[BloqueaMontoPagar] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Inventario].[Almacen]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Inventario].[Almacen](
	[IdAlmacen] [decimal](18, 0) NOT NULL,
	[CodigoAlmacen] [varchar](100) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[Telefono] [varchar](50) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[IdAlmacen] ASC,
	[CodigoAlmacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Inventario].[Producto]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Inventario].[Producto](
	[IdProducto] [decimal](18, 0) NULL,
	[CodigoProducto] [varchar](100) NULL,
	[IdAlmacen] [decimal](18, 0) NULL,
	[IdTipoProveedor] [decimal](18, 0) NULL,
	[IdProveedor] [decimal](18, 0) NULL,
	[IdTipoEmpaque] [decimal](18, 0) NULL,
	[IdTipoProducto] [decimal](18, 0) NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[CantidadAlmacen] [int] NULL,
	[PrecioCompra] [decimal](20, 2) NULL,
	[PrecioVenta] [decimal](20, 2) NULL,
	[SegundoPrecio] [decimal](20, 2) NULL,
	[TercerPrecio] [decimal](20, 2) NULL,
	[FechaEntrada] [date] NULL,
	[LlevaDescuento] [bit] NULL,
	[PorcientoDescuento] [int] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Inventario].[Proveedor]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Inventario].[Proveedor](
	[IdProveedor] [decimal](18, 0) NOT NULL,
	[CodigoProveedor] [varchar](100) NOT NULL,
	[IdTipoProveedor] [decimal](18, 0) NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[Telefonos] [varchar](100) NULL,
	[Fax] [varchar](20) NULL,
	[Contacto] [varchar](70) NULL,
	[LlevaComision] [bit] NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC,
	[CodigoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Inventario].[TipoEmpaque]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Inventario].[TipoEmpaque](
	[IdTipoEmpaque] [decimal](18, 0) NOT NULL,
	[CodigoTipoEmpaque] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_TipoEmpaque] PRIMARY KEY CLUSTERED 
(
	[IdTipoEmpaque] ASC,
	[CodigoTipoEmpaque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Inventario].[TipoProducto]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Inventario].[TipoProducto](
	[IdTipoProducto] [decimal](18, 0) NOT NULL,
	[CodigoTipoProducto] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[IdTipoProducto] ASC,
	[CodigoTipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Inventario].[TipoProveedor]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Inventario].[TipoProveedor](
	[IdTipoProveedor] [decimal](18, 0) NOT NULL,
	[CodigoTipoProveedor] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_TipoProveedor] PRIMARY KEY CLUSTERED 
(
	[IdTipoProveedor] ASC,
	[CodigoTipoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Reporte].[HistorialFacturacionCotizacion]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reporte].[HistorialFacturacionCotizacion](
	[IdUsuario] [decimal](20, 0) NULL,
	[NumeroFactura] [decimal](20, 0) NULL,
	[NombrePaciente] [varchar](1000) NULL,
	[IdTipoIdentificacion] [decimal](20, 0) NULL,
	[TipoIdentificacion] [varchar](100) NULL,
	[NumeroIdentificacion] [varchar](100) NULL,
	[IdEstatusFacturacion] [decimal](20, 0) NULL,
	[Estatus] [varchar](100) NULL,
	[CodigoFacturacion] [varchar](100) NULL,
	[NumeroConector] [decimal](20, 0) NULL,
	[IdTipoFacturacion] [decimal](20, 0) NULL,
	[TipoComprobante] [varchar](1000) NULL,
	[ValidoHasta] [varchar](100) NULL,
	[Comprobante] [varchar](100) NULL,
	[Telefono] [varchar](100) NULL,
	[IdCentroSalud] [decimal](20, 0) NULL,
	[CentroSalud] [varchar](100) NULL,
	[Sala] [varchar](1000) NULL,
	[IdMedico] [decimal](20, 0) NULL,
	[Medico] [varchar](100) NULL,
	[Direccion] [varchar](8000) NULL,
	[IdSexo] [decimal](20, 0) NULL,
	[Sexo] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[ComentarioPaciente] [varchar](8000) NULL,
	[FechaFacturacion0] [date] NULL,
	[FechaFacturacion] [varchar](100) NULL,
	[IdUsuarioCrea] [decimal](20, 0) NULL,
	[Creadopor] [varchar](100) NULL,
	[IdProducto] [decimal](20, 0) NULL,
	[TipoProducto] [varchar](100) NULL,
	[ProDucto] [varchar](1000) NULL,
	[Cantidad] [decimal](20, 0) NULL,
	[Precio] [decimal](20, 2) NULL,
	[DescuentoAplicado] [decimal](20, 2) NULL,
	[Total] [decimal](20, 2) NULL,
	[CantidadArticulos] [decimal](20, 0) NULL,
	[TotalDescuento] [decimal](20, 2) NULL,
	[Subtotal] [decimal](20, 2) NULL,
	[Impuesto] [decimal](20, 2) NULL,
	[TotalGeneral] [decimal](20, 2) NULL,
	[IdTipoPago] [decimal](20, 0) NULL,
	[TipoPago] [varchar](100) NULL,
	[MontoPagado] [decimal](20, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Reporte].[RutaReporte]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reporte].[RutaReporte](
	[IdReporte] [decimal](20, 0) NOT NULL,
	[DescripcionReporte] [varchar](8000) NULL,
	[RutaReporte] [varchar](8000) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[ClaveSeguridad]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[ClaveSeguridad](
	[IdClaveSeguridad] [decimal](18, 0) NOT NULL,
	[IdUsuario] [decimal](18, 0) NULL,
	[Clave] [varchar](8000) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClaveSeguridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[EjecutarUsuario]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[EjecutarUsuario](
	[IdRegistro] [decimal](18, 0) NOT NULL,
	[IdUsuario] [decimal](18, 0) NOT NULL,
	[CantidadIntentos] [int] NULL,
 CONSTRAINT [PK_EjecutarUsuario] PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC,
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[LogonBD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[LogonBD](
	[IdLogonBd] [decimal](20, 0) NOT NULL,
	[Usuario] [varchar](20) NULL,
	[Clave] [varchar](8000) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLogonBd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[Modulo]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[Modulo](
	[IdModulo] [decimal](18, 0) NOT NULL,
	[CodigoInterno] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[Opciones]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[Opciones](
	[IdModulo] [decimal](18, 0) NOT NULL,
	[IdPantalla] [decimal](18, 0) NOT NULL,
	[IdOpcion] [decimal](18, 0) NOT NULL,
	[CodigoInterno] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Opciones] PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC,
	[IdPantalla] ASC,
	[IdOpcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[Pantalla]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[Pantalla](
	[IdModulo] [decimal](18, 0) NOT NULL,
	[IdPantalla] [decimal](18, 0) NOT NULL,
	[CodigoInterno] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Pantalla] PRIMARY KEY CLUSTERED 
(
	[IdModulo] ASC,
	[IdPantalla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[Perfil]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[Perfil](
	[IdPerfil] [decimal](18, 0) NOT NULL,
	[CodigoPerfil] [varchar](100) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[IdPerfil] ASC,
	[CodigoPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[Usuario]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[Usuario](
	[IdUsuario] [decimal](18, 0) NOT NULL,
	[CodigoUsuario] [varchar](100) NOT NULL,
	[IdPerfil] [decimal](18, 0) NULL,
	[Usuario] [varchar](20) NULL,
	[Clave] [varchar](8000) NULL,
	[Persona] [varchar](1000) NULL,
	[Estatus] [bit] NULL,
	[UsuarioAdiciona] [decimal](18, 0) NULL,
	[FechaAdiciona] [date] NULL,
	[UsuarioModifica] [decimal](18, 0) NULL,
	[FechaModifica] [date] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [Caja].[Caja] ([IdCaja], [CodigoCaja], [Descripcion], [MontoActual], [Estatus]) VALUES (CAST(1 AS Decimal(20, 0)), N'CA201991', N'Caja Principal', CAST(0.00 AS Decimal(20, 2)), 0)
INSERT [Caja].[Moneda] ([IdMoneda], [CodigoMoneda], [Descripcion], [Sigla], [Tasa], [Estatus], [PorDefault], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(1 AS Decimal(20, 0)), N'MO201991', N'Pesos Dominicanos', N'$RD', CAST(1.00 AS Decimal(20, 2)), 1, 1, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-16' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-16' AS Date))
INSERT [Caja].[Moneda] ([IdMoneda], [CodigoMoneda], [Descripcion], [Sigla], [Tasa], [Estatus], [PorDefault], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(2 AS Decimal(20, 0)), N'MO201992', N'Dollar', N'$US', CAST(52.40 AS Decimal(20, 2)), 0, 0, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-16' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-16' AS Date))
INSERT [Caja].[Moneda] ([IdMoneda], [CodigoMoneda], [Descripcion], [Sigla], [Tasa], [Estatus], [PorDefault], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(3 AS Decimal(20, 0)), N'MO201993', N'Euro', N'$E', CAST(60.00 AS Decimal(20, 2)), 0, 0, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-16' AS Date), NULL, CAST(N'2019-09-16' AS Date))
INSERT [Configuracion].[ConfiguracionGeneral] ([IdConfiguracionGeneral], [CantidadIntentoLogin], [LlevaComprobantes]) VALUES (1, 3, 1)
INSERT [Configuracion].[InformacionEmpresa] ([IdInformacionEmpresa], [CodigoInformacionEmpresa], [NombreEmpresa], [RNC], [Direccion], [Email], [Email2], [Facebook], [Instagran], [Telefonos], [Fac], [IdLogoEmpresa]) VALUES (CAST(1 AS Decimal(18, 0)), N'IF20191601', N'Biortho', N'131929206', N'AV. Las Americas 361, Local 201, Ens. Ozama, St Dgo, Este', N'', N'', N'', N'', N'(809)-608-0042', N'', CAST(1 AS Decimal(18, 0)))
INSERT [Configuracion].[LogoEmpresa] ([IdLogoEmpresa], [Descripcion], [LogoEmpresa]) VALUES (CAST(1 AS Decimal(18, 0)), N'Logo', 0xFFD8FFE000104A46494600010101000000000000FFDB004300030202020202030202020303030304060404040404080606050609080A0A090809090A0C0F0C0A0B0E0B09090D110D0E0F101011100A0C12131210130F101010FFDB00430103030304030408040408100B090B1010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010FFC000110801D4050003012200021101031101FFC4001D000100020301010101000000000000000000080905060704030201FFC400641000010303020304050309120A070802030100020304050607110812210913314122516171811432911523384252577275A116171819333756627476829295B1B3B4D2D32436435393A2A4B2C1D1253563739496C2345483B5C3D4E1E355F026A3F1FFC4001C0101000203010101000000000000000000000102030607050408FFC40043110002010301050407070205030305000000010203041105061221314151617191131481A1B1C1D11522324252E1F0729216233435536282F133B2C2364383A2D2FFDA000C03010002110311003F00B3D444401111004444011110044440111100444401111004444011110044440111100445F2AAABA5A1A792AEB6A62A78221CCF925786B5A3D649E810733EA8B9C5FF0088FD06C5CB997BD5BC5E0919E3136E0C9641FC0612EFC8B9EDE38FEE176D45CC833BAAB93DBE2DA3B4551EBEA0E7C6D69F81D94651F752D32F6BFF00E9D193F08BFA1225144BAEED31E1FE99C594766CC2AC8F0736821634FF001A607F22C549DA7FA3EDE6EEB08CA9FB786ED806FF00EB9D9328FAE3B3DAA4B9519132514378FB4FF479C477B84E54C1E7CAC81DB7FF00EC0B2B41DA5FC3E54B836AED598519F373EDF0BDA3F8B313F913284B67B548F3A32259A2E71A39C4069AEBBD2DC2AF4EAE15D54CB5BA36D57CA28258031CFDF940739BCAE3E89E8D248E9BF885D1D49E5D6A352DE6E9D58B8C9747C184444310444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111005003B4878827B9D4FA0D8BD6F2B5A595B90491BBABBA6F153123CBA87B87B19EDDE5EEBCEAEDAB4434C6EF9EDCB9249A9A2315053B8EDF28AA70DA367BB7EA7D80AA59C9723BCE5F7FB865190D7495972BA543EAAAA779EAF91C7727D83D43C00D82AC9F4375D8ED27D66BBBDAABEEC3977CBF6F8E0C6A222A1D40222200BDD62B25D725BCD0E3D63A292AEE172A88E969608C6EE9257B835AD1F12BC2A76766FF0FB2DC2E33EBBE4F463E47465F47618DEDEB24FE12D47B0347A0D3E64BBC397A92C9E7EA9A8434CB595C4FA725DAFA2FE74261F0EDA336ED0AD2CB560F4DDD495CD60A9BA54B0749EADE0778E07CDA3E68F6342E9688B29C3EBD69DCD4955A8F3293CB088886208888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888021200DC9D80451CF8DFD7E3A2FA5735AAC55822C9B296C943405AEF4E9E22DDA5A81E60B41D9A7C9CE07C9391F4D9DA54BEAF1B7A5CE4F1FBFB0861C79F1012EACEA6BB0DB1D6F3E3188C8FA78431DE854D6784D31DBC76DB91BEA01C7ED8A8C08E739CE2E738924EE493D494589BC9DCAC6CE9D85BC6DE9728AFF00CBF6844443EA088880DDB4634AEFBACFA8F66D3EB0B0B64B84E3E53391BB69A99BD6599DEC6B4120799D80EA42BABC3712B2E098B5AF0FC769453DBAD14CCA5A760FB968DB73ED27727DA5467ECFDE1F5DA67A7A751F25A211E4396C4C96163C7A74B41E31B4FA9CFF009E47902D07A8214B1578AC1C976B357F5FBAF414DFDC870F17D5FC97EE111158D5022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880F1DE6EF6EC7ED3597CBBD5329A86DF03EA6A2679D9B1C6C69739C4FB0054C1C47EB4DD35DB552EB9A55C8F6DBDAEF92DA6989E94F46C3B306DF74EEAF71F3738F96C04C3ED20E201F69B553E85E315C595373636AAFAF8DDD5B4FBEF1C048EA3988E670F5003C0955DAA927D0E9DB1BA4FA0A2EFAAAFBD2E11EE5DBEDF8788444553770888802EF9C19E814FAE5AAF4DF54A03F99AC75CCB85D9E47494077D6E9C7B5EE1D7D4D0E3EA5C2EDD6FADBB57D35AEDB4D25455D5CAC8208631BBA491C766B40F59242B96E17743A9341B4A2DB8B48D89F7AAB68ADBCCECF07D53C0DD80F9B583D007CF977E9BECA62B26B7B4FAB7D9968E34DFF993E0BBBB5FB3E275A8A28E0899042C6B238DA18C6B46C1A00D800BF488B21C78222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802D3358B53ACBA3DA7379D40BDBDA62B6C04C31176C679CF48E21ED73B61EEDD6E6AAEFB41F88093517501BA638F57F363D894AE6D4774FDD95570DB67B8EDD0F763760F512FF5F486F07B3A16972D5AF234BF2AE32F0FDF9119336CC2FBA8196DDB34C96B1D5372BC554955512389F171E8D6FA9AD1B35A3C0000792C2222C676B8C6308A8C56120888848445B5696E9CDFB5673DB3E018DC60D65DAA1B1778E1E8411F8BE577ED5AD049F5EDB0EA4215A95234A0E73784B8B64ACECE6E1F5D93E4D36B664D49FF0045D86434F688DE3A545611E94BF8318236F5B9DFB52AC916B9A7581D8B4CB09B460B8E43C94368A5653B091B3A4701E948EFDB39DBB8FB4AD8D644B0711D6B5396AB772AEFF0F28AEC5FCE2C222293CA088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222F8D6D6D2DB68AA2E35D3B20A6A589F34D2BCECD631A097389F2000250259E08E1DC636BD3743349EAAA6D556C8F25BE8750DA06E0BA3711E9CFB7ED1A7707C398B7DCA9FA69A5A895F3CF2BE4964717BDEF3BB9CE2772493E2495D7F8A9D72ADD77D59B8644C9E4FA896F2EA0B3404FA2CA66B8FA7B7DD3CEEE27DA07905C79636F2765D9BD27ECBB34A6BEFCB8CBE4BD9F1C8444506C01111005663D9DBC3E1C270E9358726A50DBCE4D1725B637B7D2A6A0DFE77B1D211BFB1A1BEB20435E13B422AB5E756282C7531BD960B6115F799C0F081A77110FDB48E019EC05C7AEDB2B8EA4A4A6A0A586868E16434F4F1B628A360D9AC6346C001EA002B4575343DB3D5BD14169F49F1971978745EDE7E1E27D51115CE6C1111004444011110044440117C2A6BE8688735656C100FF00B49037F9D606BB52B05B76E2A725A3E61E2D8DC5E7E86EE80D951737B86BE60F49B8A365C2B9DE4628031BF4BC83F916B35FC46D438916CC62360F274F505DBFC1A07F3A8C93BACEDC8A3757EBB67357B8A7929291A7FCDC3B91F13BAD76BB51338B8EE2A727B86C7C447298C7FABB2649DD64B345CB744F3F92FB40EC6AEF5064AEA26EF048F3BBA58BD47D65BFCCBA92921AC044442022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022C76437EB7E3368A8BCDCE50C869DBBEDE6F779347AC92B81CDAF59C3AA65920F90B2173C9646E837E56F90DF7EA99252C923514768F882CDD9F3A8ED127E14127FC1E17AA3E223291FAAD96D4EFC16C83FF5951927759DFD1708671197A1FAA63744EFC199E3FE6BD0CE23AA7FCA62917BDB567FB09923759DBD17188F88D80FEAB8C483F06A01FF0082F4C5C455A5C407E3959B9E9B364694C8DD675E458FB0DD2A2F36C8AE3516B9EDE661CCD867239C37C8903C37F52C82920285BDA35AFCEC5313874631AB818EE9914626BB3A27ECF86877E919DBA8EF08D8FADA1C3C0A957A99A8163D2CC12F39EE45306515A298CCE1BEC647F83231ED738B5A3DA55286A3E7B7FD4FCDEF19DE4B52E9ABEEF52E9DFB93CB1B7C191B47935AD01A079001564F06DFB23A4FAEDCFAD545F721EF974F2E7E46B6888A87560888802FA53D3CF57511D2D2C2F96699E238E3637773DC4EC0003C492BE6A5F767A70F9F9E0674FD56C968F9AC38B483E46C7B7D1AAAFF0016FBDB18F48FEDB947AD12C9F1EA17D4F4EB695CD4E4BDEFA2F69333843D05834234A28EDD5F1B1D915E832E178907DA4AE68E5801F5460F2EFE6EE63E6177044594E1B757352F2B4ABD579949E5851838EDE22EA746F4FA3C5711B93A9B2CC9C3A28668652C9686947EA93B48EA1E7E6B4F9124FDAF591794E4D66C371CB8E5590563296DD6AA67D554CAE3B72B1A373F13E007992152C6BAEAEDE75BF532EF9FDD83A28EAE5EEE86979B714B4ADE91C63DBCBD5C7CDC5C7CF65593C1B16CAE91F68DD7A6AABFCB8717DEFA2F9BFDCDEF12E39B89AC4B92366A24977A76FF0091BB52C555CDEF90B7BDFF005D779C0FB516E513E2A6D49D398278FA092AAD1396387ACF7726E0FBB987BD40C455CB3A25CE81A6DD2FBF4527DAB83F760BA2D29E29744358A36478966B4B15C1C06F6CB8914B58D3EA0C79D9FEF6170F6AEB0A81E29658256CD04AF8E4610E6BD8E21CD23CC11E0A4B68471E1AB1A4D34168CA2A64CBF1C0435D4D5D293534EDF5C331EBD3EE5DB8F572F8AB29769A86A5B1338273B1967FE97CFD8F979E3C4B6245CEB4675F34DB5DAC66EF82DED92CF0B41ACB74DB32AA909F27B3D5EA70DDA7D7BEE174556346AD46A5BCDD3AB16A4B9A67C6BA1A8A8A4961A4AB752CCF690C99AC6B8B0F91D9C083F151BF50EB7536C1757DBF20C8AE0F85FBBA196194C70CCDF580CD86FEB07C3F2A92CB15936336ACB2D32DA6ED007C7203C8F1F3E277939A7C88FF00FEA331A78221CB513CEE2E9A692427A92E7124FD2BE6B3998E2373C32F325A6E2C247CF86603D1959BF470FF0088F25835432044440111101EEB1DE6B71FBB52DE6DD298E7A5903DA41F11E6D3EC237047A8A96F8FDEA9322B3525EA89DBC55518781BFCD3E60FB8EE143A5D8F4032D7C3555188D5CBF5A9B7A8A5E63F35E3E7B47BC6C76F583EB528AC9753B92222B140888802222008888022D62FBAA7A638B5C5F67C9B51B17B457C6D0E7D2D7DDE9E9E66823704B1EF0E008F0E8B1DF9FAE88FDF8F07FF00CC349FDE21995B5692CA83C78337845A3FE7EBA23F7E3C1FFF0030D27F78B61C6F30C4B32A596B710CA6D17CA7824EEA59ADB5D154B237EDBF2B9D1B8807620EC7D6844E855A6B7A716978332E8888620888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008B5AC875374DF12AF16ACAF5071AB2D696097E4D70BB53D34BC87C1DC923C1D8EC7AEDE4B19F9FAE88FDF8F07FF00CC349FDE219A36F5A4B31836BC19BC22D1FF003F5D11FBF1E0FF00F98693FBC59CC673AC2334F947E63B31B1DFBE47C9F28FA997086ABB9E6DF979FBB71E5DF95DB6FE3B1F52112B7AB05BD28B4BC199C44443104444011162723CBB14C3A923AFCBB27B4D8E96693BA8E7B956C74D1BDFB13CA1D238027604EDE3D0A1318B9BDD8ACB32C8B47FCFD7447EFC783FFE61A4FEF13F3F5D11FBF1E0FF00F98693FBC4337AAD7FD0FC99BC22D56CBAB1A5992DCA1B363BA958ADD6E151BF75494579A69E6936049E5631E5C760093B0F0056D48639D39D3789A69F784444281111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004243417388007524A2E6BAD79C8C7ACBF506825DABEE4D2D7107F5287C09F79F01F140B89CD757F3E395DE8DB6DF3136CA0716B36F0964F02FF7790F67BD73E445532A580888A00444407F5AD739C1AD049276007892BBBE94691B2DAC8B24CA2983AACECFA6A678DC423C9CE1E6EF6797BD79746F4BDAC6C397E4106EF3E9D153BC7403CA470FE61F15D9D5922927D0222E39C56EB953E83E9357E454D3C62F971DE82CD11D89350E69FAE6DE6183771F80F35265B6B7A9775A34292CCA4F08869DA2DAFAFCBF318B4731DAF26CF8DCBDE5CFBB77A33D7EC4723B6F1118246DF745DE606D0CD7D6AEAEAABEAA6AEADA892A2A2A2474B34B2B8B9F23DC77739C4F5249249257C9626F2771D3AC69E9B6D1B6A7D3DEFAB088887DA1111019EC130ABF6A2E5F6AC271AA6EFEE377A96D3C2DFB56EE7AB9C7C9AD1B927D415D6E92E9958747F4FACFA7F8E8E6A6B5C01924C5BB3AA263D6495C3D6E76E76F2E83C944EECE3E1F3EA0D8E6D73C9E948B85D9AEA5B244F6F58697C1F3FBE43BB47ED5A4FDB749C0AF1472BDAFD5FD72E3D5293FB90E7DF2FDB9798445CF75EB57ED3A1FA6377CF6E4192CF4D118ADF4AE76DF29AB702238FDDBF577A9A0AB1A951A33B8A91A54D664DE1110BB483884739F4FA0D8B558E41C959904AC7789F18A9BA7F1DDFC01EB501164F26C8EF19864371CA720AC7D55CAEB5325554CCE3D5D23CEE7DC3C80F200058C589BC9DC349D3A1A5DA46DE1CD737DAFABFE74088887A21111019CC2B38CAF4EF22A5CAF0CBDD4DAEE746EE68E781DB6E3CDAE1E0E69F307A15699C2871878EEBD5BE2C6324305AB36A58B79A947A315735BE32C3BF9F996788EBB6E154BAF6D8EF776C6AF1477FB0DC26A1B8DBE66D4535442EE57C5234EE1C0A94F078BACE894358A589709AE52F93ED45F6A2E03C21F13743C41E1669EEEE869F2EB2B1ACB9D33080276F40DA88DBF72E3D08F277BC2EFCB27338E5DDAD5B2AD2A159625135ACFF0AA3CDAC525BE50D655440BE96623E63FD47D87C0A8AF70A0ABB5D6CF6EAF85D0D453BCC7231DE208533571BD79C204D03333B747E9C5B455AD03C5BF6AFF008781F78F52868C317D0E1C888AA5C222200BA668A6115F78BEC39348648286DD2733641D0CB20FB51ECEBD7E85ABE098557E6F7B8EDD4FBC74CCF4EA6723A46CFF0099F003FE0A535A6D54363B6D3DAADB088A9E99818C68FE73ED3E2A522B278E07AD11158A044440111100445E1BF5DE971FB1DC6FD5CEE5A7B6D24D5731F53236173BF20284A4E4F08A6FE2DF276E5DC48E7F748DAE6B20BC496E6871DFFF0065029C91EC2622EF8AE46BD779B8D45DEEF5D76AB9DD34F5B532D44B23FE73DEF717171F692775E4588EFB6B455BD08515F9525E4B015A9F670E331D9787B6DE3BA7B26BE5DAA6A5E5DE0E6B368DA47B366AAAC5757C30634712E1EF00B2B9E5CE163A7AB7EE362D7540EFDCDF81948F82B4799AA6DBD7DCB18525F9A5EE49FEC74F444573960444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401117F1EF646C74923835AD05CE713B00079A02A178ECCA1D93713394B05432686D1F27B6445BE0DEEE2697B7DE1EE783EE5C016C5A8F93C99B6A164D98CB1863AF978ACB89603B86F7B339FCA3D839B65AEAC4CEF76143D5AD69D1FD314BC90566DD98F8C3AD9A3B7DC9658D9CD7ABD3846F03D231C31B59B1F738BFE95592AE3382DC60E2DC35E194B252F7135752BEE32B7EE8CD239ED77C585A55A3CCD6F6D2BFA3D3953FD524BCB2FE48EDC888AE728088880280FDA9B9572D3607844354D3DE3EB2EB5108F11CA191C4E3EC3CD30F8153E1552F68CE50FBFF121556AF43BBC76D1476E6169DF72E0EA8713EDDE723F82AB2E46CFB2143D36A9197E94DFCBE645F444543AF12C7B3631A75DF5EEA6FA5AD31D92CF3C8771D43E42D6348FA5DF4AB49503BB2CF19E5B3E7399494E077B534D6C865F33CAD3248DFF005E33F153C55E3C8E41B5B5FD36A935FA525EECFCC2222B1AC8444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444407E647F771BA4E473B95A4F2B46E4EDE43DAA22E617FADC9B22ADBB57B1F1BE490B5B13BC6268E819F01F97752F170FD6FD3B30BDF9959E0FADBCFF8746D1F34FF009C1ECF5FD2A1968B38D2222A970888802E8FA3DA78729B97D5BBA53EF6BA178E8E1E8CF28EBCBED03A13F00B4EC5B1CAECAEF94D64A06FA73BBD379F08D83E738FB00FF8052C6C966A2B05AA9AD16E8C320A6606347AFD64FB49EAA522B2783DC1A1A035A00006C00F244456287E659238637CD33DAC8E369739CE3B0681E24954F3C60EBC4DAE9AB3575D6FAC7498E5939A82CF1871E47460FA7301E1BC8EEBBFDC868F25337B4335F4E9F604CD2DC7AB8C57DCB213F29746ED9F05BF72D79E9D477841603EA0F5580A927D0E91B19A4EE41EA155717C23E1D5FB7979F684445537D0888802EA9C34E895C35E3556D98746248ED713855DDEA5BFE46918473007EE9DD1ADF6BB7F00572C631F23DB1C6D2E73880D681B924F92B73E0A387F8F44B4AE0AEBCD3019464CD6D75C9C47A504647D6A9C1F535BD4FED9C7C8052964F0768B565A559B945FDF9708FD7D9F1C1DF2D36AB758AD74965B452474B43430B29E9E08C6CD8E36001AD1EE017A9116438CB6DBCB04803727601552F1E5C413F56B52DD86D82B03B18C4A47D3C26376EDABABF09663E440DB91BEC0E3F6CA737183A9D97E9F69455D069E63F76BA64990075052BE828A5A8F91C647D76777203B10D24377FB620F5008552F70C173BB746FABBAE1D7EA666E4BE5A8B7CCC1BF9925CD5593E86FBB19A6C379DF566B3CA2BE2FE4BDA60511150E8E11110044440111101B8E916A8643A3BA8369CFF1B9DCDA8B74DBCB17310CA980F4922781E2D7377F71D8F880AEAB00CDEC5A918659F39C6EA9B3DBAF34ACA985C0825BBFCE63BD4E6B81691E4410A8914F3ECCCD65961AEBBE895DEAF78676BEEB686BDDF35E36EFE36FBC6CFDBF6AE3EB568B34DDB0D295D5B7AE535F7E1CFBE3FB73F0C960EBE15F434F72A29EDF57187C3511BA291A7CDA46C57DD15CE58440CAAC1518C6415B63A91D69A5218EFBB61EAD77C5A415895DA7886C7835F6FC9E268F4BFC1263EDEAE67FEAFA1716556644F282F6D9ACF5F7FBA53DA2DB0996A2A5E18C03CBD64FA801D495E48E392691B144C73DEF21AD6B46E5C4F8001494D27D3A661D6CFAA17285A6ED56DFAE1F1EE59F700FAFD6896437833F8461D6FC2AC91DAE8DA1D2BBD3A8988F4A590F89F70F003D5F15B0222B18C22220088880222200B93F15B931C4B879CE6ED1D4B6095F6A9296273BCDF36D186FBCF36CBAC289FDA5592FD47E1F69AC8C2C2FBF5FA9699CD2EF48471B2498B80F3D9D1C63F84A1F23D1D2287AC5FD1A7DB25E59CB2AD5111633BA195C4B1FA8CB32AB362D48E6B67BC5C29E8232EF00E9646B013ECDDCAF8A0820A5823A6A68991430B0471C6C1B358D0360001E00054E5C19E3032AE24F0BA39293E510D2563ABE569F26C31B9E1DF07069F82B905789CD76EABEF5C52A3D89BF37FB0444563440888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802D075FB226E29A279BDF9DCFBD358EAC34B0EC439F1963483EC2E056FCA35F684E4C31EE1B2EB4ACA974335EEBE92DD186FF009405C647B4FB39237FD08CFBB4CA3EB37B4A976C97C4A992773B9444588EEE159DE21DA07C33E2189D9714A21959A7B35BE9EDF1136C6EE59146D6027EB9E3B355622294F0797AA68F6FABA8C6E3388E71878E65A97E992F0E3EACABF92DBFDE2E87A2BC57E966BDDFEB31CC0A3BD1AAA0A5F95CCEADA36C2C11F306F421E773B91E4A9A9580F65962E3E4D9DE692D2904BE92D704DE47A3A491A3DDBC47E214A936CD475BD9AD3F4DB19DC53DEDE58C65F56D2EC27CA222B9CF02A4BE237246E5BAEB9C5FD81C19517AA96B038EE4358EE403FD5573D97DEA971AC4EF79156C863A7B55BAA6B6678F16B2289CF71FA1A5510D7564F70ADA8AFAA797CD532BE691C4F5739C4924FC4AA48DFF00612866A56ADD892F3CBF923E2888012760372554E8C5B3767AE24CC67868B45C0C2F8E7C8EBEB2EB307789FAE770C23D86381847BF7F35251691A1F8EB713D1DC2F1C6927E4163A388923625DDD3493F124ADDD644707D4ABFACDE55ADDB26FDFC0222293E20888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802F9D453C1574F252D4C4D92295A58F6386E1CD3D082BE88808B7A9B81CD84DF1CC8039F6EAA264A590F90F361F68FCA365A729799762F4197D8E7B357B07A639A2936EB1483C1C3FF00EF86EA295F6CB5D8F5DAA6CF7188B27A6796BBD447911EC23AAAB4648BC9E0445B1E9F632FCB32AA2B5721300777D507C9B137A9DFDFD07BC85049D9B43F0BFA8762FCD05743CB5B7301CC0475641F6BF4F8FBB65D317E638D90C6D8A3686B18035A07901E0BF4AE627C42C1E7198D934FB11BB66B91D5369EDD67A57D54EF71DB70D1D1A3D6E71D9A0799202CE2AEBED24D7975DAF54DA178F569F925ADD1D6DECC6FE925416EF142EDBC43010E20FDB16F98E90DE0F5347D365AADDC6DD72E6DF625CFE8BBC893ABBA997CD5FD43BCE7F7F99EE9EE7505D146E76E2080748E268F20D6803DFB9F35A7A22C676EA74E3460A9C161258411110B844594C5B19BCE6591DB715C7E91D5371BAD4C74B4D10FB67BCEC373E43CC9F20844A4A09CA4F09124B808E1F06ABEA3FE6E323A4E7C6B127B672C7B776D5D6F8C517E0B7E7BBF05A3EDBA5AA2D07433492CBA25A6768C02CE1B23A922EF2B6A797635554E00CB29F79E80793401E4B7E5912C1C5B5FD55EAD78EA2FC0B847C3B7DBCC222293C4088880D3334D18D28D4363DB99E9F58AE92483633CD44C138F74A0078FA544DD68ECD0C76E3495178D14BF496CAF6EEF6DA6E4F32534BFB564BF3A33EAE60E1E5D3C54E5450D64F4ACB58BDD3E49D0A8D2ECE6BC8A26CEF4FF0031D34C867C5F38B0555A6E301EB14ECD83DBE4F63BC1ED3E446E16BCAEBF5E340B07D7DC425C7329A46C559134BADD738983E51452F9169F369FB669E847B76229F75574CB26D20CEAE7816594FDDD75BA4D9B2347A13C47AB2561F36B875FA4792A3583A9683AFD3D620E325BB51735DBDEBF9C0D4911141B084444016DBA4B9EDC74C352F1BCF6D9239B2D9AE11543C076DDE43BED2C64FA9D197B4FB1C56A48852A538D583A73594D61FB4BF2B757D25D6DF4B74A0944B4D590B2A2178FB68DED0E69F88217A171AE0F72D9334E1C70ABACCF73A58284DBE4739DCC5CEA77BA227FD45D95653825D5076D5E745FE56D793C1AD6A4D945FF0009BAD0067348213343B78F78CF486DEFDB6F712A27A9A72C6D9637C4F1BB5ED2D23D8547DC034B24BDE575B2DDE94B2D56BAB7C6E69E8267B5DD231EC1E7F479A86628BC19CD15D35E511E637D83D23D686170F01FE74FFC3E9F52ED0BF8C632363638D81AD68D9AD036007A82FEA921BC844442022220088880222200ABAFB537261539660987B39C7D4FB7D5DC64EBE8B8CF23236F4F58F93BBF8CAC5154971FF930C87895BED3C752F922B3D352DBDAD3E11B9B187380FE13C9F8AACB91B56C750F4BA9A9FE94DFCBE6472444543AD9303B3271965D75AAF3914B1C85B63B23CC6F03D112CD235801F7B3BCDBDCACD2B2B68EDD4B256DC2AE1A5A785BCD24D34818C60F5971E802A80E1E38A2B870E38B6554D8AE3D0D75FF00269A980AAAB77F83D2C50364E53C83ABDC5D33F71B8003478EFD345D4AD72D57D5DAE75667B9B5CAE2CE6E68E93BD31D2C5F810B7660F7EDB9F325593C2346D5766EEB59D4655A5250A6B093E6DE171C2F1CF365AC665C6270E7843DF0DD352ADF553C7B87436E0EAB7EFEAFAD823F2AE5977ED36D05A1718ED98EE657220F47B28A9E28CFC5F3077FAAAAFD13799F551D8AD3E9AFF31CA4FC71F05F32CB29BB517489F29159A7D97C51EFF3A214B23B6F7195BFCEB77C6BB43786CC865641537ABCD91EFE83EA95B8B5A3DEE89CF68F8955388A379992A6C6E993588A92F07F5C97B1876A2E09A8349F2EC272EB55EA100171A3A96C8E68FDB341DDBF10B62542D61C8F20C56E70DE719BE57DA6BE9DDCF15551543E19587D61CC208535F87BED1DBCDBAAA9318D778C5750BDCD885FE9E2DA78078734D1B07D700F32D1CDEC255948D6B53D8CB8B68BA9692DF5D9CA5F47EE7DC58922F0D8EFB66C96D34B7DC7EE94D71B756C625A7A9A690491CAC3E05AE1D0AF72B1A5B4E2F0F9844442022C46617E8F16C52F1924AF8D8DB5D0CF57BC87666EC6170DFD9B855C07B4E75977E989E33FE8E5FED286F07ADA6E8B77AB294AD926A3CF2F1CCB3645591FA673ACDFB13C67FD1CBFDA4FD339D66FD89E33FE8E5FED28DE47A7FE0ED53F4AF3459BA2C56275578AEC5ACD5B914504775A8B7D3CB5CC837EEDB50E8DA640CDFED4389DBD8B2AAC6AF28EEB682222101162B27CAB1BC2ECB51916597BA3B4DB691BCF354D54A236347BCF89F60EA5417D6EED2E7367A9B168758DAE8D84C62F77267CFF002E68A0F21EA2F3BFADA3C143783D2D3B49BBD525BB6F1CAEAF925EDFE3278DDAF368B0D0C973BE5D292DF4717CF9EAA66C51B7DEE7101716CBB8DBE1B30E7BE1ABD4386E3333A18ED703EA8EFEADDA3947C4ECAA8B3CD51D43D4EBA3AF19EE6173BD54B89E5F94CE4C7183E2238C6CC8C7B1A005ABAAEF1BB5A6C3528A4EEAAB6FB23C179BCFC1167773ED3BD0CA590C76DC4F34AEDBEDFE494D130FBB79F9BE90178E87B50F476478171C0B31A769F130B2965DBE0666AAD0451BCCF556C769696375F9B2DBB15E3FB86ACA2564126535D6595E76E5BAD0BA203DEF697307F19775C6730C5733A0174C4B23B75E294FF95A2A964AD1EC3CA4EC7D8550E2CEE1D9DE67A7D778AFD84E4F72B2D7C2771351D43A32E1F72E00ECE69F36B8107CC29DE3CEBBD87B79A6ED6A38BEFE2BE4FE25EEA2827C39F68C535DEAE9310D768E9E8669488A2C8216F2405DE5F2860F99BFDDB7D11E600EA2745354D3D653C757493C73C13343E392370735ED3E0411D08564F2687A8E9773A5D4F47731C763E8FC1FF19F44445279E111100445F89A6869E27CF512B228A36973DEF706B5A078924F80407ED7CAAEB292DF4D256D7D5434D4F0B79A49667863183D65C7A00A1FF101DA238660953538BE93D245945E22DD92DC1CE22829DFE1B348EB311E7B6CDFDB1EBB40AD50D7AD59D62AE3579EE655D5B087174542C90C5490FE042DD9A0F96E4177AC9557248DAB4CD92BCBE4AA56FF002E2FB79F97D705A8E67C64F0E7833DF05CF5228AB278F70E86DAC755BB7F57D6C11F9572BBAF69CE84D1C862B662F99DC363FAA0A3A689847B39A7E6FA5A1561228DE66D94762B4FA6BFCC7293F1C7C17CCB9CE1CF88EB2711D66BBDF71FC5EE768A5B454B291CEAD923719647339886F213B6C0B7C7EE975E516BB38F19FA87C3CB2EAFA57432DF2ED53565C7FCA31BCB1B5C3D9B336F8294AACB91CEB57A346DEFAAD1A0B118BC2EBCBF70A0876A6E5AF86CB81E0B054C65955555976A98BED81898C8A177B8F7D38FE0FB14EF5561DA4992BAF5C4232CFCAD0CB0D9696901077E62F2F9893EA3F5DDBE092E47ABB2343D36A9093FCA9BF763E2C8A8888B19D7C22EB3A33C2FEAD6BC5A6E17CD3EB650CD456DA86D24D2D5563600652DE6E56EFE3B0209FC20BA1FE974F12FFF00F0F61FE568FF00E498679F5B56B1B79BA756B4549734DA231AB61ECEEC4A3C6F86AB6DD76789725B956DD240F1B6DB49F276EDEC2DA76BBF84A1D7E974F12FFF00F0F61FE568FF00E4ACAF4630AAAD39D28C5306AE746EAAB2DAE0A4A8319DDA656B7D320F9FA5BF5568A350DAED5ADAE6CE346DAA29372CBC3CF049FCF06E6888AE73938871A996CB8770CD9B56D354B62A8B85247698B7F178A9959148D1EDEE9F29F82A745663DA79929A0D24C7B186727FD2D7AEFDFD7D20218DDB74F56F27E4559CB1CB99D5F62E87A3D39D4FD526FCB0BE4C2D934D2C32E51A898C637072F7973BBD252379BC377CCD6F5FA56B6BBA704762A2BDF12B894F74929A3A1B43E7BA4EFA89031AC3142F311DCF4DFBE316CA11B25F56F57B5A957F4C5BF245C1C10C74D0474F13435913031A07900360BF6B15F9ACC5BF64B6AFFC647FF35F48723C7AA0F2C17EB7487D4CAA63BF98ACA707709F368C8A235CD73439AE041EA083D0A21408888022220088880222D3753F57F4F3476C2FC8B50323A7B6D3807BA88EEF9EA1C3C191463D2713E1EA1E640EA85E9D39D69A8534DB7C92E66E4B0B9466D87E1349F2FCBF27B5D9E0D890FADAA645CDB7DC871DDDF055D3ACDDA47A8194BE7B4E92DB5B8BDB9C4B5B5D386CD5CF6FAC78B233EEE623D7E6A23E4193E49965C65BC6517FB8DDEBA73CD254D754BE791C7DAE792555C8DCF4FD8AB9AE94EEE5B8BB1717F45EF2D7F28E3EB869C6647C0CCBAAEF12B3ED6D742F981F73DDCACFCAB40B876A0E8CC2F2DB660D995501E0E962A5881FA2671559A8ABBCCD8E96C669B05F7B7A5E2FE89166F6CED3ED12A97065D30DCCE8B7DBD2653D34CD1EFF00AF03F402BA6E1BC6E70DD9A4ACA7A5CFE3B64F21D8457581F4A77F5733872FD0553DA26F32B5B62F4EA8BEE3945F8E7E28BF1B6DCEDB79A28AE568B85356D24E39A39E9E56C91BC7AC39A482BD2A9034BB5C3547472E82E78065B5B6F69703352179929671EA92277A2EF7EDB8F22158BF0CFC7661DAC53C187E730C38DE56F01B0EEFFF0004AF77AA371F98FF00DA3BC7C89F05652C9A8EADB2977A745D5A4F7E0BAAE6BC57D3DC4A84445635608888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802E7BABFA7C32CB4FD54B6C00DD28584B034759A3F12CF69F31FFE57424409E0856E6B9AE2D702083B107C415DF74031C14563A9C8A68F696E0FEEE3247F9261F2F7BB7FA160758F4CE686E4CC92C14FCD0D74AD8EA2160F99338EC1C3D8E247B8FBD766B05A20B05928ACD4FB1651C0C8B703E7103ABBE2773F1509176F28F7A222928695ACFA9341A47A657FD40AF2C22D548E7C0C71D84B3BBD1899F1796854917DBDDCF25BD57E437AAB92AABEE553255D4CF21DDD24AF71739C7DE4953B3B4F355E733639A376CA8E58434DEAEA1A7AB9DD594EC3EC03BD7107D6C3E4A02AA49F13AB6C769FEAD65EB325F7AA7C172F3E2FC82222A9B78444401580F66F70F8D8E3A8D7AC9E9097BC3E8AC113DBD00DF696A7DFD391BEC2F3EA2220682E90DD35C353ECF80DBDEF860AA97BDAFA96B77F93D2B3AC8FF7EDD00F3242BA7C731EB3E2561B7E338FD13292DB6CA7652D340CF0646D1B01ED3EB3E67AAB457534ADB1D5BD5A8AB2A4FEF4F9F747F7F864C8A222B9CBC22220088880222200A297685688D26A0694BB50ED742D37EC3819DD2B1BE9CB427F558CEDE21A7678DFC367786E54AD5E5BADAE86F76BACB35D29D951475F0494D5113C6ED9237B4B5CD23D441211F13ECD3EF2761730B88738BF35D57B5141E8B399DE2F3E119B5FF0DA990C92D8EE7536E7485BCBCFDD4AE6736DEDE5DFE2B06B11DDE12538A947930888858222202D07B32AEE6BB412ED6C9272E7DB725A963584FCC8DF4F4EF1F02E327E552E5419ECB0A895D88E7D4A5DF5B8EE5452347ED9D1480FFBA14E65917238AED243D1EAB592EDCF9A4C2FCC71450B4B628DAC05C5C4346DB927727E257E9149E20444401111004444011110044440151E6B8650ECCF58732C98D4B2A195D7AAB7432B3C1F0B642D8C8FE035AAE7354B2A7E0FA6B956631063A5B2D9AB2BA26BCECD7491C2E731A7DEE007C55162A48E85B09438D6AEFB92F7B7F20888AA7430888D6B9CE0D6B4924EC001D494011768D3EE0F3884D47822ADB469FD5D051CC03995375FF04639A7C1C03F6711B75076D8F92EB147D98BADF510F795395E214AFDB7EEDF513B8EFEADDB110A70CF32BEB5A7DBCB76A568A7E39F810FD149BCBBB3C388AC669E4ABB7DB6D37F8E31B96DBAB3790FB9920692A3AE418E64189DDA7B164F65ADB55C698ED2D2D640E8A567AB76B803B1F23E07C946307D16B7F6B7BFE9EA29783F918E44443EB248F07FC585E342B268B1AC96B25AAC22EB286D540EF48D0484EDF288BCC01F6CDF023AF880AD9292AE9ABE961AEA29D93D3D446D962958776BD8E1BB5C0F982082A829596F66F6B7CF96E155BA457FAE74D70C5DA27B6BA59377BE81CEDB906FD488DC401EA6B9A3A0002B45F4341DB0D162E1F6850586BF177AEDF1EDFD899A888AE73838AF19F917E663863CF2BDAC6BDF53411DB9AD276FFDA678E0247B4090BBF82A9BD595F6A164EDA0D29C571263A56CB77BE9AC7169D9AE8A9E078735DEBF4A78C8FC155A8B1CB99D5F62E87A2D39D47F9A4DFB1617C530B68D2DC75D976A4E2F8C8A4354DB95DE929E4847DBC6E95BCE3F8BBAD5D77BE063198F27E26B118A66CA63B6BE7B9B9D18F9A6189CE6177A817F28F88508D92FEB7AB5AD4ADFA62DF922DF61899044C8221B323686347A801B05FA44594E08172FD7DE21705E1F71537DCA6A84F70A90E65B6D70B877F59201E43ED583A733CF41ED2403ECD77D6CC6341B00ABCDB233DF480F714144D786BEB2A4825B1B4F90E8493D76009EBE0A9D754354331D5FCC2B336CDEE5F2AB855BBA3180B61A78FED6289A49E560F21B93E6493B9556F06D1B3BB3D2D5A7E9AB70A4BDEFB17CDFF16C1AE1C426A36BDE4525E331BAB9B431BCFC86D501E5A5A367906B7ED9DEB7BB771F60D80E6688A8758A3429DB5354A94528AE49045F4A6A6A9ACA88E928E9E49E799C191C51B0B9EF71F0000EA4FB1775C17820E2333B863AB87077D9A9A41B892F120A53B7AF91DE9FC08DD0A5C5DD0B48EF579A8AEF783832298707661EB6C9077B2E5F87C4FDBF537545413F488B65A4E6FC02711986D3495B4F8E525FE9E31B9369A912C840F1DA3706B8FC029C33E1A7AEE9B565B91AD1CF8E3E247245E8B85BAE168AE9ED975A1A8A2ACA6798E7A7A889D1CB13C78B5CD7005A47A8AF3A83D64D359414C8E06F8BAAFC0AF547A45A857074F8CDCA66C36CAB99DBBADB3B8ECD6127C627123F04F51D0950DD113C1F16A1614752A12B7ACB83F73ED45FD0208DC1DC1451BB813D70A8D5DD1E86D57EADEFF20C4DCDB755BDF273493C007D625779EE5A3949EBB96124EE4A922B2AE2711BDB4A963713B7ABCE2F1FBFB798445F89A6869A192A2A25645144D2F7BDEE0D6B5A06E4927C001E687CA78324C92C587D8ABB26C96E74F6EB65BA174F53533BC3591B07AC9F3F203C492005569C5571A794EB655CF88E1B2CF65C2A2716F74D3CB3DCBF6F31F267AA31D3CDDB9DB6FDF1AFC54D56B46552E138856C91E156598C6C2D7102E550D3D6777AD80F460F50E6F13B08BEA929761D4366B66E369057776B351F149FE5FDFE1E2111154DD422ECBA6FC216BF6A8534371B0E0B53476F9C07C759733F2489ED3E0E6F3FA4E0475040D8F92EC36DECC2D66A8313EE39962548C2E6F78DEFAA1EF6B77EBB6D16C4EDED53867995F5AD3EDA5BB56B453ECCE7E04E6E18B1B18A70FB8059F9646BBEA1535548D91BB39AF9DBDF39A4796C6423E0BA72FC410454D0474D03032389818C681B06B40D801F05FB590E255EABAF56555F3936FCDE42A58E293256E59C41E77788F9C47F5626A66079DC810FD6B6F76EC2AE62FF007BB7E3362B96477697BAA1B5524D5D52FDB7E58A2617BCFC1AD2A876E971ABBC5CEAEED5F2BA5A9AD9E4A89A471DCBE47B8B9C4FB49255246F3B0B43356B57EC4979F1F91E6444553A396B9D9D18CB2C1C37525C7BB7B25BFDDAB2E32730F516C0DDBD9CB034FC549E5CEB875C77F32BA178358CB839D059295CE3B6DB97B03C9FF5974559172384EA95FD66F6AD5ED93F8F00888A4F80222202B73B51723155A8D88E2ACE61F53ECF256BFAF43DF4A5ADE9ECEE8FD2A142EF7C73E58CCB789BCB9F4F52F969AD2FA7B4C3CDF6860858D95A3D9DF197E95C11637CCEDFA0D0F57D368C1FE94FCF8FCC2FEB5CE61DDAE20FB0AFE2283D63F7DF4DFE75FF00C62BE90D7D7539E682B278CFAD9211FCCBE0883099BD621AE9AC581CCC9F12D49BFDBCB0EFC8DAC73E377B1D1BF76B87B08214AAD1FED33C9EDD253DA759B1D82ED4DB863AEB6D6086A00FBA7C5F31C7F0793DCA0DA226D1E6DEE8F637F1C57A69BED5C1F9AE25EA69EEA4E13AA98DC195E0790535D6DF3F42E89DE9C4FDBAB2461F498F1BF56900FC16CCA9074775AB3CD0ECAA2CA708B9989DCCD1554729269EB2307E64AC046E3C7623A8DFA156FDA1DAD38AEBBE074B9B62EFEECB8F735B44F787494750002E8DDB78F8EE0EC370415913C9CC35ED9DA9A3CBD241EF537C9F55DCFEBD4E80888A4D6C2228E9C61F14D6FD03C50D931F9A2A9CD2F313850C3E228E33D0D4483D9F6ADF33EC051F03E9B3B4AB7D5A34282CC9FF0033E07E78A9E31319D00A47637638E0BCE6751173C5445FF5AA36B87A324FB751EB0CE84FB075556B9EEA2667A9D91546559CDFEA6EB71A97126499DE8B079318D1D18D1E0001B2C45E6F375C86EB577CBDD7CF5B5F5D2BA7A8A89DE5EF91EE3B97127C578D636F2761D1B43B7D229FDD599BE72FA762FE3088B2161C76FD94DD21B263566ADBADC273B454D4703A695DEE6B413B7B541ED4A4A2B2F918F4524B0FECFCE2372A819555760A0B0C4F1B8FAA75818F1EF6303885B8CDD987AD91C1DEC597E1F2C9B7EA42A2A01FA4C5B29C33CAA9AF69B4E5BB2AD1CF8E7E043C45DBF517832E20F4D6965B8DD30896E541002E92AAD2F154D6347996B7D203E1D3CD7102083B11B10A0FBEDEEA85DC77E84D49773C85FA8E492291B2C4F731EC21CD734EC411E0415F944339659C09F1713EA153C3A3FA9374126474709FA935D3BBD3B8C2C1B989C7EDA56B413BF8B9AD24EE4126672A15C7AFF75C5AF9419258AADF4B70B6D432A69A661D8B2469DC15761A1FAA16ED63D2DB06A0DB8B41B9530155103D61A9612C9633EE7B4EDEB1B1F3578BC9CB36B7458D8D5575416213E6BB1FD1FD4DE911158D342222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222203F8E635E395ED0E1EA2375FD44401116A9AB195BF05D30CAF31848EFACD66ABAC8413B032B227160F8BB94217A707566A11E6DE3CCA84E28F3B7EA2EBD66390B6632D332E5250D29DF71DC407BB6EDEC3CA48F7AE568E739CE2E712493B927C494588EFB6F4636F4A3461CA292F20888865088BF5146E9A5642C1BB9EE0D03DA4A02CB7B3534922C734E2E3AAD71A7DAE194543A9A8C91D594309DB71F87287EFEC634F9A996B4FD1EC620C334AF13C5E9D9CADB759E961208D8F37760BB7F6EE4ADC1645C0E17AB5E4AFEF6A579757C3C1705EE0888A4F382222008888022220088880A66E2FE08E9F896D408E2686B4DD4BF603CDD1B1C7F292B8F2E95C4ADFE3C9F5FB3FBC43B776FBF55C0C23C1CD89E620EF88603F15CD562677AD3E2E1694A32E6A31F82088887D611110164FD9716930E9665F7DE51FE199036937DBC7B9A68DDFFD7534D467ECF0C65B8F70D56EADD9E24BEDCEB2E7207791E66C2DDBD859030FC5498591723896D05555B53AD25FAB1E5C3E4111149E3844440111100444401111004444047BE3CF236E3FC32E4D17A61F769296DED2C3B11CF335C77F66CC20FBD544AB1EED45CA1B478162188C754E64B73B9CD58F88783E286300EFEE74AC55C2B1CB99D6B63687A2D377FF00549BF97C8222C863D60BB6557DB7E3561A292B2E374A98E929608C6EE9257B835AD1F12A0DA9B51597C8D8B4A749337D67CB69F0EC16D66AAB25D9D2CAF3CB0D347BF59257EC795A3E24F8004F4568FA03C17E95E88C14B75AAA18724CA2301CFBAD6C2088A4F5C119DC47EC77577B56D5C3768163DC3F69E536336F8209AF1561B5179B835BBBEA6A361B80E237EEDBE0D6F80EA76DDCE27ABABA58393EBFB4B5B509BA16CF7692ECE72EF7DDDDE6111158D4C2E6DADDA01A77AF38EBECD995A63F9644C70A0B9C4DDAA68DE7C0B5DE6DDFC587A1F7F55D2510CB46B54B7A8AAD293525C9A28F759B48B29D11CFAE181E5706D352BBBCA5A968FADD5D3389EEE661F5103C3C41041EA0AD1D59CF694E98D2E45A4B47A954F4A0D7E2B571C534A3A1F924EE0C20FAC090C7FC6558CB1B586768D0B537AAD946BCBF12E0FC57D7830BB3707DA8355A73C4461F748E6E5A5B9D6B6CD5CD327231D0551EEB771F531EE649B7AE30B8CAC8E3538A5C8AD55249022AD81E76F6480A847A17746373427465CA49AF345F4A2F9525432B2961AB8FE64F1B646FB88DC7F3AFAACA702E456C76A064FF002ED4CC5F148AB1CE8ED568754C90793249A43E97BCB58DFA142C5DF78EAC9DF92F13595B4CD14B15A0D3DB2174677D847134B81F687BDE0FB970258DF33B7E8543D5F4DA30FF00A53F3E3F30A6D765B62C6B351334CD0CC036D56686D8222DF9CEAA9C49CC0FB05211FC3509559CF664E3125AF462F5924D0440DEEF6FEEA46FCF7470C6D672BBD81FCE47E1148F33E2DABAFE834AA897396179BE3EE4C982BE755554D434D356D64F1C14F4F1BA596591C1AD631A3773893D0000124AFA28ABDA23ABB2E03A36DC2ED559DCDCB3495D44FE5796BC513003391B107676ED61F2D9E41F1591F0394D859CEFEE616D0E727E4BABF6220CF165AF95DAF9AA35576A7AA94E3967749456380921821E6F4A6E53E0E90B4127C760C07E68038AA22C5CCEE56D6D4ED28C6852588C56105D3B41787CCEB881CA9B60C56014F43039A6E3759984C14719F1276F9CFDB7E5603B93E606E46B5A61A75916ACE7967D3FC5A9FBDAFBBD408838FCC8631D6495E7C9AC60738F9EC36009D81B9DD20D27C5745F03B760989D2363A7A46734F3968EF2AA73F3E690F9B89FA000074014A593C1DA3D796914D53A5C6ACB9772ED7F2FD8D4B437857D27D08A3865C7ACB157DF5ACE59AF55B1B5F52E3B75E427A44D3EA6EDED2576144590E4B717356EAA3AB5E4E527D584444309C5788CE16300E206C933EBA8E1B6E510C25B417A899B48D70F9AC940FD523F61EA37E9B79D45E7185645A75965CF0ACB2DEFA3BADA67305444EEA37F10E69F02D7021C08E841055EF2809DA7FA634AC8B19D5CA1A52D9DF21B2DC2468E8E1B3A484BBAF8F4900E9E1EE0AB25D4DDF64359AB4AE158D57984B9773FA3ECED2002222A1D38949D9D19FD4629C41418AB9CE34597D04F432379806B66898E9E279F59FADC8C03D72AB56549BC36557C8B5FF4F2A4CA630CC8E8399C0EDE8999A0FC36242BB2578F2396EDBD08D3BE8555F9A3C7C53C7C301449ED0BD7B9B4E34F20D36C6EACC57DCBD8F6D448C76CEA6B78E921F587487D01EC12781D94B654C5C57EA69D56D77CA722A7A96CF6EA6AB75B6DCE638398EA68098DAF691E21E41783EA70493C23E3D93D395FDF29D4598C38FB7A7D7D8722444543AF190C7F1FBCE557AA3C771EB74D5D71B84AD829A9E16EEE91E4F403FE6AD07863E05F0BD28A2A1CAF5128A9321CC395B372CADEF292DF27886C6D3D1EF6FDD91E3D5BB742B48ECE0D00A0B4E372EBA6454424BA5D0C9496512B3FF66A50767CCDDFED9E416870F068201F48853815E2BA9CD36A7686A4EACAC6D6588C7849AEAFAAF05EFF0001E0888AC68A111101C6B8C5C9DF8A70D59DD7413B229AB2DA6D91F37DB0A97B617B47B791EFFA15352B3EED32C90DAF446D58FB5AD26F57B8813BF568898E7F87BF65582A92E6756D8AA3E8F4F753F549FBB0BEA16630CB1D4E4D9858B1BA26B5D5176B9D2D0C41DE05F2CAD6377F66EE0B0EBB8F05189B72EE2670BA69E94CD4F6DAA92ED2FA9869E37491B8FBA5117D2AA8D9AF2BFAB5B54ACFF2C5BF245C1D152414147050D330321A689B146D0360D6B40007D017D91165381B79E21111005F8A89E1A5824AAA89047142C323DC7C1AD03724FC17ED68FAE7917E64F46F34C88061750D8EB246871D817774E007D250C94A9BAB5234D75697994BFA8D7F9F2AD41C9B26A990492DD6EF5758F78F07192673B71F4AD75092E2493B93D4A2C477F841538A82E482F7C58FDFA78D934364AF92391A1CC7B699E4381F02081D42F3D05154DCABA9EDD471F793D54AC8626FDD3DC4068FA4857B189E336BC6F16B363B47430B20B5DBE9E8A26F20F4591C6D601F434294B2781AF6BCB4454F10DE72CF5C72C773ED28C1D8EE40C697BEC5706B478934AF007E458F735CD25AE0411D083E4AFD0D15111B1A4848FF00BB0B42D4AE1F347B56ADF250E6B825AEA6578D995D0C0D82B223EB64CC01E3DC4969DBA82A774F068EDDC1C92AD45A5DA9E7DD85F12921148EE2B783DC8387DA96647629EA2F386D64BDDC758E68EF68E43F3639F6E9D7C9FB0076DBA1D818E2AAF81BB59DE51BFA2ABD09662FF9E61779E0D35CEB745757A845556B998EE472476EBBC4E76D180E76D1CC47DD46E71EBEA73879AE0C884DDDB53BCA12A1557DD92C7F3C0BF96B9AF687348208DC11E617F5727E1533FA8D4AD00C3B26AF98CB5C281B4358F73B99CF9E9C989CF77B5DC81FFC25D61653845C5195B569519F38B6BCB81AB6A86A258B4A303BC67D913F6A3B4D3BA5EEC1D9D349E0C89BED738803DFBAA57D4ED47C9756738BA67995D4F7B5F7398BF95BF3218C74644C1E4D6B7603E9F12A60F699EB2CB5B7DB4689DA27229ADD1B6EB762D3F3E77822188FE0B3779F22646F9B54155493E874FD8FD295ADAFADCD7DF9F2EE8F4F3E7E4111768E14B87FA9E20B5321B15599A1C7ED8D15979A88FA11083B089AEF27BCF407C86E7C954DA6E6E69DA51957AAF118ACB362E16F83BCB35FEB1B905DDF2D930CA793966AF2DFAED5B878C7034F8FB5E7A0F69E8ACEB4B74674E346ACA2C9A7F8CD35B98F6813D472F3545491E724A7D277BB7D87900B68B158AD18CD9E8F1FB05BE1A1B75BE16D3D353C2DE56471B46C001EE5EE5912C1C7B59D7AE756A8D378A7D23F5ED7FC4111149E1051238BBE0A31CD4BB3DC75034D2D74F6BCC6998EAA9A9A0608E1BA81D5CD2D1D1B311B90EDBD2774778F3096E88D64FB2C6FEBE9D5957A12C35E4FB9F71413514F3D24F252D4C4F8A685E63918F1B39AE076208F220AF9A92FDA05A5949A73AF15176B4C022B765D4ADBBB18D6ECD8EA0B9CC9DA3F84D0FF006779B28D0B13E076FB1BB8DF5B42E21CA4B3FB7B02B06ECBACEE596DF97E9BD44C4B29E48AEF4CC3E0DE71DDC9B7BF963FA157CA95FD9AB719A97882A9A06B8F755B60AA0F1EB2D7C441FE7FA54AE6799B4B4557D2EAA7D167C9E4B4B444590E2E1111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401709E37EE8EB5F0C9997249C8EAB861A507D7CD33371F100AEECA3576863DCCE19EEDCAE239AE3440FB4778A19E968F153D42827FAA3F12A69111633B98444401653148993E516786420324AFA76BB7F0D8C8D0562D7A2DD54686E14D5ADF1A799928FE0B81FF00821134DC5A45F8B5AD634318D01AD1B003C82FEAC56257B8F24C5ACF90C2F6BD972A182AC39A77079E30EFF8ACAACA7E7C945C5B8BE68222210111100444401111005A5EB46A043A5BA59936792B99DE5A6DF2CB4CD7F83EA08E589A76EBB1796EFECDD6E8ABEBB4AF5D29AAE6B7685E3F53CE695EDB95F1ED3D03F6FAC41EF0097BBDECF6A86F08F5745D3E5A95EC2825C3397E0B9FD3DA40C96592691F34D239F248E2E739C772E27A924F995F94458CEE01111005FA8A27CF2B2189BCCF91C1AD1EB24EC17E5764E1134C5DAADAF98BD8E787BCB75BEA45DAE3BB7769A7A721FC87D8F78633F87BF92186E6BC6D68CEBCF94537E45B1E8C622703D27C4B107B1CC92D768A68656B9BB1127202F047AC3895B9A22CA703AB525566EA4B9B79F308BF134D0D3B43E795B1B4B9AC05C761CCE2001EF2481F15FB428111100444401111004444011110158FDA7395BEEBAD162C522A96494F62B0B24746DF18EA2A257B9E0FBE36407E3ED50F576BE33EFDF9A1E26B3AABE5DBE4D5CCA0FF00411322DFFD45C51627CCEE3A251F57D3A8D3FF00A53F6BE2FDEC2995D99FA670645A9779D46B852B658717A410D2B9C010DAA9F701C3CF711B64EBED50D559C76615B28E1D11C82EF1C405555E4D3412BFCCB23A6A72C1F0323FE9531E67C3B55712B7D2EA6EF396179BE3EE2612222C871C08888022220388F1AE280F0BB9EFD512445F23A7E5DBFCEFCAA1EEFF00D7E554E6AD27B48B3FA7C73431985C750D159955C2188C5B6E4D3C0E12BCFB3D36C5D7DE155B2A4B99D5B62A94A9E9D29CBF349B5E497C50591C6E1153915AE9DDE12D6C0C3F190058E5D6B84FC227D40E21F07B147131F0C3748EE555DE34B99DC52EF3BC3B6FBA11F20F6B82AA368BAAB1B7A13AB2E514DF922E6E929D9474B0D247F3208DB1B7DC06C3F997D1EE6B1A5EF2035A0924F905FD5A06BFE46CC4B44B38BFBDD237E4D63AB6B1D19D9CD7BE32C691EE7381594E0D4A9BAF5634D73934BCCA63D42C9A4CD73EC973196010BEFB77ACB93A20771199A67C9CBBFB39B6F82C021249DCA2C477E841538A847920AE3B830C5FF32BC35E174B2513A9A7AEA475C6669F1719A473DAFF008B0B0FC553A4104D553C74D4F13A4966788E36346E5CE276000F592AF8B13C769710C56CD89D0C8F929ACB6FA7B742F7FCE73218DB1B49F6ECD0AD1347DBAAFBB6F4A8F6B6FC97EE65554E76846A24B9B711171B1C3331F6FC42921B441DDC84B5D296F7B3B883D03C49298CEDE50B55B1AA36D65BFCD94EACE6390D446192D7DEEB2673478026572991E4EC3DBAA97952B3FCB1F7B7F44CD3911150EA0582F65FE99D37D4FC9F56EB216BA774E2C742F3B1E40D6B64988F304F3C43D47E0A7AA8F1C015BE8E8B856C46A6969D91C95F35CAA2A5CD1D6490574F1871F6F246C6FB9A148759172389ED0DC4AE753AD2974938FF006F0F904445278C1111005153B4A04078748BBE2EE719151775B7817777378FB3979BF22956A0A76A16A053C38F629A654D55BCF5554FBBD544363B46C698E327CC757BF6F5EC7D4A25C8F6F67294AAEA94547A3CFB1712BC1111633B51D2386DA6157AFF00A794E633207E49401CDDB7DC77CDDFF22BB2553FD9E1844F95711D6EBE967F8262B43557398BA32E6B9EE8CC11B77F00EE69B9C7FDD956C0AF1E472EDB7AD19DEC29AFCB1E3ED6FE469DAC7959C1B4A32ECB63AD14935B2CF55353CDB6FC93F764447FD2162A36F156E5C7CE48FC7B867C8A18A48DB25DA6A5B7F2BCF5735F2B4BB97DBB349F82A8D5123DBD87A1B96952B7EA963C97EEC222E85C3CE2C334D73C131A929A3A882AAFD46EA98A4F9AFA78E4124C0FAFEB6C7F455372AD5550A72AB2E514DF91727A6789C58269E63786C4D8C7D46B5D351BCC6DE56BA464603DDB7B5DCC7E2B6544594E0139BA92739737C4222215088880AE8ED4BC99B3E678461CC3207515AE7B9CA37F45C2697BB674F58EE24FA541C521F8F9C964C8B89DC962F953A6A7B3C3476DA707C230C81AF7B07B3BD9253F12A3C2C6F99DBB40A1EAFA65187FD39F3E3F30A657661E38DAED5BC8B257B5FF00F45594C2C3B7A3BCD2B77F8ECCFE750D5590765CE3E29B4FB30C9DCE6935F768A8DA36EAD10C5CC7E9EF47D091E67CDB535BD0E9557BF0BCDAF913691116438D044440146BED0ACA598DF0D177A1F484B905C28AD5139A76E53DE77EEDFD85903C7C54945037B533286B6D582E1715438192A2AAE93C5E4435AD8E277BFD2947C543E47B5B3D43D6353A31EC79F2E3F22BDD111633B59D2386FC65B97EBB60F619227BE39AF34F2481BE21B1BB9C9F77A2AEC95527673E35F57B891A5B8B89E4B05A2B6E246DD0921B001F4CE0FC15ADABC791CB76DEBEFDF4292FCB1F7B6FF60888AC69860F38C3ECD9FE2376C3320A664F4177A57D2CCC70DC0E61D1C3DA0EC47B405471986375B8765979C4AE4C2DAAB2D7D4504C0F93E290B0FE56ABE354A7C4F4B0CBC446A33E020B7F3495ED3B7DD099C1DF9415491BF6C2D69FA5AB47F2E13F6F2FE781CC511154E8E5A4F66A54C92F0FD5503DC4B61BFD506EE7C0164454AF91ED8A374AF3B3580B8FB828B1D9B96CA8A1E1DCD64F1398DAFBDD5CB113F6CC018DDC7C5AE1F05DEF582F1558EE9266D90514A63A8B663972AC85E3C5AF8E9A47B4FC080B22E4714D6A1E9756AB08F59E0A6AD6ECD65D44D5ACAF3192632B2E3749DF0BBFEC438B63D8797A21AB484458CED14A9C68D38D38F2492F20ADB780AD2EA3D3CD01B55DDD4C1B75CB49BBD6C847A5C8EF46067AF944601DBEE9EFF5AA92037206FB6E7C55EBE9B524343A798C525380238ACF46D6EDE1B772D5689A5EDC5C4A9DAD3A31E527C7D9FF009F71B1A222B9CC422220088880AFBED526C1F2ED3B76CDEF8C57200F9F2EF07FC540952A3B4675129B32D776E356E9BBCA6C42DECB7C841DC1AA7B8CB2EDEE0E8D87DAC2A2BAC72E676AD9CA32A1A5D18CF9E33E6DB5EE614AEECD6B7CD55C425456B5A7BAA3B05517B879173E2007F3FD0A28A9F9D96F864BCD99EA04D138464416A81C47471EB23F6F77A1F4848F323692B2A3A5D66FAAC79BC13F91116438B0444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440117CDB534EFA892959331D344D6BDF1877A4D6BB7E524796FCAEFA0AFA200A3D71ED6D371E19725701BFC925A5A9F76D2B47FEA5215737E24719932FD06CF2C1040669A6B1D54B0C6D1B97CB130CAC03DA5CC0119F76995551BDA551F4947E2526A222C4777088880222202D8F801D58A6D44D0AA2C7AA6A5A6EF873FEA5D4C64FA460DB9A0936F51692CDFD71B949754C5C306BCD770FF00A9B4B9416CD3D96B1BF24BBD2C67AC94E4FCE68F02E61F487B88F357178DE4763CBEC543936357382E16CB942DA8A6A985DBB646386E0FAC1F220F5077076215E2F28E41B53A54B4FBC9558AFB93795E3D57D3B8C92222B1AC844440111100445CA3881E23F01E1F71A75D323AC6D55DEA5AE6DB6D103B79EA5FB7891F6918F37BBA790DC9010CD42DEADD5454A8C7327C923E3C4C710760E1F34FEA2FF54E8AA6F958D74167B717ECE9E63F6EE1E3DDB3E738FB36F12A9D324C8AF1975FEE1936415B255DCAE750FA9A999E772F91C7727FE5EC5B26AFEAF665AD99AD666D99D7BA69E73C94F4CD27B9A3847CD8A26FDAB47D24924EE492B4958DBC9D7F67F448E8F43EF71A92E6FE4BB97BC222283600888802B27ECD2D20971EC1AE9AB776A531D4E4921A4B773B7AFC8E276CE78F63A4047F03DA140CD1AD32BBEB0EA558F4FACCC7F7974A8026940E9040D05D2C87D41AC04FBF61E242BB4C671DB5E238EDB717B253360A0B552C5474D1B7C1B1B1A1A07D015A2BA9A46DA6A4A8DBAB283FBD3E2FC17D5FC1992444573989C9F880C89F4168A0B252CC592D54E2A1FCA7621B1FCDFF005B63EF6859FD2AD408B33B30A7AC9036EB440327693FAA37CA41EFF3F6FBC2E27AAD933727CCEB2A207F352D21F92C041DC39AC24170F7BB73EED961319C8EE18ADE69EF56D93692177A4C27D1919E6D3EC23FE6AB9E25F778130116331BC828328B353DEADCFDE29DBB96EFD58EF369F682B26AC502222008888022220088880A5CE2B6967A4E23B50A3A88CB1CEBED4C8D07CDAE77334FC4105728528BB4670DA9C6F889A8BF16B8D2E4F6CA5AF89FC9B343E36F712301F024774D71F5778145D589F33BAE935957B0A3523D62BE187EF0AC07B2E73CA714B9869AD4D41131962BC524648008E5EEE523CC9E917C02AFE5B9E8F6A9E41A33A8768D41C71DCD3DBA5FAF40E76CCA9A777492177B1CDDFAF91D88EA02278663D6AC1EA56352DE3CDF2F15C57D0BC745A5E91EADE1BAD385D1E6B865C193D3D437967A72E1DF524C00E68A46F8870DFE20823A10B74594E235694E8CDD3A8B0D70682222140BCF71B8D0DA282A6EB73AB8A968E92274F3CD2BB9591C6D1BB9C49F00005E5C8F25C7F10B354E43945E692D76DA361927AAAA94471B1A3DA7CFD40753E01565717FC6BD66B2B65D3ED3896AADF87324FF0009A87031CD752DF0E66F8B6207A861EA4805C3A0021BC1EBE91A35C6AF59429AC45739745FBF6239B716BAF751AF9AAD557AA373D98FDA03ADF65849F185AE3CD311E1CD23BD23EA1CA3AF2EE78AA22C6767B6B6A7694634292C462B082B00ECC3D2B9E16647AC570A773593B3EA2DB9C7A07B799AF9DC3AF51BB631E1E47DAA1269B69FDFF54B38B46078CD3BA5AFBBD4361690D2446CF17C8EF535AD05C4FA82BB0D35C06C5A5D8259701C6E9C454165A4653B0EC0195FE324AEDBC5EF7973DC7D6E2AD146A9B65A9AB6B5F5483FBD3E7DD15F57C3CCD9546BED08CA0E39C365D6963AC304D7BAEA4B6C607F9505C647B3F891BCFC14945043B53B2C921B260583432C463ABAAACBB54337F4DA61632284FB01EFE7F796FB159F2346D9EA1EB1A9D1877E7CB8FC8AF444458CED674EE18B1B396710580D984AD8C7D5CA6AB7173770440EEF8B48F688F6F8ABAC5557D9C58C497CE219977F93C52C362B4D555C85FE2C2EE589AE6FB777FE556A8AF1E472DDB7AFBF7D0A4BF2C7DEDBF9602A23CFE2921CEB238A56398F6DDAAC16B86C47D79CAF71535F18B8954E1BC496716E9A2E48AAEE1F54E9DC222C63A2A963661CBE4434BCB091D3998E1E49233EC2D551B8AB4BAB8A7E4FF738CA222A1D2CB3FECD3CFA2BF68AD760B5157CF578BDD25EEA23B0E4A5A8FAEB76F33F5D3393EF0A5DAA5CE1A35E2EBC3EEA5D2E5D4F0C9576AA96FC92ED42D7F2F7F4EE3E23CB9D8767377F511D038AB87C2736C6351319A1CBF0FBB4371B5DC6212C33467C3D6D70F16B81DC169EA082AF1794724DACD2EA59DECAE12FB951E73DFD57CCCE2222B1AA8445AE67DA89866986375395E737FA5B55BA95A499267FA523BC991B7E73DE7C9AD04942D084AA49420B2DF447AF30CBAC381E3172CBF27AE651DB2D503AA2A257103668F21BF8927600799202A5CD75D5CBCEB7EA75E3506F1CD1B6AE41151531712DA5A46748A21EE1D4EDE2E738F9AE91C58716F7FE212EEDB2D9DB536AC32DF297D2D0B9DB3EAA41D04F381D0BB6F9ADEA1BB9F324A8F0B1C9E4EADB2FA0CB4C83B8B85FE64BA7E95D9E2FA8445D2787AD1ABAEBA6A8DAB05A064ADA47BBE5373A860FFD9A8D84778F276D813B868DFED9CD0A0DA6BD685BD3955A8F118ACB279F66DE954B89694D76A1DCA91D156E5F500D3970D89A28776B0F8F839E6423A786C7C0852F978ECD68B6E3F68A2B0D9E922A5A0B753C74B4D044D0D645131A1AC6B40F0000017B1645C0E17A8DECB50BA9DCCBF33F25D1791077B53324F92E1782E2223DCDCAE757702FDFE68A7898CE5DBDA6A77FE0AAE752D3B4BB26178D7DA2B0C32CA63B05829A0923713CA27964926739A3DAC7C209FDAFB144B549733AD6CCD0F57D2E927CDA6FCDE57BB01498ECF2C61B7FE23EDD709695D2C763B7D557078F08E4E5EEDA4FFA42146753BFB2CB1A6CD7CCEF307F383494B496D674F45DDEBDF23BAFAC774DFE322E665DA2AFEAFA5D69F763CF87CCB0B444590E261111004444052F71654F3D37121A84CA861639D7C9E400FDCB88734FC41057265297B46F09AAC6B8869B252C26932AB652D744F1196B5B244CF93C8CDFC0B8774C79FF00BC0A2D2C4F99DD748ACABD851A91EB15F0C3F7853F3B2F350E8E2FCD669855D486D44CE8EEF451B881CE00EEE5DBAEE4FEA67DC140359DC1737C934E32CB6E6B88DCA4A1BADAA76CF04AC3D0EDE2C70FB66386ED734F4209089E195D5F4FFB4ECE76D9C37CBC57145EEA28DBA07C72E93EADD0D2DAB26BB52E29941686CB475F2F774F3BFCCC333BD13B9F0638877A81F152360AAA5A9607D354C52B5DD4163C381FA1654F2716BBB2B8B1A8E95C41C5F7FCBB4FAA2221F285569DA4D93BAF3AF70589B3B248AC7678210D6FDA3E42E91C0FB7A83F15696A97B8B0C94E59C46EA05D3D1E586F53DBD9CA7705B4DB40083EDEEB7F8AACB91B8EC4D0F497F2A8FF002C5F9B697C32726444543AA1607D9638B72D1E7B9B4B1B0F7B2D15AA9DFB7A4DE5124928DFD479E1FA14F75183B3AB19361E1D296E3253F7725EEE7555A4FDDB4111B5DF433F2293EB22E4715DA3AFEB1AA569763C792C7C8222293C43CF72AF82D76EAAB9D49221A485F3C9B78F2B1A5C7F20544395DDE6C8328BBDF6A247492DC6BA7AA7BDC772E2F90B893F4AB9DE24F27387E83E719032A043241669D913FF00ED241DDB07C5CF03E2A939524747D84A18A75AB76B4BCB8FCD044590C7ACF36437FB658299C1B2DCEB21A38DC46FB3A478603F495537D6D45659721C26E2E310E1C700B4ECE0F9ACF15C24E61B383EAB7A820FBBBDDBE0B35C42533AAF41751E9D8E7073B13BB72F29D8922924207C76D96ED6AA18AD96BA3B6C0C0C8E929E3818D03601AD68681F405F3BF5A696FD63B8D8EBA212D35C6926A49987C1CC9185AE1F104ACA70795CEFDDBB997596F7BF2509A2C964F61ACC5B23BA635706F2D4DAAB26A3947EDA37969FE658D588EF119292525C985753C30E734BA89A0F876474F331F27D4E8E8EA5AD3FA9CF07D69ED3F167D041F354ACA537037C50D2E89E4B518566B5C62C47209D8F74EEDCB6DF55D1A263EA6386C1FF0082D3E454C5E19ACED5E993D46CF7A8ACCA0F2976AEABE7EC2D5117CA92AE92BE962ADA1AA8AA69E7609229A2787B24691B8735C3A1047985F5590E43C8222200B987115AE360D05D36B865D7399925C6461A7B4D16FE9D555387A236FB96FCE71F2683E24807F7AE1C4269CE82E3CEBBE63778DD5D2B48A1B540F0EAAAB7FED583AB5BEB79D9A3D7B900D4D6BCEBC667AFD9A4B9565330869A2DE2B75BA271EE28E1F26B41F171F173BC49F50D80AB78367D9ED9FA9AA55556AAC525CDF6F72F9BF99A25FAF772C96F55F905E2A1D3D75CAA24AAA895DE2F91EE2E71FA4AF0A22A1D75251585C8FD45149348C861639EF91C1AD6B46E5C4F800AE77855D296E8E687E3B8A4F0359729A1371BA103ABAAE6F49C0FAF95BCB183EA60500780CE1F67D57D4C8B37BE52FF00FE31894CCA9979DBBB6AEAC758A11EB00ECF77B001F6CAD655E2BA9CE76D75355271B0A6FF000F1978F45E5C7DA82222B1A084444011110044440111100444401111004444011110044440111100444401111004444011110044440111100580CDB30A0C2EC925D6B367CA7D0A7877D8CB26DD07BBD65656EB74A1B2DBE7BA5C676C54F4EC2F7B8FABD5EF51633BCD2BF36BDBEE152E2CA68C9652C1BF48D9FF0033E24A86C94B26FBA2B95D7DDF3BBA4B75A8324D74A72F3EAE663B7000F506976CBBA2899A7B79161CCAD7707BB9631388E43BEDE8BBD13FCEA59A2265CC2FE491B258DD148C0E63C16B9A46E083E217F5149528E75A704934CF55B29C1DD139915AAE73454DBEFD69CB8BA23D7C7D02D5A5A9C1DA69A49516BCAEC9AC36CA52686F110B65C5ED1D23AA8C131177E1C7CC3DF19F58507D626B0CEE7A3DEAD42CA9D74F8B5C7C5707EF088887A41111005203861E2F332E1F6E2DB4D5892F587D4BF7A9B5BDFB3A0713D6581C7E6BBD6DF9AEF3D8EC447F44E47CF756946F693A35E398BFE79977BA4DAE5A67AD568174C0726A6AD918C0FA8A273832AA9B7FF3911F480DFA6FE07D6B7D542366BD5E31DB94178B05D6AEDB5F4CEE686A69267452C67D6D734821486C1FB40B889C3A28E96BAF94391C1180036ED4DCEF23DB230B5C7E9575239F5FEC4558C9CACA69AEC9707E7C9FB8B68455DD6CED50C9E2880BC68F5AEAA4DBABA9AEF240D27DCE8DFF00CEBF75FDAA391491116BD1AB753C9B747545E5F3377F736267F3A9DE478FFE12D5B38F47FF00ED1FA961CB15936598CE176996FD96DFE82CF6E807A7535B3B628C1F56EE3D49F203A9F2557997768BF10B9246F82D53D971E8DFB8DE828CB9EDF73A5738851F331D40CDF506E1F55337CAEE97BA91BF2BEB6A5D28603E4C04ECC1EC680146F1E9DA6C45D5469DCCD4577717F25F127B6BD7691D8ED74F558E686D07D52AF7031FD5CAB672D3C3FB68A223790FA8BB66FB1DE0A00E579764D9CDF2A725CBAF75775B9D5BB9A6A9A990B9CEF67B07B0745884546F26F7A6E8F69A54376DE3C7AB7C5BF6FC970088887A61111004452E7812E1627D4EC922D52CDADE0627659B9A92199BBFD51AB69040D8F43133C5C7CCECDEBE96C4B27C77F7D4B4EB795C567C17BDF44BC492BC02F0EF2E95604FD40CA2DC60C9B2A858F6B2566D252509D9CC8C83F34B8ECF70E87E683E0A5620000D80D8045952C1C46FEF6A6A1712B9ABCE5EEEC5EC0B51D52CA5B8AE2355511C9CB55563E4D4C37EBCEE0773F01B9FA16DC480372A316AE66232CC9DECA5979E82DFBC14FB1E8E3F6CFF00891F400A19F2A59668E492492772511154C86F7A51A81261B7914B5B31FA955AE0D9DA7C23779483FE3ECF7052658F648C6C91BC39AE00B5C0EE083E6142B5DC743F50C4F1330CBC4FF5D8C7F80C8F3F39A3C63F78F2F674F2564CAC9753B2222292811110044440111101157B43F4826D41D1E66696AA5335CF0B91F5A431BBB9D44F004E3DCD0D6BCFB185557ABF79E086A61929AA6264B14AD2C9237B439AF691B1041F104792A93E31F860B9684E692DF31FA0924C2AF53192826602E14721EAEA690F96C77E527C5BED05524BA9D17633578EE3D3EABE3CE3F35F3F323A2222A9D00DB34DF5573FD24BE8C8B4FF0024A9B4D6741277643A399A3ED648DDBB5E3D8429998076A34F151C549A9DA6C27A86001F5B65A8E4127B7B9977D8FAF67EDEA01407444DA3CCBFD1ACB52E3714D37DBC9F9A2CE9DDA6FA2620EF1B8C64EE936FD4FB98B7FA79F65CEB3CED47AE9A965A5D34D338A9A7702195979AAEF033DBDCC5B6E7DF26DEC2A05229DE679B4B64B4BA52DE706FC5B37AD4FD6FD51D63AFF97EA0E5D59720D717454DB88E9A2FC089BB347BF6DFDAB4544506C34A953A1054E94524BA2E082FAD25255DC2AE1A0A0A696A6A6A646C30C3130BDF23DC766B5AD1D49248000EA495E8B258EF1925D69AC760B6D4DC2E159208A0A6A78CBE491C7C800ACD3840E096DFA4B1D26A2EA547157662F6F3D351EC1F05A81F0D8FDBCDB78BBC1BBEC3C0B8CA593CDD5F58B7D228EFD57993E51EAFF6ED6673827E16A3D10C54E5D97D046734BEC43BEE61CCEB7D31D88A707C0389EAF23CF61E4A4EA22C8960E357B7956FEBCAE2B3CC9FF30BB90555FDA47921BD710CDB47741ADB0D96928C381DF9F9CBE627D9FAAEDF056A0A9638A4C9A3CBB882CEAF30BE5745F55E6A667787AB443F5A207B3761D9565C8DA362686FDFCAABFCB17E6DAFDCE58888A875327FF658E27E867B9CD450BC75A3B4D2549F9A7E7CB3C63DA3FC1C9F7853ED463ECEAC6A3B070D7435ED32F797FBB56DCE56BC6DCA439B03797D8594EC3F12A4E2C8B91C5768EBFAC6A95A5D8F1E5C3E4141CED34D209AF38FD8F592D348E926B237EA55D1CC6127E4AF79742F71F20D91CF1E1FE57C7C14E358EC8F1DB365B60B86319150455B6CBA53BE96AA9E51BB648DE3623D9E3D08EA0EC423593E4D2AFE5A65DC2E63D39AED4F9942C8BAEF12FC3DE43C3EE7F5162AB8A5A8B156BDD359AE05A7967837E8C71F01237C1C3E3E0572258CEDF6F714EEA946B52798BE282E81A47AF1AA1A2174372D3FC924A48E570754514A3BDA5A8DBC9F19E9ECDC6CEF510B9FA216AB469D783A75629C5F47C5161385F6A4DAA4A48A1D42D31A98AAC00249ECF54D7C4F3EB11CBB3983D9CEEF7ADBEA7B4E345A283BCA7C57279E4DBF531144DFCA5FB2AC7453BCCD76A6C8E95396F2835E0D939350FB5072AB8D34943A63A7F476773C102BAE939AA91A3D6D89A1AC07F09CF1EC510F5035433FD53BB9BE67D94D75E2ABAF219DFE8460F9318366B07B000B57450DB67AB63A45969DFE9A9A4FB79BF37C4222CEE1583E57A899152E2986592A6E973AC772C70C0C2761E6E71F06B479B8F4087DF39C69C5CA4F091E4C6F1BBEE5F7EA1C6719B5CF71BA5CA66C14B4B03799F23CF90F678924F4001276015BE70A7C39DAF87AD3F65BA76415192DD4367BCD6B3AF33C6FCB0B0FDC337207ACEE7CD603852E10B1CD00B5C790DF0C375CDAB21DAAAB39778E8C3875860DFAEDE45FE2EF60E8A45ABC560E59B4DB45F68BF55B67FE5AE6FF0053FA2F7F3088BCD73AD8ADD6EABB84F2B228A9609267BDE766B5AD692493EA002B1A8259784535F16D939CB788ACE2E6DACF94C515CDF470BC7808E10230DF872EDF05C8964323BD54E4990DD322AC6B5B3DD2B26AD9437C03E4797903D9BB963D623BEDAD1F57A10A4BF2A4BC9056A1D9B78ABAC5C3B9BE4AE639D925EEAEB9840D8B638C329C349F3F4A090FF09557ABACE18F197E1FA0382D865A664134367865998CF0EF24DE479F8B9E4FC55A3CCD536DABFA3B18D25F9A5EE49FCF074E4445739604444011110119F8F6D11A9D57D207DFEC342FA9BF622E7D7D3C71B79A49A988FAFC6D1B6E4F280E007896799D82A9D57F4AB4F8D8E0D6E384DD2B75634C2D7DFE3356E74F73A0A767A76D949DDCF6B078C27C7A7CD3B8DB6D8AA497537FD8FD6E1497D9F5DE32FEEBF1E6BE6BFF000431444553A30522F8148AFD90F1178B59DB77B98B6D0F7F709A08EA9E2202289CE6F3341D8B79F906DB79851D14DAECB7C58566A1E659A3DCE02D56786DCC6EDD09A99B9C9DFD6052EDFC252B99E46BF5950D36B4DFE96BDAF82F89640888B21C44C76477AA7C6F1EBA64554C2F82D5453D6C8D076259130BC8FA1AA872B2AE7AFAC9EBAAA4324D5323A591E4EE5CE71DC93F12AE4B8BEC9BF329C3966F716D43A1967B79A289CDF12E99CD8F6F88710A99D52474AD85A1BB42B56ED69792CFCC222CDE0F8DBF32CD6C18845298DF7CBA52DB83C0DF90CD2B63E6F8736EAA6F5392845CA5C9172FC37634312D06C12C7DD3E37C763A59A563C6CE6C92B04AF07DA1CF23E0BA42FC410454D0474D0B036389818C68F2681B00BF6B29C02BD575EACAABE726DF98444431116BB47B2B763FC3A496689EC0FC92F3476F7349F4BBB67354388F8C0C07F0BDAAAA94F3ED4DC9BBCB9E09873371DC41577393AF47778E646DFA3BB7FF001940C58E5CCEBFB2343D0E97197EA6DFBF1F04175DE12F197659C44E0F6CEE1B2C715CD9592B5DE1C9083213F0E5DD72252D3B34B17379D7CADC825A673A1B058AA266CBF6AC9E57C71341F6963A5DBF04A85CCF5358AFEAF615AA7645FBF822D19111653861565DA1FA375781EAF1D40B7D19164CC9BDFF0078D1E8C75CC1B4D19F512395E3D7CCEDBE6951495DDEB9E8ED835CB4EAE381DF4885D50DEF68AAF9039D4B52D079241F1E847982479AA69D45D3BCAF4AF2EAFC2733B71A4B95BE42C78077648DFB5918EFB663875056392C1D6B653578DF5AAB79BFF320B1E2BA3F93FDCD6911141B59DAF44B8BBD63D0C115BAC1778EE96263B775A2E4D32C0079F76E043E33F8276F582A5A635DA8B80D5D3B0657A6F7AB6D46DE97C8EA63A98B7F617063BF22AE04529B478B7BB3DA75FCBD255A7F7BB5707EDC73F6966574ED3CD20A585CEB5E1993574BB7A2D2D8A26EFED25C76FA0AE1BAA3DA55AAF95C32DB74F6C56FC4292405A6A4B8D5D691EC7B80633E0C24793943F44DE660B6D96D2EDA5BCA9EF3EF6DFBB97B8C8E4191DFB2BBACF7CC96F15773B854BB9A5A9AA94C9238FBCAC722283608C545622B805BC68DE90E57ADB9D5160D89D31334E7BCA9A92C263A4A70407CAFF60DC7BC903CD7AB45B42B5035DF278F1CC26DBBC6D70F965C2705B4D46C3E2E91C01F2F068DC9F20ADB341340709E1FB1118E62D077F59521AFB95CE5601356CA01D8BBD4D1B9E56EFB0DCF8924994B26B9AFED052D269BA74DE6ABE4BB3BDFC97533BA4FA5D8BE8E60B6DC0B13A72CA4A08C09267EDDE54CC47A7348478B9C7AFA8780D800B6F44590E4352A4EB4DD4A8F2DF16C222214088880222200888802222008888022220088880222200888802222008888022220088880222200888802FE3DEC8D8E924706B5A37249D800BFAB8CEB5EA4F72D970DB1CDE9BBA574CD3F347F9B1EFF003FA1094B26ABAB9A8CECB2E26CF6B95DF52A8DE4023A09E41D39FDDE3B7D2B9D222A9912C0F052C34EB233946216FB94B2735436310D41DFAF78DE849F7F8FC544F5D574172D6DB2F5363559272C172F4A024F46CC0787F087E503D688892E048044456319A3EB5E975AF5934CEF7A7D74E560B941FE0F3386FDCD434F34527C1C07C3754A394E337AC3323B962991D0C94773B554BE96AA09075648D3B1F78F30474208215F32859DA01C2ED4E6F6C7EB46096F335EAD5072DE29226FA7574AC1D2568FB67B0788F12D1D372003592C9B96C8EB2ACAB3B4ACF109F27D92FDF97915B089E1D0A2A1D4C22220088880222200888802222008888022220088A44F0B3C1FE57AFB718AFF007813D9F0BA69769EBCB367D5907D28A9F7E84F917F837DA7A2733E6BBBBA36349D7AF2C457F3CCF0F0A3C2D5FB884CA05557C7514387DB6406E57068D8CA475EE2227C5E4789EBCA3A9F256DD8DE3964C46C5438CE396E8682D96D81B4F4B4F10D9B1B1A3603DA7D64F5277257C310C431CC0F1CA1C4F13B5436EB5DBA211414F10D8003CC9F124F8927A92B30B225838FEB9ADD5D62B65F082E4BE6FBC222C2661965BB0EB2CD77AF76E47A30C40FA52C9E4D1FF13EA527866A1AD39E371EB39B05BE702E371610EE53D6284F427D84F503E2A3A2F7DF6F55D90DD6A6F17194BE7A97971F53479347B00E8BC0AACC896022228242FA53544F49511D5534AE8E585C1EC7B4F56B81DC15F34404A5D33CEE0CDAC6D9252D65C69408EAA3F59F278F61FC8775B82E21C3EE33546A6AF2B95EF640D69A585A0EC247742E27D6074F895DBD5918DF06111149011110044440161F2FC431CCF71CAEC4B2DB54371B55C62315453CA37041F307C43878823A82B30885A329424A517868AB4E24B80BCE74BA7A9CA34D69EAB26C577748E8E36F3D6D0B7C767B07591807DBB4797A4078A8A3247244F7452B1CC7B0ECE6B86C41F510AFE7C5720D58E13B437589B2D464F87C549739474BA5AC8A5AA69F592072BFF86D705571EC37BD2F6D254A2A95FC77BFEA5CFDABAF8AF2299114FCCB7B2D0891F260BAA7BC67AB22BB51FA4DF617C4763EFE50B9FD5F665EB8C5296D26458B4ECF271A8959F9390AAEEB36BA5B4BA555595592F1CAF8A221A29836FECC7D6AA89036E194E2F48CDFAB9B34B27E40C0BA3627D9696B63992675AA5552B47CF86D346D8C9F7492F36DFC429BAC8ABB4DA551597553F04DFC8AF86B5CE706B5A49276000EA4AEF7A1FC17EB1EB454415C2CEFC771E710E92EB73618C39BEA862F9F23BE01BEB705641A63C26E8369388A7C6B05A5A9B84407FD23733F2BA971F582FF004587F01AD1EC5D7C00D01AD0001D001E4A547B4D6750DB7724E1630C7FD52F92FABF61C7F40F85CD32E1FEDE5D8DD01AEBE4F18655DE6AC074F20F36B3CA366FF6ADF1F327A2EC088AE689717156EAA3AB5A4E527D584444309E1BFDEEDD8D58AE391DDE71050DAA926ADAA94F83228985EF77C1AD2550E5D2E55979B9D5DDEE3319AAEBA792A6790F8BE47B8B9C7E2492AFBAA29E0AB824A5AA859343330C724723439AF691B16907A10474D9613F303837EC3AC9FF00808BFB2A1AC9B2681AED3D115472A7BCE58EB8C633DCFB4A23457B9F981C1BF61D64FF00C045FD94FCC0E0DFB0EB27FE022FECAAEE9B1FF8EE9FFC0FFBBF635BE1EB1E762BA1D83589D236475358A90B9ED6EC097461FF00FA97425F98E38E18DB0C4C6B18C686B5AD1B0681E000F20BF4AE73DAD55D6A92A8F9B6DF984444311A9EA869761BAC188D5E179C5AD95941523998E1D258241F3648DDE2D70F5FBC1DC12155D7111C156A5E8955CF77B3D25464D89EE5D1DCA961DE4A76FDCD446DDCB3F087A27D60F456E2BF8F632463A39181CD70D8B48DC11EA2A1AC9EDE91AF5CE8F2C53E307CE2F97B3B1940C410762362115C26ABF055A07AB0E9ABABB177586ED292E75C6C8F14D239DEB7B08313FDA4B37F6851B329ECB5BBC72BDF85EA952CD178B5972A2746FF0077346483EFD87B953759D06D36C34EB88FF9ADC1F7AF9ACFC881C8A5D4FD999AEAC90B60BF62D2B3C9C6AA56EFF0EED7AED9D989AC952F02E797E3144DF32D7CB2EDF4342619E83DA1D2D2CFA6890E97EE1826A995B053C2F96579E56B18D2E738FA801E2AC470FECB7C529DF1CD9E6A5DD2B4020BE0B5D3C74E0FB3BC903CEDFC10A4DE9AF0DFA29A4AC8DD84E036EA6AB6000D75434D45538FACCB212E1EE1B0F62951679579B6761416282737E4BCDFD0AE9D09E03356B55E486F194D33F10C71DB3BE515D1FF00855437FECA1F1FE13F947AB9958E68C681E9B684584D9B05B2B629E700D65C273CF5556E1E6F79F01EA68D9A3D5BEE4F454564B0689AAED05E6ACF76A3DD87E95CBDBDA111149E185C9F8B0C9FF323C38EA0DDBBA323A5B2CD6F680ED887556D4C1DFC1EFB9BE0BAC2F857DBE82E94AFA2B9D141574F26DCD14F187B1DB1DC6E0F43D50CD6D52346B42A4965269B5DB87C8A0C457B9F981C1BF61D64FF00C045FD94FCC0E0DFB0EB27FE022FECAA6E9D07FC774FFE07FDDFB14678E5AA6BE6416CB2D340F9E5AFAC86999133E73DCF786868F69DD5F05A6DD059ED54769A51B43454F1D3C63D4D634347E40B1F061186D2CF1D4D3627678A689C1F1C8CA28DAE6381DC1040E841F359A564B06B7AFEBDF6DBA7BB0DD51CF5CE738EE5D8111149AE0444401111005FC7B19234B2468735C36208DC10BFA88088BAF3D9E3806A255D564BA6959162379A873A59295B117504CF3D49E46F58B73F71D3F6AA0FEA37093AFF00A635130BEE9F575651464F2DC2D83E574EF6FDD6ECDDCCF73DAD3EC57348AAE299B3E9DB597F63154E6F7E2BB79F9FD7250655D0575049DD57514F4EF1D39658CB0FD042B32ECC9C65D6BD18BCE472066F7BBD3CB081E972431B59B13F85CC7E2A57D76338E5CC975C6C16DAA2EF13352B1E4FD217DED768B5592905059ADB4D434CD25C21A789B1B013E2766803AA28E0FA758DAAFB56D1DB2A7BADB4DBCE797B11EB4445634F23671F38EEA0661A270627A7B8BDCAFB5572BC538AB828699D33D94F1B5F2731DBC073B631F155D3FA16F88BFBCBE5BFC9B27FC95D4A2871C9B3695B4D5B49B7F57A54D3596F2F3D4A56FD0B7C45FDE5F2DFE4D93FE4BAE709FC33EB25AB5FF12BEE63A677CB4DA6D354EAD9EA6BE89D1C40B18EE41B9E9BF3F2EDEE569A8A374FB2E36D2EAE28CA8BA715BC9ACF1EBC02222B1A684444056FF1DBA4FAD1A9DAE72DCB11D34C96ED68A0B6D3D1C1534D42F9227387339FC840D88DDDF4EEA3B7E85BE22FEF2F96FF0026C9FF00257528AAE3936FB3DB0B8B2B785BC29C71158EA52B7E85BE22FEF2F96FF26C9FF25393B39B46B32D32B0E6978CF317B958EE377ACA4A6869EBE9CC4F30C2C7BB9DA0F520BA623F80A62A228E0C3A9ED55C6A76D2B59C124F1CB3D1E42222B1AB05C8F887E1AB04E21B1D6D0DFE11457AA26BBEA75DE160EFA027ED1DF77193E2D3EF1B15D7110CD6F7156D6A2AD465892E4D14AFAD9C36EA96845DE5A3CBEC6F96D85E452DDE9019292A1BE479BC58EF5B5C011ED1B13CB55F95C6DB6FBBD1CB6FBAD0C1594B3379648678C3D8F1EA2D3D0A8D7A9FD9EDA0B9F4D25C6C1495D875C2425CE75AA40699EE3E6E824DDA3DCC2C5471EC3A169DB6D4E4942FA387FA9715ED5CD7B32550A29BF91765CE714F2B9D8BEA4D9EB62FB51594D240F3EFE5E61F956AEEECCFD790E21B79C548DFA1F96483FF00A6A30CD8E1B47A5CD65565EDCAF8A2242299F66ECBFD53A991BF56F3BC76863FB6EE9B2CCEF8740175FC1BB3174B2CF3C5599D6617BC84B082EA5A70DA3A77FB1C5BCD211F82E694DD660AFB55A5D059F49BCFB126FF006F795BB68B2DE320AF8AD562B5D55C2B2621B1C14D0BA491C7D8D68254C6D05ECE2CC727753643AD152FC72D84878B4C2F6BEBA66FEDC8DDB0823CBABBD61A54FBC0F4974D74C28C50E0385DAECB181B1753C3F5D7FB5D23B77B8FB49256DAACA3DA6A5A96DA57AE9D3B38EE2ED7C5FD17BCD7F05C030FD34C6E9713C22C34B6AB65237664503362F779BDEEF17BCF9B9C492B60445634A9CE5524E73796FA844442A111100444401111004444011110044440111100444401111004444011110044440111100444401111004458DC96EEFB0582BEF51D23EA5D4703A51133C5DB7FC0789F60280D4F55F5123C3AD6682DD2B4DDAB19F5A1E3DCB3C0BCFE5DBDBEE51AA59649A474D33DCF7BDC5CE738EE5C4F89257B2F779AFC82E95177B94C64A8A87F338F90F501EC03A2F0AAB322580888A090BEB4B533D1D4C5574D218E585E1EC70F10E077057C91012CB01CBE9B33C769EE71B80A860115547E6C940EBF03E23DEB63515B4E339A8C22FADA970749435044757103F6BF743DA3C7DBE0A51D1D652DC2962ADA299B2C13343E37B4EE1C0F9AB26636B07D97F1CD6BDA58F68735C36208DC11EA5FD452415D5C69F04F5563ABAED5AD20B54935AE6E6A8BBD9E06F33A95FB92E9A168EA633E25BD4B4EE4743B360D2BFAF150D389EE002C79EBAB738D1E6D3D9F2190BA69ED4ED99495CF3D4961F08A43FC527C76F15471EC3A0ECFED5A8455ADFBEE52F94BEBE7DA56822CD65F8565780DEE7C7332B0D65A2E34E767C153196BBDE3C9C3DA370B0AAA7438CA338A945E53088884844440111100444401110024EC06E4A00BEB47475770AA868682965A9A9A8788E2861617BE4793B06B5A3A924F905DCF44B832D65D689E9EB61B41C7B1F908325DAE6C731A59E7DD47F3E53EADB66FADC3C558BE83F093A51A0D1C770B35BBEAAE4219CB25E6B9A1D30DFC7BA6FCD881FDAF5DBC4952A2D9AEEABB4D67A62704F7E7D8BE6FA7C7B88B9C30767B575CA5A5CE35DE07D2D1B4096971E69DA598F88754387CC6FF00D98EA7CC8DB6360B6DB65BACD6FA7B55A6860A3A2A48DB1414F046191C6C0360D6B474002F4A2BA583976A7AB5CEAB57D25C3E1D12E4BC3EBCC222F15E2F36DB0DBE5BA5D6A9B053C237739DE7EC03CCFB149E69FDBC5DEDF61B6CF75B9D4361A6A76F33DC7F201EB24F4D945DCFB38AFCE2F2FAC9C98E92225B4B06FD18CF59F5B8F995E9D44D44B867570D807C16D81C4D35393F0E777EDB6FA37D969EAAD978AC04445058222200B2B8C63D5B945F296CB42D25F3BFD276DD18C1F39C7D802C5805C435A0927A001492D1FC07F32766FAA7718396E9706032070EB147E219ECF227DBB7A94A21BC1BB59AD34762B552DA28230C8296311B00F3F593ED27727DA57B11158C611110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111005F99A28EA217C12B4399234B1CD23A1046C42FD220224E758CCB8964F5967734889AEEF2027EDA277569FF0087BC1580523B5B30CFCD0E3E2F3450F3575ADA5FE88EAF87C5C3E1E3F4FAD471556644F282222824222200BA5E936A8BF179DB61BE4EE75A667FA0F775F9338F9FE09F31E5E3EB5CD1656DB8A64D77D8DB2C170A969F07C74EE2DFE36DB290F892FA29629E36CD0C8D923780E6B9A770E07CC1F35FA5CA749E875371EE5B55EED1CD6977CDEFA76F794FF83B13B8FDA9F87B7AB2B189F0088880D3B52F4834E357AC8FB0EA0E2B457581C368E57B396A203F7514A367C67DC46FE0771D1423D57ECC6BD52BA6B8E8E65B0D74437736DB7877772FE0B6668E527F08347AC8561A8A1A4CF574FD6AF74CE16F3E1D8F8AF2FA60A3BCEB44F5674D2AE4A3CDF00BD5ACB091DF494CE7C0FF006B2566F1B87B438AD255FB5453535642EA6ABA78E789E3674723039AE1ED07A15CDB2BE19F413352F7E43A55609A593E74D0D30A797F8F172BBF2AAEE9B7DB6DD4718B9A5ED8BF93FA94A48AD62FDD9C3C36DDDCE75BE9324B273780A1BA9786FBBBF6C8B53A8ECBAD2373F7A5D42CBE367AA434AF3F48887F328DD67AF0DB2D326B2DC978AFA64AD34565B4DD977A40C7EF59A81984ACF544EA58CFD26277F32DB6C5D9C9C35DA1CC757D06457AE5F115D752D0EF7F70D8D37589ED969905C1C9F82FAE0AA55B3E27A61A8D9DD5328F0DC1EF77891E401F24A292468DFCCB80E568F69202B84C5F863D01C38B1F61D29C7E2919F3659A985449FC79399DF95749A3A2A3B7C0DA5A0A4869A167CD8E18C31A3DC07453BA79571B7504B16F49FF00DCFE4B3F12B334D7B35357323EE6B750EEF6DC5691FB1753B6415757B7B430F76DFE39F68530747F82BD0BD20922B9D2E3A320BD4601171BC86D43A377AE38C8EEE33ED039BF6CBBC22B2491AB5FED1EA3A82719CF117D23C17D5FB59FC6B1AC68631A1AD68D80036002FEA2293C20888802D4333D38A2CDEA2396E979B847142368E9E273446D3EBDB6EA7DA56DE880E4EFE1DF1E3FA9DF2BDBEF6B0AF3C9C39DB3FC964955FC285BFF0035D8114609CB38B49C39B3FC964CEFE141FF00E579DFC39577F93C9E0FE1539FF9AEE28981BCCE0CFE1D6F83F53C8689DEF89C179DFC3CE523F53BBDB5DEF2F1FF00A548144C13BCCE3D80E8856592FACBBE4D3D1D4474BB3E08A12E70749E45DCC0741E23C7AFB97614452437908888404444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111002011B11B82A3A6A4695DDEDB923A4C6AD33D550D76F2C6D8584889DF6CD3EA1B9E9EC522D1094F0461A0D1AD40AED89B38A707C4CF2B5BB7C37DD6C96FE1D6F92EC6E77FA2A607C4451BA523E9E51F9577A451827799CAEDFC3D63106CEB85DABEA9C3C43796369F86C4FE55B150E90E9FD0EC5B6164C479CD239FFCE56E48A7046598FA1C76C36C03EA7D9A8A9C8F031C0D07E9DB7590444202222008888022220088880222200888802222008BCD5D73B75B2233DC6BA0A68C0DCBA590347E55AEDBF52B1CBDDFA2C7F1F74D719DFBBA596266D0C2C1E2E738F8F901B03B92101B5A22200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802FC4F1BA5824899218DCF616878F16923C42FDA2023F4DAC99F62D75AAB2DDFE495EEA399D138CB0F23CEC7A1DD9B0F0F62CD51F11901D85C31A78F5986707F9C2C5F1018C8A3BBD2E4F4CCDA3AE67733EC3C256F81F8B7A7F07DAB92AAF22E926890D07105883C0F94505C623EC8DAEFF00885EA6EBCE04E1B97DC1BEC34DFF00E546F44C93BA891B26BE60AC0791B7279F65381FCEE58FAAE21F1D8C1F92D96BA63E5CCE6B3FE6B8122646EA3B0D7F11771782DB6E3B4F19F274D2977E41B7F3AD52EDAC99FDD8160BC0A28CFDAD24623FF5BABBF2AD25132308F455DC2BAE1219ABAB26A879EA5D2C85C7F2A905A1B88FD44C74DF6AA2E5AABA80E6EE3AB611F37E9F1FA171AD3CC55F97E514B6B2C269D87BEA923CA2691BFD3D07C54AF8E36451B628DA1AC600D6B40D8003C0294449F43FA888A4A0445AEEA06A062BA618AD5E699A5CBE4168A2746D9E7EEDCFE5323C31BD1A09EAE701F142D084AA49420B2DF246C48B80FE8ECE18FEF85FEC537F653F47670C7F7C2FF629BFB2A328FBFEC8BFFF00867FDAFE877E45C8B01E2BF42F5372BA2C270CCC7E5D78B8094D3C1F25959CFDDC6E91FD5CD006CD638FC175D527C95EDAB5ACB72B45C5F3C35808B48D4CD6BD2FD1FA48AAB50F30A1B4BAA1A5D053BDFCD51301D09644DDDC46FE7B6DED5C920ED07E19E7A814E725B9C409DBBC92DB2060F6EEA3267A1A6DE5CC3D251A5292ED49E09248B53D3FD57D39D53A07DC74FF0030B6DEE28B6EF5B4D30EF22DFC39E33B3D9F1016D8A4F96A539D2938544D35D1F0611726D43E2A34434B3289F0DCDF2FF905DA9A38E5960F9348FD9AF68734EED691D410B5AFD1D9C31FDF0BFD8A6FECA64FAE1A65ED58A9C28C9A7C9EEB3BF22E5982F145A0BA8D718ACD8B6A4DAA5B8D43B921A4A871A796571F06B04807313EA1B95D4D0F9EB5BD5B796E568B8BEF58F8845AC6A36A561DA518D3F2ECEAE9F53ED71CD1C0E9FBB73F67BCECD1B3413D765CA3F47670C7F7C2FF00629BFB2865A16175731DFA34E525DA93677E45C07F47670C7F7C2FF629BFB2B68D39E28B45355F25662382E5BF542E9244F9DB0FC9A466EC60DDC777003A264BD4D32F6945CE74A492E6DA6756445E6B95CEDD66A0A8BADDEBE9E868A96332CF51512B638A260F1739CE20003D650F8926DE11E9451EB25E3D3868C6AB1F447349EE8E61E573EDB4524F1EFEC77407DE370BEF8AF1D5C3565556CA28F3A36B9243CAD374A67D3B37F6BCEED1EF24051947A0F48BF50DFF00432C7F4B3BF22F8D1D6D1DC6921AFB7D543554B50C6CB0CD0BC3E391846E1CD70E8411E042F264990DA712C7EE5945FAA7E4F6DB4524B5B57372977770C6D2E7BB61D4EC01F0527C0A2E52DD4B899145C934FF008ABD0ED4FC9E9F0FC2F30F97DD6A9AF7C507C965673063799DD5CD03C02EB6864AF6F5ADA5B95A2E2FB1AC0445A1EAEEB7E9E687DA28EF5A8576928E9EE15069A9C450BA57BDE1A5C7D11D760078A15A54AA579AA7493727C92E66F88B9968FF0011DA51AE95572A1D3DBEC95553698E396A219E130BF91E480E6B5DD5C016EC48F02E6EFE2174D426B50AB6D374EB45C64BA3E0C222E55A8FC5068AE9364AEC4B3BCB7EA7DD1B0475061F9348FF00ADBF7E53BB411D76284D0B7AB732DCA31727D8964EAA8B0B85E638F6A062F6FCC714AEF965A6E71996967E42DE76871693B1EA3AB4ACD218E519424E325868222E79AA9AFDA59A2D516EA5D45C8FEA649756492528EE1F2778D8CB438FA20EDB7337E942D468D4B89AA74A2E527D171674345AB69BEA7619AB58DFE6B703BB7D51B599DF4DDF776E67D719B730D9C01E9CC16D28454A73A52709AC35CD308B956A7F143A21A455AFB4E659C52C7738C03250528351511EFE1CED66FC87D8E20F55A55A78FCE19AEB54DA5765F5943CC76EF2AEDF23183DE402A328FB29E977B5A1E929D1938F6A4C9148B138BE5D8BE6D688AFF886416FBCDBA6E8CA9A2A86CD193E6D25A4EC47983D479AFC66597D8301C62E1986535BF23B55AE2EFAAA7E42EE467306EFB0EA7A90A4F8FD1CF7FD1E1EF72C75CF619945C07F47670C7F7C2FF629BFB29FA3B3863FBE17FB14DFD951947DDF645FFF00C33FED7F43BF22E03FA3B3863FBE17FB14DFD95DBEC17DB664F64A1C86CB51DFD05C60654D3CBCA473C6E1BB4EC7A8E8A4F9EBD95CDAA4EBD3714FB5347BD11699AAFABD82E8AE351E59A81747D1504D54CA388C713A47C9339AE706868EBF358E3BFB10C34A94EB4D53A6B2DF248DCD1727D25E28747B5B2F9538E6057F9AA2E14B4FF2A743514EE84BA304025BCDF3B6DC6FB2EB085EBDBD5B69FA3AD171976358088B1B91E4B8FE2166A9C8729BD51DAAD946DE79EAEAE66C5130780DDCE3B6E4F403C49200EA8628C5C9EEC565992451CAE9DA01C33DB2ADF48DCB2BAB39091DED2DBA47C6EF713B6EB76D3BE29B423546B62B562BA83406E339E58A8AAC9A69E43EA6B5FB731F63492A328FBAA6977D4A1E927464976E19D5D11149F00445E1BEDEEDB8D596BB20BC4FDC50DBA07D4D449CA4F246C1BB8EC3A9E810949C9E1733DC8B80FE8ECE18FEF85FEC537F653F47670C7F7C2FF629BFB2A328F43EC8BFFF00867FDAFE877E45C32D3C6C70E37CBAD1596D99E77B5970A88E969E3F91CC39E491C1AD1B96F4DC90BB9A93E6AF6B5ED5A55E0E39ED4D045C873EE2BF42F4CB2BADC2733CC7E4378B7888D441F2595FC9DE46D919D5AD20EED7B4FC5746C432FC733CC72872CC4AEB0DC6D5718FBDA7A888FA2E1BEC47AC1041041EA084152D2BD1A6AAD483517C9B4F0FC199845E7B95C296D36EAABAD749DDD351C2FA899FB6FCAC634B9C76F702B90625C6068067392DBF10C6B35F95DD6E930A7A587E492B79E43E0372DD8782114AD6BD78CA74A0DA8F369378F13B3A2221802222008B4CD47D65D31D25A56556A16676EB3999A5D0C12CBBCF301D37644DDDEE1BF4DC0DBDAB8D49DA23C344753F27FAB97A78DF6EF1B6B7967BF7DFC1464FB6869B79751DFA34A525DA93C12611681A69AF7A47ABDBC58066F6FB955B19DE3E8B9FBBA9634789313B67103D6011ED5BFA93E6AB46A5096E558B8BEC6B0C222E73AA1C42E8FE8EBD94D9EE6947435B2379D942CDE5A9737C9DDDB77207A89D814268D1A9713F474A2E4FB12CB3A3228E141DA07C33D754B699D955C29438EDDECF6D91AC1EF237FE65DBF0AD40C2751AD22F982E516EBDD0EFCAE968E70FE477DCBC78B1DEC7005339335C69F7568B7ABD394577A68D811796EB73A3B2DB2B2F17197BAA4A0824A99DFB6FCB1B1A5CE3B0F500570BFD1D9C31FDF0BFD8A6FECA15A16771749BA1072C7626CEFC8B80FE8ECE18FEF85FEC537F653F47670C7F7C2FF629BFB2A328FA3EC8BFFF00867FDAFE877E4582C1F37C6F51B17A1CCB11AFF96DA6E2D73A9E7E42CE70D7169E84023AB485AC6A9F101A57A2F554145A8B91FD4C9AE71BE5A66F70F939DAC2038FA20EDD48527C90B6AD52AFA1845B976638F0E7C0E888B80FE8ECE18FEF85FEC537F653F47670C7F7C2FF00629BFB2A328FAFEC8BFF00F867FDAFE877E45A3E966B569CEB3D1D75C34EEFBF54E0B74AD86A5DDCBE3E47B86E07A406FD16F0A4F8AAD29D09BA75134D747C184587CAF31C5705B3CB90663905059ADD0F47D4D64ED8D9BF9346FE24F901B92B835DBB41B867B555BA95993DCAB83491DED25B647C67DC4EDFCC9933DB585D5DACD0A7292EE4D9245171CD3DE2EF87FD4BAD86D560CFE929EE150E0C8692E20D2C9238F835BCFB35CE3E401DCFA9763431D7B6AD6B2DCAD0717DEB01116B39FEA6605A5D67FABB9FE534165A3712D8DD53280E99C06FCB1B3E73CEDE4D050C7084AAC9420B2DF446CC8A36BFB4238676D49A6FCD2DD1C03B97BC16D9390FB77F57C1756D37D76D24D5A0E8F00CE6D974A96339DF46D9792A58DF326276CED87AC023DAA328FAEB69B796D1DFAB4A515DAD3C1BE222E79AA7AFBA59A3151414DA8991FD4C92E4C7C94C3B87C9CED6900FCD076F10A4F968D1A971354E945C9BE8B8B3A1A2D434C356305D63B05464FA7D79FAA56EA5AC7D04B2F74E8F9676B18F2DD9C01F9B230EFED5B25E6ED4160B4575F6E93773456EA696AEA64D89E48A36973DDB0EA76009413A5529CFD1CE2D4BB3A9EB45C5717E323877CC320A0C62C99FC2FAFB94C20A664B4F244D7C87C1BCCE680093D06E7C485DA90BD7B5AF6AD46BC1C5BED5808B4CD51D60C0346AD1497DD43BDFD4CA2ADA9F92412774F939A5E573B9766827C1A4FC17CB4B35A74EB59E86BAE3A777DFAA74F6E95B054BBB97C7C8F70DC0F480DFA20F55AFE8BD3EE3DCEDC70F337845AB6A46A6E19A4B8D9CB73BBB7D4EB589D94DDF776E7FD71FBF28D9A09EBB15CABF47670C7F7C2FF629BFB2864A16175731DFA34E525DA93677E45C07F47670C7F7C2FF00629BFB2BEB4BC71F0D35B550D1D367FCD2CF23628DBF229BAB9C7603E6FACA8CA32FD937EBFF00B32FED7F43BCA2FE46F6CB1B6561DDAF01C0FB0AE39997179A0780E4D5F886539A7C8EEB6C97B9A983E492BB91DB03B6E1BB1E84293E6A16D5AE64E3460E4D762C9D911701FD1D9C31FDF0BFD8A6FECA7E8ECE18FEF85FEC537F654651F57D917FFF000CFF00B5FD0EFC8B0B866638FEA06316FCC715AEF965A6E91996967E42DE76871693B1EA3AB4ACB54D55351534B595951141040C324B2CAF0D631806E5CE27A000799527C1284A127092C35C307D1147FC9B8ECE1AB18B83EDCFCE1D737C6E2D7496DA57D44408F53C6C1DEF048591C338D2E1C736AC8EDF43A874B6FA99886C6CBA31D481C4F973BFD01F12A328FB9E957D187A474658FE9676F45F98E48E68DB2C4F6BD8F01CD734EE1C0F8107CD6332BCA2CB8563970CB323ABF92DB2D703AA6AA6E52EE48C789D8752A4F863173928C565B32A8B9269F7155A1FAA394D36198565FF002FBB55B247C307C965673363617BBAB9A0746B495D6D0C95EDEB5B4B72B45C5F635808B5ECE35070AD35B23B22CEF25A1B2DBDAEE41355481BCEEF1E560F17BBD8012B87CDDA0FC33C35269864D7390076DDEB2DB2161F6EFEAF8264CD6FA7DDDDC77A85394976A4D9245173DD36E20347B56E4F936079DDB6E35A1A5E688BFBAA900789EE9FB3881E6402174243E7AB46A5096E558B8BEC6B011110C61111004444011110044440111100444401111004444011110044440111101ADEA2637F9A9C4ABED91B39AA033BEA71EB91BD40F8F87C544F2082410411D082A6A28BBAB58E7E67334AB6451F2D3D69F9543EAD9C7D203DCEDD432F17D0D3111154B0444401116D9A67897E6BF2AA7A29E32EA383EBF55E3B1603F377F69D87D280ECDA2988B71EC605D2A6102B6EBB4AE24756C5F68DFCBBFC57435FC6B5AC686B5A0340D8003A00BFAAE627C4222200A3B76807D8B1957EE8B6FF005D8548951DBB403EC58CABF745B7FAEC2A1F23D2D1BFDC687F5C7E28AFBE14F878A0E23731BAE2F70C9EA2C6CB7507CB44D0D33672F3CE1BCA417376F1F1528FF4ABF19FBF15CFF9223FEF5426D28CC756B0CBC5557E90D7DDE92E5353F7550EB6C1DEBCC3CC0EC472BB61BECBA97E7F5C6FFEC9B39FE4DFFF0052A2C1D3B53A1AAD4B872B4B98C21C383C67FF006B262686700B63D11D50B3EA651EA4D75D66B40A90DA496DCC89B277B04909DDC1E48D849BF87929515951F25A49EAB979BB98DD26DEBD86EA29F0179D6B5E6D4196BF58AE57BAB92966A61426E74DDD1682D7F372FA2DDFC02960F63646398F00B5C0820F98575DC737D6E774EF1C2F2A29CA292CAE58E7D8BB4A49C8321BDF101AD42BF25BFB6967CA2F11D2B6AEB1DBC7450C9286B01DCF4631A474E83A7929A971ECB5C2A4B472D97556F51DCBBBDDB354D143253B9DB7DC34B5C01FC33B7B572EE243802D4BB065172CAF496D9F9A4B0D7D4495428A9DCD6D6519738B8B3BB3B778D04F42CDCF916F4DCF1DB0EB1F143A0B336DB4F92E59618A9C868B7DD227C94EDFDA88A769637F820154E5CCE8752A55D4E8D3968D71186EAFC3C3DFC1B58F0254F0A7C0E6A1696EB2CD996A0DD194F458F0DEDAFB556BB92E723F71E9F8384407CE6380E63B03B80779DAA0A70E1DA27579564D6EC1B596D7454B25CE56D353DEA8C18E26CCEE8C134649E50E3B0E607604F5006E44EB5758E8687B44B50F5A4F51494B1C31C9A5D9EDE654BF685FD93F7DFDC16FFEAEC5D03447B3D2D7ABBA578F6A3CFAA7556C92F94EF99D48CB43651172CAF66C1E656EFF00337F01E2B9FF00685FD93F7DFDC16FFEAEC5D47423B40F0AD24D24C734EAE580DE6BAA6C94EF864A882A226B242E95EFDC03D474701F055E19E26ED55EA31D1ADBECCFC788E718E5BBDFDF8387F137C2B64FC34DD2DB2D4E414F7BB35D9CF143708A230482466C5CC7C65CEE52010410E20FB3C14E7ECFFD6DBDEAD694D6D932BAC96B2F388D54746EAA9372E9E96467342E7B89EAF0592B4FB1AD3E24A84DC56715D71E252BAD343478DFD46B2D99EF929A9DF289A69657800BDCE000F000068FCAA68767A68CDF34C34A2BF25C9E965A3B9E61551D5369641B3A1A489A5B0F30F2738BE476DF72E6781DC22E7C0F8B5EF48F4483D4B1E9F2B1CB3CFBBFE9E78E193D7DA33F634D6FE38A0FF7DCA117095C31DB7895B9E474171CBAA6C42C5053CCD74348D9FBDEF1CF1B105CDDB6E4FCAA6EF68CFD8D35BF8E283FDF72AE2D24CE75A309A9B8CDA3B72BDD24F551C6DAE36CA7EF4B98D27939BD176C372ED91F32FB351AF3D1271B69A84F79E1BE4BF0F8F4268FE957E33F7E2B9FF2447FDEAE95C3EF03165D03D44875068750EB6F12C34B3528A596DEC85A448DDB7E60F27A7B942EFCFEB8DFFD93673FC9BFFEA536F812CC756B34D3BC82BF57EE177ABB9417A30D2BAE50774F1077119D9A395BB8E62EEBEBDD4AC1F06B11D62DACE52B8B98CE0F834B1979E1FA5124E69A2A6864A8A891B1C5134BDEF71D835A06E493EAD9547716BC4F64DAF59BD663F66AC9E0C36DD5669ED94113881565A794544A3ED9CE3B96823D1040EA7726CEB5D6AAE543A339AD5DA038D64763AC30868DCEFDD3BCBDDBAA93E15E86C372E22B4FA93247B5B44EBE53B8070DC3E7692E818479874A236EDED497618F642DA9429D6D42A4779D35C17B1B7EDE88915A3BD9A37CC9F1EA7C8755731971F92B18D962B5D0D309678D846E0CB23C86B1DFB40D76DE677DC0F0EB2F66B669895B1F7DD29C93F3571420BA6B6D4C029EB00F5C6412C97DDE89F56EACA913751E6ADAED4D56F4BBEB1FA70B1E1DBEFC9C1B839D0DCAB43B4B62B466590D5555CEE4F1592DB7BEE7A6B6730DFB98FF006DD77791D39B7DB70398EE7C48FD8FBA91FBD5BA7F56917465CE7891FB1F7523F7AB74FEAD229E48F2A37352F3508D7ABF8A524DF9A2B5BB3FFEC9CC7BF72D6FF42E56DEAA43B3FF00EC9CC7BF72D6FF0042E56DEA23C8F7F6DBFDC63FD0BE2C2A96E38B576B35975DA7C7EC4F755DA31977D46B5C508E633CE5C3BE78037DDCE93D01B78B63674DF75615C56EB145A27A2D7BC9E9E560BBD633EA6DA2327ABAAA5DC07FB98DE690FAF936DF721571705B6FC16B35CA8B2FD4DCB6D369A0C701BB31F74AC6C5F29AC0E1DD6C5E7D27071E7F1F168292EC33ECA5AFAB52ABAAD48E7753515DAFAE3DCBDACC5F0F79F5EB86CE2168AA3248E5A06D1564965BF5393F36173B924E6D8EC435C1AF07A8F4011BF4571EC7B2463648DC1CD780E691E041F35547C7D50E9BDC354E9350B4DB31B0DEA9F24A626E315B6B2399D055C5CAD2F78613B07B5CD209F12D7FA82993C04EB19D4ED13A3B05D2AFBDBCE1DC96A9F9B6E67D3347F83BFDBE800CDFCCB372492523C1E0C9B4F6EEFECE8EAB18E1E3125D9FF8795ED4494554FDA3DF649D47E24A1FE67AB58554FDA3DF649D47E24A1FE67A4B91F0EC5FFB93FE97F144EEE0C3EC60C03F17CBFD6255DA9715E0C3EC60C03F17CBFD6255DA94AE4781A9FF00AEADFD72F8B0ABCBB54BFEBFD3BFDC772FF7E0561AABCBB54BFEBFD3BFDC772FF7E049723D5D93FF0076A5FF0077FED6767ECDDFB1C1BF8FABBF9A35D73892D43B86956866619DDA585D5F6FA0EEE91C36FADCF348C82393AF8863A56BC8F30DD9723ECDDFB1C1BF8FABBF9A3522B3AC3ACFA8386DEB08BFC5DE5BEF9452D14FB01CCD6BDA407B77F0734ECE69F220145C8C3AA4E9D3D66A4AAACC54F8AED59E3EE29DB40B4C9BC43EB2D262193E5B2DBDD76F94565557C804B34CF682F2D6F311BBDC7CCEFEE2A5966FD96F6A169966D3AD4CACFAA51B4BA3A7BCD331D0CC7EE4C910063F7F2BBDDE6B826AC703BAF5A55779AAF1EB0D4E4D6785E64A6B9D9FD395AD07A73C20F78C70E9B900B7D4E587C5B8AEE28B48AA196D9735BD3E284EDF20C821352361F6A0CC0C8D1F82E0A8B8733A0DD4AEF50946BE91731DD4BF0F0C7B7837EC69609AFC0CF0BF97687515EF26CFEA67A5BCDD24751B2D90D573D347046EE92B834F2BDEE23D13E4DFC22BBF6B0E9D3356B4CEFF00A72FBB9B5B6FB4C29CD6083BE30ECF6BB7E4E66F37CDDB6E61E2B86709BC6BDBF5EAE6EC132DB4C166CAD903A7A7EE5E4D3D7B18377F203D5AF68DDC5BB9E8091E076948AEB18E073BD5EA5F52D41D6BB5BB5534D63970E58E795C3EA409FD2A9A2FBF8CFF00F9707FF72A05E3B6A17EC82D96333F702E3590D277BCBCDC9DE3C379B6DC6FB6FBEDB857D4A8934F7FC7EC6BF1C51FF4CC55692376D96D5AF3518577733DEDD51C704B19DEEC4BB11397F4AA68BEFE33FF00E5C1FF00DCA9B18162ADC1F0BB261EDAE3582CD431510A831F77DEF234379B9773B6FB786E5679159248D06FB57BDD4A2A1753DE4B9704BE0905573DA27AC1F9BDD5C874EACD5227B6E1CD34F208FA87D7C9B1940DB7DCB472B3D8E0E1B74560DAF7AA549A37A4F9067F50E677D414C5944C7F84B54FF4626EDB75F4883EE07C3C5553F0D166C573AD77B65D75572DB6DB6CF4750FBE5D2A6ED5822158F63C3845CCF3E93DF2B9BBEE77E5E73BEE144BB0D8F64AD153F49A9D55954D3C77BC71C7B387B4C5E976659670D7ADB6BC82E56EA8A5ACB1D5B23B9D0B8F2BA6A5900EF63F57A51BB769F0DF94F92BA2B4DD282F96BA4BCDAAA5951455D032A69E56F8491BDA1CD70F7821568F68747A559564F64D4FD38CD71CBB5656C1F53AEF4F6DAD8A591CE8C6F14EE0C3B9F43EB649F2630792EFFD9CDAD11E6FA5D51A6575A9DEF186B8084388066A090931B8799E477331DD3A031F5DDCA23C1E0FA768E8BD4F4FA5AAA8EEC97092FE763E5DCC972AB37B4BB51AFD74D56A0D351592C765B2DBE0AC34E3A364AA9798990FDD6CCE503D5BBBD6ACC944BE35383DBCEBA55D2EA0E9FD5D3B726A0A41473515549DDC75B035CE73031E7A35E0B9DB736C0EFD48D95A5C51E0ECC5D5B5A6A11A972F0B0D26F927DA71AE1FFB3EF08D57D29B46A05FB52EE0DABBCC2676C16B8E23152F5D846F2F04B9E3ED87A3B1E9D76DCE3AFF00D99FA9369CEED3458F6534576C62AEAD8DA9B90DA9AAA862077739D112438EC3669638EE76DC05C2863BC4EF0F3717CD4F6FCD70F958EF4DF4A656412EDEB2C26291BF485D7B4C3B48758B18AC829B51A9E8B2BB6B486CAFEE194D561BE64398030903C8B7AF9954E1D4DDEBD2D6D4E75EC6BC6AC1E70B870ECC74E1E3C7A96658FD9A0C72C36EC7E96A6AAA21B6D2C5491CD5533A59A46C6C0D0E7BDDB9738EDB927A92BDEB0180E738EEA5E1D6ACEB13ACF94DAAF14E2A20791B387521CC70F2735C1CD70F22D2B3EB21CAEA46719B553F1678F8F50B45D76FD66337FC435BFD1396F4B45D76FD66337FC435BFD1391996D3FD443C57C4A81D00D2EA6D68D5DB0699D65E25B5C37A7548755C50895D17754D2CC3669201DCC6078F9A99DFA55F8CFDF8AE7FC911FF007AA0869FDF736C672FB7DF34EAA6BA9F22A6321A2928A3EF2669746E6BF95BB1DFD073F7E9E1BAED1F9FD71BFF00B26CE7F937FF00D4B1AC753AE6AF4753A9593B2B88D38E393C73CBE3C9F7126F15ECCBC7317C9ECF9345AB572A87DA2BE9EB9B13AD51B4486291AF0D27BCE9BF2EDBA9ACA0B7037A9BC46E65AB372B66ADDE324ABB3C7629E689972A4EEA215027803483C8DF4B95CFE9BF86EA74ABAC7439C6D04AF55C2A37B5554715C1AC638FB1150FC7C7D95B9A7E05B3FF0097D3ACBF05DC54D6687E52CC4B2CB848FC22F33013B5E4B85BA7774F94307934F40F03C475F10B11C7C7D95B9A7E05B3FF0097D3ADAB5C784D7D0689625AEFA7B4723E9E7B352CB90D046D27BA7160DEA99FB53F6E3C8F51D09DA9C73C0E851769574CB6B4BCE552114BC77563C1F677964F9DD5D2D7E99E455D45511D453D458AAE58658DC1CC918EA7716B9A4742082082AA27848FB25B4F7F1D47FEEB976AE13B8B4FA8982DEF433512B4FD4FA8B4574760B84AFE94F2185FB533F7FB471DF94F913B781DC715E123EC95D3DFC751FF00BAE52DE7079BA56995B49B7BDA15796EF07DAB12E3F52E751115CE641713E2D78816F0FDA612DEEDB1C53E437693E43688A41BB1B291BBA670F36B1BD76F37728F0DD76C55D3DA993D71CBF05A67B76A46DBAADF19DFE748646077D0397E950F823D9D9FB2A77FA8D3A357F0F16FBF0B3823A69C69A6ADF163A95551D2D7C971B954115374BBDC24718A9A32760E7B8027D8D601E5B0D80DC4B98BB2C31516AEEE7D5DBA9B972FEACCB5C6200EDBFCD97F36DBFEDD6C9D98343698F44F21B8D34717D509F25962AA9034093BB6534063693E25A39DE4796EE77B54C450923DFD7B68EF6DAF256D6B2DC8438704B8F9AF25D8532EB3E84EA970B59A50C970AF31EF299ECF7DB648F63642D3E2D3D1D1C8371BB7CB7E848EA6C27827E25EA75EB07A9B4656E8C6598E16C758F6F415B03BF53A803C9DBEED701B8DC03D39B61E6ED13B7586AF868B9D65D9EC656D0DCA865B5EFE2EA874C18F68FF00E0BA63B7ED7D8A29F66954DCE2D7CADA7A5E7F924F61A8F956C3A747C659BFC7751C99F657A8B6834295DDC452A94F3C7C30FDE9F2ED2C9B50B229F11C0F23CAA9226C93DA2D5555D131C376B9F1C4E734103CB7037F62A6AC06C776E2175AEDB66CC332F9357657703F2DBB569E720905C7604805C437958DDC0DCB4740AEAAEF6AA1BEDA6B6C97487BEA3B853C94B511EE473C5234B5CDDC751B8242AB2D6CE01B58F4E6F3535F805A6A32EC743CC94F3D0906B206F886C90EFCC5C3EE98083B79782991F0EC85DDB5055A94E6A1525F864F1DFDBC383E38EA76FC9BB2D7177DAA4386EA95D21B93584B05CE92396091DE40F77CAE603EBF4B6F5159AE0A383FCF346B32BDE6FA8F58DA4A8803ADD6FA3A1AC2F8AAD8762EA893976059E018D70DF7E6240D86F1031BE2378A2D159D96C6E639251C54E7905BEF713AA22681F68D6D402583D8C214CAE15B8F21AB9935269C6A3D9696D97DAE696D0D7521220AA900DFBB730EE58E201236241DB6E8A160FBB54A1AED1B3A919545569B5C5AE6975FDF992C728B20C9719BBE38EA934E2EB435144660CE6EEFBD8DCCE6E5DC6FB736FB6E141CFD2A9A2FBF8CFF00F9707FF72A7B22B35934DB1D5EF34D528DACF753E7C13F8A6511E738BB70ECE2F78736B4D58B3DC67A015063E432F7721673F2EE76DF6DF6DCFBD4E1A6ECAFA2A8A78A7FCFBE76F78C6BF6FCCE83B6E37FFDE543CD6EFD7B735FDF156FF4EE576D6EFF00ABE97FEE59FEE85549337CDA5D5EF6C28DBCEDE7BAE49E78279E11ED4FB59A76896983346B4C6CBA6F1DE9D766D9D9230563A9FB832F3C8E7EFC9CCEDB6E6DBE71F0509BB53BFC69C07F17D6FF00491AB1255DBDA9DFE34E03F8BEB7FA48D4CB91ACECBD59D7D66156A3CB7BCDF8B4CD4B868E062CBAFBA5F06A1576A1D6D9E59AB6A290D2C56F64CD0232073731783D77F52EABFA55F8CFDF8AE7FC911FF7AA26E99EAA71338962ECB3E96DEB27A6B13679246476FA3EF21EF5C7D33CDC87AEFB6FD56D7F9FD71BFF00B26CE7F937FF00D4A381B85DDB6B32AF3746EA318E5E13C652ECFC258470CDC345BB86CB45EAD36ECB2A6FADBCD4C752E7CD48D80C65ADE5D800E76EBA36A3E7962D30C1AF59F6492B996FB2D2BEA650DEAF908E8C8DA0F8B9CE2D68F6B82D4F865BD661916856257ACFAA2B27BFD552CAEAE92B23E499CF13C80733761B1E50DF2F0D9729ED219EAE1E1C5CCA77111CD7CA264DB123766D21D8FAC6E07D015B923408D2A9A86ACA8DD4B7A4E7BADAEB878E1E5C08079DEA0EADF161AA34F04A2AAE55F71A830DA6D10C87B8A4613F3580ECD68007A4F3B6FB6E7C14A8C33B2DE964B2453EA06A75443759581D253DAA91AE86077DCF7921DE4DBD7CADFF008AE73D997456AA9D74BB54D74713AA6931F9A4A22F0399B219A26B8B7DBC8E7FC37567EAA9678B368DA3D6AE34BAD1B0B1FB918A5C92EBE3D0A98E24F824CE340E81D975AAECCC9716639AD96B6380C33D239C761DEC7BB872EE400F6B88DFC437A2EDBC00F155915EAF516886A1DD5F5E2481CEB157543CBA60E60DCD3B9C7AB872825A4F51CA4751B6D367512DF66BB60391DB7226C6EB5D4DAAAA2ACEF0ECDEE4C4EE624F974DFAAA6CE1CEA2BA93880D3A96D4E7F7DF9A9B6C60B7C4C6EA9635E0FB0B0B81F6128F83E066B0BA7B49A5D6A57A939D35952C77369F8F0E38E68BB454E7C5DEA0643A93C446574979AF2DA5B1DE2A2C56F85EF221A686098C5CC079731697B8FACFB95C62801C5EF02B9AE499A5D754F47E961BA0BCCCEACB8D9FBE6C73B6777592488BC86BC38EEE2DDC1DC9D81F01324787B23776B69792770D45B584DF24F3DBD3264EC5D98981DDB12A1AF3AB17792E3594B1CDF29A7A585F485CE683BB59F39CDEBD3D3EAB5CD25ECF6D48C375D6D95B92DF61762D6793EA84777B654BA196A5CC70E4879370F89C4FCEEA472EFB38A8E36ACBB89EE1E2A7E494771CCF12642E24D254C728A5DF7F130CA0C47DFCAA44E89769465105E68EC9AD76DA3ACB6D448D8A4BBD143DD4D4E09DBBC7C6DF45ED1E279403B7803E0A160D92EA86BD4A954950AD1AD0927D167D9D3DEFC0B1455E7DA9BFF5F609FB8EAFFDF6AB09A7A882AE08EAA9A664B0CCC1247230EED7B48DC107CC10ABDBB537FEBEC13F71D5FF00BED56972354D93E1AB53FF00BBE0CE9DD983FAC1DFFF007E155FD4A8948FD63FD68B38FDEDDCFF00AAC8A387660FEB077FFDF8557F52A2523F58FF005A2CE3F7B773FEAB222E462D63FDEAA7F5AF9146D14B243232686473248DC1CD734EC5A478107C8AB45E0778B06EADD8D9A6D9D573465F6987FC1E779D8DCE99A3E77FDEB47CE1E63D2F5A817C2FE1F61CFF005DF15C3327A26D5DAEEF2D4D354C47A6ED34B2EC41F2208041F2201595D6DD1FCFF850D5AA77505754C51D35436E18F5EA0DDA25635DB8EBE4F69F45CD3F95A46F45C389D135AB6B4D5A5F675478ABBBBD17E6BE5C57671E84C5ED45FD68B14FDF20FEAB32C5F659FF0088F9C7E35A6FE84AE4BC4DF12564E217868C4AAE4922A6CA2D591322BC5003B10EF92CDB4EC1E71BFAEDEA2083E5BF5AECB3FF0011F38FC6B4DFD0956E6CD72BDB55B3D9A9D0ACB1252E3FDC8921C46E87C7C4169C9D3F97257589A6BA0ADF95B693E527EB61DE8F273B3C79BC77F250F33DECD0A3C2705C8F336EB24D586C369ACB98A736011F7C6085D272737CA0F2EFCBB6FB1DB7F02AC5168DAEFF00AC7EA1FEF52EFF00D4E552D266B5A56B37D64E36F42788392E184F9B59E6B253C687E993358B542C9A7325E5D696DE257C66B053F7E62E5639DBF273377F0DBC429A76BECB7A2B65CE92E435B6690D24F1CFC9F99E039B95C0EDBFCA7A6FB28C9C137D93784FEEA97FA17AB88558A4CDB36AF59BDD3EEA34ADA7BB171CBE09F57DA99F8822EE208E0E6E6EED81BBEDE3B0D9537F191F64C67BF8CBFF00A6C5726A9B38C8FB2633DFC65FFD362991E6EC3FFADA9FD3F34490C2BB33B1DCB30DB0E532EACDCA99F79B652DC1D0B6D51B8466689AF2D07BC1BEDCDB6FEC599FD2AFC67EFC573FE488FF00BD51AEC9ADDC655BECD414162C8F3465B69A962868DB0DBF9A36C0D6011869EEFA8E50363EA59CC7F5D78D59EFD6D82B725CDCD3C9570B250EB76CD2C2F01DBFD6FC36DD4703DCAB6DAEA949C6EE18E3D9FF00F259969069CD3E9269B58B4E696E925CA2B1D3BA06D549108DD282F73F72D0481F3B6F1F2515BB4EB51EFF008EE1D8A69FD9EAA4A6A4C9A6AB9EE2E638B4CB1D3F741911DBC5A5D31247ED5AA6BC45C6261778968DFDEB86716DC35C7C4761345416EB843419058A592A2D751383DD3BBC681244FDB721AEE461DC024168E9E2ACF970347D1EEE953D4E17378F2B2DB7DEF3C7CF8909F846E0DB15E21B14B9E5992E77596F1475868E3A1B732333376683DE48E7EFB03BEC006F91EBE4B69D57ECCCCDEC2195FA4F94439253B9ED6C9455ED6D2D4C409DB99AEDF92403C4FCD3EA0570BBDE897137A0D787DC463394D8A7A72436E76695EE8DC01F1135392363E3B120FAC2DE700ED02E21F06AA8A9326BA419451C0E0D929EE94CD64E00F11DEB035FBFB5DCC5538753A15C4755AB59DD69B7119C1F28BC63C32BE394591686697B74774BEC9801BB54DCA5B7C3F5FA89E573F795DD5E19CDF36307A35A3A00161F8AAFB1CF507F124FFF0005EDD02D73C5F880C0A1CD71B8E4A692394D2DC286520C94950D0096123E7021C1C1C3C41F22081E2E2ABEC73D41FC493FFC15FA1CE29AACB538AB8589EFACF8EF15CFD9F5F652635FB92E3FD52556DAAA4BB3EBECA4C6BF725C7FAA4AADB544791EE6DB7FB8C7FA17C6454071B5A8F9167BAFD91D05D6B253418E54BAD96EA52F3DDC31B36E6706F80738F527C4F4F50522B0AECCFC1324C12D57CAAD57B9CB71B951455467A0821928DAE7B43B6603E93DA37DB7E61BEDE03C17DB8C3E0672ECDB2FB86AB691B60AFA9B99135CACD248D8A574C06CE9617B886BB7D812D241DF7DB7DF65142DD7CE27B878AB3051D566B88089C4BA9A564ADA52479989E0C4EF79054727C4D92DEB3D434FA34B4AB854E514B2B873C75EBCFAE1E490B8376726A3E39AD56917AC969E4C42826F979BD5B6674152EEECEEC88464F345239DB7505C037721C4EC158C46C11B1B1B4921A0346E773D3D64F8AAE0D1BED2ACDEDB74A4B56B1DAA96F16C9646C72DCA8A21054C2D3D0BCB07A0FDBC4801AAC62DB71A1BBDBE9AEB6CA9654525644C9E0958776BE370DDAE1EF054AC74351DA55A9AA90FB471C16135C9F6BF1F2F03D0888AC6B211110044440111100444401111004444011110044440111100444401111005CD35DB196DDF1665EA08B7A9B53F9C91E26177478FA794FC0FAD74B5F1AEA382E1473D055339E1A88DD1BC7ADA46C502E04304592C8ECB518EDF6BAC9543D3A499D1EFB6DCCDFB577C46C7E2B1AA8650888802933A3B87B718C5D9555316D5F73DA79B71D58CFB467C075F792B8C694E2072DCAA08EA184D0D111515276E8E00FA2CF89E9EEDD4A3003406B40000D801E4AC8AC9F40888A4A0444401476ED00FB1632AFDD16DFEBB0A912B49D66D27B1EB6E9EDC74E322B85751505C9F03E49E88B04CD314AD91BB17B5CDEA5801DC786EA1F147DBA75785B5E52AD53F0C649BF04CAC2E0AF5DB07D03CF2F391E76DB89A4AFB67C922F90D3899FDE778D77505CDD86C0A993FA64FC39FF9ACAFF92D9FDEAC07E95E68CFECF334FF004B49FDC27E95E68CFECF334FF4B49FDC2AACA371D42F367B52AEEE2BCA7BCF1C93E9EC3A3E99F1C5A27AB19C5AF4FB158F21175BBBA46539AAA06C716EC89F23B99C243B7A2C77978ECBB9DFEF7438D58EE1915D0CA28ED94B2D65418A2748F11C6D2E772B5A0971D81E806E5474D25E01F4C747B50ECFA8F60CBB28ACAFB33E57C3056494E61799227C47983226BBC2427A11D4052688046C46E0AB2CF5355D4D69F1AF1F506DC31C73CF397DDD982BEECDDA7B5B0EA05CFF0034183326C3A69F9680539E4AEA68C74E67EE795E5DF388E9B6FB025759BEF1DFC26E4F8E4ADC8595973649110EB6D6597BC7BB71F37D2DD9FEB2DCB54F825D03D55AB9AEB5F8E4D64B9CE4BA4ACB34A29DCF71F173985AE8C9F696AE367B2D300F95F38D53C8052EFF00A99A387BCDBF0FC3FD551C4F7E357672E5467253A5258E0B3D3BF8F9F020BD86D873CD62A5B760363969E3BCE41BDAA818799D4F0BE7E68E3DCFDC336049FB924ABC3858E8E1646E79796B434B8F8B881E2B9068970A7A41A0F29B8E21689EAEF0E618DD75B8C826A90D23621A400D6023A1E568DC15D854A583E0DA3D6696AD5211A09EE41349BE6F38FA152FDA17F64FDF7F705BFF00ABB1480E1BF822D09D4DD11C533BCA6DF7992EB77A5925A974371746C2E1348C1B340E9D1A1759D6AE06B4DF5C73FACD44C932AC9686BAB218617C343240220226060203E271DC81D7AAECBA59A7769D26D3FB369DD8EB6AEAE86CB0BA1866AB2D32BC39EE792E2D006FBB8F800A31C4FBEF36862B4BA16F675251A91C278CAE4B0F8F89A3E9FF00087C3CE9AD64573C734E68E5B84243995770964AC91AE1E6DEF5CE6B4FB5A02EC400000036011158D4EBDCD6BA96FD79B93EF6DFC48C3DA33F634D6FE38A0FF7DCA1FF00041C44E9F70FB77CAEB73E6DD0C779A6A58A9BE434C263CD1B9E5DCDBB9BB7CE0AC7F5C346B1FD78C125D3FC9AE770A0A296AA1AA3350B98250E8C9207A6D70DBAF5E8A3AFE95E68CFECF334FF004B49FDC2AB4F3946D9A3EA9A6D3D2E7617CDADE96782E9C3AFB0CFFE993F0E7FE6B2BFE4B67F7AB74D23E33B4775AB348303C3197E173A88659D86B285B147CB1B799DBB83CF5DBD8B967E95E68CFECF334FF4B49FDC2DF744B81ED38D0BCF69F5071ACAB24AEAEA6A79A9DB0D7490188B646F292792269DC0F0EA9C4F9AEA1B3CA84FD5E53DFC3C67967A742425CADF4976B7D55AABE212D35642FA79984FCE63DA5AE1F412A99B5E346F33E1BB5524B6CA278A9E0AA15F61BAC6D219344D7F346E6BBC9EC2007377DC11EA209BA15ADE7DA71846A7D89F8DE778E51DDE81E798473B3731BB6F9CC70EAC77B410A5AC9F1E83ADCB47AAF796F425CD7CD7F389137493B4AF00AEC7E968B572D771B65EA089B1CF57434E26A7A9701D5E1A087309F12362013D3A2F36AEF69861F45679E83472C55B71BB4AD2C8EBAE7088A9E0247CF0CDCB9E47880761D3AFA964B28ECC0D2AB9D6BEAB16CEB21B2452127E4F347155B19EC693C8EDBF09C4FB57B70CECCCD1BB156C75D9564D7FC8FBB20FC99C63A581FD7ED830179F83C28FBC7B3BFB2EA7EB1F79F5DDC3C7F3DB83A7709BC47BF88AC1E6BA5CB1F9ADB79B43994F707470BC51CD211BF342F3BF8EDB96124B771E236276CE247EC7DD48FDEADD3FAB48B71C6315C730BB25363989D9692D56CA46F2C34D4B10631BEDD87893E64F52BE19CE25439EE177DC22E9513D3D1DFEDD516D9E5808123239A32C739BCC08E601C76DC10A7A1ABCEBD077AAB518EED3DE4D2E78592AB3B3FF00EC9CC7BF72D6FF0042E56DEA3768CF02BA6BA259F516A163B95E4D5B5D431CB1B21AD929CC4E1234B4EE19134F81F5A91B53149353CB0C53BE07C8C735B2B002E612360E1B82371E3D46C91583D3DA5D4686A978AB5BBFBBBA97158EACABBED12D648F3DD5A8F4FACB5C27B561AD34F318DFCCC92BDFB19BC3A6ECE919F30E6BC792F561FD9B3AA79562D6AC965CC2C76C75D2923ABF925447299210F68706B8B46DBEC478291747D9BDA431E550E5975CCF2FBAD40AF170A88AAE7A72CAA7F79CEE6C85B10710E3BEFB107A9EAA59318D8DA18C686B5A36000D801EA518CF167A971B4B0B0B5A36BA53FC2BEF36B9F9F6BCB2B42E7D989AAD436EAAADA5CE31FAC9A9E17CB1D3471CA1F339AD2431A48D81246C37E9D5732E0B75967D18D71B78B8CBDDD932222CB7663F7DA30F78EEA5D81F9CC90377241F41D200373BAB7D515F3DECECD1ECEF36BC66EFC9326B44F79AC7D74B4B412D3B608E579DDE581D139C3776EEDB7E849DB61B0471EC2D65B511BCA556DB56798C970697D3CD7812A01046E0EE0AAA7ED1EFB24EA3F1250FF33D5A463D687582C36EB1BAE1535E6DF4B152FCAAA797BD9F91A1BCEFE500731DB73B0037F25C1F5C7824D3AD79CE9F9F64D94E47415AFA48690C34124022E58F7D8FA7138EFD7AF552D651E46CE6A16FA5DF3AD5DFDDC35C177A38970F1C76E8BE96E8BE2D8064949913EE566A57C350EA6A263E32E32BDE39497827A38792E8BFA657C3E7FEE1957F27C7FDE2C37E95E68CFECF334FF4B49FDC27E95E68CFECF334FF004B49FDC28E27AB5A7B355EACAACE53CC9B6F9F37C7B09558066D67D47C32D19CD81950DB75EA99B554E2A18192063BC39802763F15047B54BFEBFD3BFDC772FF007E053A74DF05B6E9960B65C06CF5753534563A46D24135496995ED6F817728037F700B9C710DC29E13C47D6D92B72DC82F96D7D8A29E2805B9F0B43C4A585DCDDE46EF0E41B6DB78952F8A3C6D1AF6DB4FD515C49BF469CB1DB869A4689D9BBF63837F1F577F346BB56B76AED8F43F4EEE3A817DA3AAAB8E93962829E9E32E74D3BF70C6923A31BB8EAE76C00F59D81F8E8668AE3DA09830C0B18BA5C6BE88564B5BDF57B9865E7903771E835A36F44792DEEBE8286EB4535B6E747055D254B0C73413C61F1C8C3E2D734F420FA8A2E47CD7D7542E3519DC61CA9B9671C9B59F710334A3B4EA37CD2D0EB1E23DDC6F99CE86BECCDDF9232776B5F13CF52D1D399A7AFA879EC1AF9C61F09FA81A6D79B4BAD5264D74ADA3922A28A5B598DF0CE5A431FDEBB62CE5241DDA4F82DFB50FB3CF40337AA9AE36AA5BA62D57312E3F52A76F725DFF0075235CD03D8DE55A1DB7B2DF4E61AD6CB76D4DC8AAE94104C3053410BC8F57390FFF0075471363857D9B9D45731DFA725C70B3F2CFC5119F802C6EF57BE27319B95B29E534B648AB6B6BE760F46188D2CB10DCFED9F2319B78FA44F802ADC168BA4BA25A71A25647D8F4FAC11D0B2620D4D43DC64A8A870F032487A9F3E9E037E802DE94A583C4DA0D563ABDDFA6A6B114B0B3CF9B797E6151269EFF008FD8D7E38A3FE998AF6D443B2F66868FD8EF3417AA6CE3317CD6FA98AAA36BE5A5E573A37870076877DB70A1AC9E86CCEAF6BA5C2BAB86D6FA58C2CF2DEFA92F111158D4CAD9ED2BD667E459A5AF47ACF5DBDBB1C6FCB6E4C8DE0B65AE91BB31AE03CE38C9DBC0EF33F7F25ABE98F678EA7EA4E0565CF1B9459ECF15F298564149571CA656C2E27BB79E5046CF672BC7B1C3CD49FBF7674696E5797D6E699367B98DC6BAE55CEAFAC6CB353064CE73F99CC3B42086FDAEC08D8741B6CA55D2D341454D151D2C4D8A1818D8A38D8366B1AD1B000790002AE32F89BAD4DA3A7A75951B5D2DF15F89B5D7DBDAFE08ADB7765DEA8069235131B240E83BA9BAFE45C43875D48B970EFAF76FBA5F43E8E0A4AC92CF7D88EE792073F925DC0F1E4700EF3F99D3C95CBA8C7AADC00E92EABE7974CFEE390E476AACBBBDB2D453D0490087BC0D00B807C4E3BBB6DCF5F128E3D864D3F6ABD6635286ACF3092C705F4FE7024DB1EC918D9237B5EC780E6B9A77041F020A861C4DF1ED72D23D4F8303C0F1BA7B836C930FABAFB8C52462725BFA8C27A11B0703DE6C41206C1CDF195FA7B8743A7B84D9B08A6BBD7DD20B252328A0AAAE735D3BE267460716B5A0F2B7668E9E0D0B01AABA0BA55ACF4829F50313A6AF9A36F24558CDE2A9887A9B2B7676DECDF652F3D0D6B4DAD656D74DDDC1D4A7C570E1EDC7CB28E258B768C70F9925A9A32C8AED63A973369A9AA28BE51113E60399BF30F780A107173A91A4DA9FA9D1E41A438E8B65B9944D86AE514ADA7159521EE265EEC787A25ADDCEC4F2A9757DECBBD2FABA974B8F6A26496D89C77EEAA2286A437D8080C3B7BF73ED5B8E997678E86E017382F77992E9965653B83E365CDCC14CD70F03DCB1A03BDCE2E0AB86CDAACF50D074AA8EEAD65372C7E1E38FE7B59B170298BDEF16E1AF1A86FAC9A296E4E9EE50432821D1D3CAF263E87C039A03C7B1E177F5FC63191B1B1C6D0D6B400D006C00F52FEAB9A4DDDC3BBB89D792C3936FCC2D175DBF598CDFF10D6FF44E5BD2C465F8D51E658B5DB13B84F3434D77A3968A69212048C648D2D25BB8237D8F98285284D53AB19CB9269FBCA6DE18B51F1DD24D72C6350F2C1546D5687559A814B10925FAE524D13795A48DFD291BE7E1BA9FFF00A64FC39FF9ACAFF92D9FDEAC07E95E68CFECF334FF004B49FDC27E95E68CFECF334FF4B49FDC2A24D1BEEA7A86CFEAD5556B894F2963826B865BECEF36DB17687F0FD90DEEDF60B7C7947CAAE755151C1DE5B581BDE48F0C6EE7BCE8372149C511B1DECD6D21C6F20B6645479BE6124F6AAC86B626492D2F239F13C3C076D083B12D1BEC54B95659EA6A7AB2D354A3F673935C739F7150FC7C7D95B9A7E05B3FF97D3AB2FE1FE969AB740B0AA3AC8239E09EC14D1CB148D0E6BD863D8B483D0823C9733D62E03F4CF5A7516EBA9390E5993D157DD84025828A4A710B7BA8190B7943E273BAB6304EE7C495DEB08C4E8705C46D1875B6A279E96CD491D1C32CE4191EC60D817728037F700A12C33D3D6356B6BCD3ADADA8B7BD04B3C3B2297C4ABEE353854A9D12C99F99E214123F09BD543BBA0C05C2DB3BB73F2771F261EBC84F90DBC475E7DC23FD929A7BF8E63FF75CAE172FC4B1FCEF1AB862394DBA3AEB5DCE130544120DC39A7C08F5107620F9100A8E9A71D9F3A57A659ED9B502C997E55515964AB157041532D3989CE1BECD772C41DB75F220A6EF1E07AB65B574E7A74EDAF5BDFDD693C67395859EFED251A222B1A0851AB8E9E1F6E9AD7A6D05D713A515191E2EF92AA9E003D3AA80B7EBB0B4FDD740E68F3236F30A4AA23E27D5657752C2E23714BF145FF17B4A73E19F892CA3866CC6B647DB25ADB3DC0882EF6A9098DFCCC2767B77F9B237770EA3A8241F64E6A7ED1FE1D65B58AD99F914353CBB9A436E0E7F37A8383B94FBF75BDEB0F07DA23AD1532DD720C7E4B65E25EAFB9DA5EDA79DE7D6F1CA58F3ED734AE12FECB2C24D4F3C7AB17C6D3F37EA6EB7C25FB7AB9B980DFDBCAAB868DC6E350D035892B8BC52A753AE3AF9279F1C2646DE2BF8B3BC711D72A2B2DA2D935AB17B64A64A5A37BB9A6A99CF4EF65DBA6FB121AD1BEDB9F32A5D767E70E978D2CC4EBB51B33A27525F3288A36535248D2D9296881E61CE0F83DEED9DB6DB801BE6481BF691F04DA15A45590DE286C9517DBBD390E8EBAF2F6CEE8DC3ED98C0D6B1A7D47977F6AEF6897567C3AB6BB6F2B45A769B171A7D5BE6FAFC79B7C4D6F51B3CB3E9961576CEAFF1D4C94368A733C8CA688C923FC83401EB240DCF41E25421D3EED3FA976435F1EA660D1B6CD5150E7D149697133D243E4C91AF3B4A40EA5C397A93D36D80B009628A789F04F13248E46963D8F682D734F42083E21475D4AE02787ED44AA96E50D9AB319AE98973A6B2CCD8985DED89CD747F400A5E7A1E7E915F4BA719D3D469B79E525D3D9C3CF8F81A7EA2F1B9C23E5F86D7535EE82A3237CF4EF6476EA9B36EF2E23A0E67FA2DEBE61DD3C541AE16719BBE59C4460D4B618650692F94D7299CC0488A9E0904B21711E0395A5BB9FBA0A62D3765AE9F32B39EB354B2196977FD4A3A481926DEAE73CC3FD55243467875D2BD08A2960C0AC263ABA968654DC6A9FDED54CDF51791D06FD795A00F628C37CCF7A3ABE95A4DA54A3A7CA5394D75E4B863AA5DBD9C4E98888AC688520EB77EBDB9AFEF8AB7FA772BB6B77FD5F4BFF72CFF007428AD967671692E5F95DD72EAFCD72E86AAED5B2D74B1C32D308DAF91E5C4377849DB73E64A95D044D8218E06925B1B43013E3B01B284B06D5B47AB5B6A546DE16EDB704F3C31D23F43F6ABB7B53BFC69C07F17D6FF00491AB125C4B885E14308E23AE166B8E5B905F2DB2596196085B6E7C2D0F1238125DDE46EEBE88F0D91ACA3CED02F68E9F7F0B8AEF1159EFE69A22CF089C6568FE8968E53E0B9A32FC6E515C2AAA5DF23A26CB1F248E05BE9178EBD3D4BB4FE993F0E7FE6B2BFE4B67F7AB01FA579A33FB3CCD3FD2D27F709FA579A33FB3CCD3FD2D27F70A3EF1EFDCD5D9BBBAD2AF5253DE93CBF6FB0EF3A1FC4669EF1034D74AAC05B750CB43E38EA3E5D4C213BBC12397673B7F0594D74D2BA0D68D2CBF69E56CAD824B8D3F3525411BF7152C3CD13FDDCC003B75E52E1E6B5CE1EF866C3F872A5BC526257CBCDC5B799239263717C4E2C2C040E5EED8DF5F9EEBAFA9F1357B9A946DEF3D25837BB169C5BE7C31F3293EC976D4CE16758995AEA275BB21C72A5CC9A9EA1A7BAA888F4734F87346F6F811E4410A7D61FDA51A1F77B4C73659417BB15C43019A06D30A88F9BCC31ED2091EF01776D57D07D2DD6AA06D1EA062D4F5D2C4DE486B19F5AAA847A9B2B7D2DB7F23B8F628CD78ECB7D3BA8AC74B62D4DC86869DC771154D2C350E6FB398727F328C35C8DAEAEAFA36B708CB528B8544B195FB67DEB8769CCB8A6E3EE9F53314ACD39D28B757DBED7736F7571B955811CF343BFA50B18D2795AEF0712772371E04AF8F679F0ED7BC8B36A6D6BC8ED9353586C45E6D4F9985BF2CABD8B79D80FCE63013E97873741D41DA4369CF674E856155B15D32092EB965542EE66B2E323594DBFFDD4606FEE739C149FA1A0A2B5D1C36EB6D2434B4B4CC11C30C2C0C646C1E0D6B47401126F8B3E6BCD76CAD2CE561A4C5A52E727D73CFBF8F2E98E88FAC923628DD2BF7E5602E3B024EC3D83A950232CED30ACB2EADD5515970D8EBB08A42691CD99AE82BE57B5DE94ED24ECD1E418E1E1B6E4153E571FD5AE13B44759AA25B96578A369EEB37575CADCFF0093D439DF74E2072BCFE102A5E7A1E26915F4FA1525F6853728B5858E9DF8E1F1E073A8BB40785EC96CAE190CB718C3D9F5CA0ADB499B73E606DCCD3F121571EABDD718CF7562F372D2FC665A0B4DDEBC0B5DB628767FA5B00D6C6DDF62E7750D1EBD94E6ADECB5D3C92ACBEDDAA191414DBFEA5352412BF6F5738E51FEAAEC1A2FC1568B68ADCE1C8AD7435B7BBE53F58AE17591B23A177AE3635AD630FB7627DAA1A6F99B45A6ABA2E8AA756CA5394A4BF0BE5F05E7C4EA5A538FDCB13D30C4716BCBC3ABED162A1A1AA21DB8EF62818C7EC7CC6ED2A0E76A6FFD7D827EE3ABFF007DAAC31715E213854C2788DACB456E5B905F2DCFB34524508B73E168787904F37791BBD5E5B296B81ADE89A853B3D4A37770F0B8E70BB53395F660FEB077FF00DF8557F52A2523F58FF5A2CE3F7B773FEAB22C1E80E83633C3C61D598562976BA5C692B6E725D1F2DC1D1BA4123E28A32D1DDB5A397685A7C37DC9EAB78C9EC34B9563576C5EB66962A7BC50CF413491101EC64B1B98E2DDC11B80E3B6E08DD172316A3774AE7529DCD3FC2E59F6150BC15FD94380FEED9FFAACCAD2B5DB44F15D78C06B70BC962EEE5734CB6FAE63477B475207A3237D63C9CDF36923A1D88E49A57C01697E92EA059B512C797E53575D6595F3430D5C94E6179746E610E0D881DB679F02149E50970E27A7B43ACD3BDBEA7756527F752E3CB8A6D945DA9BA6F94692E6B72C132EA2753D7DBE4E5DF63C93467E64AC27C5AE1D4153C3B2CFFC47CE3F1AD37F425483D7FE1834E3889A4A06E5DF2DA0AFB6B88A7B8DBCC6CA8119F18897B5C1CCDFAEC4743D46DB95F5E1EF870C4B872B4DDACF89DEEEF718AF150CA999D71744E731CD6F280DEED8D1B6DEBDD12C33D0D4F69686A7A4BA13E155E32B1C3835C727595A36BBFEB1FA87FBD4BBFF0053956F2B1397E354799E257BC3EE13CD0D2DF6DD536D9E4848123239A2746E7377047300E246E08DFC958D2E84D53AB19CB9269FBCA8DE09BEC9BC27F754BFD0BD5C428C7A53C02E98691E7D6AD42B165D9455D75A2474914357253989E4B4B7D2E589A7C0F910A4E288AC1EFED3EA76FAA5D46ADB36D28E38AC71CB0A9B38C8FB2633DFC65FFD362B93517F543B3FB4BB5573CBC6A0DEF30CA696BAF53FCA2686964A71131DCA06CDE6889DBA7992A24B24ECBEA76FA5DCCEADCB6938E382CF546ADA7BDA17A018CE038D637728F27F965A6CF474351DDDB58E6779142C63B94F79D46ED3B159FF00D327E1CFFCD657FC96CFEF5603F4AF3467F6799A7FA5A4FEE13F4AF3467F6799A7FA5A4FEE13EF1F74D6CCCE4E4E53CBFE7612874CB5171ED59C1AD7A858A0AA16ABBB657538AA88472ED1CAF89DCCD04EDE931DE7E1B2E11C63717B53C3FB28316C3AD6CACCA2E0D655192B69DE6920A60EEBD416F3B9DB11B34F41B9241D9770D23D33B3E8EE9E5A34DEC15D595941666CCD867AC2D333C4933E53CC58D6B7C6423A01D005EACFB4D705D50B31B06798CD15E28FA9636A23DDD113E2E63BE730FB410A78E0D7EDEAD950BE73A9073A29BC2EB8E99EDF0E0460D3AED2BD26BF5BA38B51ACD72C76E3CA04A6087E554AE3E65A47A607B0B4A8EFC6DEB8E81EAEB2CEDD2BB0875DE9677C95977140297BC88B7611F939FD7AEE474F8A911957663E8E5DAA5F538C65991D843C92202F8EAA267B1BCE03FE9795F6C2BB33F46B1FAF8ABF2AC8EFD92F74E0E14D2165353BF6FBA0C05E47B39C050D366D36B79B3D63595E5094D497E5E3FCF7985ECBCC56F96CC0330CAABE1962B75EEE34D0D0F38204869D927792377F16932B5BB8F3611E4A41F155F639EA0FE249FF00E0BA3D8EC567C66D14B61B05B69E82DD4318869E9A0606471B0780002C5EA26116ED48C1EF5825DEAAA69A8EF948FA39A6A62D12B1AEF12DE6046FEF054E30B06B573A92BCD4FD7A6B09C93F62C7C91569D9F5F652635FB92E3FD52556DA486824F80EAA3768BF02DA6DA21A8341A8D8E65792D757DBE39E28E1AD929CC2E12C6E8DDB8644D7740E2475F1524522B07D7B4DA8D0D52F156B7798A8A5C5638E5FD481BA93DA4572C5358AA2CB8E61F0D76216973E8AAD952D7C359533076CE9584FCC0DDB66B5CDEBB927C46DD3287B41F864C92CC7F3432DCE90BD9F5DA1ADB599813EA1CBCCD77C765D3756B85AD15D6791F5B986251B2E6F1B1B950BBE4F527D45CE6F47FF0008151FEE3D96DA752D5992D5A9D91D353176FDD4F4D04CF03D5CE0307FAAA389F6D1ABB3B734A0AB4654E515C5AE39F6F1F82211EBC64D8267FABB79BF69462EEB3D8AE1344DA3A26C4185F27235AF788DBB8673BC17728F5AB7FD11B05D315D20C3B1DBD35CDAFB7D9A960A86BBC5AF118DC1F68F05CC747381CD12D1EBA53E454F475D90DEA99C1F0D65DDEC9042F1F6D1C6D6B58D23C89048F5A9088960C3B43AD50BFA74AD6D53DC8757CDF0C7F33CC2222B1AB0444401111004444011110044440111100444401111004444011110044440111101A5E5DA518E66374177AF96A619FBB11BBB97001C07813B8F15856F0FD878F9D597077FF107FC974E44C139673A8741F048CEF2475B2FBE723F9964A9747F4F69B63F505B291FE7657BBFE2B7344196782D361B2D8A374566B5D351B5FB17F73186F36DE1B9F35EF44420222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200B1B7BC971EC6A28E7C86F9436D8E6716C6EABA86C41E478805C46E5649420ED4BFF0011307FC6D53FD0B543783D0D2EC96A3790B66F0A5D7D8D92DBF3D4D34FD9FE3FFCA317F693F3D4D34FD9FE3FFCA317F6951722AEF1BC7F81297FCCFC97D4BD48F5434DE6788E3CF31F738F801718BFB4B3D4372B75CE2EFEDB5F4D5717DDC12B646FD209541AB62C4751B3CC06E315DB0CCBAEB67AA8482D7D2D53983DC5BBECE1EB04107CD378C5576116EFF955B8F7AFA32F61144BE0DF8D076B54E34EB5123869B2E861325355C4D0C86E6C68F4BD11D19281D481E891BEDB6DB2968AC9E4D22FAC2BE9D59D0B85892F26BB577183BB67585D82B0DBAF7965A682A9AD0E30D4D6471BC03E0795C77EABFB67CE30DC82AFE4162CAAD370A9E52FEE69AB2391FCA3C4ECD3BECAAEFB457EC98B8FE29A0FE8D705D3FCF725D31CC2D99C6235DF25B9DAA76CD1388DD8F00FA51BC7DB31C37047983E4A1CB0CDBAD763A377670B8855FBD28A6963865AE59C97B28B9DE83EB4639AEFA77439C585CD8E57FD62E147CDBBA92A9A073C67CF6EBB83E6082BA22B1A4D6A33B7A8E95558927868F15E2F966C7E93EA85F6EB496FA6E70CEFAA666C6CE63E03771037E8560FF3D4D34FD9FE3FFCA317F6947FED25FB1C9BFBE0A2FF00725555CAAE5836CD0F6621ABDAFAC4AA38F16B18CF2F697ED4B554D5D4B0D6D1CF1CF4F511B658A58DC1CC918E1BB5CD23A10410415F45A2681FEB17A73FBD2B47F53896F6AC6A75A1E8AA4A1D8DAF20B1F7BC8EC18D521AEC86F5436DA768DCCB5750D89BF4B88512B8B1E3BA8F4BABAB34EB4A3E4D71C9E9F78ABAE1237BCA6B74847CC68F09651BF51D5AD3D0EE4168AE9CC73FCD7506EB2DEF35C9EE379AD99DCCE92AA72FDBD8D6FCD68F500000AAE58369D2764AE75082AD5DEE41F2E196FD9D17F305C3D67153C39D0CEEA7A9D63C6048D3B10CAC0FD8FBDBB8598C6F5E745F2F99B4F8DEA86375F33BA08E2B847CFF004120AA4146B9CD707349041DC11E20A8DE3DF96C2DB38FDDAB2CF82FE7BCBF96BDAF687B1C1CD70DC1077042FEAA78D09E30756F446BE0A786F33DF71CE61DFD9EE129919CBE66279DDD13BDDD0F982AD6F4AB522CDAB7815A7502C3495B4B47758BBC6C3570BA3918E04870EA3670DC1D9C3707C9593C9A86B3A05CE8ED4A7F7A0F935F06BA336C4445278411736E22F5032BD2DD1EC833EC32DF455972B3C4C9847581C621197B5AF710D209D81DF6DC2AACD43E2D3880D4D32C590EA2DC29E8A4DC7C86DA451D3869FB52D8F62F1F865C54378360D1F676E3588BA94E4A314F0F3CFCBFF05B9DF75574D319AA14390E7B61B7D411BF75515F131FF413BAF4631A8782E6B34F4F88E5D69BC4B4CD0F9994554C98C6D276048693B0DD514CD3CD5123A6A899F2C8E3BB9EF71713EF254DFECB3FF1D339FC574DFD2950A5967B1AA6C952D3ACA773E95B71C74C2E691630B5CABD49D3EA0AA9A86BB37B1D3D453C8E8A58A4AF89AF8DED3B16B813B8208D885B1AA48E22BF5FFD4AFDF6DDBFADC8A5BC1E3681A2C75AAB3A729EEEEACF2C971DF9EA69A7ECFF001FFE518BFB49F9EA69A7ECFF001FFE518BFB4A8B915778DA7FC094BFE67E4BEA5E8FE7A9A69FB3FC7FF9462FED2C9D932DC5F257CB1E3D915BAE4E800748DA4A964A580F813CA4ECA86D4ECECB207F3459D9DBA7C8A93FA472952CB3CED5764A9E9B673BA555B71C70C77A5DA5872F9D4D5535142EA9ACA88A0858377492BC35AD1ED27A0511F8E9E25758341AE18FDAB4FE3B55250DFE8E678B94F4E279E3A889E03DAD6B8F2001AF8C82E6BB7DCFA957966FAC7AA7A8F50EA9CE33DBD5DCB893DDCF54E11377F26C6DD98D1EC000472C1F1E93B2971A9D18DC39A8C1F2EAFB3972F797233EB968DD34CFA79F543196491B8B5ED3738B704788F9CB6CB35EAD3915B20BD58AE54F5F4154D2E86A69E412472004825AE1D0F5047C1508AB8FE0BBEC5FC07F704DFD66544F25B5FD9CA7A35BC6B426E4DBC715DCDFC8ED68E735AD2E7380006E493D005E5BADD6DD63B655DE6EF5915250D0C2FA8A99E53B3228D8097389F500095555C4FF001AD9BEB1DDAAB1DC2AE75961C2E27B991410B8C53D7B474EF2770EBB1F111EFB0E9BEE7AA96F0795A3E8B71AC5570A5C22B9B7C97D5F71641936BFE89E1D52EA3C9B5471BA0A86F431495EC2F1FC16925782D5C4E70FB7BA96D1DB357F1896679D9AC35CD6171F6736DBAA5425CF717389739C7724F524A39AE69D9CD20FA8855DE3745B0B6DBB875659F05F0FDCBF3A3ADA3B85332B282AA1A98241BB2585E1EC70F5823A15F654CBA03C4F6A3E81DFA1A8B35D27AFB0C8F02BACB5129741333CCB01DFBB78F27376F51DC7456E5A65A8F8CEACE116BCF711AA335BAE9173B43C6D244F0767C6F1E4E6B8107CBA6E37041564F26A3ADE815F4692727BD07C9FC9F6336842400492001D492BC37EBED9F18B2D6E45905C20A1B6DBA07D4D554CCEE56451B46E5C4AAB2E2738DCCE3582E5558DE0F71AAB061B1B9CC647038C7515E3C39E678EA1A7CA31B0EBD773B6C6F061D2345B8D62A38D2E115CE4F92FABEE2C8F23D73D1CC46775364BA9D8D5BA66F47473DC620E07D5B6FBAF358F884D0EC96A5B4762D57C5EB2771D8471DC63E627DC4AA477BDD238BDEE2E738EE493B9257F3C3A855DE3735B0B6FBB8759E7C163CBF72FE229629E36CD0C8D92378E66B9A770E1EB0478AFD2A83E1B38BCCFB42EFB4D4571B9565EB0F9A40DACB5CD273989A4F59202EF98F1E3B021AEF03E445B6D82FB6AC9EC9419158EAD9556FB953C7554D337C1F1BDA1CD3ECE87C3C9593C9A76B3A1D7D1AA2551E62F935F3EC67BD7CEA2A69E8E07D4D5CF1C30C6399F248E0D6B47AC93D02D735375131CD28C1AED9F65551DD5BAD30F78F03E7CAF243591B079B9CE21A3DEAA3F5EF8A5D4ED78BDCD2DE2ED35BAC2C79F91D9A9242C82267917EDD64791E2E77C001D11BC19345D02BEB326E2F760B9BF925D5969979E25B4071FAA7515DF5731982761E57462B98F734FB4377D97A31EE21F4372BA96D163DAAB8D56543CECD89B5EC6BC9FC1710552406B9C766824FA82FEFA4C779B5C0FB882ABBC6DCF616DB770AACB3E0BE1FB97F0C7B24607C6E0E6B86E083B823D6BFAAA7785AE33F32D17BBD2E3797D7D55EF0BA890325826797CD4009FD52171EBB0F12CF03E5B1F1B59B5DCE82F56DA5BBDAAAA3A9A3AD8593C1346776C91B86ED703ED05593C9A5EB1A2D7D1EAA855E317C9AEBF47DC7A57E279E0A585F51533470C518E67BE4706B5A3D649E816A9AABAA38A68F61370CEB30ACEE68A85BE8C6DFD52A253D1913079B9C7E8EA7C02A9AD7DE2AF5375E2F333AE3749ED58F31E7E4765A498B618DBE464236EF5FEB2EF80011BC19B45D02E35893945EEC17393F82ED65A7DE7889D0AC7EA1D4979D5AC5E96669D8C6FB9465C0FB815EFC675B348B32985362DA958E5CE677411D3DC237389F56DBEEA8E97EA39248646CB0C8E63DA776B9A7620FAC155DE36C7B0B6FBB8559E7C163CBF72FE115657075C69E5386E456DD35D4EBC4B75C62E32B29696B2A9E5F3DB6471D99E99EAE889D81077E5F1040DC2B350410083B82AC9E4D2756D26BE915BD156E29F26B935FCE6822F85757515AE8A7B95C6AE2A5A4A58DD34F3CCF0C6471B46EE739C7A00002492AB078A4E3AB2ED4AB85661BA5D729EC78946F744FAA8098EAAE43C3773BC5919F268D89FB6DFC01BC16D2747B8D62AEE51E09736F92FDFB8B0ECAF5C747F079CD365BA958F5B276F8C53D73049FC5077FC8B1765E25B40721AA6D0DA3573199EA1E766C7F2E6B1CE3EC0EDB754A52CB2CD23A59A4748F79DDCE71DC93ED257E55778DD63B0B6FBB8955967C163CBF72FDA9EA29EAE1654D2CF1CD1483999246E0E6B87AC11D0AFA2A69D06E29F54341EF10C968BB4F73B0B9E3E5765AB94BA091BE659BEFDD3FD4E6FC411D15B2E926AAE2BACD835BF3BC46A4BE92B1BB490BC8EF29A61D1F13C79381FA46C7CD593C9A96B5B3F71A3B5293DE83E525F06BA3371445A16B6EB262DA1980D6E7394485ED8BEB5474919FAE55D41079226FABC3727C0004FB149E2D2A53AF5152A6B327C12377ACADA2B7533EB2E1570D34118DDF2CD20631A3DA4F40B9BDD789DE1F2CB52EA3B96AFE3114CD3B3982B9AF2D3EDE5DF6554BADBC47EA7EBADF66B86557DA886D9CE7E4968A790B292999E4030747BB6F17BB727DDB01CB551C8DFECF61938295DD4C3EC8F4F6BFA17798D6BEE8A6613B6971AD51C6EBE771D8451D7C61E7F82482B7D6B9AF68735C08237041E842A076B9CC70735C41077041EA0A989C05EB6EBB54EA5DB74CADB5F35FF00179B796BE0B848E905BA9DBF3A58A43BB987C8337E5713E03C54A964F9B54D8D5694255EDEAE54565A970F7FEC59AA222B1A284444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111004444011110044440111100444401111005083B52FF00C44C1FF1B54FF42D537D420ED4BFF11307FC6D53FD0B544B91EEECCFFBAD1F17F065722B878B829E199D131C74BA8772D04FD7A5F57E12A7857EF07EA11FE00FE65589B6EDB5D57B6F41E866E39DECE1B5FA7B0E175BC0EF0C75B4CFA6769A411078DB9E1AB9E378F68707EE1405E31785B8F876C9A82B71BAEAAAEC5AFDCFF237548065A595BB7342F70003FA1E66BB6076DC11D3736E0E7358D2F7B835AD1B924EC0055C3DA45ADF8866D70C7F4CF12B9D35D1D629E5ADB8D4D3BC3E38A673791B1070E8E3B73176DE1D3DBB4C92C1E46CB6A3A856BF8D37394A0F3BD96DA4B1CF8F2E2445D3BCCABB4F33AB0E6F6E749DFD96BE1AC0D63B94C8D63817B37F20E6F334FB0ABD90438070F02370A85F18C7EE1966476BC5ED2C0EADBBD643434E0F877923C31BBFB373D7D8AF9DAD0C6868F00365113ECDBB50DFA0D7E2C4B3E1C31F32A87B457EC98B8FE29A0FE8D464526FB457EC98B8FE29A0FE8D72DE1FB493F3EFCFCE9F45716D0D5D65BAAE6A39DE098DB511B39A3E7DBAF213D0EC0900EE01DB650F99B6E955A16FA4D2AB51E22A09BF0C19CE16F886BC70F9A870DE04D3CD8EDC8B69EF542D3B8962F291A3EED9B920FAB71E055C363F7FB3E5364A1C8F1FB8435D6DB940CA9A5A985DBB258DC37047FF00DE8A8A329C62FB85E435F8AE4D6F9286E76C9DD4F53049E2C7B4EC7A8E8479823A11D54BAE0138A56E0B798B4673BAF7B6C176948B3D548EDDB4356E76FDDBB7F9B1C849EA3C1FB74D9C4898BC703C2DAAD115F52F5FB6599A5C71F9A3DBE2BDEBD8483ED25FB1C9BFBE0A2FF725555CAD47B497AF0E4DFDF0517FB92AAAE512E67D5B17FED9FF0073F9177FA07FAC5E9CFEF4AD1FD4E25A1F197AE72E86E8F55D7D9A56B721BF3CDB2D24FF0092739BF5C9FF0080CDC8FDB166E08DD6F9A07FAC5E9CFEF4AD1FD4E2503FB4F72AAAAED53C730F3CEDA7B5D9FE560739E573E691C37DBC37023DB7F6ABB784693A3D8C6FF58F4551662A526FD8FEA434A8A89EAEA25ABAA99F34D33CC9248F76EE7B89DC924F89254B2E12381FAAD65A28350F51AA6A6DB8939C7E494D07A15172D8EC48711E845B8239BC4EDD36F151A74F7147E799EE3784475069DD905DA92D9DF0673775DF4CD8CBF6F3DB9B7DBD8AF32C564B663565A1C7ECB4ACA6A0B753C74B4D0B3C191B1A1AD1F40548AC9BA6D5EB3574CA51A16CF139E78F625D9DEFDC737B2F0ABC3CD8681B6EA1D26B03E36B794BEA29FBE91DED73DFBB89F6EEB9C6AD767EE8867D6D9E5C46DAEC3AF5CA4C15141B9A62FF00212407A16FE0969F69F0527515F08E714756BEA153D2C2ACB3E2DF9E7995A5A23D9F19CD4EAD5450EAEDBDB062B8FCAD9649A19378EEFE6C8E23E3C876F4C90081D3C4AB26A1A1A2B651416EB752C54D4B4B1B618618981AC8D8D1B06B40E80003C17DD112C19354D5EE7579A9D77C9704B977BF16111149E5983CEB17A6CDB0BBE6215623EEAF36F9E8897B799AD3230B43B6F6120FC1422C1FB2D600E8EA351F5424737FCA52D969034FC26977FE8D4F9450D64F4ACB57BCD3A9CA9DB4F754B9F05F328C756F17B6E11AA99861B6674CEA0B15F6BEDB4A6770748628677B19CC4000BB668DCEC3AA96DD967FE3A673F8AE9BFA52A307117FAFFEA4FEFB6EDFD6E4527FB2CFFC74CE7F15D37F4A551733A76B9273D0A72973718FC51630B9F5D387CD11BDDCEAEF377D2EC76AEBABE77D4D4D44B44C73E595EE2E73DC7CC924927DABA0A2C8723A75AA5179A726BC1E0E5772E1EF870B35BAA6EF76D2FC468E8A8A27CF51513D1C6C8E28DA3773DCE3D000012495597C51EAAE9867193FD41D1CC02C961C6AD7210DADA5A26C5517197C0BC9F16C63ED5BE7D49F20DE9BC78714592E6D97DDF45AC70545A71DC7EB1D495E1CFDA4B95446EEAE781D0441C3D16EE77D838EDB86B622530A7754442ADF23202F6895D1B439E19BF52D04804EDE0091EF0A926751D9AD22BD182BCBC9B726B2965B493EAFB5BF778F2DF344F44737D77CC22C4F0DA1716B3964AEAE7B4F7145093B73C8EF6F5D9BE2E23A78122DD743B42F08D06C3E1C5B11A3E699CD6BABEE1281DFD6CDE6F79F21B93B347403A7B570EE1275EF84DB263341A71A7F71A9C76BE52D3332FD0B61A8AEA82002F74CD2E8DCE3E43986C3A0014B60411B83B82A628D636A756BBBAADEAF3838535C93E19EF7F23847171C37D7711D89D96CB67BBD0DAEBED371F94B6A6AA3738772E616BDA3946FBFCD3B781D828D1A8DD9E985E9468BE599E5E33BBBDEEF566B649554CC8218E96944836F9CD3CEF70EBF74D561CB92716BF6366A1FE2497F9C29691F0E93ACDED0952B3A73C437970C2EAD678F329815C7F05DF62FE03FB826FEB32AA70571FC177D8BF80FEE09BFACCAAB1E66E3B73FE869FF005FC99A4F68AE6B5B8A70FB25AE864746FC92E705B247B5DB1EEF674AE1EDDC47B7C55532B44ED2EB056DDB41EDF73A588BE2B35FA0A9A823ED58E8A4881FE348155DA89733E8D8C8C169998F37279F77CB05B970D5C24698E97E0568ACBE6336EBE64F5F4B1555C2BABA9DB377723DA1C6289AE04358DDF6076DCEDB9F1D8745CEF87CD1BD46B3CD66C974FECEE64CC2C6CF4D4AC82788F93992300208F25A7F0D7C4E69D6B06056760BFD15BB23A4A48A9AE36CAA99B148D998D0D73A30E3E9B1C473348DFA1D8EC410BA5669AA7A79A7B679AFB9865F6CB6D240C2F264A8697BB6F26306EE71F60055D63073EBCA9A92BD97A472F499EFCFB3BBB305326B4E9B4FA47AA190E9ECB546A5968AB74704EE1B19613E946E23D7CA46FEDDD4BFECBCD44AA372CAF4AEAEA79A0F9336F7451927D12D7B629B6F2FB788FD2A24EBDEA543ABBAB99267F494F2414973AC2692393E7881A0363E6F512D0091E44ECBAC7677DD67B7F13968A48BE6DCEDB70A597F044265FF007A26AA2E0CE97ABD09DCE893570BEFA826FC52CB2CC757B4AF1DD68C0AE3A7D944D590D0DC035DDED24A6392391A7763C793B676C795C083B750AADB3CE09B5AB0ED4BB7E9F50D8E4BC53DE6A0C56DBBD3C6452C8D1D4BA5775EE8B5BD4877903B6EADED15DAC9CE348D7EEB4752852C38BE8FB7B7EBDA473D15E07346B4C71FA68F25C7A8F2BC81F183595F708BBC8C484756C319E8C60F01B8E63E24F90D2B8C5E10B4CABF4A2F99F6058C51582FD8D52BEE4EF91304515553C439A663D83A6E181CE69037DDA079A982A2BF1F9AF568D3CD29B869BDB6B239324CBE9CD1181AEF4A9E85FD2691E3F6CDDE303CF9C9FB5EA6960CBA65FEA379A953942A49C9C9678F0C75E1CB182AB55B6767F5FAB2F9C3458A3AD90BDD6DAAABA28C9FF36D94968F8076CAA4D5C4F0598257E9FF000EB8BDAEE903E1ACAE6497396378D9CCEFDE5ED07F825AAB1E66E5B6F282B08C5F37258F279239F6A466D5EC7619A7504CE651C8D9AF150C07A4AF07BA8F71FB51DE6DF84A0E6138BD666F9958B0CB73836AAFB72A6B6C2E3E0D7CD235809F60E6DCFB94CCED4AC7AAE2CB30ACA8427E49516F9E83BCF2EF59273EDFC57850DB02CAEA704CE31FCD692212CD61BA52DC99193B0798656BF94FB0F2EDF1512E67DFB391DDD1A9FA1E78979E59717A63C34E8E695E3F4B65B26136BAB9E28DAD9EBEB69193D45449B7A4F739C0EDB9F21B01E0B11AD9C286936AEE2D5D6F1895B2D37B30B8D05CE8699904914DB7A3CDC8073349DB7077E9ED5B6699EB9698EACD829AFD88E5741377F1B5D252493B59514EE23AB1F193B820F4F57A8AF06B1F109A6BA358BD6DEF20C96824AE8A179A4B6C53B5F515336C791818D3B804EDBB8F403757E0732854D495E7DD72F4B9EFCE7F9EC296AE76FA8B4DCAAED754369E8E7929E41EA7B1C5A7F285683D9C3A995799E89D4E2174A8EF6AB0DAE3470927777C8E51DE45BFB9DDEB47ED5AD0AB02F1729AF376ADBBD40025AEA892A5E078733DC5C7F295383B2CAE2F66459DDA79BD0968A92A08F6B64737FF005AA4799D2B6AE82ADA54A535C6387EDCE1FB9B257F133C3A59788CC262B056DD6A2DB73B63DF536BAA63DC6264CE00112C7E0F69036DFC47523CC1AE4C5F828D69BCEAF9D29BC58E4B632940A8ACBBB985F46CA4E6DBBD63FC1E5DD435A3AEFBEFB6C76B7B45771C9CFF004CDA3BBD2E8CA853C38BE59FCAFB57D0E2FA7DC1F680E9F58E1B4D3E036FBBD435804F5F7488544F3BBCDC4BBA3773E4D000516F8FDE16F4FB03C4E8F5634EACD1D90B6B594572A1A7E94F20901E4918DFB47070D881D083EB1D6C31402ED25D78C7EE16FA1D0FC72B59595B055B6BEF4F8CEECA72C07BA877F3792E2E23C801EBE90F183EAD9EBBBFB9D520D4E52CBFBD96DAC75CF4F0EFC100838B487349041DC11E4AF0B43321ADCB346306C92E6F2FACB8E3D415152F3F6F2BA0673BBE2EDCFC5523DAAD75F7CB9D259AD54CFA8ACAE9994F044C1B97C8E20340F89579BA6D8A3305D3CC670B6383BEA15A292DC5C3ED9D142D6177C4827E2A227BFB77287A2A31FCD97E5859F9114BB4A758AAB16C26D7A5166AB74555947354DC0B1DB3BE451BB60C3EC7BFE90C2156CD2D2D456D4C3454703E69EA246C5146C6F339EF71D83401E249206CA45F68264F5390F1397FA096573E0B0D2515B69C13D1ADEE1B3380FF00E24F22D7B82EC529B2FE2470FA2AC8DB2434552FB8B98E1B8260617B7FD600FC143E2CF6745A70D274655B1F95CDF7E567E1844DEE1B3814D3CC0716A3BCEA8E3D4990659591B66A88EAC77B4F4248DFBA633E6B9C3CDE77DCEFB745BE6AA706DA17A9B8FD4DB598750D82E4633F24B95AE16C124126DE892D0395EDDF6DDA4751BEC41D88EE48AF84731ABAC5F55AFEB2EAB52CF46F0BBB1D9DC516EA769DDFF4A73ABBE039344195F699CC4E7004365611BB246EFF006AE690E1EC2A4276796B357607ABADD3EAFAC3F50B316F71DD38FA3157346F0C83D448E661F5F337EE42DDFB51F0DA4A2CBF0DCEE9A26B66BA50D45BAA881B73181ED7C64FACED2BC7B9A1439C0AF936339C63F90D3C8E63EDB73A6AA0E0763B325693F90154E4CEA74A71D7F47CD45C6717FDCB867CD64BDD5561DA21ABD539CEB3498150D4BBEA3E1918A52C0EF464AD7B43A679FC1DDB1FB0B1DEB56922A1A28C55BFE6F77DE1F76DBAA2DD46BD546479FE497EAB7F34D70BAD5543DDBEFB974AE2AD234ED89B48D5BB9D792FC0B878BFD93F3333A23A497AD6ED48B569F596514EEAD797D4D496730A6A768DE4908F3D8780E9B9202B5CC17845E1FF0002B2C368A2D3CB6DCE48D81B2D6DD226D4D44EEF3739CE1B0DFD4D000F201562F0F1C40D4F0F35B9064763C6A9AE77EBA514741433553C886919CFCD23CB4757B8F2C600DC0F1DCF91CBDF78DCE262FB56EAAFCF2EAA81AE248868608A28C7B87293F9542691B26B7A6EA9AA57DCB79A8528AED6B2FAF2ECE5C49F3AB5C08685EA45AE7163B0B312BCF2934F5D6B6F2C61FE5DE43F35EDF5EDB1F510B39C2970CF6BE1D30C9A8EAA6A7B864D7594C973B846D3CA5809EEE28F71B86346C4FADC5C7D40400C438F8E24717AA8E6ADCB61BF40D3E9C172A56383C7AB9981A47C0A9DFC32718785F1094FF512A297EA0E5B4F197CF6C924E78E768F19207F4E61EB6901C3DA3A994D366B1AAE9FADD8D9BA55A7BF4B397879C78E78E3DC4814445634D0888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200A1076A5FF0088983FE36A9FE85AA6FA841DA97FE2260FF8DAA7FA16A89723DDD99FF75A3E2FE0CAE45B1FE793A8A3A0CFB23FE559FF00B4B5C56851F66670FAF8D8F37DCDF773413FF48D37FF006EA8964EA3AAEAD67A5EE7ADAFC59C70CF2C67E28AD8AECE735B9C0696E5985EEAE1778C73DC2691A7E0E710B0F0C13D5CCC829E19269A5772B18C69739C4F9003A92BB9716DC35D470ED9D45456A96B2B317BBC666B55654ECE9016EDDE43239AD6B4BDA483D00DDAE0765A3E86EAA55E8C6A759B3FA7B7D3D7C5432F255D2CD1B5C26A777478693F35E0756B878380F11B8307D546E69D7B5F59B34A49ACA5CB2FB3BBB0991C0A707B7FB05E6935AB542DAFB7CD4ED2EB1DAA7696CCD739A47CA256FDAF42795A7AF5DC81D379EAB118865963CEB18B665F8DD60AAB65DA999554D20F36386FB1F511E047AC15975912C1C6755D42E352B9955B8E0F963B31D0AA0ED15FB262E3F8A683FA35E5ECF9FB262CBFB86B3FA35EAED15FB262E3F8A683FA35E5ECF9FB262CBFB86B3FA354EA74C5FF00D39FFE2FFE24ABE3CF85B8F52B1E975670AA12729B1D3FF86D3C4CDCDC691BB9F01E32306E41F36EE3C86D5880B98E0E692D734EE08E84157F3E3D0AAC9E3DF85BFCEEAFD2EAF60D6B2CC66F5503EA8D3C0CF42DD56FFB6D87CD8E476FB79079E5E9CCD0A64BA9E1EC8EBBCB4FB87FD2FF00F8FD3CBB0D6B37E281DAB5C25B74D732AB6BB2BC7AEF41DCCCE3E95C28DAC91A1E7F6ECE8D77AFA1F32A30222AE726F369654ACA32851584DB78EC6F9E0BBFD03FD62F4E7F7A568FEA712AF7ED32A1AA875EADB5F242F6C1538F53B22791D1C592CBCC07BB987D2AC2340FF58BD39FDE95A3FA9C4A37F69669455E4DA7569D4FB4D23A69F1598C35FCBD4B68E62073EDEA6C9CBBFB1FBF802AEF91CBB67EE636DADFDFE52728F9F2F7F0205E82E4747896B660991DC6A22A7A3A0C86825AA9A53B32283BF6891E4F900C2E3BFB15DFF8AA0556A3C17F1678EEAA6296ED3CCBEEF1D266B69A76D3B5B52FE5FAA71306CD92371F9D20681CCDF9DE2E1B8DF688BE86C1B6BA755AF085DD25951CA7DCBA3F8E495288B1D9164960C4ACF5590E4F78A4B5DB68A3324F55552B638E368F593F907893D02B9CDA31727BB1596645145DC038FDD2ACEF5765D3B8E196DF6AAA2CA7B45E6A9DC8CABA9DC82D734FEA6D77A2184F527A1DB70A5126727D577637163250B8838B6B2B211110F9022220292388BFD7FF00527F7DB76FEB72293FD967FE3A673F8AE9BFA52A307117FAFF00EA4FEFB6EDFD6E4527FB2CFF00C74CE7F15D37F4A5635CCEBDAD7FB0CBFA63F1458C2228F5AF7C6969BE85E5D6DC2EAE096F3719278CDDA3A478FF00A369DC37E677AE4D88219D0F2F5E9B8DF267072AB5B3AF7B53D15BC5CA5DC722E263808CE3577586EFA8B846458ED0515E63A7926A7AD74CC7B6A191363790191B810EE40EDF7DF7739479D41ECFDE21B02B54D7A82D96AC92969DA5F28B2D53A5998C1E27BA918C73BDCC0E2AD4712CBF1BCEF1EA2CAB12BC535CED75F18960A881E1CD70F307D4E077041EA0820ACB9200DCAAEEA67BF6DB55A958A8D0786A1C30D71E1C31DA503B9B2432163DAE63D876208D8B48F2F615669D9D9AF77CD43C4AE3A6996D7CB5D70C5A38E4A2AA9897492513896863DC7E71611B027AF2903C941CE296BF17B9F1099DD6E1A69DD6A92ED208DF4E4189F28004CF611D0B5D2890823A1DF71D1773ECC3A5AC9358F21AB889F93436073661E5CCE9A3E4FF0075CAAB83376DA1A74EFB47957A91C34949679A7C387BF059A2E49C5AFD8D9A87F8925FE70BADAE49C5AFD8D9A87F8925FE70B23396E9DFEB297F547E28A60571FC177D8BF80FEE09BFACCAA9C15C7F05DF62FE03FB826FEB32AA4799D176E7FD0D3FEBF933A6E7984D8B51B0FBB61192D3F7D6EBC533A9A600ECE6EFE0E69F2734EC47B42A80D7DE19751741322A8A2BCDAEA2BAC4E793437AA7849A79E3F20E23F53781E2D3F0DC75573AB9DE4BAD1A3F43A81068CE5990DBA3BDDC699B3B28EB5AD30C9CC766C45CEF4448EF10D3E23C3AF4566B26A1A06B375A64E51A30DF83E2E3E1D576779494C7BE377331C5A47983B15F560ADAF9994F189EA2579E5646377B9C7D40799574379E16B877C82735773D20C69F2BCF339F0D2084B8FAC98CB77F8AF1DD70AE1CF86FC5AE1A88304C76C34F6984CA6A22A361A891E3E6C71B9DBB9CF71E8D1BF89F2EA55774DB16DB50A988D2A32737C970E7FCEE29C6F365BB63D7196D17DB7545056C1CBDED3D430B248F7008E669EA0EC41EBEB523BB3AACF2DCF898B6D6C67D1B4DAABEB1FF008263EE7F9E60B826A0E635DA839C5F737B8B792A2F75F356B99CDCDDD87B896B01F30D1B37E0A6E765D69FCF1CB976A7D553ED1C914765A390B4F51CC259B63E6376C5F4285CCF675FB874349A92A9C24E38F6BE04FE45FC7BD9131D24AF6B18C05CE738EC001E64A815C58F1F71D3B2BB4E3432BF9A7DDD05764513BD16793994A7CCF9779E5F6BEB576F0728D374CB8D56B7A2B75E2FA2F13AC7153C6AE2FA2504F8861CE86F59A48C20C6D21D4F6EF53A623C5FEA8C75F376DD37AB9CB32CC8F39C86BB2BCB2EF5173BADC65335454CEFE6739C7C87A9A06C0347400000001796082EF915D59053C55572B957CDCAD6B43A59A795C7E25CE24FBD582F0B1D9FB4D64928B3FD75A38EAAB9804D498F1707430BBC5AEA823A3DC3EE01E5DFC79BC1538C8E954A969DB256DBF3799BFEE9772EC5EEED399F05DC19DCB50AE743AA3A9F67753E29492B66A2A0AA610EBABDBD412C3FE401DB7DFA3FC3A8DD59AB5AD6B435AD0001B00074017E21861A7899053C4C8E28DA1AC631A035A0780007805FB574B073AD5B56ADABD7F4B57825C9744BEBDACE69C42E88D8F5F34D6B706BAB99055070AAB65691B9A4AB6821AFE9E208739AE1EA71F3D95426A8E8EEA1E8EE41518F6798E55504913CB62A8E42EA7A96F93E2907A2E69F61DC781008215E32E6549AADA1FAA5985F748A5BA59EF177B24A61AAB75644C7B6570682FEEB9F71272125AEE5EA083EF50D64F4F40D7AE74B8CA11839D35C5AFD3DF9E852A472CB11DE291CC27CDA765EDB4DA2F993DCE0B4D96DF5973AFA9706450411BA591E4F40001B957235DC25F0DB71A835553A398E8909DCF734E61693F82C207E45A8EB8DCF467851D24BBDE714C531FB0DE2E34F2505A21A3A68E3A8A8A87B080E047A64301E673B7D86C37EA4031BA6D10DB2A57328D2B6A327397059C63DD92A3E68A4A795F04CC2D92371639A7C883B10A76F658DB1CFBE67979DBD18A928E977DBCDEF7BBFF42825248F96474B21DDCF25CE3EB255A7F67369BD4619A12ECA6E10F2556635EFAF602DD9C29631DD420FBCB6478F648144799F7ED6D75474B9C5F3934979E7E08952BF8F7B2363A491C1AD68DCB89D801EB2BC57DBF59B18B3D5DFF21B9D35BADD43119AA6A6A240C8E260F124955A3C5771D77AD4FF0094E07A53535368C5798B2A6B86F1D55C9BE1B7AE388FDC8D9CEF3E9D15DBC1CDB49D1EE357ABB945622B9CBA2FDFB8EB9C59F1EB478C9ADD39D11B8C5577600C15D7D8C07C348EF0732027A3E41F77D5AD3E1B9076AEC9A6AEBAD73E79E59EB2B2AE52E7BDE4C924B238F524F52E7127DE564F0EC3329D41C8E9314C3ACB5576BAD7BF921A7A761738FADCE3E0D681D4B8EC000492ACDF85AE07317D1C14F99E7A20BF6605A1D134B43A96DC7FEC811E949FB73E1F6A0789A7191D127574ED92B6DC8F19BFEE93EFEC5EEECCB346E07B835AAC466A2D65D54B7BA1BBF2F7966B4CCDD8D2070E93CA0F849B1F45A7E6EFB9EBB6D389115D2C1CD352D46BEA95DD7AEF8F45D12EC453DF1C96E9ADBC52E711CAD204F35254309FB66BE8E1774F8923E0B21C03DD69ED5C4DE366A246B3E570D5D2B37F37BE1700175AED3ED389A8B32C6F54A8E976A5B9D0FD4AAC7B474EFE2739CC73BDA58FE5F746143AC1F2EB9E0598D9B34B3380ADB2D6C55B102760E2C7025A7D8E1B83EC2551F06755B0C6A7A1C69C1F170DDF6A5BBF12F7D169FA4DAA78AEB1E0F6ECEB12AC6CB4B5B1832C25C0C94B36DE9C3201E0E69E9EDE8474216D55B5B476DA39EE370AA8A9A9696374D34D2B83591B1A37739C4F40000492B21C7EA529D29BA735892E18EF20676A85CA9841A7D68E7699DCFAFA92DDFA860113773EF24FD0540CB0D14D73BE5BADB4E3796AEAE18231EB739E00FCA575FE3035B60D72D65AEBFDA262FB15AA16DAED47C9F0B1CE2E97F86F739DEEE51E4BE7C1DE9CD46A5F1038C5B1B019292D538BC569DBA32180876E7DEF2C6FBDC1637C59D874BA6F48D1E3E9B838C5C9FB72F1F22E06B2378C7E7876DDC28DCDDBDBC8A88AF6D2DBCD7B5C3622AA5047F0CABEC735AE696B86E08D88F62A3AD6AC52A707D5BCBB14AA8DCC7DBAEF5318DC78B0BCB98EF7169691EC214C8D67612A2F495E9F5693F2CFD4CC68068265BC41E6BF992C6648A921A68BE5370AF9DA4C74B0EFB6E40EAE713D037CCFA80254D8A5ECBBD3765BC4559A897F92B397D29590C4D6737B1BEAF8AD1BB2DB2CB0505FB38C3AB258A1BB5D61A2ABA3E6203A78E1EF848C1EB2DEF5AED879127C9587A98A5829B4DAEEA16B7F2B7A32DC8C52C612E3959CFCBD853E713BC27657C38D6D1D6CD7265EB1DB9BCC74B708E32C7324037EEA56F50D76DD410763B1F0DB65C8F09CC6FBA7D96DA735C6AA8D3DCACD571D5D3BFC8B9A77E570F36B86ED23CC121594F69564D61B7E85D2E3159342EBA5DAEF4F251C248E76B62E6324807880010DDFF6EAAED55F066D5B3F795B55D3D54BA596F2B9735DBF22F9310C8E9730C52CD95D0B4B69EF3414F5F1B4F8B5B2C61E01F68E6D965968BA116CABB3E8B60D6DAE616544160A11230F8B5C6169D8FB46FB2DE96438F578C6156518F24DE3CC22221882222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200A1076A5FF0088983FE36A9FE85AA6FAE47C44F0DF8D711D67B459B25BFDCED71D9EA64A989F42232E7B9ED0D21DCED3D3A79286B28F5744BAA5657F4EE2B3C462DE7C994C2AFDE0FD423FC01FCCA187E95CE957DF1B2BFE2D37F76A68B1A18C6B0783400A22B07B5B57AC5AEABE87D59B7BBBD9E0D73DDC7C0E79AF9A3360D75D36B960D7A63239E46F7F6EAC2DDDD4956D079241ECF270F3692153065F8A5F306C9EE78864B44FA4B9DA6A1F4D530BC6C5AE69F11EB046C41F304157C6A3F6BFF05DA6DC406514D98DE2E772B25D62A714D5135B5B10356D6FCC3273B4EEE68F441F1DB61E006C92C95D99DA08E972950B96FD1BE3DB87F46455ECF6E2524C33236E8AE5F5E3EA15F26E6B44B21005256BBC63DFEE25E9D3C9E06DF38AB2B50BD9D979A5B1BDB247A9196B5CD20B5C0530208F31F5B52FF1BB5D6D92C34167B85EAA6F15147032092BEA9AD1354968DB9DFCA03798F9EC06E54ACF53E5DA3B8D3EF6E15CD94B8CBF12C35C7B7DBD7CCAB1ED15FB262E3F8A683FA35E5ECF9FB262CBFB86B3FA353635CF81DC135DF3F9F506FF00985FADD573D3434C60A36C2630D8DBB03E9B09DCFBD7CB44B816C0B43B3FA4D41B16657FB855D2432C2D82ADB088C87B7624F2B01FCAAB879C9EFADA1B0FB1BD4F79EFEE6EF27CF18E649658DC971CB2E5F60B86319150475B6DB9C0FA6A98241BB5EC70D88F7F983E4402B248AE73E8C9C5A9479A298B89BE1FAF9C3EEA25463F52D7D458EB9CEA9B357794D4FBFCC77AA467CD70F88E842E44AEE35C743F0ED7BC29F86E5ED9626B656CF495B4E1BDFD24A0F5730B811D46E083D083EE51BFF4AE74ABEF8D95FF00169BFBB5471EC3A7699B636AEDA2AF5B55170784DE7BF87BC92FA07FAC5E9CFEF4AD1FD4E25B8DD6D7417BB655D9AEB4B1D4D157C0FA6A98641BB6489ED2D7348F510485E1C3319A5C2B0FB161B43512D453586DB4B6C865976E7919044D8DAE76DD3721A09DBA6EB30AE736AF514EB4AA43AB6D799523C57F08B94684DFAAF21B0D2CD72C1EAE52FA5AC63799D45CC7A413FA883D03FC1C36F03B811DA19A6A79593D3CAF8A58DC1CC7B1C5AE6B87810478157E557494B5F4B351575345514F50C7452C32B03D9231C362D734F4208E841518352BB3BF43337AA9AE58F36E18955CC4B8B6DCE6BA9B9BD913C10D1EC691ECD951C7B0DFB49DB382A6A96A09E57E65C73E2BB7C0AFEB2F151C43E3F42CB75AF56B20653B000D6C951DE903F09E09FCAB51CD353F50F51256CD9C66576BD161E66B6AEA5CF634FAC37E683EE0A6755F656D7F7E4D0EB4538849E825B1B8B80F789B63F916C98AF65C61B453B25CC7532E974634EE62A2A3652877B09739E7E82A30CF596D068341FA5A6D6F7741E7E0BE2401C330ACA750722A4C570DB354DCEE958FE58A081BB9F6B9C7C1AD1E64F40AE7F41B0FCEB03D2CB1E2FA8D947D5EBE51C3CB3D4F8F237ED62E73D64E41B0E63D4ECBEFA59A27A65A316B75AF4F716A5B777C00A8AADB9EA6A36F0EF253E9387B3C06E76016F2AC960D37687687ED8C52A70C422F3C79BFA78044456357088880A48E22FF005FFD49FDF6DDBFADC8A4FF00659FF8E99CFE2BA6FE94AEC59D767269AE799ADFB37B867B93535564172A9B9CD0C2DA7EEE37CD2BA4735BBB09D8171037EABA170EBC25E21C385DAF176C6B27BC5D24BCD3C74D2B6B8441AC6B1C5C0B791A3AF5F35449E4E87A9ED0D85CE94ED29C9EFEEC5727D31F43A7EA4DB331BC60B7AB669FDEA0B4E435148F650564D173B62948E9D3C89F007AEC4EFB1D9527EA3E279CE1798DCACBA8D6FAEA5BF366749546AC973E673892650F3F3C38EE79813BABD55A4EA8E8BE9AEB2DA5B68D42C5E96E6D881F93D411C9514E4F9C7237D26FBB7D8F982ACD64F0767B5E5A34E51A90CC25CDAFC4BEABB8A66C0F55B51B4C2A9F5780E6373B2BA53CD2369A622390FADCC3E893B74DC85BA651C5BF10F9859E5B0DEB536E4EA29DA5933200C84C8D23620B980123E2A5DE57D97385D7543E6C3752EE96A6389222ADA3655B59EC05AE6123DE56BB41D95B542A01BA6B3C4E801EADA7B210F23DEE9881F4154C33747AFE835DFA6A8D6F77C1E7CF0FE24098E392691B144C73DEF21AD6B46E5C4F8003CCAB57E02F87DB9E8EE9DD4E4D97509A5C8F2A7326929DE3D3A5A56FEA51BBD4E3B9711E5B81E20AD8345F824D17D1BB84190414151905F29887435D742D7F72FF00BA8E30031AEF51D891E45481564B06B5B47B4F0D469FAADAA7B9D5BEBDC97605C938B5FB1B350FF124BFCE175B5AD6A5E0941A9D815F300BA56D452525F691D4934F4FCBDE46D76DD5BCC08DFA79856354B3A91A3714EA4F92926FD8CA2A571FC177D8BF80FEE09BFACCAB8C7E95CE957DF1B2BFE2D37F76A5369469D5B74974F6CBA7568AFA9ADA3B242E8629EA797BD78748E7EEEE50078B88E815629A370DA8D76CB54B5852B6936D4B3C9AE1868FDEA8E5F72C0F4FEFB9759B1EAABE575B28DF353D05330BDF34807A2361D7941EA76EBB03B2A48CC72FC8B3ACA6E3986537092AEED73A875454CCEE879C9F003ED40E8001E0000AF81706D62E0B344758EBA7BE57D9A5B25EAA497CD70B53844E99E7C5D23082C7BBD676DCF99492C9F06CCEB76BA4CA4AE21F8BF32E2D7763B3C0AD0C4F8A1D7DC268596CC7F546F51524439590CD377CD68F203BC0480B5CCFF57B53354A78E7CFF33B9DE7B93BC51D44BF5B8CFADAC1B341F6ECA66DD7B2B8BA773AC7AC823877F4595766E7701ED736500FD0B2F8A765B6314752C9B33D51AFB9C4D3BBA1A0A06D2F37B0B9CF79FA3655C33705B41A0D27E9E0D6F7741E7CF1F320DE95695E61AC79951E1585DB9D535952EDE59483DD5345BFA52C8EFB568DFE27603A95733A41A5F60D1BD3CB3E9EE3A0BA9ED90ED2CEE1B3EA6777592577B5CEDCEDE4361E017F34B747B4F346AC271ED3EC760B6C1210EA8947A53D4B80D83A590F571F1DBC86E76016E6AE960D2B6836825AC4953A6B769C792EADF6BF9221F7696E5F92E39A5561B558AF353434D7CB9494D70640FE53511363E60C711D7977F11E7E6AB195D07111C39E35C46D8AD561C96FD73B5C569AA7D5C6FA111973DCE6729079DA46DB7A9707FD2B9D2AFBE3657FC5A6FEED55A6D9EEECEED069FA6D8AA359E2596DE13EDE1EE2BC711CCF27C0EF2CC8710BC4D6BB944D2C8EA610DEF180F8F2920EC7DA3AADFBF458711DF7DFC87FD38FF929A1FA573A55F7C6CAFF008B4DFDDA7E95CE957DF1B2BFE2D37F76A30CF56AED2E875A5BD5565F7C33F2217FE8B0E23BEFBF90FF00A71FF253FF00B3DB51737D4AD26BFDE73CC96B6F75D4D914B4B14F54F0E732214D4EE0C1D3C399CE3F15A87E95CE957DF1B2BFE2D37F76A4070F5C3FE3DC3AE255F886377BB8DD29EE17175C9F2D70607B5EE8A38F94720036DA307E2559279E2783AF6ADA4DDD9BA56714A795F971EFC187E2F75532AD25D16BADFF000DB1D6D6DCEAB6A365541197C76E6BC1E6A9936F0006E0797316EFD3754EECB8DC23AF1758EB67656897BF150D90B64126FBF3070EA0EFD7757E13430D444F82A2264B148D2C7B1ED0E6B9A7A1041F10A326A8F67C6866A0564D75B1C15989574C4BDDF52CB7E4E5C7CFB97021BEE6EC3DC8D64C1B33AF59E974E546E218DE7F8971F635DDDC402B3F177C47D8E85B6EA1D57BC9818DE56099CD95CD1EC73813F9573CCC73ACC7506ECEBE66B9257DE6B9C397BEAB98BCB47A9A3C1A3D8365366AFB2B2B8CE4D0EB4402127A09AC64B80F789F63F916E3837661E9D59EAA3ABCE739BAE4023209A7A681B4713FDFD5EEDBDCE55C33685B43A15B66AD16B7BBA0D3F82F890EB867E1D328E20738A6B6D2534B4F8ED14AD92F1722DF421881DCC6D3F6D2387403DBB9E815C5D92CD6DC76CF4561B3D2B29A86DF0329A9E260E8C8D800681F00BC587E178AE9FD829F17C32C34768B5D28DA3A7A68C35BBF9B8F9B9C7CDC7727CCACD2BA58343D775CA9ACD64F1884792F9BEFF815CDDA7F9964F167B8DE0B0DEAA63B0C96465C64A163F96392A0D44CCE7701F3886B1A06FD06CA0F2B7BE21B839C3388ACB2DF96E49955EAD7516EB736DCC8A844458E609649398F3B49DF7908F805CB3F4AE74ABEF8D95FF169BFBB5569B66D9A2ED269B63634E8546D492E384F9900306D51D40D3496A67C0F29ACB24B560366929795AF781E00B88276F62DBFF458711DF7DFC87FD38FF929A1FA573A55F7C6CAFF008B4DFDDA7E95CE957DF1B2BFE2D37F769867D95368F42AB2DFA8937DAE19F910BFF458711DF7DFC87FD38FF92B44E12328C8333E1DB0DC9B29BB4F73BAD753D4BAA2AA776F24A5B55334127D8D681F05C2FF004AE74ABEF8D95FF169BFBB528F48F4D6D9A41A7566D38B35C2AABA8ECB1C91C55155CBDEBC3E57C879B9401E2F23A0F00A526B99AE6D1EA7A5DEDB4616314A4A597F771C30FBBC0F36B4692E3FAD9A7775D3FC8B78E3AE8F9A9AA5ADDDF4B50DEB1CAD1E7B1F11E6371E6A9B75574A732D1CCC2AF0CCD6DAFA6ABA724C52807BAA98B7F4658DDF6CD3F93C0F55794B50D4ED25D3FD61B01C735071DA7B9D2B49740F70E59A9DE46C5F1483AB0FBBC7CF752D64F8767F6867A3C9D3A8B7A9BE6BAA7DABE68A5EC0754F50F4BABDF71C072EB8D966976128A6948649F84C3E8BBE216773FE22F5AB542DC6CF9B6A0DCEBEDE762EA40E11C4FDBEE9AC003BE2A6765BD96F8AD6D4BE6C2B53AE16B89C496C35F42DAB0DF60735CC3F4EEB1962ECB0A58EA9AFC9B5825A8A707D28E86D222791F84F91C3FD554C3376FF0011685524AE24D6FF007C1EF79E3E640AB258EF1925DA96C360B6D45C2E35D28869E9A9E32F92579F000056D5C1C70D51F0FF008249517E8A1932DBF06CB7395A43840C1BF253B5DEA6EE4923C5C7D816D9A2FC31691E854667C36C024BAC8CE496EB5AEEF6A9CD3E20388D980FA9A06FE7BAEAEACA38353DA1DA67AA47D5AD9354FAE79BFA20A07F68870D374BECE35D308B5BEA66829C439053C0CE67BA38C6CCA9D8753CAD1CAEFDAB5A7C8A9E0840702D70041E841F352D64F034CD46AE97731B8A5D39AED5D5142565BDDDF1CBA535EEC372A9B7D7D23C49054D3C859246E1E6085DDE8B8F6E27A86DC2DCDCF619806F289A7B6D3BE5FE3966E4FB54D9D5AECFCD14D49B8D45F6CA2B313B954B8BE436D0D34EF79EA5C6170D86E7C79485C5EA3B2B2E1F283F25D69A71013D3BCB138BC0F84FB1FC8AB868E8BFE21D0F518A95DA595D251CE3DA93215E75A859AEA5DF1F91E7591D65E2E0F1CA25A87EFC8DFB96B7C1A3D8005D8383DE1B2EDAE7A814773BADB64186D92A593DD2A1ED223A82D21C299A7CCBBA076DE0D27C370A58603D997A5B60AA8AB738CB2EB92BA321C69E36369207EDE4402E7EDFC252DF1CC6AC188592931BC5ED14B6CB650B3BBA7A5A68C3238DBE3D00F592493E24924A28F69F06ABB5D6D4E83B7D35716B19C6125DCBB7CB0645AD6B1A18C686B5A36000D800BFA88AE7390888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880222200888802222008888022220088880FFD90000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(1 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), N'Perfiles de Usuarios', N'P', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(2 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), N'Usuarios', N'U', CAST(2 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(3 AS Decimal(18, 0)), CAST(11 AS Decimal(18, 0)), N'Informacion de Empresa', N'IF', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(4 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), N'Tipo de Proveedor', N'TP', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(5 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), N'Proveedor', N'PR', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(6 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), N'Almacen', N'A', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(7 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), N'Tipo de Producto', N'TPRO', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(8 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), N'Productos', N'PRO', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(9 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), N'Tipo de Empaque', N'TE', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(10 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Centro de Salud', N'CS', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(11 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Medicos', N'M', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(12 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Paciente', N'PA', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(13 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Nacionalidad', N'NA', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(14 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Tipo de Cliente', N'TC', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(15 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Ocupacion', N'O', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(16 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Estado Civil', N'EC', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(17 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'ARS', N'ARS', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(18 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'Salas', N'SAL', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(19 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Pantalla de Tipo de Pagos', N'TF', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(20 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Facturacion', N'F', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(21 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), N'MONEDAS', N'MO', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Configuracion].[Secuencial] ([IdSecuencial], [IdModulo], [Pantalla], [Sigla], [Secuencia], [Estatus]) VALUES (CAST(22 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Facturacion Comprobante', N'FC', CAST(0 AS Decimal(18, 0)), 1)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(1 AS Decimal(20, 0)), N'FACTURA DE CREDITO FISCAL', N'B', N'01', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(2 AS Decimal(20, 0)), N'FACTURA DE CONSUMO', N'B', N'02', 0, 0, 1000, 1000, 1, N'31-12-2019', 1, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(3 AS Decimal(20, 0)), N'NOTA DE DEBITO', N'B', N'03', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(4 AS Decimal(20, 0)), N'NOTA DE CREDITO', N'B', N'04', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(5 AS Decimal(20, 0)), N'COMPROBANTE DE COMPRAS', N'B', N'11', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(6 AS Decimal(20, 0)), N'REGISTRO ÚNICO DE INGRESOS', N'B', N'12', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(7 AS Decimal(20, 0)), N'COMPROBANTE PARA GASTOS MENORES', N'B', N'13', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(8 AS Decimal(20, 0)), N'COMPROBANTE DE REGÍMENES ESPECIALES ', N'B', N'14', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(9 AS Decimal(20, 0)), N'COMPROBANTE GUBERNAMENTAL', N'B', N'15', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(10 AS Decimal(20, 0)), N'COMPROBANTE PARA EXPORTACIONES', N'B', N'16', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(11 AS Decimal(20, 0)), N'COMPROBANTE PARA PAGOS AL EXTERIOR', N'B', N'17', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 8)
INSERT [Contabilidad].[ComprobantesFiscales] ([IdComprobante], [Descripcion], [Serie], [TipoComprobante], [Secuencial], [SecuenciaInicial], [SecuenciaFinal], [Limite], [Estatus], [ValidoHasta], [PorDefecto], [Posiciones]) VALUES (CAST(12 AS Decimal(20, 0)), N'COMPROBANTE FISCAL ELECTRONICO', N'E', N'31', 0, 0, 1000, 1000, 1, N'31-12-2019', 0, 10)
INSERT [Contabilidad].[Impuesto] ([IdImpuesto], [Impuesto]) VALUES (CAST(1 AS Decimal(20, 0)), CAST(1.18 AS Decimal(20, 2)))
INSERT [Empresa].[Sexo] ([IdSexo], [Descripcion]) VALUES (CAST(1 AS Decimal(20, 0)), N'Hombre')
INSERT [Empresa].[Sexo] ([IdSexo], [Descripcion]) VALUES (CAST(2 AS Decimal(20, 0)), N'Mujer')
INSERT [Empresa].[TipoIdentificacion] ([IdTipoIdentificacion], [Descripcion]) VALUES (CAST(1 AS Decimal(20, 0)), N'Cedula')
INSERT [Empresa].[TipoIdentificacion] ([IdTipoIdentificacion], [Descripcion]) VALUES (CAST(2 AS Decimal(20, 0)), N'RNC')
INSERT [Empresa].[TipoIdentificacion] ([IdTipoIdentificacion], [Descripcion]) VALUES (CAST(3 AS Decimal(20, 0)), N'Pasaporte')
INSERT [Empresa].[TipoIdentificacion] ([IdTipoIdentificacion], [Descripcion]) VALUES (CAST(4 AS Decimal(20, 0)), N'Otro')
INSERT [Facturacion].[EstatusCirugia] ([IdEstatusCirugia], [Descripcion], [Estatus]) VALUES (CAST(1 AS Decimal(20, 0)), N'Pendiente', 1)
INSERT [Facturacion].[EstatusCirugia] ([IdEstatusCirugia], [Descripcion], [Estatus]) VALUES (CAST(2 AS Decimal(20, 0)), N'Operado', 1)
INSERT [Facturacion].[EstatusCirugia] ([IdEstatusCirugia], [Descripcion], [Estatus]) VALUES (CAST(3 AS Decimal(20, 0)), N'Entregado', 1)
INSERT [Facturacion].[EstatusFacturacion] ([IdEstatusFacturacion], [Estatus]) VALUES (CAST(1 AS Decimal(20, 0)), N'FACTURADO')
INSERT [Facturacion].[EstatusFacturacion] ([IdEstatusFacturacion], [Estatus]) VALUES (CAST(2 AS Decimal(20, 0)), N'COTIZACION')
INSERT [Facturacion].[EstatusFacturacion] ([IdEstatusFacturacion], [Estatus]) VALUES (CAST(3 AS Decimal(20, 0)), N'CANCELADA')
INSERT [Facturacion].[TipoPago] ([IdTipoPago], [CodigoTipoPago], [Descripcion], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica], [BloqueaMontoPagar]) VALUES (CAST(1 AS Decimal(20, 0)), N'TF201991', N'Efectivo', 1, CAST(0 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), 0)
INSERT [Facturacion].[TipoPago] ([IdTipoPago], [CodigoTipoPago], [Descripcion], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica], [BloqueaMontoPagar]) VALUES (CAST(2 AS Decimal(20, 0)), N'TF201992', N'Tarjeta', 1, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), 1)
INSERT [Facturacion].[TipoPago] ([IdTipoPago], [CodigoTipoPago], [Descripcion], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica], [BloqueaMontoPagar]) VALUES (CAST(3 AS Decimal(20, 0)), N'TF201993', N'Cheque', 1, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), 1)
INSERT [Facturacion].[TipoPago] ([IdTipoPago], [CodigoTipoPago], [Descripcion], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica], [BloqueaMontoPagar]) VALUES (CAST(4 AS Decimal(20, 0)), N'TF201994', N'Transferencia', 1, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), 1)
INSERT [Facturacion].[TipoPago] ([IdTipoPago], [CodigoTipoPago], [Descripcion], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica], [BloqueaMontoPagar]) VALUES (CAST(5 AS Decimal(20, 0)), N'TF201995', N'Otro', 1, CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-08' AS Date), CAST(1 AS Decimal(20, 0)), CAST(N'2019-09-23' AS Date), 0)
INSERT [Inventario].[Proveedor] ([IdProveedor], [CodigoProveedor], [IdTipoProveedor], [Nombre], [Direccion], [Telefonos], [Fax], [Contacto], [LlevaComision], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(1 AS Decimal(18, 0)), N'PR201981', CAST(1 AS Decimal(18, 0)), N'EDEESTE', N'', N'', N'', N'', 0, 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-21' AS Date), CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-21' AS Date))
INSERT [Inventario].[Proveedor] ([IdProveedor], [CodigoProveedor], [IdTipoProveedor], [Nombre], [Direccion], [Telefonos], [Fax], [Contacto], [LlevaComision], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(2 AS Decimal(18, 0)), N'PR201982', CAST(2 AS Decimal(18, 0)), N'CAST', N'', N'', N'', N'', 0, 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-21' AS Date), CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-21' AS Date))
INSERT [Inventario].[Proveedor] ([IdProveedor], [CodigoProveedor], [IdTipoProveedor], [Nombre], [Direccion], [Telefonos], [Fax], [Contacto], [LlevaComision], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(3 AS Decimal(18, 0)), N'PR201983', CAST(1 AS Decimal(18, 0)), N'SUPLIDORES DEL CARIBE', N'', N'', N'', N'', 0, 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-21' AS Date), CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-23' AS Date))
INSERT [Reporte].[RutaReporte] ([IdReporte], [DescripcionReporte], [RutaReporte]) VALUES (CAST(1 AS Decimal(20, 0)), N'FACTURA DE VENTA', N'C:\Users\Ing.Juan Marcelino\Documents\Desarrollo de Software\Sistema Medico\Reportes\FacturaVenta.rpt')
INSERT [Reporte].[RutaReporte] ([IdReporte], [DescripcionReporte], [RutaReporte]) VALUES (CAST(2 AS Decimal(20, 0)), N'CUADRE DE CAJA', N'C:\Users\Ing.Juan Marcelino\Documents\Desarrollo de Software\Sistema Medico\Reportes\CuadreCaja.rpt')
INSERT [Reporte].[RutaReporte] ([IdReporte], [DescripcionReporte], [RutaReporte]) VALUES (CAST(3 AS Decimal(20, 0)), N'HISTORIAL DE FACTURACION', N'C:\Users\Ing.Juan Marcelino\Documents\Desarrollo de Software\Sistema Medico\Reportes\HistorialFacturacionCotizacion.rpt')
INSERT [Seguridad].[ClaveSeguridad] ([IdClaveSeguridad], [IdUsuario], [Clave], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(1 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'MQAyADMANAA1ADYANwA4ADkA', 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-20' AS Date), CAST(1 AS Decimal(18, 0)), CAST(N'2019-11-17' AS Date))
INSERT [Seguridad].[LogonBD] ([IdLogonBd], [Usuario], [Clave]) VALUES (CAST(1 AS Decimal(20, 0)), N'sa', N'IQBAAFAAYQAkACQAVwAwAHIAZAAhAEAAMAA2ADIANAA=')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(1 AS Decimal(18, 0)), N'btnFacturacion', N'Facturacion ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(2 AS Decimal(18, 0)), N'btnInventario', N'Inventario ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(3 AS Decimal(18, 0)), N'btnCaja', N'Caja ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(4 AS Decimal(18, 0)), N'btnContabilidad', N'Contabilidad ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(5 AS Decimal(18, 0)), N'btnEmpresa', N'Empresa ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(6 AS Decimal(18, 0)), N'btnGestionCobros', N'Gestion de Cobros')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(7 AS Decimal(18, 0)), N'btnNomina', N'Nomina ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(8 AS Decimal(18, 0)), N'btnHistorial', N'Historial ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(9 AS Decimal(18, 0)), N'btnReportes', N'Reportes ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(10 AS Decimal(18, 0)), N'btnSeguridad', N'Seguridad ')
INSERT [Seguridad].[Modulo] ([IdModulo], [CodigoInterno], [Descripcion]) VALUES (CAST(11 AS Decimal(18, 0)), N'btnConfiguracion', N'Configuracion ')
INSERT [Seguridad].[Perfil] ([IdPerfil], [CodigoPerfil], [Descripcion], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(1 AS Decimal(18, 0)), N'P2019081', N'Administrador', 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-15' AS Date), CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-15' AS Date))
INSERT [Seguridad].[Usuario] ([IdUsuario], [CodigoUsuario], [IdPerfil], [Usuario], [Clave], [Persona], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(1 AS Decimal(18, 0)), N'U2019081', CAST(1 AS Decimal(18, 0)), N'juan.diaz', N'MQAyADMANAA1ADYANwA4AA==', N'Juan Marcelino Medina Diaz', 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-08-15' AS Date), NULL, CAST(N'2019-10-28' AS Date))
INSERT [Seguridad].[Usuario] ([IdUsuario], [CodigoUsuario], [IdPerfil], [Usuario], [Clave], [Persona], [Estatus], [UsuarioAdiciona], [FechaAdiciona], [UsuarioModifica], [FechaModifica]) VALUES (CAST(2 AS Decimal(18, 0)), N'U2019102', CAST(1 AS Decimal(18, 0)), N'Admin', N'MQAyADMANAA1ADYANwA4ADkA', N'Administrador', 1, CAST(1 AS Decimal(18, 0)), CAST(N'2019-10-28' AS Date), CAST(1 AS Decimal(18, 0)), CAST(N'2019-11-17' AS Date))
/****** Object:  StoredProcedure [Caja].[SP_BUSCA_CAJA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Caja].[SP_BUSCA_CAJA]
  @IdCaja DECIMAL(20,0) = NULL
, @CodigoCaja VARCHAR(100) = NULL

AS

SELECT
  C.IdCaja
, C.CodigoCaja
, C.Descripcion
, C.MontoActual
, C.Estatus AS Estatus0
, CASE C.Estatus WHEN 1 THEN 'ABIERTA' WHEN 0 THEN 'CERRADA' END AS Estatus
FROM [Caja].[Caja] C

WHERE C.IdCaja = ISNULL(@IdCaja,C.IdCaja)
AND C.CodigoCaja = ISNULL(@CodigoCaja,C.CodigoCaja)
GO
/****** Object:  StoredProcedure [Caja].[SP_BUSCA_MONEDA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Caja].[SP_BUSCA_MONEDA]
  @IdMoneda DECIMAL(20,0) = NULL
, @CodigoMoneda VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  M.IdMoneda
, M.CodigoMoneda
, M.Descripcion AS Moneda
, M.Sigla
, M.Tasa
, M.Estatus AS Estatus0
, CASE M.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' END AS Estatus
, M.PorDefault AS PorDefault0
, CASE M.PorDefault WHEN 1 THEN 'SI' WHEN 0 THEN 'NO' END AS PorDefecto
, M.UsuarioAdiciona 
, UC.Persona AS CreadoPor
, M.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,M.FechaAdiciona,103) AS FechaAdiciona
, M.UsuarioModifica
, UM.Persona AS ModificadoPor
, M.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,M.FechaModifica,103) AS FechaModifica
FROM [Caja].[Moneda] M
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = M.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = M.UsuarioModifica

WHERE M.IdMoneda = ISNULL(@IdMoneda,M.IdMoneda)
AND M.CodigoMoneda = ISNULL(@CodigoMoneda,M.CodigoMoneda)
AND M.Descripcion LIKE '%' + ISNULL(@Descripcion,M.Descripcion) + '%'

ORDER BY M.PorDefault DESC
OFFSET(@NumeroPagina -1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Caja].[SP_MANTENIMIENTO_CAJA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Caja].[SP_MANTENIMIENTO_CAJA]
  @IdCaja decimal(20,0)
, @CodigoCaja varchar(100)
, @Descripcion varchar(100)
, @MontoActual decimal(20,2)
, @Estatus bit
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdCaja decimal(20,0)
, CodigoCaja varchar(100)
, Descripcion varchar(100)
, MontoActual decimal(20,2)
, Estatus bit
)

IF(@Accion='ADD')
	
	BEGIN
		
		UPDATE [Caja].[Caja] SET
			

			 MontoActual= (SELECT MontoActual + @MontoActual FROM [Caja].[CAJA] WHERE IdCaja =1)

				
				OUTPUT
					
					  inserted.IdCaja
					, inserted.CodigoCaja
					, inserted.Descripcion
					, inserted.MontoActual
					, inserted.Estatus
						
						INTO @ITEMS	
							
							WHERE IdCaja = @IdCaja
							--AND CodigoCaja = @CodigoCaja
END
IF(@Accion='LESS')
	
	BEGIN
		
		UPDATE [Caja].[Caja] SET
			

			 MontoActual= (SELECT MontoActual - (@MontoActual * -1) FROM [Caja].[CAJA] WHERE IdCaja =1)

				
				OUTPUT
					
					  inserted.IdCaja
					, inserted.CodigoCaja
					, inserted.Descripcion
					, inserted.MontoActual
					, inserted.Estatus
						
						INTO @ITEMS	
							
							WHERE IdCaja = @IdCaja
							--AND CodigoCaja = @CodigoCaja
END
IF(@Accion='OPEN')
	
	BEGIN
		
		UPDATE [Caja].[Caja] SET 
			
			Estatus = 1
				
				OUTPUT
					
					  inserted.IdCaja
					, inserted.CodigoCaja
					, inserted.Descripcion
					, inserted.MontoActual
					, inserted.Estatus
						
						INTO @ITEMS	
							
							WHERE IdCaja = @IdCaja
							--AND CodigoCaja = @CodigoCaja
END

IF(@Accion='CLOSE')
	
	BEGIN
		
		UPDATE [Caja].[Caja] SET 
			
			Estatus = 0
				
				OUTPUT
					
					  inserted.IdCaja
					, inserted.CodigoCaja
					, inserted.Descripcion
					, inserted.MontoActual
					, inserted.Estatus
						
						INTO @ITEMS	
							
							WHERE IdCaja = @IdCaja
						--	AND CodigoCaja = @CodigoCaja
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Caja].[SP_MANTENIMIENTO_HISTORIAL_CAJA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Caja].[SP_MANTENIMIENTO_HISTORIAL_CAJA]
  @IdistorialCaja DECIMAL(20,0)
, @IdCaja DECIMAL(20,0)
, @Monto DECIMAL(20,2)
, @Concepto VARCHAR(8000)
, @IdUsuario DECIMAL(20,0)
, @NumeroReferencia DECIMAL(20,0)
, @IdTipoPago DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdistorialCaja DECIMAL(20,0)
, IdCaja DECIMAL(20,0)
, Monto DECIMAL(20,2)
, Concepto VARCHAR(8000)
, Fecha DATE
, IdUsuario DECIMAL(20,0)
, NumeroReferencia DECIMAL(20,0)
, IdTipoPago DECIMAL(20,0)
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdistorialCaja=ISNULL(MAX(IdistorialCaja),0) + 1
		FROM [Caja].[HistorialCaja]
		IF(ISNULL(@IdistorialCaja,0) = 0)
		SET @IdistorialCaja = 1
			
			INSERT INTO [Caja].[HistorialCaja]
			(
				  IdistorialCaja
				, IdCaja
				, Monto
				, Concepto
				, Fecha
				, IdUsuario
				, NumeroReferencia
				, IdTipoPago
			)
				
				OUTPUT
					
					  inserted.IdistorialCaja
					, inserted.IdCaja
					, inserted.Monto
					, inserted.Concepto
					, inserted.Fecha
					, inserted.IdUsuario
					, inserted.NumeroReferencia
					, inserted.IdTipoPago
						
						INTO @ITEMS
							
							VALUES
							(
								  @IdistorialCaja
								, @IdCaja
								, @Monto
								, @Concepto
								, GETDATE()
								, @IdUsuario
								, @NumeroReferencia
								, @IdTipoPago
							)
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Caja].[SP_MANTENIMIENTO_MONEDAS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Caja].[SP_MANTENIMIENTO_MONEDAS]
  @IdMoneda DECIMAL(20,0)
, @CodigoMoneda VARCHAR(100)
, @Descripcion VARCHAR(100)
, @Sigla VARCHAR(100)
, @Tasa DECIMAL(20,2)
, @Estatus BIT
, @PorDefault BIT
, @Idusuario DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdMoneda DECIMAL(20,0)
, CodigoMoneda VARCHAR(100)
, Descripcion VARCHAR(100)
, Sigla VARCHAR(100)
, Tasa DECIMAL(20,2)
, Estatus BIT
, PorDefault BIT
, UsuarioAdiciona DECIMAL(20,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(20,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdMoneda = ISNULL(MAX(MO.IdMoneda),0) + 1
		FROM [Caja].[Moneda] MO
		IF(ISNULL(@IdMoneda,0) =0)
		SET @IdMoneda = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 21) WHERE IdSecuencial = 21

			INSERT INTO [Caja].[Moneda]
			(
				  IdMoneda
				, CodigoMoneda
				, Descripcion
				, Sigla
				, Tasa
				, Estatus
				, PorDefault
				, UsuarioAdiciona
				, FechaAdiciona
				, UsuarioModifica
				, FechaModifica
			)
				
				OUTPUT
					
					  inserted.IdMoneda
					, inserted.CodigoMoneda
					, inserted.Descripcion
					, inserted.Sigla
					, inserted.Tasa
					, inserted.Estatus
					, inserted.PorDefault
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							VALUES
							(
								  @IdMoneda
								, (SELECT
								   CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
								  FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 21)
								, @Descripcion
								, @Sigla
								, @Tasa
								, @Estatus
								, @PorDefault
								, @Idusuario
								, GETDATE()
								, @Idusuario
								, GETDATE()
							)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Caja].[Moneda] SET 
			
			  Descripcion = @Descripcion
			, Sigla = @Sigla
			, Tasa = @Tasa
			, Estatus = @Estatus
			, UsuarioModifica = @Idusuario
			, FechaModifica = GETDATE()
				
				OUTPUT
					
					  inserted.IdMoneda
					, inserted.CodigoMoneda
					, inserted.Descripcion
					, inserted.Sigla
					, inserted.Tasa
					, inserted.Estatus
					, inserted.PorDefault
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdMoneda = @IdMoneda
							AND CodigoMoneda = @CodigoMoneda
END

IF(@Accion='DEFAULT')
	
	BEGIN
		UPDATE [Caja].[Moneda] SET PorDefault = 0
		UPDATE [Caja].[Moneda] SET
			
			  PorDefault = @PorDefault
			, UsuarioModifica=@Idusuario
			, FechaModifica=GETDATE()
				
				OUTPUT
					
					  inserted.IdMoneda
					, inserted.CodigoMoneda
					, inserted.Descripcion
					, inserted.Sigla
					, inserted.Tasa
					, inserted.Estatus
					, inserted.PorDefault
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdMoneda = @IdMoneda
							AND CodigoMoneda = @CodigoMoneda
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Caja].[Moneda] SET
			
			  Estatus = 0
			, UsuarioModifica=@Idusuario
			, FechaModifica = GETDATE()
				
				OUTPUT
					
					  inserted.IdMoneda
					, inserted.CodigoMoneda
					, inserted.Descripcion
					, inserted.Sigla
					, inserted.Tasa
					, inserted.Estatus
					, inserted.PorDefault
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdMoneda = @IdMoneda
							AND CodigoMoneda = @CodigoMoneda
END

SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Caja].[SP_MOSTRAR_HISTORIAL_CAJA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Caja].[SP_MOSTRAR_HISTORIAL_CAJA]
  @FechaDesde DATE = NULL
, @FechaHasta DATE = NULL

AS

SELECT
  HC.IdistorialCaja
, HC.IdCaja
, C.Descripcion AS Caja
, HC.Monto
, HC.Concepto
, HC.Fecha AS Fecha0
, CONVERT(NVARCHAR,HC.Fecha,103) AS Fecha
, HC.IdUsuario
, UC.Persona AS CreadoPor
, HC.NumeroReferencia
, HC.IdTipoPago
, TP.Descripcion AS TipoPago
FROM [Caja].[HistorialCaja] HC
INNER JOIN [Caja].[Caja] C ON C.IdCaja = HC.IdCaja
INNER JOIN [Facturacion].[TipoPago] TP ON TP.IdTipoPago = HC.IdTipoPago
LEFT JOIN [Seguridad].[Usuario]  UC ON UC.IdUsuario = HC.IdUsuario

WHERE (
HC.Fecha >= ISNULL(@FechaDesde,HC.Fecha)
AND HC.Fecha <= ISNULL(@FechaHasta,HC.Fecha)
)

ORDER BY HC.Fecha DESC
GO
/****** Object:  StoredProcedure [Configuracion].[ConfiguracionGeneralSistema]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Configuracion].[ConfiguracionGeneralSistema]

@IdConfiguracionGeneral INT

AS

SELECT
  CG.IdConfiguracionGeneral
, CG.CantidadIntentoLogin
, CG.LlevaComprobantes
FROM [Configuracion].[ConfiguracionGeneral] CG

WHERE CG.IdConfiguracionGeneral = ISNULL(@IdConfiguracionGeneral,CG.IdConfiguracionGeneral)
GO
/****** Object:  StoredProcedure [Configuracion].[SP_BUSCA_LISTAS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Configuracion].[SP_BUSCA_LISTAS] 
   @NombreLista VARCHAR(150)
 , @PrimerFiltro VARCHAR(150) = null
 , @SegundoFiltro VARCHAR(150) =null
 , @TerceFiltro VARCHAR(150) =null
 , @CuartoFiltro VARCHAR(150) =null
 , @QuintoFiltro VARCHAR(150) =null

AS



IF (@NombreLista ='TIPOPROVEEDOR')
BEGIN 
	SELECT 
		  Descripcion = Descripcion
		 ,PrimerValor = CAST(IdTipoProveedor AS VARCHAR(150))
		 ,SegundoValor = CAST(IdTipoProveedor AS VARCHAR(150))
		 ,TerceValor = CAST('' AS VARCHAR(150))
	FROM  [Inventario].[TipoProveedor]
	ORDER BY Descripcion
END



IF (@NombreLista ='PROVEEDOR')
BEGIN 
	SELECT 
		  Descripcion = Nombre
		 ,PrimerValor = CAST(IdProveedor AS VARCHAR(150))
		 ,SegundoValor = CAST(IdTipoProveedor AS VARCHAR(150))
		 ,TerceValor = CAST('' AS VARCHAR(150))
	FROM  [Inventario].[Proveedor]
	where IdTipoProveedor = @PrimerFiltro
	ORDER BY Descripcion
END
GO
/****** Object:  StoredProcedure [Configuracion].[SP_GUARDAR_LOGO_EMPRESA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Configuracion].[SP_GUARDAR_LOGO_EMPRESA] 
  @IdLogoEmpresa DECIMAL(18,0)
, @Descripcion VARCHAR(100)
, @LogoEmpresa IMAGE

AS
--ELIMINAMOS LA IMAGEN QUE YA ESTA
DELETE FROM [Configuracion].[LogoEmpresa]

--GUARDAMOS LA IMAGEN NUEVA
INSERT INTO [Configuracion].[LogoEmpresa]
(
  IdLogoEmpresa
, Descripcion
, LogoEmpresa)

VALUES
(
	  @IdLogoEmpresa
	, @Descripcion
	, @LogoEmpresa
)
GO
/****** Object:  StoredProcedure [Configuracion].[SP_MANTENIMIENTO_INFORMACION_EMPRESA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Configuracion].[SP_MANTENIMIENTO_INFORMACION_EMPRESA]
  @IdInformacionEmpresa DECIMAL(18,0)
, @CodigoInformacionEmpresa VARCHAR(100)
, @NombreEmpresa VARCHAR(100)
, @RNC VARCHAR(50)
, @Direccion VARCHAR(8000)
, @Email VARCHAR(50)
, @Email2 VARCHAR(50)
, @Facebook VARCHAR(50)
, @Instagran VARCHAR(50)
, @Telefonos VARCHAR(100)
, @Fac VARCHAR(50)
, @IdLogoEmpresa DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdInformacionEmpresa DECIMAL(18,0)
, CodigoInformacionEmpresa VARCHAR(100)
, NombreEmpresa VARCHAR(100)
, RNC VARCHAR(50)
, Direccion VARCHAR(8000)
, Email VARCHAR(50)
, Email2 VARCHAR(50)
, Facebook VARCHAR(50)
, Instagran VARCHAR(50)
, Telefonos VARCHAR(100)
, Fac VARCHAR(50)
, IdLogoEmpresa DECIMAL(18,0)
)

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Configuracion].[InformacionEmpresa] SET
			
			  NombreEmpresa = @NombreEmpresa
			, RNC=@RNC
			, Direccion = @Direccion
			, Email=@Email
			, Email2=@Email2
			, Facebook=@Facebook
			, Instagran=@Instagran
			, Telefonos=@Telefonos
			, Fac = @Fac
				
				OUTPUT	
					
					  inserted.IdInformacionEmpresa
                    , inserted.CodigoInformacionEmpresa
                    , inserted.NombreEmpresa
                    , inserted.RNC
                    , inserted.Direccion
                    , inserted.Email
                    , inserted.Email2
                    , inserted.Facebook
                    , inserted.Instagran
                    , inserted.Telefonos
                    , inserted.Fac
                    , inserted.IdLogoEmpresa
						
						INTO @ITEMS
							
							WHERE IdInformacionEmpresa = @IdInformacionEmpresa
							AND CodigoInformacionEmpresa = @CodigoInformacionEmpresa
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Configuracion].[SP_SACAR_INFORMACION_EMPRESA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Configuracion].[SP_SACAR_INFORMACION_EMPRESA]
@IdInformacionEmpresa DECIMAL(18,0) 

AS

SELECT
  I.IdInformacionEmpresa
, I.CodigoInformacionEmpresa
, I.NombreEmpresa
, I.RNC
, I.Direccion
, I.Email
, I.Email2
, I.Facebook
, I.Instagran
, I.Telefonos
, I.Fac
, I.IdLogoEmpresa
, L.Descripcion AS DescripcionLogo
, L.LogoEmpresa
FROM [Configuracion].[InformacionEmpresa] I
INNER JOIN [Configuracion].[LogoEmpresa] L ON L.IdLogoEmpresa = I.IdLogoEmpresa

WHERE I.IdInformacionEmpresa = ISNULL(@IdInformacionEmpresa,I.IdInformacionEmpresa)
GO
/****** Object:  StoredProcedure [Contabilidad].[SP_BUSCA_COMPROBANTES_FISCALES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Contabilidad].[SP_BUSCA_COMPROBANTES_FISCALES]
@IdComprobanteFiscales DECIMAL(20,0) = NULL

AS

SELECT
  C.IdComprobante
, UPPER(C.Descripcion) AS Comprobante
, C.Serie
, c.TipoComprobante
, C.Secuencial
, C.SecuenciaInicial
, C.SecuenciaFinal
, C.Limite
, C.Estatus AS  Estatus0
, CASE C.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' END AS Estatus
, C.ValidoHasta
, C.PorDefecto AS PorDefecto0
, CASE C.PorDefecto WHEN 1 THEN 'SI' WHEN 0 THEN 'NO' END AS PorDefecto
, C.Posiciones
FROM [Contabilidad].[ComprobantesFiscales] C

WHERE C.IdComprobante = ISNULL(@IdComprobanteFiscales,C.IdComprobante)

ORDER BY C.IdComprobante ASC
GO
/****** Object:  StoredProcedure [Contabilidad].[SP_GENERAR_COMPROBANTE_FISCAL]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Contabilidad].[SP_GENERAR_COMPROBANTE_FISCAL] 
@IdComprobante DECIMAL(20,0) = 1

AS
--AUMENTAMOS LA SECUENCIA
UPDATE [Contabilidad].[ComprobantesFiscales] SET Secuencial = (SELECT MAX(Secuencial) + 1 FROM [Contabilidad].[ComprobantesFiscales] WHERE IdComprobante = @IdComprobante) WHERE IdComprobante = @IdComprobante
SELECT
  NCF.Descripcion AS TipoComprobante
, CONCAT(NCF.Serie,NCF.TipoComprobante,REPLICATE(0,(NCF.Posiciones - (LEN(NCF.Secuencial)))),NCF.Secuencial) AS Comprobante
FROM [Contabilidad].[ComprobantesFiscales] NCF

WHERE NCF.IdComprobante = ISNULL(@IdComprobante,NCF.IdComprobante)
GO
/****** Object:  StoredProcedure [Contabilidad].[SP_MANTENIMIENTO_COMPROBANTE_FISCALES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Contabilidad].[SP_MANTENIMIENTO_COMPROBANTE_FISCALES]
  @IdComprobante DECIMAL(20,0)
, @Descripcion VARCHAR(100)
, @Serie  VARCHAR(1)
, @TipoComprobante  VARCHAR(2)
, @Secuencial BIGINT
, @SecuenciaInicial BIGINT
, @SecuenciaFinal BIGINT
, @Limite BIGINT
, @Estatus BIT
, @ValidoHasta VARCHAR(50)
, @PorDefecto BIT
, @Posiciones BIGINT
, @Accion VARCHAR(150)

AS

DECLARE @ITEMS TABLE
(
  IdComprobante DECIMAL(20,0)
, Descripcion VARCHAR(100)
, Serie  VARCHAR(1)
, TipoComprobante  VARCHAR(2)
, Secuencial BIGINT
, SecuenciaInicial BIGINT
, SecuenciaFinal BIGINT
, Limite BIGINT
, Estatus BIT
, ValidoHasta VARCHAR(50)
, PorDefecto BIT
, Posiciones BIGINT
)

IF(@Accion ='UPDATE')
	
	BEGIN	
		
		IF(@PorDefecto = 1)
			
			BEGIN
				
				UPDATE [Contabilidad].[ComprobantesFiscales] SET PorDefecto = 0
			END

		UPDATE [Contabilidad].[ComprobantesFiscales] SET
			
			  Descripcion = @Descripcion
			, Serie = @Serie
			, TipoComprobante = @TipoComprobante
			, Secuencial=@Secuencial
			, SecuenciaInicial=@SecuenciaInicial
			, SecuenciaFinal=@SecuenciaFinal
			, Limite=@Limite
			, Estatus=@Estatus
			, ValidoHasta=@ValidoHasta
			, PorDefecto=@PorDefecto
			, Posiciones=@Posiciones
				
				OUTPUT
					
					  inserted.IdComprobante
                    , inserted.Descripcion
                    , inserted.Serie
                    , inserted.TipoComprobante
                    , inserted.Secuencial
                    , inserted.SecuenciaInicial
                    , inserted.SecuenciaFinal
                    , inserted.Limite
                    , inserted.Estatus
                    , inserted.ValidoHasta
                    , inserted.PorDefecto
                    , inserted.Posiciones
						
						INTO @ITEMS
							
							WHERE IdComprobante = @IdComprobante
END 
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Empresa].[SP_BUSCA_ARS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Empresa].[SP_BUSCA_ARS]
  @IdARS DECIMAL(18,0) = NULL
, @CodigoARS VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPaina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  A.IdArs
, A.CodigoARS
, A.Descripcion AS ARS
, A.Estatus AS Estatus0
, CASE A.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, A.UsuarioAdiciona
, UC.Persona AS CreadoPor
, A.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,A.FechaAdiciona,103) AS FechaAdiciona
, A.UsuarioModifica
, UM.Persona AS ModificadoPor
, A.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,A.FechaModifica,103) AS FechaModifica
FROM [Empresa].[ARS] A
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = A.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = A.UsuarioModifica

WHERE A.IdArs = ISNULL(@IdARS,A.IdArs)
AND A.CodigoARS = ISNULL(@CodigoARS,A.CodigoARS)
AND A.Descripcion LIKE '%' + ISNULL(@Descripcion,A.Descripcion) + '%'

ORDER BY A.IdArs
OFFSET(@NumeroPaina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Empresa].[SP_BUSCA_CENTRO_SALUD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Empresa].[SP_BUSCA_CENTRO_SALUD]
  @IdCentroSalud DECIMAL(18,0) = NULL
, @CodigoCentroSalud VARCHAR(100) = NULL
, @Nombre VARCHAR(100) = NULL
, @NumeroPAGINA INT = NULL
, @NumerosRegistros INT = 10

AS

SELECT
  CS.IdCentroSalud
, CS.CodigoCentroSalud
, CS.Nombre
, CS.Direccion
, CS.Telefonos
, CS.Estatus AS Estatus0
, CASE CS.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, CS.UsuarioAdiciona
, UC.Persona AS CreadoPor
, CS.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,CS.FechaAdiciona,103) AS FechaAdiciona
, CS.UsuarioModifica
, UM.Persona AS ModificadoPor
, CS.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,CS.FechaModifica,103) AS FechaModifica
FROM [Empresa].[CentroSalud] CS
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = CS.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = CS.UsuarioModifica

WHERE CS.IdCentroSalud = ISNULL(@IdCentroSalud,CS.IdCentroSalud)
AND CS.CodigoCentroSalud = ISNULL(@CodigoCentroSalud,CS.CodigoCentroSalud)
AND CS.Nombre LIKE '%' + ISNULL(@Nombre,CS.Nombre) + '%'

ORDER BY CS.IdCentroSalud
OFFSET(@NumeroPAGINA - 1) * @NumerosRegistros ROWS
FETCH NEXT @NumerosRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Empresa].[SP_BUSCA_MEDICO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Empresa].[SP_BUSCA_MEDICO]
  @IdMedico DECIMAL(18,0) = NULL
, @CodigoMedico VARCHAR(100) = NULL
, @NombreMedico VARCHAR(100) = NULL
, @IdCentroSalud DECIMAL(18,0) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  M.IdMedico
, M.CodigoMedico
, M.NombreMedico
, M.IdCentroSalud
, CS.Nombre AS CentroSalud
, M.Email
, M.Estatus AS Estatus0
, CASE CS.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, M.UsuarioAdiciona
, UC.Persona AS CreadoPor
, M.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,M.FechaAdiciona,103) AS 'FechaAdiciona'
, M.UsuarioModifica
, UM.Persona AS ModificadoPor
, M.FechaModifica AS fechaModifica0
, CONVERT(NVARCHAR,M.FechaModifica,103) AS FechaModifica
FROM [Empresa].[Medico] M
INNER JOIN [Empresa].[CentroSalud] CS ON CS.IdCentroSalud = M.IdCentroSalud
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = M.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = M.UsuarioModifica

WHERE M.IdMedico=ISNULL(@IdMedico,M.IdMedico)
AND M.CodigoMedico = ISNULL(@CodigoMedico,M.CodigoMedico)
AND M.NombreMedico LIKE '%' + ISNULL(@NombreMedico,M.NombreMedico) + '%'
AND M.IdCentroSalud = ISNULL(@IdCentroSalud,M.IdCentroSalud)

ORDER BY M.IdMedico
OFFSET(@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Empresa].[SP_BUSCA_PACIENTES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Empresa].[SP_BUSCA_PACIENTES]
  @IdPaciente DECIMAL(20,0) = NULL
, @CodigoPaciente VARCHAR(100) = NULL
, @IdComprobante DECIMAL(20,0) = NULL
, @Nombre VARCHAR(500) = NULL
, @IdCentroSalud DECIMAL(20,0) = NULL
, @IdMedico DECIMAL(20,0) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  PA.IdPaciente
, PA.CodigoPaciente
, PA.IdComprobante
, NCF.Descripcion AS Comprobante
, PA.Nombre
, PA.Telefono
, PA.IdCentroSalud
, CE.Nombre AS CentroSalud
, PA.Sala
, PA.IdMedico
, M.NombreMedico AS Medico
, PA.IdTipoIdentificacion
, TI.Descripcion AS TipoIdentificaion
, PA.TipoIdentificacion AS NumeroIdentificacion
, PA.Direccion
, PA.IdSexo
, S.Descripcion AS Sexo
, PA.Email
, PA.Comentario
, PA.Estatus AS Estatus0
, CASE PA.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' END AS Estatus
, PA.UsuarioAdiciona
, UC.Persona AS CreadoPor
, PA.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,PA.FechaAdiciona,103) AS FechaAdiciona
, PA.UsuarioModifica
, UM.Persona AS ModificadoPor
, PA.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,PA.FechaModifica,103) AS FechaModifica
FROM [Empresa].[Paciente] PA
INNER JOIN [Contabilidad].[ComprobantesFiscales] NCF ON NCF.IdComprobante = PA.IdComprobante
INNER JOIN [Empresa].[CentroSalud] CE ON CE.IdCentroSalud = PA.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdCentroSalud = PA.IdCentroSalud AND M.IdMedico = PA.IdMedico
INNER JOIN [Empresa].[TipoIdentificacion] TI ON TI.IdTipoIdentificacion = PA.IdTipoIdentificacion
INNER JOIN [Empresa].[Sexo] S ON S.IdSexo = PA.IdSexo
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = PA.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = PA.UsuarioModifica

WHERE PA.IdPaciente = ISNULL(@IdPaciente,PA.IdPaciente)
AND PA.CodigoPaciente = ISNULL(@CodigoPaciente,PA.CodigoPaciente)
AND PA.IdComprobante = ISNULL(@IdComprobante,PA.IdComprobante)
AND PA.Nombre LIKE '%' + ISNULL(@Nombre,PA.Nombre) + '%'
AND PA.IdCentroSalud = ISNULL(@IdCentroSalud,PA.IdCentroSalud)
AND PA.IdMedico = ISNULL(@IdMedico,PA.IdMedico)

ORDER BY PA.IdPaciente ASC
OFFSET(@NumeroPagina -1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Empresa].[SP_BUSCA_SALAS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [Empresa].[SP_BUSCA_SALAS]
  @IdSala DECIMAL(18,0) = NULL
, @CodigoSala VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  S.IdSala
, S.CodigoSala
, S.Descripcion AS Sala
, S.Estatus AS Estatus0
, CASE S.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, S.UsuarioAdiciona
, uc.Persona as CreadoPor
, S.FechaAdiciona AS FechaAdiciona0
, CONVERT(nvarchar,s.FechaAdiciona,103) as FechaAdiciona
, S.UsuarioModifica
, um.Persona as ModificadoPor
, S.FechaModifica as FechaModifica0
, CONVERT(nvarchar,s.FechaModifica,103) as FechaModifica
FROM [Empresa].[Sala] S
left join [Seguridad].[Usuario] uc on uc.IdUsuario = s.UsuarioAdiciona
left join [Seguridad].[Usuario] um on um.IdUsuario = s.UsuarioModifica

where s.IdSala = ISNULL(@IdSala,s.IdSala)
and s.CodigoSala = ISNULL(@CodigoSala,s.CodigoSala)
and s.Descripcion like '%' + ISNULL(@Descripcion,s.Descripcion) + '%'

order by s.IdSala
offset (@NumeroPagina - 1) * @NumeroRegistros rows
fetch next @NumeroRegistros rows only;
GO
/****** Object:  StoredProcedure [Empresa].[SP_MANTENIMIENTO_ARS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Empresa].[SP_MANTENIMIENTO_ARS]
  @IdArs DECIMAL(18,0)
, @CodigoARS VARCHAR(100)
, @Descripcion VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdArs DECIMAL(18,0)
, CodigoARS VARCHAR(100)
, Descripcion VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdArs = ISNULL(MAX(IdArs),0) + 1
		FROM [Empresa].[ARS]
		IF(ISNULL(@IdArs,0) = 0)
		SET @IdArs = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 17) WHERE IdSecuencial = 17
				
				INSERT INTO [Empresa].[ARS]
				(
					  IdArs
					, CodigoARS
					, Descripcion
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdArs
						, inserted.CodigoARS
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdArs
									, @CodigoARS
									, @Descripcion
									, @Estatus
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Empresa].[ARS] SET 
			
			  Descripcion = @Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdArs
						, inserted.CodigoARS
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdArs=@IdArs
								AND CodigoARS = @CodigoARS
END

IF(@Accion='DISABLES')
	
	BEGIN
		
		UPDATE [Empresa].[ARS] SET
			
			  Estatus=0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdArs
						, inserted.CodigoARS
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdArs = @IdArs
								AND CodigoARS = @CodigoARS
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Empresa].[SP_MANTENIMIENTO_CENTRO_SALUD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Empresa].[SP_MANTENIMIENTO_CENTRO_SALUD]
  @IdCentroSalud DECIMAL(18,0)
, @CodigoCentroSalud VARCHAR(100)
, @Nombre VARCHAR(100)
, @Direccion VARCHAR(8000)
, @Telefonos VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdCentroSalud DECIMAL(18,0)
, CodigoCentroSalud VARCHAR(100)
, Nombre VARCHAR(100)
, Direccion VARCHAR(8000)
, Telefonos VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdCentroSalud=ISNULL(MAX(IdCentroSalud),0) + 1
		FROM [Empresa].[CentroSalud]
		IF(ISNULL(@IdCentroSalud,0) = 0)
		SET @IdCentroSalud = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 10) WHERE IdSecuencial = 10
				
				INSERT INTO [Empresa].[CentroSalud]
				(
					  IdCentroSalud
					, CodigoCentroSalud
					, Nombre
					, Direccion
					, Telefonos
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdCentroSalud
						, inserted.CodigoCentroSalud
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefonos
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdCentroSalud
									, (SELECT
									  CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
									  FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 10)
									, @Nombre
									, @Direccion
									, @Telefonos
									, @Estatus
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Empresa].[CentroSalud] SET
			
			  Nombre=@Nombre
			, Direccion=@Direccion
			, Telefonos=@Telefonos
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				


				OUTPUT
						
						  inserted.IdCentroSalud
						, inserted.CodigoCentroSalud
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefonos
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdCentroSalud = @IdCentroSalud
								AND CodigoCentroSalud = @CodigoCentroSalud
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Empresa].[CentroSalud] SET
			
			  Estatus = 0
			, UsuarioModifica = @IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdCentroSalud
						, inserted.CodigoCentroSalud
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefonos
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdCentroSalud = @IdCentroSalud
								AND CodigoCentroSalud = @CodigoCentroSalud
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Empresa].[SP_MANTENIMIENTO_MEDICO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Empresa].[SP_MANTENIMIENTO_MEDICO]
  @IdMedico DECIMAL(18,0)
, @CodigoMedico VARCHAR(100)
, @NombreMedico VARCHAR(100)
, @IdCentroSalud DECIMAL(18,0)
, @Email VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdMedico DECIMAL(18,0)
, CodigoMedico VARCHAR(100)
, NombreMedico VARCHAR(100)
, IdCentroSalud DECIMAL(18,0)
, Email VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdMedico=ISNULL(MAX(IdMedico),0) + 1
		FROM [Empresa].[Medico]
		IF(ISNULL(@IdMedico,0) = 0)
		SET @IdMedico = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 11) WHERE IdSecuencial = 11
			
			INSERT INTO [Empresa].[Medico]
			(
				  IdMedico
				, CodigoMedico
				, NombreMedico
				, IdCentroSalud
				, Email
				, Estatus
				, UsuarioAdiciona
				, FechaAdiciona
				, UsuarioModifica
				, FechaModifica
			)
				OUTPUT
					
					  inserted.IdMedico
					, inserted.CodigoMedico
					, inserted.NombreMedico
					, inserted.IdCentroSalud
					, inserted.Email
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							VALUES
							(
								  @IdMedico
								, (SELECT
								 CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
								  FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 11)
								, @NombreMedico
								, @IdCentroSalud
								, @Email
								, @Estatus
								, @IdUsuario
								, GETDATE()
								, @IdUsuario
								, GETDATE()
							)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Empresa].[Medico] SET
			
			  NombreMedico=@NombreMedico
			, IdCentroSalud=@IdCentroSalud
			, Email=@Email
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
					
					  inserted.IdMedico
					, inserted.CodigoMedico
					, inserted.NombreMedico
					, inserted.IdCentroSalud
					, inserted.Email
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdMedico = @IdMedico
							AND CodigoMedico = @CodigoMedico
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Empresa].[Medico] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
					
					  inserted.IdMedico
					, inserted.CodigoMedico
					, inserted.NombreMedico
					, inserted.IdCentroSalud
					, inserted.Email
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdMedico=@IdMedico
							AND CodigoMedico = @CodigoMedico
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Empresa].[SP_MANTENIMIENTO_PACIENTES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Empresa].[SP_MANTENIMIENTO_PACIENTES]
  @IdPaciente DECIMAL(20,0)
, @CodigoPaciente VARCHAR(100)
, @IdComprobante DECIMAL(20,0)
, @Nombre VARCHAR(500)
, @Telefono VARCHAR(50)
, @IdCentroSalud DECIMAL(20,0)
, @Sala VARCHAR(100)
, @IdMedico DECIMAL(20,0)
, @IdTipoIdentificacion DECIMAL(20,0)
, @TipoIdentificacion VARCHAR(100)
, @Direccion VARCHAR(8000)
, @IdSexo DECIMAL(20,0)
, @Email VARCHAR(100)
, @Comentario VARCHAR(8000)
, @Estatus BIT
, @IdUsuario DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdPaciente DECIMAL(20,0)
, CodigoPaciente VARCHAR(100)
, IdComprobante DECIMAL(20,0)
, Nombre VARCHAR(500)
, Telefono VARCHAR(100)
, IdCentroSalud DECIMAL(20,0)
, Sala VARCHAR(100)
, IdMedico DECIMAL(20,0)
, IdTipoIdentificacion DECIMAL(20,0)
, TipoIdentificacion VARCHAR(100)
, Direccion VARCHAR(8000)
, IdSexo DECIMAL(20,0)
, Email VARCHAR(100)
, Comentario VARCHAR(8000)
, Estatus BIT
, UsuarioAdiciona DECIMAL(20,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(20,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdPaciente=ISNULL(MAX(IdPaciente),0) + 1
		FROM [Empresa].[Paciente]
		IF(ISNULL(@IdPaciente,0) = 0)
		SET @IdPaciente = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 12) WHERE IdSecuencial = 12

			INSERT INTO [Empresa].[Paciente]
			(
				
				 IdPaciente
               , CodigoPaciente
               , IdComprobante
               , Nombre
               , Telefono
               , IdCentroSalud
               , Sala
               , IdMedico
               , IdTipoIdentificacion
               , TipoIdentificacion
               , Direccion
               , IdSexo
               , Email
               , Comentario
               , Estatus
               , UsuarioAdiciona
               , FechaAdiciona
               , UsuarioModifica
               , FechaModifica
		)
					OUTPUT
					 	
						 inserted.IdPaciente
                       , inserted.CodigoPaciente
                       , inserted.IdComprobante
                       , inserted.Nombre
                       , inserted.Telefono
                       , inserted.IdCentroSalud
                       , inserted.Sala
                       , inserted.IdMedico
                       , inserted.IdTipoIdentificacion
                       , inserted.TipoIdentificacion
                       , inserted.Direccion
                       , inserted.IdSexo
                       , inserted.Email
                       , inserted.Comentario
                       , inserted.Estatus
                       , inserted.UsuarioAdiciona
                       , inserted.FechaAdiciona
                       , inserted.UsuarioModifica
                       , inserted.FechaModifica
						
						INTO @ITEMS
						
						VALUES
						(
							@IdPaciente
							,(SELECT
							CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
								FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 12)
								, @IdComprobante
								, @Nombre
								, @Telefono
								, @IdCentroSalud
								, @Sala
								, @IdMedico
								, @IdTipoIdentificacion
								, @TipoIdentificacion
								, @Direccion
								, @IdSexo
								, @Email
								, @Comentario
								, @Estatus
								, @IdUsuario
								, GETDATE()
								, @IdUsuario
								, GETDATE()
							)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Empresa].[Paciente] SET
			
			  IdComprobante = @IdComprobante
			, Nombre = @Nombre
			, Telefono = @Telefono
			, IdCentroSalud=@IdCentroSalud
			, Sala=@Sala
			, IdMedico = @IdMedico
			, IdTipoIdentificacion = @IdTipoIdentificacion
			, TipoIdentificacion = @TipoIdentificacion
			, Direccion=@Direccion
			, IdSexo = @IdSexo
			, Email = @Email
			, Comentario = @Comentario
			, Estatus = @Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
					 	
						 inserted.IdPaciente
                       , inserted.CodigoPaciente
                       , inserted.IdComprobante
                       , inserted.Nombre
                       , inserted.Telefono
                       , inserted.IdCentroSalud
                       , inserted.Sala
                       , inserted.IdMedico
                       , inserted.IdTipoIdentificacion
                       , inserted.TipoIdentificacion
                       , inserted.Direccion
                       , inserted.IdSexo
                       , inserted.Email
                       , inserted.Comentario
                       , inserted.Estatus
                       , inserted.UsuarioAdiciona
                       , inserted.FechaAdiciona
                       , inserted.UsuarioModifica
                       , inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdPaciente = @IdPaciente
							AND CodigoPaciente = @CodigoPaciente
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Empresa].[Paciente] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
					 	
						 inserted.IdPaciente
                       , inserted.CodigoPaciente
                       , inserted.IdComprobante
                       , inserted.Nombre
                       , inserted.Telefono
                       , inserted.IdCentroSalud
                       , inserted.Sala
                       , inserted.IdMedico
                       , inserted.IdTipoIdentificacion
                       , inserted.TipoIdentificacion
                       , inserted.Direccion
                       , inserted.IdSexo
                       , inserted.Email
                       , inserted.Comentario
                       , inserted.Estatus
                       , inserted.UsuarioAdiciona
                       , inserted.FechaAdiciona
                       , inserted.UsuarioModifica
                       , inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdPaciente = @IdPaciente
							AND CodigoPaciente = @CodigoPaciente
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Empresa].[SP_MANTENIMIENTO_SALAS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [Empresa].[SP_MANTENIMIENTO_SALAS]
  @IdSala decimal(18,0)
, @CodigoSala varchar(100)
, @Descripcion varchar(100)
, @Estatus bit
, @IdUsuario decimal(18,0)
, @Accion varchar(150) = 'insert'

as

declare @items table
(
  IdSala decimal(18,0)
, CodigoSala varchar(100)
, Descripcion varchar(100)
, Estatus bit
, UsuarioAdiciona decimal(18,0)
, FechaAdiciona date
, UsuarioModifica decimal(18,0)
, FechaModifica date
)

if(@Accion='INSERT')
	
	begin
		
		select
		@IdSala=ISNULL(max(IdSala),0) + 1
		from [Empresa].[Sala]
		if(ISNULL(@IdSala,0) = 0)
		set @IdSala = 1
			
			update [Configuracion].[Secuencial] set Secuencia = (select max(Secuencia) + 1 from [Configuracion].[Secuencial] where IdSecuencial = 18) where IdSecuencial = 18
				
				insert into [Empresa].[Sala]
				(
					  IdSala
					, CodigoSala
					, Descripcion
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					output
						
						  inserted.IdSala
						, inserted.CodigoSala
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							into @items
								
								values
								(
									  @IdSala
									, @CodigoSala
									, @Descripcion
									, @Estatus
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
end

if(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Empresa].[Sala] SET
			
			  Descripcion=@Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				output
						
						  inserted.IdSala
						, inserted.CodigoSala
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							into @items
								
								WHERE IdSala=@IdSala
								AND CodigoSala = @CodigoSala
END

IF(@Accion='DISABLE')
	
	
	BEGIN
		
		UPDATE [Empresa].[Sala] SET
			
			  Descripcion=@Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				output
						
						  inserted.IdSala
						, inserted.CodigoSala
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							into @items
								
								WHERE IdSala=@IdSala
								AND CodigoSala = @CodigoSala
END
SELECT * FROM @items
GO
/****** Object:  StoredProcedure [Facturacion].[SP_BUSCA_DATOS_FACTURACION_ESPEJO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_BUSCA_DATOS_FACTURACION_ESPEJO]
  @NumeroConector DECIMAL(20,0) = NULL
, @IdUsuario DECIMAL(20,0) = NULL

AS

SELECT
  DFE.NumeroConector
, DFE.IdUsuario
, U.Persona AS Usuario
, DFE.IdTipoFacturacion
, TF.Descripcion AS TipoFacturacion
, DFE.NombrePaciente
, DFE.Telefono
, DFE.IdCentroSalud
, CS.Nombre AS CentroSalud
, DFE.Sala
, DFE.IdMedico
, M.NombreMedico AS Medico
, DFE.IdTipoIdentificacion
, TI.Descripcion AS TipoIdentificacion
, DFE.NumeroIdentificacion
, DFE.Direccion
, DFE.IdSexo
, S.Descripcion AS Sexo
, DFE.Email
, DFE.Comentario
, DFE.GuardarCliente
, DFE.TipoProceso
, DFE.IdTipoPago
, TP.Descripcion AS TipoPago
, DFE.IdEstatusirugia
, EC.Descripcion AS EstatusCirugia
FROM [Facturacion].[DatosFacturacionEspejo] DFE
INNER JOIN [Contabilidad].[ComprobantesFiscales] TF ON TF.IdComprobante = DFE.IdTipoFacturacion
INNER JOIN [Empresa].[CentroSalud] CS ON CS.IdCentroSalud = DFE.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdCentroSalud = DFE.IdCentroSalud AND M.IdMedico = DFE.IdMedico
INNER JOIN [Empresa].[TipoIdentificacion] TI ON TI.IdTipoIdentificacion = DFE.IdTipoIdentificacion
INNER JOIN [Empresa].[Sexo] S ON S.IdSexo = DFE.IdSexo
INNER JOIN [Facturacion].[TipoPago] TP ON TP.IdTipoPago = DFE.IdTipoPago
INNER JOIN [Facturacion].[EstatusCirugia] EC ON EC.IdEstatusCirugia = DFE.IdEstatusirugia
LEFT JOIN [Seguridad].[Usuario] U ON U.IdUsuario = DFE.IdUsuario

WHERE DFE.NumeroConector = ISNULL(@NumeroConector,DFE.NumeroConector)
AND DFE.IdUsuario = ISNULL(@IdUsuario,DFE.IdUsuario)
GO
/****** Object:  StoredProcedure [Facturacion].[SP_BUSCA_PRODUCTOS_AGREGADOS_FACTURA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_BUSCA_PRODUCTOS_AGREGADOS_FACTURA] --1
  @NumeroConector DECIMAL(20,0) = NULL
, @Secuencial DECIMAL(38,0) = NULL

AS

SELECT
  FP.NumeroConector
, FP.IdProducto
, PRO.CodigoProducto
, PRO.Descripcion
, PRO.PrecioCompra
, FP.Precio
, PRO.LlevaDescuento AS LlevaDescuento0
, CASE PRO.LlevaDescuento WHEN 1 THEN 'SI' WHEN 0 THEN 'NO' END AS LlevaDescuento
, PRO.PorcientoDescuento
, FP.Cantidad
, FP.DescuentoAplicado
, FP.Total
, FP.Secuencial
, FP.NumeroPago
FROM [Facturacion].[FacturacionpProducto] FP
INNER JOIN [Inventario].[Producto] PRO ON PRO.IdProducto = FP.IdProducto

WHERE FP.NumeroConector = ISNULL(@NumeroConector,FP.NumeroConector)
AND FP.Secuencial = ISNULL(@Secuencial,FP.Secuencial)
GO
/****** Object:  StoredProcedure [Facturacion].[SP_BUSCA_PROGRAMACION_CIRUGIA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_BUSCA_PROGRAMACION_CIRUGIA]
  @IdProgramacionCirugia DECIMAL(20,0) = NULL
, @FechaDesde DATE = NULL
, @FechaHasta DATE = NULL
, @IdCentroSalud DECIMAL(20,0) = NULL
, @IdMedico DECIMAL(20,0) = NULL
, @IdEstatusCirugia DECIMAL(20,0) = NULL
, @NumeroFactura DECIMAL(20,0) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10 
AS

SELECT
  PRO.IdProgramacionCirugia
, PRO.FechaCirugia AS FechaCirugia0
, CONVERT(NVARCHAR,PRO.FechaCirugia,103) AS FechaCirugia
, PRO.IdCentroSalud
, UPPER(CE.Nombre) AS CentroSalud
, PRO.IdMedico
, UPPER(M.NombreMedico) AS NombreMedico
, PRO.IdEstatusCirugia
, UPPER(EC.Descripcion) AS Estatus
, PRO.NoFactura
, PRO.NoReferencia
, PRO.UsuarioAdiciona
, UPPER(UC.Persona) AS CreadoPor
, PRO.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,PRO.FechaAdiciona,103) AS FechaAdiciona
, PRO.UsuarioModifica
, UPPER(um.Persona) AS ModificadoPor
, PRO.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,PRO.FechaModifica,103) AS FechaModifica
, FCLI.IdTipoFacturacion
, NCF.Descripcion AS TipoComprobante
, FNCF.Comprobante
, UPPER(FCLI.NombrePaciente) AS Paciente
, FCLI.Telefono
, FCLI.IdCentroSalud AS IdCentroSaludAnterior
, FCLI.Sala
, FCLI.IdMedico AS IdMedicoAnterior
, FCLI.IdTipoIdentificacion
, FCLI.NumeroIdentificacion
, FCLI.Direccion
, FCLI.IdSexo
, FCLI.Email
, FCLI.ComentarioPaciente
, FCLI.FechaFacturacion AS FechaFacturacion0
, CONVERT(NVARCHAR,FCLI.FechaFacturacion,103) AS FechaFacturacion
, FCLI.IdUsuario
FROM [Facturacion].[ProgramacionCirugia] PRO
INNER JOIN [Empresa].[CentroSalud] CE ON CE.IdCentroSalud = PRO.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdMedico = PRO.IdMedico
INNER JOIN [Facturacion].[EstatusCirugia] EC ON EC.IdEstatusCirugia = PRO.IdEstatusCirugia
INNER JOIN [Facturacion].[FacturacionCliente] FCLI ON FCLI.NumeroFactura = PRO.NoFactura
INNER JOIN [Contabilidad].[ComprobantesFiscales] NCF ON NCF.IdComprobante = FCLI.IdTipoFacturacion
INNER JOIN [Facturacion].[FacturacionComprobante] FNCF ON FNCF.NumeroConector = PRO.NoReferencia
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = PRO.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = PRO.UsuarioModifica

WHERE PRO.IdProgramacionCirugia = ISNULL(@IdProgramacionCirugia,PRO.IdProgramacionCirugia)
AND 
(
PRO.FechaCirugia >= ISNULL(@FechaDesde,PRO.FechaCirugia)
AND PRO.FechaCirugia <= ISNULL(@FechaHasta,PRO.FechaCirugia)
)
AND PRO.IdCentroSalud = ISNULL(@IdCentroSalud,PRO.IdCentroSalud)
AND PRO.IdMedico = ISNULL(@IdMedico,PRO.IdMedico)
AND PRO.IdEstatusCirugia=ISNULL(@IdEstatusCirugia,PRO.IdEstatusCirugia)
AND PRO.NoFactura = ISNULL(@NumeroFactura,PRO.NoFactura)

ORDER BY PRO.IdProgramacionCirugia ASC
OFFSET(@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;



GO
/****** Object:  StoredProcedure [Facturacion].[SP_BUSCA_TIPO_PAGO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_BUSCA_TIPO_PAGO]
  @IdTipoPago DECIMAL(20,0) = NULL
, @CodigoTipoPago VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  TF.IdTipoPago
, TF.CodigoTipoPago
, TF.Descripcion AS TipoPago
, TF.Estatus AS Estatus0
, CASE TF.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' END AS Estatus
, TF.BloqueaMontoPagar AS BloqueaMontoPagar0
, CASE TF.BloqueaMontoPagar WHEN 1 THEN 'SI' WHEN 0 THEN 'NO' END AS BloqueaMontoPagar
, TF.UsuarioAdiciona
, TF.FechaAdiciona AS FechaAdiciona0
, UC.Persona AS CreadoPor
, CONVERT(NVARCHAR,TF.FechaAdiciona,103) AS FechaAdiciona
, TF.UsuarioModifica
, UM.Persona AS ModificadoPor
, TF.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,TF.FechaModifica,103) AS FechaModifica
FROM [Facturacion].[TipoPago] TF
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = TF.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = TF.UsuarioModifica

WHERE TF.IdTipoPago=ISNULL(@IdTipoPago,TF.IdTipoPago)
AND TF.CodigoTipoPago = ISNULL(@CodigoTipoPago,TF.CodigoTipoPago)
AND TF.Descripcion LIKE '%' + ISNULL(@Descripcion,TF.Descripcion) + '%'

ORDER BY TF.IdTipoPago ASC
OFFSET (@NumeroPagina -1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Facturacion].[SP_GUARDAR_DATOS_FACTURACION_CALCULOS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_GUARDAR_DATOS_FACTURACION_CALCULOS]
  @NumeroConector DECIMAL(20,0)
, @CantidadArticulos DECIMAL(20,0)
, @TotalDescuento DECIMAL(20,2)
, @Subtotal DECIMAL(20,2)
, @Impuesto DECIMAL(20,2)
, @Total DECIMAL(20,2)
, @IdTipoPago DECIMAL(20,0)
, @MontoPagado DECIMAL(20,2)
, @IdEstatusCirugia DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  NumeroConector DECIMAL(20,0)
, CantidadArticulos DECIMAL(20,0)
, TotalDescuento DECIMAL(20,2)
, Subtotal DECIMAL(20,2)
, Impuesto DECIMAL(20,2)
, Total DECIMAL(20,2)
, IdTipoPago DECIMAL(20,0)
, MontoPagado DECIMAL(20,2)
, IdEstatusCirugia DECIMAL(20,0)
)

IF(@Accion='INSERT')
	
	BEGIN
		
		INSERT INTO [Facturacion].[FacturacionCalculos]
		(
			  NumeroConector
			, CantidadArticulos
			, TotalDescuento
			, Subtotal
			, Impuesto
			, Total
			, IdTipoPago
			, MontoPagado
			, IdEstatusCirugia
		)
			
			OUTPUT
				
				  inserted.NumeroConector
				, inserted.CantidadArticulos
				, inserted.TotalDescuento
				, inserted.Subtotal
				, inserted.Impuesto
				, inserted.Total
				, inserted.IdTipoPago
				, inserted.MontoPagado
				, inserted.IdEstatusCirugia
					
					INTO @ITEMS
						
						VALUES
						(
							  @NumeroConector
							, @CantidadArticulos
							, @TotalDescuento
							, @Subtotal
							, @Impuesto
							, @Total
							, @IdTipoPago
							, @MontoPagado
							, @IdEstatusCirugia
						)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Facturacion].[FacturacionCalculos] SET
			
			  CantidadArticulos = @CantidadArticulos
			, TotalDescuento = @TotalDescuento
			, Subtotal = @Subtotal
			, Impuesto = @Impuesto
			, Total = @Total
			, IdTipoPago = @IdTipoPago
			, MontoPagado = @MontoPagado
			, IdEstatusCirugia = @IdEstatusCirugia
				
				OUTPUT
				
				  inserted.NumeroConector
				, inserted.CantidadArticulos
				, inserted.TotalDescuento
				, inserted.Subtotal
				, inserted.Impuesto
				, inserted.Total
				, inserted.IdTipoPago
				, inserted.MontoPagado
				, inserted.IdEstatusCirugia
					
					INTO @ITEMS
						
						WHERE NumeroConector = @NumeroConector
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Facturacion].[SP_GUARDAR_DATOS_FACTURACION_CLIENTE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Facturacion].[SP_GUARDAR_DATOS_FACTURACION_CLIENTE]
  @NumeroFactura DECIMAL(20,0)
, @IdEstatusFacturacion DECIMAL(20,0)
, @CodigoFacturacion VARCHAR(100)
, @NumeroConector DECIMAL(20,0)
, @IdTipoFacturacion DECIMAL(20,0)
, @NombrePaciente VARCHAR(100)
, @Telefono VARCHAR(30)
, @IdCentroSalud DECIMAL(20,0)
, @Sala VARCHAR(200)
, @IdMedico DECIMAL(20,0)
, @IdTipoIdentificacion DECIMAL(20,0)
, @NumeroIdentificacion VARCHAR(100)
, @Direccion VARCHAR(8000)
, @IdSexo DECIMAL(20,0)
, @Email VARCHAR(100)
, @ComentarioPaciente VARCHAR(8000)
, @FechaFacturacion DATE
, @IdUsuario DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'
AS

DECLARE @ITEMS TABLE
(
  NumeroFactura DECIMAL(20,0)
, IdEstatusFacturacion DECIMAL(20,0)
, CodigoFacturacion VARCHAR(100)
, NumeroConector DECIMAL(20,0)
, IdTipoFacturacion DECIMAL(20,0)
, NombrePaciente VARCHAR(100)
, Telefono VARCHAR(30)
, IdCentroSalud DECIMAL(20,0)
, Sala VARCHAR(200)
, IdMedico DECIMAL(20,0)
, IdTipoIdentificacion DECIMAL(20,0)
, NumeroIdentificacion VARCHAR(100)
, Direccion VARCHAR(8000)
, IdSexo DECIMAL(20,0)
, Email VARCHAR(100)
, ComentarioPaciente VARCHAR(8000)
, FechaFacturacion DATE
, IdUsuario DECIMAL(20,0)
)

IF(@Accion='INSERT')
	
	BEGIN

		SELECT
		@NumeroFactura = ISNULL(MAX(NumeroFactura),0) + 1
		FROM [Facturacion].[FacturacionCliente]
		IF(ISNULL(@NumeroFactura,0) = 0)
		SET @NumeroFactura = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 20) WHERE IdSecuencial = 20
			INSERT INTO [Facturacion].[FacturacionCliente]
			(
				  NumeroFactura
				, IdEstatusFacturacion
                , CodigoFacturacion
                , NumeroConector
                , IdTipoFacturacion
                , NombrePaciente
                , Telefono
                , IdCentroSalud
                , Sala
                , IdMedico
                , IdTipoIdentificacion
                , NumeroIdentificacion
                , Direccion
                , IdSexo
                , Email
                , ComentarioPaciente
                , FechaFacturacion
                , IdUsuario
			)
				
				OUTPUT
					
					  inserted.NumeroFactura
					, inserted.IdEstatusFacturacion
                    , inserted.CodigoFacturacion
                    , inserted.NumeroConector
                    , inserted.IdTipoFacturacion
                    , inserted.NombrePaciente
                    , inserted.Telefono
                    , inserted.IdCentroSalud
                    , inserted.Sala
                    , inserted.IdMedico
                    , inserted.IdTipoIdentificacion
                    , inserted.NumeroIdentificacion
                    , inserted.Direccion
                    , inserted.IdSexo
                    , inserted.Email
                    , inserted.ComentarioPaciente
                    , inserted.FechaFacturacion
                    , inserted.IdUsuario
						
						INTO @ITEMS

							VALUES
							(
								  @NumeroFactura
								, @IdEstatusFacturacion
								, (SELECT CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR)) FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 20)
								, @NumeroConector
								, @IdTipoFacturacion
								, @NombrePaciente
								, @Telefono
								, @IdCentroSalud
								, @Sala
								, @IdMedico
								, @IdTipoIdentificacion
								, @NumeroIdentificacion
								, @Direccion
								, @IdSexo
								, @Email
								, @ComentarioPaciente
								, @FechaFacturacion
								, @IdUsuario
							)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Facturacion].[FacturacionCliente] SET 
			
			  NombrePaciente = @NombrePaciente
			, Telefono = @Telefono
			, IdCentroSalud = @IdCentroSalud
			, Sala = @Sala
			, IdMedico = @IdMedico
			, IdTipoIdentificacion = @IdTipoIdentificacion
			, NumeroIdentificacion = @NumeroIdentificacion
			, Direccion = @Direccion
			, IdSexo = @IdSexo
			, Email = @Email
			, ComentarioPaciente = @ComentarioPaciente
				
				OUTPUT
					
					  inserted.NumeroFactura
					, inserted.IdEstatusFacturacion
                    , inserted.CodigoFacturacion
                    , inserted.NumeroConector
                    , inserted.IdTipoFacturacion
                    , inserted.NombrePaciente
                    , inserted.Telefono
                    , inserted.IdCentroSalud
                    , inserted.Sala
                    , inserted.IdMedico
                    , inserted.IdTipoIdentificacion
                    , inserted.NumeroIdentificacion
                    , inserted.Direccion
                    , inserted.IdSexo
                    , inserted.Email
                    , inserted.ComentarioPaciente
                    , inserted.FechaFacturacion
                    , inserted.IdUsuario
						
						INTO @ITEMS
							WHERE NumeroFactura = @NumeroFactura
							AND CodigoFacturacion = @CodigoFacturacion
							AND NumeroConector = @NumeroConector
END

IF(@Accion='CHANGESTATUS')
	
	BEGIN
		
		UPDATE [Facturacion].[FacturacionCliente] SET
			
			IdEstatusFacturacion = 1
				
				OUTPUT
					
					  inserted.NumeroFactura
					, inserted.IdEstatusFacturacion
                    , inserted.CodigoFacturacion
                    , inserted.NumeroConector
                    , inserted.IdTipoFacturacion
                    , inserted.NombrePaciente
                    , inserted.Telefono
                    , inserted.IdCentroSalud
                    , inserted.Sala
                    , inserted.IdMedico
                    , inserted.IdTipoIdentificacion
                    , inserted.NumeroIdentificacion
                    , inserted.Direccion
                    , inserted.IdSexo
                    , inserted.Email
                    , inserted.ComentarioPaciente
                    , inserted.FechaFacturacion
                    , inserted.IdUsuario
						
						INTO @ITEMS
							WHERE  NumeroConector = @NumeroConector
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Facturacion].[SP_GUARDAR_FACTURACION_COMPROBANTES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_GUARDAR_FACTURACION_COMPROBANTES]
  @IdFacturacion DECIMAL(20,0)
, @CodigoFacturacion VARCHAR(100)
, @NumeroConector DECIMAL(20,0)
, @TipoComprobante VARCHAR(100)
, @Comprobante VARCHAR(100)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdFacturacion DECIMAL(20,0)
, CodigoFacturacion VARCHAR(100)
, NumeroConector DECIMAL(20,0)
, TipoComprobante VARCHAR(100)
, Comprobante VARCHAR(100)
)

IF(@Accion='INSERT')
	
	BEGIN
		
		UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 22) WHERE IdSecuencial = 22
		INSERT INTO [Facturacion].[FacturacionComprobante]
		(
			  IdFacturacion
			, CodigoFacturacion
			, NumeroConector
			, TipoComprobante
			, Comprobante
		)
			
			OUTPUT
				
				  inserted.IdFacturacion
				, inserted.CodigoFacturacion
				, inserted.NumeroConector
				, inserted.TipoComprobante
				, inserted.Comprobante	
					
					INTO @ITEMS
						
						VALUES
						(
							  (SELECT NumeroFactura FROM [Facturacion].[FacturacionCliente] WHERE NumeroConector = @NumeroConector)
							, (SELECT CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR)) FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 22)
							, @NumeroConector
							, @TipoComprobante
							, @Comprobante
						)
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Facturacion].[SP_GUARDAR_FACTURACION_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_GUARDAR_FACTURACION_PRODUCTO]
  @NumeroConector DECIMAL(20,0)
, @IdProducto DECIMAL(20,0)
, @Precio DECIMAL(20,2)
, @Cantidad DECIMAL(20,0)
, @DescuentoAplicado DECIMAL(20,2)
, @Total DECIMAL(20,2)
, @Secuencial DECIMAL(38,0)
, @NumeroPago DECIMAL(1,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  NumeroConector DECIMAL(20,0)
, IdProducto DECIMAL(20,0)
, Precio DECIMAL(20,2)
, Cantidad DECIMAL(20,0)
, DescuentoAplicado DECIMAL(20,2)
, Total DECIMAL(20,2)
, Secuencial DECIMAL(38,0)
, NumeroPago DECIMAL(1,0)
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@Secuencial = ISNULL(MAX(Secuencial),0) + 1
		FROM [Facturacion].[FacturacionpProducto]
		IF(ISNULL(@Secuencial,0) = 0)
		SET @Secuencial = 1

		INSERT INTO [Facturacion].[FacturacionpProducto]
		(
			  NumeroConector
			, IdProducto
			, Precio
			, Cantidad
			, DescuentoAplicado
			, Total
			, Secuencial
			, NumeroPago
		)
			
			OUTPUT
				
				  inserted.NumeroConector
				, inserted.IdProducto
				, inserted.Precio
				, inserted.Cantidad
				, inserted.DescuentoAplicado
				, inserted.Total
				, inserted.Secuencial
				, inserted.NumeroPago
					
					INTO @ITEMS
						
						VALUES
						(
							  @NumeroConector
							, @IdProducto
							, @Precio
							, @Cantidad
							, @DescuentoAplicado
							, ((@Precio * @Cantidad) - @DescuentoAplicado)
							, @Secuencial
							, @NumeroPago
						)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Facturacion].[FacturacionpProducto] SET
			
			  IdProducto = @IdProducto
			, Precio = @Precio
			, Cantidad = @Cantidad
			, DescuentoAplicado=@DescuentoAplicado
			, Total = ((@Precio * @Cantidad) - @DescuentoAplicado)
			, NumeroPago = @NumeroPago
			--, Total=@Total
				
				OUTPUT
				
				  inserted.NumeroConector
				, inserted.IdProducto
				, inserted.Precio
				, inserted.Cantidad
				, inserted.DescuentoAplicado
				, inserted.Total
				, inserted.Secuencial
				, inserted.NumeroPago
					
					INTO @ITEMS
						
						WHERE NumeroConector = @NumeroConector
						AND Secuencial = @Secuencial
END
IF(@Accion='DELETE')
	
	BEGIN
		
		DELETE FROM [Facturacion].[FacturacionpProducto]
			
			OUTPUT
				
				  deleted.NumeroConector
				, deleted.IdProducto
				, deleted.Precio
				, deleted.Cantidad
				, deleted.DescuentoAplicado
				, deleted.Total
				, deleted.Secuencial
				, deleted.NumeroPago
					
					INTO @ITEMS
						
						WHERE NumeroConector = @NumeroConector
						AND Secuencial = @Secuencial
END
IF(@Accion='DATAUPDATE')
	BEGIN
		
		UPDATE [Facturacion].[FacturacionpProducto] SET DescuentoAplicado = 0 WHERE NumeroConector = @NumeroConector
		UPDATE [Facturacion].[FacturacionpProducto] SET
			
			DescuentoAplicado = @DescuentoAplicado
		    ,Total=((@Precio * @Cantidad) - @DescuentoAplicado)
				
				OUTPUT
				
				  inserted.NumeroConector
				, inserted.IdProducto
				, inserted.Precio
				, inserted.Cantidad
				, inserted.DescuentoAplicado
				, inserted.Total
				, inserted.Secuencial
				, inserted.NumeroPago
					
					INTO @ITEMS
						
						WHERE NumeroConector = @NumeroConector
						AND Secuencial = (SELECT MAX(Secuencial) FROM [Facturacion].[FacturacionpProducto] WHERE NumeroConector = @NumeroConector)	
						END

SELECT * FROM @ITEMS



GO
/****** Object:  StoredProcedure [Facturacion].[SP_HISTORIAL_FACTURACION_COTIZACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_HISTORIAL_FACTURACION_COTIZACION]
  @NumeroFactura DECIMAL(20,0) = NULL
, @IdEstatusfACTURACION DECIMAL(20,0) = NULL
, @CodigoFacturacion VARCHAR(100) = NULL
, @NumeroConector DECIMAL(20,0) = NULL
, @IdTipoFacturacion DECIMAL(20,0) = NULL
, @NombrePaciente VARCHAR(100) = NULL
, @IdCentroSalud DECIMAL(20,0) = NULL
, @IdMedico DECIMAL(20,0) = NULL

AS

SELECT
  FCLI.NumeroFactura
, FCLI.IdEstatusFacturacion AS IdEstatusFacturacion0
, EF.Estatus AS EstatusFacturacion
, FCLI.CodigoFacturacion
, FCLI.NumeroConector
, FCLI.IdTipoFacturacion AS IdTipoFacturacion0
, NCF.Descripcion AS TipoComprobante
, NCF.ValidoHasta
, FC.Comprobante
, FCLI.NombrePaciente
, FCLI.Telefono
, FCLI.IdCentroSalud AS IdCentroSalud0
, CE.Nombre AS CentroSalud
, FCLI.Sala
, FCLI.IdMedico AS IdMedico0
, M.NombreMedico
, FCLI.IdTipoIdentificacion AS IdTipoIdentificacion0
, TI.Descripcion AS TipoIdentificacion
, FCLI.NumeroIdentificacion
, FCLI.Direccion
, FCLI.IdSexo AS IdSexo0 
, S.Descripcion AS Sexo
, FCLI.Email
, FCLI.ComentarioPaciente
, FCLI.FechaFacturacion AS FechaFacturacion0
, CONVERT(NVARCHAR,FCLI.FechaFacturacion,103) AS FechaFacturacion
, FCLI.IdUsuario AS IdUsuario0
, UC.Persona AS Usuario
, PRO.CodigoProducto
, PRO.Descripcion AS Producto
, PRO.PrecioCompra
, FPRO.Precio AS PrecioVenta
, FPRO.Cantidad AS CantidadVendida
, FPRO.DescuentoAplicado
, FPRO.Total
, FPRO.Secuencial
, FPRO.NumeroPago
, FCAL.CantidadArticulos AS CantidadTotal
, FCAL.TotalDescuento
, FCAL.Subtotal
, FCAL.Impuesto
, FCAL.Total
, FCAL.IdTipoPago
, TP.Descripcion AS TipoPago
, FCAL.MontoPagado
, CASE WHEN (FCAL.MontoPagado - FCAL.Total) <1 THEN 0 ELSE (FCAL.MontoPagado - FCAL.Total) END AS Cambio
FROM [Facturacion].[FacturacionCliente] FCLI
INNER JOIN [Facturacion].[EstatusFacturacion] EF ON EF.IdEstatusFacturacion = FCLI.IdEstatusFacturacion
INNER JOIN [Contabilidad].[ComprobantesFiscales] NCF ON NCF.IdComprobante = FCLI.IdTipoFacturacion
INNER JOIN [Facturacion].[FacturacionComprobante] FC ON FC.IdFacturacion = FCLI.NumeroFactura AND FC.NumeroConector = FCLI.NumeroConector
INNER JOIN [Empresa].[CentroSalud] CE ON CE.IdCentroSalud = FCLI.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdCentroSalud = FCLI.IdCentroSalud AND M.IdMedico = FCLI.IdMedico
INNER JOIN [Empresa].[TipoIdentificacion] TI ON TI.IdTipoIdentificacion = FCLI.IdTipoIdentificacion
INNER JOIN [Empresa].[Sexo] S ON S.IdSexo = FCLI.IdSexo
INNER JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = FCLI.IdUsuario
INNER JOIN [Facturacion].[FacturacionpProducto] FPRO ON FPRO.NumeroConector = FCLI.NumeroConector
INNER JOIN [Inventario].[Producto] PRO ON PRO.IdProducto = FPRO.IdProducto
INNER JOIN [Facturacion].[FacturacionCalculos] FCAL ON FCAL.NumeroConector = FCLI.NumeroConector AND FCAL.NumeroConector = FPRO.NumeroConector AND FCAL.NumeroConector = FC.NumeroConector
INNER JOIN [Facturacion].[TipoPago] TP ON TP.IdTipoPago = FCAL.IdTipoPago
GO
/****** Object:  StoredProcedure [Facturacion].[SP_MANTENIMIENTO_DATOS_FACTURACION_ESPEJO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_MANTENIMIENTO_DATOS_FACTURACION_ESPEJO]
  @NumeroConector DECIMAL(20,0)
, @IdUsuario DECIMAL(20,0)
, @IdTipoFacturacion DECIMAL(20,0)
, @NombrePaciente VARCHAR(500)
, @Telefono VARCHAR(100)
, @IdCentroSalud DECIMAL(20,0)
, @Sala VARCHAR(500)
, @IdMedico DECIMAL(20,0)
, @IdTipoIdentificacion DECIMAL(20,0)
, @NumeroIdentificacion VARCHAR(100)
, @Direccion VARCHAR(8000)
, @IdSexo DECIMAL(20,0)
, @Email VARCHAR(100)
, @Comentario VARCHAR(8000)
, @GuardarCliente BIT
, @TipoProceso BIT
, @IdTipoPago  DECIMAL(20,0)
, @IdEstatusirugia DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  NumeroConector DECIMAL(20,0)
, IdUsuario DECIMAL(20,0)
, IdTipoFacturacion DECIMAL(20,0)
, NombrePaciente VARCHAR(500)
, Telefono VARCHAR(100)
, IdCentroSalud DECIMAL(20,0)
, Sala VARCHAR(500)
, IdMedico DECIMAL(20,0)
, IdTipoIdentificacion DECIMAL(20,0)
, NumeroIdentificacion VARCHAR(100)
, Direccion VARCHAR(8000)
, IdSexo DECIMAL(20,0)
, Email VARCHAR(100)
, Comentario VARCHAR(8000)
, GuardarCliente BIT
, TipoProceso BIT
, IdTipoPago DECIMAL(20,0)
, IdEstatusirugia DECIMAL(20,0)
)

IF(@Accion='INSERT')
	
	BEGIN
		
		INSERT INTO [Facturacion].[DatosFacturacionEspejo]
		(
			  NumeroConector
            , IdUsuario
            , IdTipoFacturacion
            , NombrePaciente
            , Telefono
            , IdCentroSalud
            , Sala
            , IdMedico
            , IdTipoIdentificacion
            , NumeroIdentificacion
            , Direccion
            , IdSexo
            , Email
            , Comentario
            , GuardarCliente
            , TipoProceso
            , IdTipoPago
			, IdEstatusirugia
		)
			
			OUTPUT
				
				  inserted.NumeroConector
                , inserted.IdUsuario
                , inserted.IdTipoFacturacion
                , inserted.NombrePaciente
                , inserted.Telefono
                , inserted.IdCentroSalud
                , inserted.Sala
                , inserted.IdMedico
                , inserted.IdTipoIdentificacion
                , inserted.NumeroIdentificacion
                , inserted.Direccion
                , inserted.IdSexo
                , inserted.Email
                , inserted.Comentario
                , inserted.GuardarCliente
                , inserted.TipoProceso
                , inserted.IdTipoPago
				, inserted.IdEstatusirugia
					
					INTO @ITEMS
						
						VALUES
						(
							  @NumeroConector
                            , @IdUsuario
                            , @IdTipoFacturacion
                            , @NombrePaciente
                            , @Telefono
                            , @IdCentroSalud
                            , @Sala
                            , @IdMedico
                            , @IdTipoIdentificacion
                            , @NumeroIdentificacion
                            , @Direccion
                            , @IdSexo
                            , @Email
                            , @Comentario
                            , @GuardarCliente
                            , @TipoProceso
                            , @IdTipoPago
							, @IdEstatusirugia
							)
END

IF(@Accion='DELETE')
	
	BEGIN
		
		DELETE FROM [Facturacion].[DatosFacturacionEspejo]
			
			OUTPUT
				
				  deleted.NumeroConector
                , deleted.IdUsuario
                , deleted.IdTipoFacturacion
                , deleted.NombrePaciente
                , deleted.Telefono
                , deleted.IdCentroSalud
                , deleted.Sala
                , deleted.IdMedico
                , deleted.IdTipoIdentificacion
                , deleted.NumeroIdentificacion
                , deleted.Direccion
                , deleted.IdSexo
                , deleted.Email
                , deleted.Comentario
                , deleted.GuardarCliente
                , deleted.TipoProceso
                , deleted.IdTipoPago
				, deleted.IdEstatusirugia
					
					INTO @ITEMS
						
						WHERE NumeroConector = @NumeroConector
						AND IdUsuario = @IdUsuario
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Facturacion].[SP_MANTENIMIENTO_FACTURACION_COMPROBANTE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_MANTENIMIENTO_FACTURACION_COMPROBANTE]
  @IdFacturacion DECIMAL(20,0)
, @CodigoFacturacion VARCHAR(100)
, @NumeroConector DECIMAL(20,0)
, @TipoComprobante VARCHAR(100)
, @Comprobante VARCHAR(100)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdFacturacion DECIMAL(20,0)
, CodigoFacturacion VARCHAR(100)
, NumeroConector DECIMAL(20,0)
, TipoComprobante VARCHAR(100)
, Comprobante VARCHAR(100)
)
IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdFacturacion=ISNULL(MAX(IdFacturacion),0) + 1
		FROM [Facturacion].[FacturacionComprobante]
		IF(ISNULL(@IdFacturacion,0) = 0)
		SET @IdFacturacion = 1
			
			INSERT INTO [Facturacion].[FacturacionComprobante]
			(
				  IdFacturacion
				, CodigoFacturacion
				, NumeroConector
				, TipoComprobante
				, Comprobante
			)
					
					OUTPUT
						
						  inserted.IdFacturacion
						, inserted.CodigoFacturacion
						, inserted.NumeroConector
						, inserted.TipoComprobante
						, inserted.Comprobante
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdFacturacion
									, (SELECT
									  CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
									  FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 22)
									, @NumeroConector
									, @TipoComprobante
									, @Comprobante
									)
END
GO
/****** Object:  StoredProcedure [Facturacion].[SP_MANTENIMIENTO_PROGRAMACION_CIRUGIA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_MANTENIMIENTO_PROGRAMACION_CIRUGIA]
  @IdProgramacionCirugia DECIMAL(20,0)
, @FechaCirugia DATE
, @IdCentroSalud DECIMAL(20,0)
, @IdMedico DECIMAL(20,0)
, @IdEstatusCirugia DECIMAL(20,0)
, @NoFactura DECIMAL(20,0)
, @NoReferencia DECIMAL(20,0)
, @IdUsuario DECIMAL(20,0)
, @Accion VARCHAR(100) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdProgramacionCirugia DECIMAL(20,0)
, FechaCirugia DATE
, IdCentroSalud DECIMAL(20,0)
, IdMedico DECIMAL(20,0)
, IdEstatusCirugia DECIMAL(20,0)
, NoFactura DECIMAL(20,0)
, NoReferencia DECIMAL(20,0)
, UsuarioAdiciona DECIMAL(20,0)
, FechaAdiciona DATE
, UsuarioModifica decimal(20,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdProgramacionCirugia=ISNULL(MAX(IdProgramacionCirugia),0) + 1
		FROM [Facturacion].[ProgramacionCirugia]
		IF(ISNULL(@IdProgramacionCirugia,0) = 0)
			SET @IdProgramacionCirugia = 1
				
				INSERT INTO [Facturacion].[ProgramacionCirugia]
				(
					  IdProgramacionCirugia
					, FechaCirugia
					, IdCentroSalud
					, IdMedico
					, IdEstatusCirugia
					, NoFactura
					, NoReferencia
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdProgramacionCirugia
						, inserted.FechaCirugia
						, inserted.IdCentroSalud
						, inserted.IdMedico
						, inserted.IdEstatusCirugia
						, inserted.NoFactura
						, inserted.NoReferencia
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdProgramacionCirugia
									, @FechaCirugia
									, @IdCentroSalud
									, @IdMedico
									, @IdEstatusCirugia
									, @NoFactura
									, @NoReferencia
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Facturacion].[ProgramacionCirugia] SET
			
			  FechaCirugia=@FechaCirugia
			, IdCentroSalud=@IdCentroSalud
			, IdMedico=@IdMedico
			, IdEstatusCirugia=@IdEstatusCirugia
			, UsuarioModifica=@IdUsuario
				
				OUTPUT
						
						  inserted.IdProgramacionCirugia
						, inserted.FechaCirugia
						, inserted.IdCentroSalud
						, inserted.IdMedico
						, inserted.IdEstatusCirugia
						, inserted.NoFactura
						, inserted.NoReferencia
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdProgramacionCirugia=@IdProgramacionCirugia
END

IF(@Accion='DELETE')
	
	BEGIN
		
		DELETE FROM [Facturacion].[ProgramacionCirugia]
			
			OUTPUT
						
						  deleted.IdProgramacionCirugia
						, deleted.FechaCirugia
						, deleted.IdCentroSalud
						, deleted.IdMedico
						, deleted.IdEstatusCirugia
						, deleted.NoFactura
						, deleted.NoReferencia
						, deleted.UsuarioAdiciona
						, deleted.FechaAdiciona
						, deleted.UsuarioModifica
						, deleted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdProgramacionCirugia = @IdProgramacionCirugia
END

SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Facturacion].[SP_MANTENIMIENTO_TIPO_PAGO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_MANTENIMIENTO_TIPO_PAGO]
  @IdTipoPago DECIMAL(20,0)
, @CodigoTipoPago VARCHAR(100)
, @Descripcion VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(20,0)
, @BloqueaMontoPagar BIT
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
	  IdTipoPago DECIMAL(20,0)
	, CodigoTipoPago VARCHAR(100)
	, Descripcion VARCHAR(100)
	, Estatus BIT
	, UsuarioAdiciona DECIMAL(20,0)
	, FechaAdiciona DATE
	, UsuarioModifica DECIMAL(20,0)
	, FechaModifica DATE
	, BloqueaMontoPagar BIT
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdTipoPago = ISNULL(MAX(IdTipoPago),0) + 1
		FROM [Facturacion].[TipoPago]
		IF(ISNULL(@IdTipoPago,0) = 0)
		SET @IdTipoPago = 1
			
	     UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 19) WHERE IdSecuencial = 19

		 INSERT INTO [Facturacion].[TipoPago]
		 (
			  IdTipoPago
			, CodigoTipoPago
			, Descripcion
			, Estatus
			, UsuarioAdiciona
			, FechaAdiciona
			, UsuarioModifica
			, FechaModifica
			, BloqueaMontoPagar
		)
			
			OUTPUT
				
				  inserted.IdTipoPago
				, inserted.CodigoTipoPago
				, inserted.Descripcion
				, inserted.Estatus
				, inserted.UsuarioAdiciona
				, inserted.FechaAdiciona
				, inserted.UsuarioModifica
				, inserted.FechaModifica
				, inserted.BloqueaMontoPagar
					
					INTO @ITEMS
						
						VALUES
						(
							     @IdTipoPago
							   , (SELECT
							     CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
							      FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 19)
							   , @Descripcion
							   , @Estatus
							   , @IdUsuario
							   , GETDATE()
							   , @IdUsuario
							   , GETDATE()
							   , @BloqueaMontoPagar
						)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Facturacion].[TipoPago] SET
			
			  Descripcion=@Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
			, BloqueaMontoPagar = @BloqueaMontoPagar
				
				OUTPUT
				
				  inserted.IdTipoPago
				, inserted.CodigoTipoPago
				, inserted.Descripcion
				, inserted.Estatus
				, inserted.UsuarioAdiciona
				, inserted.FechaAdiciona
				, inserted.UsuarioModifica
				, inserted.FechaModifica
				, inserted.BloqueaMontoPagar
					
					INTO @ITEMS
						
						WHERE IdTipoPago = @IdTipoPago
						AND CodigoTipoPago = @CodigoTipoPago
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Facturacion].[TipoPago] SET
			
			  Estatus=0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
				
				  inserted.IdTipoPago
				, inserted.CodigoTipoPago
				, inserted.Descripcion
				, inserted.Estatus
				, inserted.UsuarioAdiciona
				, inserted.FechaAdiciona
				, inserted.UsuarioModifica
				, inserted.FechaModifica
				, inserted.BloqueaMontoPagar
					
					INTO @ITEMS
						
						WHERE IdTipoPago = @IdTipoPago
						AND CodigoTipoPago = @CodigoTipoPago
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Facturacion].[SP_SACAR_CALCULOS_FACTURACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Facturacion].[SP_SACAR_CALCULOS_FACTURACION] 
@NumeroConector DECIMAL(20,0) = NULL

AS

SELECT
  SUM(FP.Cantidad) AS CantidadArticulos
, SUM(FP.DescuentoAplicado) AS ToTalDescuento
, SUM(FP.Total) AS Total
, I.Impuesto AS PorcientoAplicado
, (SUM(FP.Total) - (SUM(FP.Total) / I.Impuesto)) AS Impuesto
, CAST((SUM(FP.Total) / I.Impuesto) AS DECIMAL(20,2)) AS SubTotal
FROM Facturacion.FacturacionpProducto FP
INNER JOIN [Contabilidad].[Impuesto] I ON I.IdImpuesto = 1

WHERE FP.NumeroConector = ISNULL(@NumeroConector,FP.NumeroConector)

GROUP BY I.Impuesto
GO
/****** Object:  StoredProcedure [Historial].[SP_CONTAR_HISTORIAL_FACTURACION_COTIZACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Historial].[SP_CONTAR_HISTORIAL_FACTURACION_COTIZACION] --null,8786527822151,null,null,null,null,null,null,null,null,null,1,1
  @NumeroFactura DECIMAL = NULL
, @NumeroConector DECIMAL(20,0) = NULL
, @NombrePaciente VARCHAR(100) = NULL
, @IdEstatusFacturacion DECIMAL(20,0) = NULL
, @CodigoFacturacion VARCHAR(100) = NULL
, @IdTipoFacturacion DECIMAL(20,0) = NULL
, @IdCentroSalud DECIMAL(20,0) = NULL
, @IdMedico DECIMAL(20,0) = NULL
, @IdTipoPago DECIMAL(20,0) = NULL
, @FechaFacturacionDesde DATE = NULL
, @FechaFacturacionHasta DATE = NULL

AS

SELECT DISTINCT
--FCLI.NumeroConector
((COUNT(FCLI.NumeroConector) / COUNT(FCLI.NumeroConector))) AS Cantidad
,CAST((SUM(FCAL.Total) / COUNT(FCLI.NumeroConector)) AS decimal(20,2)) AS Total
FROM [Facturacion].[FacturacionCliente] FCLI
INNER JOIN [Empresa].[TipoIdentificacion] TI ON TI.IdTipoIdentificacion = FCLI.IdTipoIdentificacion
INNER JOIN [Facturacion].[EstatusFacturacion] EF ON EF.IdEstatusFacturacion = FCLI.IdEstatusFacturacion
INNER JOIN [Contabilidad].[ComprobantesFiscales] NCF ON NCF.IdComprobante = FCLI.IdTipoFacturacion
INNER JOIN [Empresa].[CentroSalud] CE ON CE.IdCentroSalud = FCLI.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdCentroSalud = FCLI.IdCentroSalud AND M.IdMedico = FCLI.IdMedico
INNER JOIN [Empresa].[Sexo] S ON S.IdSexo = FCLI.IdSexo
INNER JOIN [Facturacion].[FacturacionpProducto] FPRO ON FPRO.NumeroConector = FCLI.NumeroConector
INNER JOIN [Inventario].[Producto] PRO ON PRO.IdProducto = FPRO.IdProducto
INNER JOIN [Inventario].[TipoProducto] TPRO ON TPRO.IdTipoProducto = PRO.IdTipoProducto
INNER JOIN [Facturacion].[FacturacionCalculos] FCAL ON FCAL.NumeroConector = FCLI.NumeroConector AND FCAL.NumeroConector = FPRO.NumeroConector
INNER JOIN [Facturacion].[TipoPago] TP ON TP.IdTipoPago = FCAL.IdTipoPago
LEFT JOIN [Facturacion].[FacturacionComprobante] FNCF ON FNCF.NumeroConector = FCLI.NumeroConector
AND FNCF.NumeroConector = FPRO.NumeroConector AND FNCF.NumeroConector = FCAL.NumeroConector
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = FCLI.IdUsuario

WHERE FCLI.NumeroFactura = ISNULL(@NumeroFactura,FCLI.NumeroFactura)
AND FCLI.NumeroConector = ISNULL(@NumeroConector,FCLI.NumeroConector)
AND FCLI.NombrePaciente LIKE '%' + ISNULL(@NombrePaciente,FCLI.NombrePaciente) + '%'
AND FCLI.IdEstatusFacturacion = ISNULL(@IdEstatusFacturacion,FCLI.IdEstatusFacturacion)
AND FCLI.CodigoFacturacion = ISNULL(@CodigoFacturacion,FCLI.CodigoFacturacion)
AND FCLI.IdTipoFacturacion = ISNULL(@IdTipoFacturacion,FCLI.IdTipoFacturacion)
AND FCLI.IdCentroSalud=ISNULL(@IdCentroSalud,FCLI.IdCentroSalud)
AND FCLI.IdMedico=ISNULL(@IdMedico,FCLI.IdMedico)
AND FCAL.IdTipoPago = ISNULL(@IdTipoPago,FCAL.IdTipoPago)
AND (
FCLI.FechaFacturacion >= ISNULL(@FechaFacturacionDesde,FCLI.FechaFacturacion)
AND FCLI.FechaFacturacion <= ISNULL(@FechaFacturacionHasta,FCLI.FechaFacturacion)
)









GO
/****** Object:  StoredProcedure [Historial].[SP_HISTORIAL_FACTURACION_COTIZACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Historial].[SP_HISTORIAL_FACTURACION_COTIZACION] --null,8786527822151,null,null,null,null,null,null,null,null,null,1,1
  @NumeroFactura DECIMAL = NULL
, @NumeroConector DECIMAL(20,0) = NULL
, @NombrePaciente VARCHAR(100) = NULL
, @IdEstatusFacturacion DECIMAL(20,0) = NULL
, @CodigoFacturacion VARCHAR(100) = NULL
, @IdTipoFacturacion DECIMAL(20,0) = NULL
, @IdCentroSalud DECIMAL(20,0) = NULL
, @IdMedico DECIMAL(20,0) = NULL
, @IdTipoPago DECIMAL(20,0) = NULL
, @FechaFacturacionDesde DATE = NULL
, @FechaFacturacionHasta DATE = NULL
, @IdEstatusCirugia DECIMAL(20,0) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT DISTINCT
  FCLI.NumeroFactura
, UPPER(FCLI.NombrePaciente) AS NombrePaciente
, FCLI.IdTipoIdentificacion
, TI.Descripcion AS TipoIdentificacion
, FCLI.NumeroIdentificacion
, FCLI.IdEstatusFacturacion
, EF.Estatus
, FCLI.CodigoFacturacion
, FCLI.NumeroConector
, FCLI.IdTipoFacturacion
, NCF.Descripcion AS TipoComprobante
, NCF.ValidoHasta
, COALESCE(FNCF.Comprobante ,' ') AS Comprobante
, FCLI.Telefono
, FCLI.IdCentroSalud
, CE.Nombre AS CentroSalud
, FCLI.Sala
, FCLI.IdMedico
, UPPER(M.NombreMedico) AS Medico
, FCLI.Direccion
, FCLI.IdSexo
, S.Descripcion AS Sexo
, FCLI.Email
, FCLI.ComentarioPaciente
, FCLI.FechaFacturacion AS FechaFacturacion0
, CONVERT(NVARCHAR,FCLI.FechaFacturacion,103) AS FechaFacturacion
, FCLI.IdUsuario
, UPPER(UC.Persona) AS Creadopor
, FPRO.IdProducto
, TPRO.Descripcion AS TipoProducto
, PRO.Descripcion AS ProDucto
, FPRO.Cantidad
, FPRO.Precio
, FPRO.DescuentoAplicado
, FPRO.Total
, FCAL.CantidadArticulos AS CantidadArticulos
, FCAL.TotalDescuento
, FCAL.Subtotal
, FCAL.Impuesto
, FCAL.Total AS TotalGeneral
, FCAL.IdTipoPago
, TP.Descripcion AS TipoPago
, FCAL.MontoPagado
, FCAL.IdEstatusCirugia
, EC.Descripcion AS EstatusCirugia
FROM [Facturacion].[FacturacionCliente] FCLI
INNER JOIN [Empresa].[TipoIdentificacion] TI ON TI.IdTipoIdentificacion = FCLI.IdTipoIdentificacion
INNER JOIN [Facturacion].[EstatusFacturacion] EF ON EF.IdEstatusFacturacion = FCLI.IdEstatusFacturacion
INNER JOIN [Contabilidad].[ComprobantesFiscales] NCF ON NCF.IdComprobante = FCLI.IdTipoFacturacion
INNER JOIN [Empresa].[CentroSalud] CE ON CE.IdCentroSalud = FCLI.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdCentroSalud = FCLI.IdCentroSalud AND M.IdMedico = FCLI.IdMedico
INNER JOIN [Empresa].[Sexo] S ON S.IdSexo = FCLI.IdSexo
INNER JOIN [Facturacion].[FacturacionpProducto] FPRO ON FPRO.NumeroConector = FCLI.NumeroConector
INNER JOIN [Inventario].[Producto] PRO ON PRO.IdProducto = FPRO.IdProducto
INNER JOIN [Inventario].[TipoProducto] TPRO ON TPRO.IdTipoProducto = PRO.IdTipoProducto
INNER JOIN [Facturacion].[FacturacionCalculos] FCAL ON FCAL.NumeroConector = FCLI.NumeroConector AND FCAL.NumeroConector = FPRO.NumeroConector
INNER JOIN [Facturacion].[TipoPago] TP ON TP.IdTipoPago = FCAL.IdTipoPago
INNER JOIN [Facturacion].[EstatusCirugia] EC ON EC.IdEstatusCirugia = FCAL.IdEstatusCirugia
LEFT JOIN [Facturacion].[FacturacionComprobante] FNCF ON FNCF.NumeroConector = FCLI.NumeroConector
AND FNCF.NumeroConector = FPRO.NumeroConector AND FNCF.NumeroConector = FCAL.NumeroConector
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = FCLI.IdUsuario

WHERE FCLI.NumeroFactura = ISNULL(@NumeroFactura,FCLI.NumeroFactura)
AND FCLI.NumeroConector = ISNULL(@NumeroConector,FCLI.NumeroConector)
AND FCLI.NombrePaciente LIKE '%' + ISNULL(@NombrePaciente,FCLI.NombrePaciente) + '%'
AND FCLI.IdEstatusFacturacion = ISNULL(@IdEstatusFacturacion,FCLI.IdEstatusFacturacion)
AND FCLI.CodigoFacturacion = ISNULL(@CodigoFacturacion,FCLI.CodigoFacturacion)
AND FCLI.IdTipoFacturacion = ISNULL(@IdTipoFacturacion,FCLI.IdTipoFacturacion)
AND FCLI.IdCentroSalud=ISNULL(@IdCentroSalud,FCLI.IdCentroSalud)
AND FCLI.IdMedico=ISNULL(@IdMedico,FCLI.IdMedico)
AND FCAL.IdTipoPago = ISNULL(@IdTipoPago,FCAL.IdTipoPago)
AND (
FCLI.FechaFacturacion >= ISNULL(@FechaFacturacionDesde,FCLI.FechaFacturacion)
AND FCLI.FechaFacturacion <= ISNULL(@FechaFacturacionHasta,FCLI.FechaFacturacion)
)

ORDER BY FCLI.NumeroFactura ASC
OFFSET (@NumeroPagina - 1) *  @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;




GO
/****** Object:  StoredProcedure [Inventario].[SP_BUSCA_ALMACEN]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_BUSCA_ALMACEN]
  @IdAlmacen DECIMAL(18,0) = NULL
, @CodigoAlmacen VARCHAR(100) = NULL
, @Nombre VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  A.IdAlmacen
, A.CodigoAlmacen
, A.Nombre
, A.Direccion
, A.Telefono
, A.Estatus AS Estatus0
, CASE A.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, A.UsuarioAdiciona
, UC.Persona AS CreadoPor
, A.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,A.FechaAdiciona,103) AS FechaAdiciona
, A.UsuarioModifica
, UM.Persona AS ModificadoPor
, A.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,A.FechaModifica,103) AS FechaModifica
FROM [Inventario].[Almacen] A
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = A.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = A.UsuarioModifica

WHERE A.IdAlmacen = ISNULL(@IdAlmacen,A.IdAlmacen)
AND A.CodigoAlmacen = ISNULL(@CodigoAlmacen,A.CodigoAlmacen)
AND A.Nombre LIKE '%' + ISNULL(@Nombre,A.Nombre) + '%'

ORDER BY A.IdAlmacen
OFFSET(@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Inventario].[SP_BUSCA_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Inventario].[SP_BUSCA_PRODUCTO]
  @IdProducto DECIMAL(18,0) = NULL
, @CodigoProducto VARCHAR(100) = NULL
, @IdAlmacen DECIMAL(18,0) = NULL
, @IdTipoProveedor DECIMAL(18,0) = NULL
, @IdProveedor DECIMAL(18,0) = NULL
, @IdTipoEmpaque DECIMAL(18,0) = NULL
, @IdTipoProducto DECIMAL(18,0) = NULL
, @Descripcion VARCHAR(100) = NULL
, @FechaEntradaDesde DATE = NULL
, @FechaEntradaHasta DATE = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  PRO.IdProducto
, PRO.CodigoProducto
, PRO.IdAlmacen
, A.Nombre AS Almacen
, PRO.IdTipoProveedor
, TPROV.Descripcion AS TipoProveedor
, PRO.IdProveedor
, PROV.Nombre AS Proveedor
, PRO.IdTipoEmpaque
, TE.Descripcion AS TipoEmpaque
, PRO.IdTipoProducto AS IdTipoProducto0
, TPRO.Descripcion AS TipoProducto
, PRO.Descripcion AS Producto
, PRO.Estatus AS Estatus0
, CASE PRO.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, PRO.CantidadAlmacen
, PRO.PrecioCompra
, PRO.PrecioVenta
, PRO.SegundoPrecio
, PRO.TercerPrecio
, PRO.FechaEntrada AS FechaEntrada0
, CONVERT(NVARCHAR,PRO.FechaEntrada,103) AS FechaEntrada
, PRO.LlevaDescuento AS LlevaDescuento0
, CASE PRO.LlevaDescuento WHEN 1 THEN 'SI' WHEN 0 THEN 'NO' ELSE 'ERROR' END AS LlevaDescuento
, PRO.PorcientoDescuento
, PRO.UsuarioAdiciona
, UC.Persona AS CreadoPor
, PRO.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,PRO.FechaAdiciona,103) AS FechaAdiciona
, PRO.UsuarioModifica
, UM.Persona AS ModificadoPor
, PRO.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,PRO.FechaModifica,103) AS FechaModifica
FROM [Inventario].[Producto] PRO
INNER JOIN [Inventario].[Almacen] A ON A.IdAlmacen = PRO.IdAlmacen
INNER JOIN [Inventario].[TipoProveedor] TPROV ON TPROV.IdTipoProveedor = PRO.IdTipoProveedor
INNER JOIN [Inventario].[Proveedor] PROV ON PROV.IdTipoProveedor = PRO.IdTipoProveedor AND PROV.IdProveedor = PRO.IdProveedor
INNER JOIN [Inventario].[TipoEmpaque] TE ON TE.IdTipoEmpaque = PRO.IdTipoEmpaque
INNER JOIN [Inventario].[TipoProducto] TPRO ON TPRO.IdTipoProducto = PRO.IdTipoProducto
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = PRO.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = PRO.UsuarioModifica

WHERE PRO.IdProducto = ISNULL(@IdProducto,PRO.IdProducto)
AND PRO.CodigoProducto = ISNULL(@CodigoProducto,PRO.CodigoProducto)
AND PRO.IdAlmacen = ISNULL(@IdAlmacen,PRO.IdAlmacen)
AND PRO.IdTipoProveedor = ISNULL(@IdTipoProveedor,PRO.IdTipoProveedor)
AND PRO.IdProveedor = ISNULL(@IdProveedor,PRO.IdProveedor)
AND PRO.IdTipoEmpaque = ISNULL(@IdTipoEmpaque,PRO.IdTipoEmpaque)
AND PRO.IdTipoProducto = ISNULL(@IdTipoProducto,PRO.IdTipoProducto)
AND PRO.Descripcion LIKE '%' + ISNULL(@Descripcion,PRO.Descripcion) + '%'
AND (
PRO.FechaEntrada >= ISNULL(@FechaEntradaDesde,PRO.FechaEntrada)
AND PRO.FechaEntrada <= ISNULL(@FechaEntradaHasta,PRO.FechaEntrada)
)

ORDER BY PRO.IdProducto
OFFSET (@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Inventario].[SP_BUSCA_PROVEEDOR]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_BUSCA_PROVEEDOR]
  @IdProveedor DECIMAL(18,0) = NULL
, @CodigoProveedor VARCHAR(100) = NULL
, @IdTipoProveedor DECIMAL(18,0) = NULL
, @Nombre VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  PRO.IdProveedor
, PRO.CodigoProveedor
, PRO.IdTipoProveedor
, TPRO.Descripcion AS TipoProveedor
, UPPER(PRO.Nombre) AS Nombre
, PRO.Direccion
, PRO.Telefonos
, PRO.Fax
, PRO.Contacto
, PRO.LlevaComision AS LlevaComision0
, CASE PRO.LlevaComision WHEN 1 THEN 'SI' WHEN 0 THEN 'NO' ELSE 'ERROR' END AS LlevaComision
, PRO.Estatus AS Estatus0
, CASE PRO.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, PRO.UsuarioAdiciona
, UC.Persona AS CreadoPor
, PRO.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,PRO.FechaAdiciona,103) AS FechaAdiciona
, PRO.UsuarioModifica
, UM.Persona AS ModificadoPor
, PRO.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,PRO.FechaModifica,103) AS FechaModifica
FROM [Inventario].[Proveedor] PRO
INNER JOIN [Inventario].[TipoProveedor] TPRO ON TPRO.IdTipoProveedor = PRO.IdTipoProveedor
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = PRO.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = PRO.UsuarioModifica

WHERE PRO.IdProveedor = ISNULL(@IdProveedor,PRO.IdProveedor)
AND PRO.CodigoProveedor = ISNULL(@CodigoProveedor,PRO.CodigoProveedor)
AND PRO.IdTipoProveedor = ISNULL(@IdTipoProveedor,PRO.IdTipoProveedor)
AND PRO.Nombre LIKE '%' + ISNULL(@Nombre,PRO.Nombre) + '%'

ORDER BY PRO.IdProveedor
OFFSET (@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Inventario].[SP_BUSCA_TIPO_EMPAQUE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_BUSCA_TIPO_EMPAQUE]
  @IdTipoEmpaque DECIMAL(18,0) = NULL
, @CodigoTipoEmpaque VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  TE.IdTipoEmpaque
, TE.CodigoTipoEmpaque
, TE.Descripcion AS TipoEmpaque
, TE.Estatus AS Estatus0
, CASE TE.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, TE.UsuarioAdiciona 
, UC.Persona AS CreadoPor
, TE.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,TE.FechaAdiciona,103) AS FechaAdiciona
, TE.UsuarioModifica
, UM.Persona AS ModificadoPor
, TE.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,TE.FechaModifica,103) AS FechaModifica
FROM [Inventario].[TipoEmpaque] TE
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = TE.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = TE.UsuarioModifica

WHERE TE.IdTipoEmpaque = ISNULL(@IdTipoEmpaque,TE.IdTipoEmpaque)
AND TE.CodigoTipoEmpaque = ISNULL(@CodigoTipoEmpaque,TE.CodigoTipoEmpaque)
AND TE.Descripcion LIKE '%' + ISNULL(@Descripcion,TE.Descripcion) + '%'

ORDER BY TE.IdTipoEmpaque
OFFSET (@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY
GO
/****** Object:  StoredProcedure [Inventario].[SP_BUSCA_TIPO_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Inventario].[SP_BUSCA_TIPO_PRODUCTO]
  @IdTipoProducto DECIMAL(18,0) = NULL
, @CodigoTipoProducto VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT =10

AS

SELECT
  TP.IdTipoProducto
, TP.CodigoTipoProducto
, TP.Descripcion AS TipoProducto
, TP.Estatus AS Estatus0
, CASE TP.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, TP.UsuarioAdiciona
, UC.Persona AS CreadoPor
, TP.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,TP.FechaAdiciona,103) AS FechaAdiciona
, TP.UsuarioModifica
, UM.Persona AS ModificadoPor
, TP.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,TP.FechaModifica,103) AS FechaModifica
FROM [Inventario].[TipoProducto] TP
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = TP.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = TP.UsuarioModifica

WHERE TP.IdTipoProducto = ISNULL(@IdTipoProducto,TP.IdTipoProducto)
AND TP.CodigoTipoProducto = ISNULL(@CodigoTipoProducto,TP.CodigoTipoProducto)
AND TP.Descripcion LIKE '%' + ISNULL(@Descripcion,TP.Descripcion) + '%'

ORDER BY TP.IdTipoProducto
OFFSET (@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Inventario].[SP_BUSCA_TIPO_PROVEEDOR]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_BUSCA_TIPO_PROVEEDOR]
  @IdTipoProveedor DECIMAL(18,0) = NULL
, @CodigoTipoProveedor VARCHAR(100) = NULL
, @Descripcion VARCHAR(100) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  TPR.IdTipoProveedor
, TPR.CodigoTipoProveedor
, TPR.Descripcion AS TipoProveedor
, TPR.Estatus AS Estatus0
, CASE TPR.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, TPR.UsuarioAdiciona
, UC.Persona AS CreadoPor
, TPR.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,TPR.FechaAdiciona,103) AS FechaAdiciona
, TPR.UsuarioModifica
, UM.Persona AS ModificadoPor
, TPR.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,TPR.FechaModifica,103) AS FechaModifica
FROM [Inventario].[TipoProveedor] TPR
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = TPR.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = TPR.UsuarioModifica

WHERE TPR.IdTipoProveedor = ISNULL(@IdTipoProveedor,TPR.IdTipoProveedor)
AND TPR.CodigoTipoProveedor = ISNULL(@CodigoTipoProveedor,TPR.CodigoTipoProveedor)
AND TPR.Descripcion LIKE '%' + ISNULL(@Descripcion,TPR.Descripcion) + '%'

ORDER BY TPR.IdTipoProveedor
OFFSET (@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Inventario].[SP_CONTAR_CANTIDAD_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Inventario].[SP_CONTAR_CANTIDAD_PRODUCTO]
  @IdProducto DECIMAL(18,0) = NULL
, @CodigoProducto VARCHAR(100) = NULL
, @IdAlmacen DECIMAL(18,0) = NULL
, @IdTipoProveedor DECIMAL(18,0) = NULL
, @IdProveedor DECIMAL(18,0) = NULL
, @IdTipoEmpaque DECIMAL(18,0) = NULL
, @IdTipoProducto DECIMAL(18,0) = NULL
, @Descripcion VARCHAR(100) = NULL
, @FechaEntradaDesde DATE = NULL
, @FechaEntradaHasta DATE = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
SUM(CantidadAlmacen) AS Cantidad
FROM [Inventario].[Producto] PRO
INNER JOIN [Inventario].[Almacen] A ON A.IdAlmacen = PRO.IdAlmacen
INNER JOIN [Inventario].[TipoProveedor] TPROV ON TPROV.IdTipoProveedor = PRO.IdTipoProveedor
INNER JOIN [Inventario].[Proveedor] PROV ON PROV.IdTipoProveedor = PRO.IdTipoProveedor AND PROV.IdProveedor = PRO.IdProveedor
INNER JOIN [Inventario].[TipoEmpaque] TE ON TE.IdTipoEmpaque = PRO.IdTipoEmpaque
INNER JOIN [Inventario].[TipoProducto] TPRO ON TPRO.IdTipoProducto = PRO.IdTipoProducto
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = PRO.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = PRO.UsuarioModifica

WHERE PRO.IdProducto = ISNULL(@IdProducto,PRO.IdProducto)
AND PRO.CodigoProducto = ISNULL(@CodigoProducto,PRO.CodigoProducto)
AND PRO.IdAlmacen = ISNULL(@IdAlmacen,PRO.IdAlmacen)
AND PRO.IdTipoProveedor = ISNULL(@IdTipoProveedor,PRO.IdTipoProveedor)
AND PRO.IdProveedor = ISNULL(@IdProveedor,PRO.IdProveedor)
AND PRO.IdTipoEmpaque = ISNULL(@IdTipoEmpaque,PRO.IdTipoEmpaque)
AND PRO.IdTipoProducto = ISNULL(@IdTipoProducto,PRO.IdTipoProducto)
AND PRO.Descripcion LIKE '%' + ISNULL(@Descripcion,PRO.Descripcion) + '%'
AND (
PRO.FechaEntrada >= ISNULL(@FechaEntradaDesde,PRO.FechaEntrada)
AND PRO.FechaEntrada <= ISNULL(@FechaEntradaHasta,PRO.FechaEntrada)
)
GO
/****** Object:  StoredProcedure [Inventario].[SP_MANTENIMIENTO_ALMACEN]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Inventario].[SP_MANTENIMIENTO_ALMACEN]
  @IdAlmacen DECIMAL(18,0)
, @CodigoAlmacen VARCHAR(100)
, @Nombre VARCHAR(100)
, @Direccion VARCHAR(8000)
, @Telefono VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdAlmacen DECIMAL(18,0)
, CodigoAlmacen VARCHAR(100)
, Nombre VARCHAR(100)
, Direccion VARCHAR(8000)
, Telefono VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion = 'INSERT')
	
	BEGIN
		
			SELECT
			@IdAlmacen = ISNULL(MAX(IdAlmacen),0) + 1
			FROM [Inventario].[Almacen]
			IF(ISNULL(@IdAlmacen,0) = 0)
			SET @IdAlmacen = 1

			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 6) WHERE IdSecuencial = 6
				
				INSERT INTO [Inventario].[Almacen]
				(
					  IdAlmacen
					, CodigoAlmacen
					, Nombre
					, Direccion
					, Telefono
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdAlmacen
						, inserted.CodigoAlmacen
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefono
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdAlmacen
									, (SELECT
									   CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
									  FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 6)
									, @Nombre
									, @Direccion
									, @Telefono
									, @Estatus
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Inventario].[Almacen] SET
			
			  Nombre=@Nombre
			, Direccion=@Direccion
			, Telefono=@Telefono
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdAlmacen
						, inserted.CodigoAlmacen
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefono
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdAlmacen = @IdAlmacen
								AND CodigoAlmacen = @CodigoAlmacen
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Inventario].[Almacen] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
							OUTPUT
						
						  inserted.IdAlmacen
						, inserted.CodigoAlmacen
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefono
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdAlmacen = @IdAlmacen
								AND CodigoAlmacen = @CodigoAlmacen
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Inventario].[SP_MANTENIMIENTO_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_MANTENIMIENTO_PRODUCTO]
  @IdProducto DECIMAL(18,0)
, @CodigoProducto VARCHAR(100)
, @IdAlmacen DECIMAL(18,0)
, @IdTipoProveedor DECIMAL(18,0)
, @IdProveedor DECIMAL(18,0)
, @IdTipoEmpaque DECIMAL(18,0)
, @IdTipoProducto DECIMAL(18,0)
, @Descripcion VARCHAR(100)
, @Estatus BIT
, @CantidadAlmacen INT
, @PrecioCompra DECIMAL(20,2)
, @PrecioVenta DECIMAL(20,2)
, @SegundoPrecio DECIMAL(20,2)
, @TercerPrecio DECIMAL(20,2)
, @LlevaDescuento BIT
, @PorcientoDescuento INT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdProducto DECIMAL(18,0)
, CodigoProducto VARCHAR(100)
, IdAlmacen DECIMAL(18,0)
, IdTipoProveedor DECIMAL(18,0)
, IdProveedor DECIMAL(18,0)
, IdTipoEmpaque DECIMAL(18,0)
, IdTipoProducto DECIMAL(18,0)
, Descripcion VARCHAR(100)
, Estatus BIT
, CantidadAlmacen INT
, PrecioCompra DECIMAL(20,2)
, PrecioVenta DECIMAL(20,2)
, SegundoPrecio DECIMAL(20,2)
, TercerPrecio DECIMAL(20,2)
, FechaEntrada DATE
, LlevaDescuento BIT
, PorcientoDescuento INT
, UsuarioAdiciona INT
, FechaAdiciona DATE
, UsuarioModifica INT
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdProducto=ISNULL(MAX(IdProducto),0) + 1
		FROM [Inventario].[Producto]
		IF(ISNULL(@IdProducto,0) = 0)
			SET @IdProducto = 1
				
				UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 8) WHERE IdSecuencial = 8
					
					INSERT INTO [Inventario].[Producto]
					(
						  IdProducto
                        , CodigoProducto
                        , IdAlmacen
                        , IdTipoProveedor
                        , IdProveedor
                        , IdTipoEmpaque
						, IdTipoProducto
                        , Descripcion
                        , Estatus
                        , CantidadAlmacen
                        , PrecioCompra
                        , PrecioVenta
                        , SegundoPrecio
                        , TercerPrecio
                        , FechaEntrada
                        , LlevaDescuento
                        , PorcientoDescuento
                        , UsuarioAdiciona
                        , FechaAdiciona
                        , UsuarioModifica
                        , FechaModifica
					)
						
						OUTPUT
							
							  inserted.IdProducto
                            , inserted.CodigoProducto
                            , inserted.IdAlmacen
                            , inserted.IdTipoProveedor
                            , inserted.IdProveedor
                            , inserted.IdTipoEmpaque
							, inserted.IdTipoProducto
                            , inserted.Descripcion
                            , inserted.Estatus
                            , inserted.CantidadAlmacen
                            , inserted.PrecioCompra
                            , inserted.PrecioVenta
                            , inserted.SegundoPrecio
							, inserted.TercerPrecio
                            , inserted.FechaEntrada
                            , inserted.LlevaDescuento
                            , inserted.PorcientoDescuento
                            , inserted.UsuarioAdiciona
                            , inserted.FechaAdiciona
                            , inserted.UsuarioModifica
                            , inserted.FechaModifica
								
								INTO @ITEMS
									
									VALUES
									(
										  @IdProducto
										, (SELECT CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR)) FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 8)
										, @IdAlmacen
										, @IdTipoProveedor
										, @IdProveedor
										, @IdTipoEmpaque
										, @IdTipoProducto
										, @Descripcion
										, @Estatus
										, @CantidadAlmacen
										, @PrecioCompra
										, @PrecioVenta
										, @SegundoPrecio
										, @TercerPrecio
										, GETDATE()
										, @LlevaDescuento
										, @PorcientoDescuento
										, @IdUsuario
										, GETDATE()
										, @IdUsuario
										, GETDATE()
									)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Inventario].[Producto] SET
			
			  IdAlmacen=@IdAlmacen
			, IdTipoProveedor=@IdTipoProveedor
			, IdProveedor=@IdProveedor
			, IdTipoEmpaque=@IdTipoEmpaque
			, IdTipoProducto=@IdTipoProducto
			, Descripcion=@Descripcion
			, Estatus=@Estatus
			, CantidadAlmacen=@CantidadAlmacen
			, PrecioCompra=@PrecioCompra
			, PrecioVenta=@PrecioVenta
			, SegundoPrecio=@SegundoPrecio
			, TercerPrecio=@TercerPrecio
			, LlevaDescuento=@LlevaDescuento
			, PorcientoDescuento=@PorcientoDescuento
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
							
							  inserted.IdProducto
                            , inserted.CodigoProducto
                            , inserted.IdAlmacen
                            , inserted.IdTipoProveedor
                            , inserted.IdProveedor
                            , inserted.IdTipoEmpaque
							, inserted.IdTipoProducto
                            , inserted.Descripcion
                            , inserted.Estatus
                            , inserted.CantidadAlmacen
                            , inserted.PrecioCompra
                            , inserted.PrecioVenta
                            , inserted.SegundoPrecio
							, inserted.TercerPrecio
                            , inserted.FechaEntrada
                            , inserted.LlevaDescuento
                            , inserted.PorcientoDescuento
                            , inserted.UsuarioAdiciona
                            , inserted.FechaAdiciona
                            , inserted.UsuarioModifica
                            , inserted.FechaModifica
								
								INTO @ITEMS
									
									WHERE IdProducto=@IdProducto
									AND CodigoProducto=@CodigoProducto
END

IF(@Accion='LESS')
	
	BEGIN
		
		UPDATE [Inventario].[Producto] SET
			
			  CantidadAlmacen = (CantidadAlmacen - @CantidadAlmacen)
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
							
							  inserted.IdProducto
                            , inserted.CodigoProducto
                            , inserted.IdAlmacen
                            , inserted.IdTipoProveedor
                            , inserted.IdProveedor
                            , inserted.IdTipoEmpaque
							, inserted.IdTipoProducto
                            , inserted.Descripcion
                            , inserted.Estatus
                            , inserted.CantidadAlmacen
                            , inserted.PrecioCompra
                            , inserted.PrecioVenta
                            , inserted.SegundoPrecio
							, inserted.TercerPrecio
                            , inserted.FechaEntrada
                            , inserted.LlevaDescuento
                            , inserted.PorcientoDescuento
                            , inserted.UsuarioAdiciona
                            , inserted.FechaAdiciona
                            , inserted.UsuarioModifica
                            , inserted.FechaModifica
								
								INTO @ITEMS
									
									WHERE IdProducto=@IdProducto
									AND CodigoProducto=@CodigoProducto
END

IF(@Accion='ADD')
	
	BEGIN
		
		UPDATE [Inventario].[Producto] SET
			
			  CantidadAlmacen = (CantidadAlmacen + @CantidadAlmacen)
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
							
							  inserted.IdProducto
                            , inserted.CodigoProducto
                            , inserted.IdAlmacen
                            , inserted.IdTipoProveedor
                            , inserted.IdProveedor
                            , inserted.IdTipoEmpaque
							, inserted.IdTipoProducto
                            , inserted.Descripcion
                            , inserted.Estatus
                            , inserted.CantidadAlmacen
                            , inserted.PrecioCompra
                            , inserted.PrecioVenta
                            , inserted.SegundoPrecio
							, inserted.TercerPrecio
                            , inserted.FechaEntrada
                            , inserted.LlevaDescuento
                            , inserted.PorcientoDescuento
                            , inserted.UsuarioAdiciona
                            , inserted.FechaAdiciona
                            , inserted.UsuarioModifica
                            , inserted.FechaModifica
								
								INTO @ITEMS
									
									WHERE IdProducto=@IdProducto
									AND CodigoProducto=@CodigoProducto
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Inventario].[Producto] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
							
							  inserted.IdProducto
                            , inserted.CodigoProducto
                            , inserted.IdAlmacen
                            , inserted.IdTipoProveedor
                            , inserted.IdProveedor
                            , inserted.IdTipoEmpaque
							, inserted.IdTipoProducto
                            , inserted.Descripcion
                            , inserted.Estatus
                            , inserted.CantidadAlmacen
                            , inserted.PrecioCompra
                            , inserted.PrecioVenta
                            , inserted.SegundoPrecio
							, inserted.TercerPrecio
                            , inserted.FechaEntrada
                            , inserted.LlevaDescuento
                            , inserted.PorcientoDescuento
                            , inserted.UsuarioAdiciona
                            , inserted.FechaAdiciona
                            , inserted.UsuarioModifica
                            , inserted.FechaModifica
								
								INTO @ITEMS
									
									WHERE IdProducto=@IdProducto
									AND CodigoProducto=@CodigoProducto
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Inventario].[SP_MANTENIMIENTO_PROVEEDOR]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_MANTENIMIENTO_PROVEEDOR]
  @IdProveedor DECIMAL(18,0)
, @CodigoProveedor VARCHAR(100)
, @IdTipoProveedor DECIMAL(18,0)
, @Nombre VARCHAR(100)
, @Direccion VARCHAR(8000)
, @Telefonos VARCHAR(100)
, @Fax VARCHAR(20)
, @Contacto VARCHAR(70)
, @LlevaComision BIT
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdProveedor DECIMAL(18,0)
, CodigoProveedor VARCHAR(100)
, IdTipoProveedor DECIMAL(18,0)
, Nombre VARCHAR(100)
, Direccion VARCHAR(8000)
, Telefonos VARCHAR(100)
, Fax VARCHAR(20)
, Contacto VARCHAR(70)
, LlevaComision BIT
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdProveedor = ISNULL(MAX(IdProveedor),0) + 1
		FROM [Inventario].[Proveedor]
		IF(ISNULL(@IdProveedor,0) = 0)
		SET @IdProveedor = 1
			
			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 5) WHERE IdSecuencial = 5
				
				INSERT INTO [Inventario].[Proveedor]
				(
					  IdProveedor
					, CodigoProveedor
					, IdTipoProveedor
					, Nombre
					, Direccion
					, Telefonos
					, Fax
					, Contacto
					, LlevaComision
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdProveedor
						, inserted.CodigoProveedor
						, inserted.IdTipoProveedor
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefonos
						, inserted.Fax
						, inserted.Contacto
						, inserted.LlevaComision
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdProveedor
									, (SELECT
									  CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
									  FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 5)
									, @IdTipoProveedor
									, @Nombre
									, @Direccion
									, @Telefonos
									, @Fax
									, @Contacto
									, @LlevaComision
									, @Estatus
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Inventario].[Proveedor] SET
			
			  IdTipoProveedor=@IdTipoProveedor
			, Nombre=@Nombre
			, Direccion=@Direccion
			, Telefonos=@Telefonos
			, Fax = @Fax
			, Contacto = @Contacto
			, LlevaComision = @LlevaComision
			, Estatus = @Estatus
			, UsuarioModifica = @IdUsuario
			, FechaModifica = GETDATE()
				
				OUTPUT
						
						  inserted.IdProveedor
						, inserted.CodigoProveedor
						, inserted.IdTipoProveedor
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefonos
						, inserted.Fax
						, inserted.Contacto
						, inserted.LlevaComision
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdProveedor = @IdProveedor
								AND CodigoProveedor = @CodigoProveedor
END

IF(@Accion = 'DISABLE')
	
	BEGIN
		
		UPDATE [Inventario].[Proveedor] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdProveedor
						, inserted.CodigoProveedor
						, inserted.IdTipoProveedor
						, inserted.Nombre
						, inserted.Direccion
						, inserted.Telefonos
						, inserted.Fax
						, inserted.Contacto
						, inserted.LlevaComision
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdProveedor = @IdProveedor
								AND CodigoProveedor = @CodigoProveedor
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Inventario].[SP_MANTENIMIENTO_TIPO_EMPAQUE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_MANTENIMIENTO_TIPO_EMPAQUE]
  @IdTipoEmpaque DECIMAL(18,0)
, @CodigoTipoEmpaque VARCHAR(100)
, @Descripcion VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdTipoEmpaque DECIMAL(18,0)
, CodigoTipoEmpaque VARCHAR(100)
, Descripcion VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE 
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion = 'INSERT')
	
	BEGIN
		
		SELECT
		@IdTipoEmpaque = ISNULL(MAX(IdTipoEmpaque),0) + 1
		FROM [Inventario].[TipoEmpaque]
	    IF(ISNULL(@IdTipoEmpaque,0) = 0)
		SET @IdTipoEmpaque = 1
			


			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 9) WHERE IdSecuencial = 9
				
				INSERT INTO [Inventario].[TipoEmpaque]
				(
					  IdTipoEmpaque
					, CodigoTipoEmpaque
					, Descripcion
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdTipoEmpaque
						, inserted.CodigoTipoEmpaque
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdTipoEmpaque
									, (SELECT 
									  CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR),CAST(Secuencia AS VARCHAR))
									   FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 9)
									 , @Descripcion
									 , @Estatus
									 , @IdUsuario
									 , GETDATE()
									 , @IdUsuario
									 , GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Inventario].[TipoEmpaque] SET 
			
		      Descripcion=@Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdTipoEmpaque
						, inserted.CodigoTipoEmpaque
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdTipoEmpaque = @IdTipoEmpaque
								AND CodigoTipoEmpaque = @CodigoTipoEmpaque
END
	
IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Inventario].[TipoEmpaque] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
							OUTPUT
						
						  inserted.IdTipoEmpaque
						, inserted.CodigoTipoEmpaque
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdTipoEmpaque = @IdTipoEmpaque
								AND CodigoTipoEmpaque = @CodigoTipoEmpaque
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Inventario].[SP_MANTENIMIENTO_TIPO_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Inventario].[SP_MANTENIMIENTO_TIPO_PRODUCTO]
  @IdTipoProducto DECIMAL(18,0)
, @CodigoTipoProducto VARCHAR(100)
, @Descripcion VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdTipoProducto DECIMAL(18,0)
, CodigoTipoProducto VARCHAR(100)
, Descripcion VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdTipoProducto = ISNULL(MAX(IdTipoProducto),0) + 1
		FROM [Inventario].[TipoProducto]
		IF(ISNULL(@IdTipoProducto,0) = 0)
		SET @IdTipoProducto = 1
			
	

			UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 7) WHERE IdSecuencial = 7

				INSERT INTO [Inventario].[TipoProducto]
				(
					  IdTipoProducto
					, CodigoTipoProducto
					, Descripcion
					, Estatus
					, UsuarioAdiciona
					, FechaAdiciona
					, UsuarioModifica
					, FechaModifica
				)
					
					OUTPUT
						
						  inserted.IdTipoProducto
						, inserted.CodigoTipoProducto
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdUsuario
									, (SELECT
									   CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR), CAST(Secuencia AS VARCHAR))
									  FROM Configuracion.[Secuencial] WHERE IdSecuencial = 7)
									, @Descripcion
									, @Estatus
									, @IdUsuario
									, GETDATE()
									, @IdUsuario
									, GETDATE()
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Inventario].[TipoProducto] SET
			
			  Descripcion=@Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
						
						  inserted.IdTipoProducto
						, inserted.CodigoTipoProducto
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdTipoProducto = @IdTipoProducto
									AND CodigoTipoProducto = @CodigoTipoProducto
END
	
IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Inventario].[TipoProducto] SET
			
			  Estatus = 0
			, UsuarioModifica = @IdUsuario
			, FechaModifica = GETDATE()		
				
							
				OUTPUT
						
						  inserted.IdTipoProducto
						, inserted.CodigoTipoProducto
						, inserted.Descripcion
						, inserted.Estatus
						, inserted.UsuarioAdiciona
						, inserted.FechaAdiciona
						, inserted.UsuarioModifica
						, inserted.FechaModifica
							
							INTO @ITEMS
								
								WHERE IdTipoProducto = @IdTipoProducto
									AND CodigoTipoProducto = @CodigoTipoProducto
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Inventario].[SP_MANTENIMIENTO_TIPO_PROVEEDOR]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Inventario].[SP_MANTENIMIENTO_TIPO_PROVEEDOR]
  @IdTipoProveedor DECIMAL(18,0)
, @CodigoTipoProveedor VARCHAR(100)
, @Descripcion VARCHAR(100)
, @Estatus BIT
, @IdUsuario DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdTipoProveedor DECIMAL(18,0)
, CodigoTipoProveedor VARCHAR(100)
, Descripcion VARCHAR(100)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)
	
	IF(@Accion='INSERT')
		
		BEGIN
				

			SELECT
			@IdTipoProveedor = ISNULL(MAX(IdTipoProveedor),0) + 1
			FROM [Inventario].[TipoProveedor]
			IF(ISNULL(@IdTipoProveedor,0) = 0)
			SET @IdTipoProveedor = 1
				
				

				UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 4) WHERE IdSecuencial = 4
					
					INSERT INTO [Inventario].[TipoProveedor]
					(
						  IdTipoProveedor
						, CodigoTipoProveedor
						, Descripcion
						, Estatus
						, UsuarioAdiciona
						, FechaAdiciona
						, UsuarioModifica
						, FechaModifica
					)
						
						OUTPUT
							
							  inserted.IdTipoProveedor
							, inserted.CodigoTipoProveedor
							, inserted.Descripcion
							, inserted.Estatus
							, inserted.UsuarioAdiciona
							, inserted.FechaAdiciona
							, inserted.UsuarioModifica
							, inserted.FechaModifica
								
								INTO @ITEMS
									
									VALUES
									(
										   @IdTipoProveedor
										,  (SELECT
										   CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR), CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR), CAST(Secuencia AS VARCHAR))
										    FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 4)
										  , @Descripcion
										  , @Estatus
										  , @IdUsuario
										  , GETDATE()
										  , @IdUsuario
										  , GETDATE()
									)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Inventario].[TipoProveedor] SET
			
			  Descripcion=@Descripcion
			, Estatus=@Estatus
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
							
							  inserted.IdTipoProveedor
							, inserted.CodigoTipoProveedor
							, inserted.Descripcion
							, inserted.Estatus
							, inserted.UsuarioAdiciona
							, inserted.FechaAdiciona
							, inserted.UsuarioModifica
							, inserted.FechaModifica
								
								INTO @ITEMS
									
									WHERE IdTipoProveedor = @IdTipoProveedor
									AND CodigoTipoProveedor = @CodigoTipoProveedor
END

IF(@Accion = 'DISABLE')
	
	BEGIN
			
		UPDATE [Inventario].[TipoProveedor] SET
			

			  Estatus=0
			, UsuarioModifica=@IdUsuario
			, FechaModifica=GETDATE()
				
				OUTPUT
							
							  inserted.IdTipoProveedor
							, inserted.CodigoTipoProveedor
							, inserted.Descripcion
							, inserted.Estatus
							, inserted.UsuarioAdiciona
							, inserted.FechaAdiciona
							, inserted.UsuarioModifica
							, inserted.FechaModifica
								
								INTO @ITEMS
									
									WHERE IdTipoProveedor = @IdTipoProveedor
									AND CodigoTipoProveedor = @CodigoTipoProveedor
END
SELECT * FROM @ITEMS	
GO
/****** Object:  StoredProcedure [Listas].[SP_BUSCA_TIPO_PROVEEDORES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_BUSCA_TIPO_PROVEEDORES]

AS

SELECT
TP.IdTipoProveedor
,TP.Descripcion
FROM [Inventario].[TipoProveedor] TP
WHERE TP.Estatus=1
GO
/****** Object:  StoredProcedure [Listas].[SP_CARGAR_LISTA_ESTATUS_FACTURACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_CARGAR_LISTA_ESTATUS_FACTURACION]

AS

SELECT
  E.IdEstatusFacturacion
, E.Estatus
FROM [Facturacion].[EstatusFacturacion] E

WHERE E.IdEstatusFacturacion != 3

ORDER BY E.IdEstatusFacturacion ASC
GO
/****** Object:  StoredProcedure [Listas].[SP_CARGAR_LISTA_MEDICOS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_CARGAR_LISTA_MEDICOS]
@IdCentroSalud DECIMAL(20,0) = NULL

AS

SELECT
  M.IdMedico
, M.NombreMedico
FROM [Empresa].[Medico] M

WHERE M.Estatus = 1
AND M.IdCentroSalud = ISNULL(@IdCentroSalud,M.IdCentroSalud)

ORDER BY M.IdMedico ASC
GO
/****** Object:  StoredProcedure [Listas].[SP_CARGAR_LISTA_SEXO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Listas].[SP_CARGAR_LISTA_SEXO]

AS

SELECT
  S.IdSexo
, S.Descripcion
FROM [Empresa].[Sexo] S
GO
/****** Object:  StoredProcedure [Listas].[SP_CARGAR_LISTA_TIPO_IDENTIFICACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_CARGAR_LISTA_TIPO_IDENTIFICACION]

AS

SELECT
  TI.IdTipoIdentificacion
, TI.Descripcion
FROM [Empresa].[TipoIdentificacion] TI
GO
/****** Object:  StoredProcedure [Listas].[SP_CARGAR_LISTA_TIPO_PAGO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_CARGAR_LISTA_TIPO_PAGO]

AS

SELECT
  TF.IdTipoPago
, TF.Descripcion
FROM [Facturacion].[TipoPago] TF

WHERE TF.Estatus = 1
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_ALMACEN]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_LISTA_ALMACEN]

AS

SELECT
A.IdAlmacen
,A.Nombre
FROM [Inventario].[Almacen] A
WHERE A.Estatus=1
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_CENTRO_SALUD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [Listas].[SP_LISTA_CENTRO_SALUD]
as

select 
ce.IdCentroSalud,
ce.Nombre
from [Empresa].[CentroSalud] ce
where ce.Estatus=1
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_COMPROBANTES_FISCALES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_LISTA_COMPROBANTES_FISCALES]
AS

SELECT 
  NCF.IdComprobante
, NCF.Descripcion
FROM [Contabilidad].[ComprobantesFiscales] NCF

WHERE NCF.Estatus = 1
ORDER BY NCF.PorDefecto DESC
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_ESTATUS_CIRUGIA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_LISTA_ESTATUS_CIRUGIA]

AS

SELECT
  EC.IdEstatusCirugia
, EC.Descripcion
, EC.Estatus
FROM [Facturacion].[EstatusCirugia] EC
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_PROVEEDOR]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_LISTA_PROVEEDOR]
@IdTipoProveedor DECIMAL(18,0) = NULL

AS

SELECT
  PRO.IdProveedor
, PRO.Nombre
FROM [Inventario].[Proveedor] PRO

WHERE PRO.IdTipoProveedor = ISNULL(@IdTipoProveedor,PRO.IdTipoProveedor)
and PRO.Estatus=1
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_TIPO_EMPAQUE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_LISTA_TIPO_EMPAQUE]

AS

SELECT
TE.IdTipoEmpaque
,TE.Descripcion
FROM [Inventario].[TipoEmpaque] TE
where te.Estatus=1
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_TIPO_PRODUCTO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [Listas].[SP_LISTA_TIPO_PRODUCTO]

AS

SELECT
  TPRO.IdTipoProducto
, TPRO.Descripcion
FROM [Inventario].[TipoProducto] TPRO
where TPRO.Estatus=1
GO
/****** Object:  StoredProcedure [Listas].[SP_LISTA_USUARIOS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Listas].[SP_LISTA_USUARIOS]
AS

SELECT
  U.IdUsuario
, U.Persona
, U.Usuario
FROM [Seguridad].[Usuario] U
WHERE U.Estatus = 1
GO
/****** Object:  StoredProcedure [Reporte].[SP_FACTURA_VENTA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [Reporte].[SP_FACTURA_VENTA] 
  @NumeroConector DECIMAL(20,0) = NULL


AS

SELECT 
  FCLI.NumeroFactura
, UPPER(FCLI.NombrePaciente) AS NombrePaciente
, FCLI.IdTipoIdentificacion
, TI.Descripcion AS TipoIdentificacion
, FCLI.NumeroIdentificacion
, FCLI.IdEstatusFacturacion
, CASE EF.Estatus WHEN 'FACTURADO' THEN 'FACTURA' ELSE 'COTIZACION' END AS Estatus
, FCLI.CodigoFacturacion
, FCLI.NumeroConector
, FCLI.IdTipoFacturacion
, NCF.Descripcion AS TipoComprobante
, NCF.ValidoHasta
, COALESCE(FNCF.Comprobante ,' ') AS Comprobante
, FCLI.Telefono
, FCLI.IdCentroSalud
, CE.Nombre AS CentroSalud
, FCLI.Sala
, FCLI.IdMedico
, UPPER(M.NombreMedico) AS Medico
, FCLI.Direccion
, FCLI.IdSexo
, S.Descripcion AS Sexo
, FCLI.Email
, FCLI.ComentarioPaciente
, FCLI.FechaFacturacion AS FechaFacturacion0
, CONVERT(NVARCHAR,FCLI.FechaFacturacion,103) AS FechaFacturacion
, FCLI.IdUsuario
, UPPER(UC.Persona) AS Creadopor
, FPRO.IdProducto
, TPRO.Descripcion AS TipoProducto
, PRO.Descripcion AS ProDucto
, FPRO.Cantidad
, FPRO.Precio
, FPRO.DescuentoAplicado
, FPRO.Total
, FCAL.CantidadArticulos AS CantidadArticulos
, FCAL.TotalDescuento
, FCAL.Subtotal
, FCAL.Impuesto
, FCAL.Total AS TotalGeneral
, FCAL.IdTipoPago
, FCAL.IdEstatusCirugia
, EC.Descripcion AS EstatusCirugia
, TP.Descripcion AS TipoPago
, FCAL.MontoPagado
, I.IdInformacionEmpresa
, I.CodigoInformacionEmpresa
, I.NombreEmpresa
, I.RNC
, I.Direccion
, I.Email
, I.Email2
, I.Facebook
, I.Instagran
, I.Telefonos
, I.Fac AS Fax
, L.IdLogoEmpresa
, L.Descripcion
, L.LogoEmpresa
FROM [Facturacion].[FacturacionCliente] FCLI
INNER JOIN [Empresa].[TipoIdentificacion] TI ON TI.IdTipoIdentificacion = FCLI.IdTipoIdentificacion
INNER JOIN [Facturacion].[EstatusFacturacion] EF ON EF.IdEstatusFacturacion = FCLI.IdEstatusFacturacion
INNER JOIN [Contabilidad].[ComprobantesFiscales] NCF ON NCF.IdComprobante = FCLI.IdTipoFacturacion
INNER JOIN [Empresa].[CentroSalud] CE ON CE.IdCentroSalud = FCLI.IdCentroSalud
INNER JOIN [Empresa].[Medico] M ON M.IdCentroSalud = FCLI.IdCentroSalud AND M.IdMedico = FCLI.IdMedico
INNER JOIN [Empresa].[Sexo] S ON S.IdSexo = FCLI.IdSexo
INNER JOIN [Facturacion].[FacturacionpProducto] FPRO ON FPRO.NumeroConector = FCLI.NumeroConector
INNER JOIN [Inventario].[Producto] PRO ON PRO.IdProducto = FPRO.IdProducto
INNER JOIN [Inventario].[TipoProducto] TPRO ON TPRO.IdTipoProducto = PRO.IdTipoProducto
INNER JOIN [Facturacion].[FacturacionCalculos] FCAL ON FCAL.NumeroConector = FCLI.NumeroConector AND FCAL.NumeroConector = FPRO.NumeroConector
INNER JOIN [Facturacion].[TipoPago] TP ON TP.IdTipoPago = FCAL.IdTipoPago
INNER JOIN [Facturacion].[EstatusCirugia] EC ON EC.IdEstatusCirugia = FCAL.IdEstatusCirugia
LEFT JOIN [Facturacion].[FacturacionComprobante] FNCF ON FNCF.NumeroConector = FCLI.NumeroConector
AND FNCF.NumeroConector = FPRO.NumeroConector AND FNCF.NumeroConector = FCAL.NumeroConector
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = FCLI.IdUsuario
LEFT JOIN [Configuracion].[InformacionEmpresa] I ON I.IdInformacionEmpresa = 1
LEFT JOIN [Configuracion].[LogoEmpresa] L ON L.IdLogoEmpresa = 1

WHERE FCLI.NumeroConector = ISNULL(@NumeroConector,FCLI.NumeroConector)
GO
/****** Object:  StoredProcedure [Reporte].[SP_GENERAR_REPORTE_CUADRE_CAJA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Reporte].[SP_GENERAR_REPORTE_CUADRE_CAJA]
@IdUsuario DECIMAL(20,0) = NULL

AS

SELECT
  CJ.IdUsuario
, U.Persona AS Usuario
, CJ.Caja
, CJ.Monto
, CJ.Concepto
, CJ.Fecha
, CJ.NumeroReferencia
, CJ.TipoPago
, CONCAT('Validado Desde ',CONVERT(NVARCHAR,CJ.FechaDesde,103)) AS 'FechaDesde'
, CONCAT('Hasta ',CONVERT(NVARCHAR,CJ.FechaHasta,103)) AS 'FechaHasta'
, I.NombreEmpresa
, I.Direccion
, I.RNC
, I.Email
, I.Email2
, I.Telefonos
, L.LogoEmpresa
FROM [Caja].[CuadreCaja] CJ
INNER JOIN [Configuracion].[InformacionEmpresa] i on i.IdInformacionEmpresa = 1
INNER JOIN [Configuracion].[LogoEmpresa] L ON L.IdLogoEmpresa = 1
LEFT JOIN[Seguridad].[Usuario] U ON U.IdUsuario = CJ.IdUsuario

WHERE CJ.IdUsuario = ISNULL(@IdUsuario,CJ.IdUsuario)
GO
/****** Object:  StoredProcedure [Reporte].[SP_MANTENIMIENTO_CUADRE_CAJA]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Reporte].[SP_MANTENIMIENTO_CUADRE_CAJA]
  @IdUsuario DECIMAL(20,0)
, @Caja VARCHAR(100)
, @Monto DECIMAL(20,2)
, @Concepto VARCHAR(8000)
, @Fecha VARCHAR(100)
, @CreadoPor VARCHAR(100)
, @NumeroReferencia DECIMAL(20,0)
, @TipoPago VARCHAR(100)
, @FechaDesde DATE
, @FechaHasta DATE
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdUsuario DECIMAL(20,0)
, Caja VARCHAR(100)
, Monto DECIMAL(20,2)
, Concepto VARCHAR(8000)
, Fecha VARCHAR(100)
, CreadoPor VARCHAR(100)
, NumeroReferencia DECIMAL(20,0)
, TipoPago VARCHAR(100)
, FechaDesde DATE
, FechaHasta DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		INSERT INTO [Caja].[CuadreCaja]
		(
			  IdUsuario
			, Caja
			, Monto
			, Concepto
			, Fecha
			, CreadoPor
			, NumeroReferencia
			, TipoPago
			, FechaDesde
			, FechaHasta
		)
			
			OUTPUT
				
				  inserted.IdUsuario
				, inserted.Caja
				, inserted.Monto
				, inserted.Concepto
				, inserted.Fecha
				, inserted.CreadoPor
				, inserted.NumeroReferencia
				, inserted.TipoPago
				, inserted.FechaDesde
				, inserted.FechaHasta
					
					INTO @ITEMS
						
						VALUES
						(
							  @IdUsuario
							, @Caja
							, @Monto
							, @Concepto
							, @Fecha
							, @CreadoPor
							, @NumeroReferencia
							, @TipoPago
							, @FechaDesde
							, @FechaHasta
						)
END

IF(@Accion='DELETE')
	
	BEGIN
		
		DELETE FROM [Caja].[CuadreCaja] 
			
			OUTPUT
				
				  deleted.IdUsuario
				, deleted.Caja
				, deleted.Monto
				, deleted.Concepto
				, deleted.Fecha
				, deleted.CreadoPor
				, deleted.NumeroReferencia
				, deleted.TipoPago	
				, deleted.FechaDesde
				, deleted.FechaHasta
					
					INTO @ITEMS
						
						WHERE IdUsuario = @IdUsuario
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Reporte].[SP_MANTENIMIENTO_HISTORIAL_FACTURACION_COTIZACION]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Reporte].[SP_MANTENIMIENTO_HISTORIAL_FACTURACION_COTIZACION]
  @IdUsuario DECIMAL(20,0)
, @NumeroFactura DECIMAL(20,0)
, @NombrePaciente VARCHAR(1000)
, @IdTipoIdentificacion DECIMAL(20,0)
, @TipoIdentificacion VARCHAR(100)
, @NumeroIdentificacion VARCHAR(100)
, @IdEstatusFacturacion DECIMAL(20,0)
, @Estatus VARCHAR(100)
, @CodigoFacturacion VARCHAR(100)
, @NumeroConector DECIMAL(20,0)
, @IdTipoFacturacion DECIMAL(20,0)
, @TipoComprobante VARCHAR(100)
, @ValidoHasta VARCHAR(100)
, @Comprobante VARCHAR(100)
, @Telefono VARCHAR(100)
, @IdCentroSalud DECIMAL(20,0)
, @CentroSalud VARCHAR(1000)
, @Sala VARCHAR(100)
, @IdMedico DECIMAL(20,0)
, @Medico VARCHAR(100)
, @Direccion VARCHAR(8000)
, @IdSexo DECIMAL(20,0)
, @Sexo VARCHAR(100)
, @Email VARCHAR(100)
, @ComentarioPaciente VARCHAR(8000)
, @FechaFacturacion0 DATE
, @FechaFacturacion VARCHAR(100)
, @IdUsuarioCrea DECIMAL(20,0)
, @Creadopor VARCHAR(100)
, @IdProducto DECIMAL(20,0)
, @TipoProducto VARCHAR(100)
, @ProDucto VARCHAR(100)
, @Cantidad DECIMAL(20,0)
, @Precio DECIMAL(20,2)
, @DescuentoAplicado DECIMAL(20,2)
, @Total DECIMAL(20,2)
, @CantidadArticulos DECIMAL(20,0)
, @TotalDescuento DECIMAL(20,2)
, @Subtotal DECIMAL(20,2)
, @Impuesto DECIMAL(20,2)
, @TotalGeneral DECIMAL(20,2)
, @IdTipoPago DECIMAL(20,0)
, @TipoPago VARCHAR(100)
, @MontoPagado DECIMAL(20,2)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdUsuario DECIMAL(20,0)
, NumeroFactura DECIMAL(20,0)
, NombrePaciente VARCHAR(1000)
, IdTipoIdentificacion DECIMAL(20,0)
, TipoIdentificacion VARCHAR(100)
, NumeroIdentificacion VARCHAR(100)
, IdEstatusFacturacion DECIMAL(20,0)
, Estatus VARCHAR(100)
, CodigoFacturacion VARCHAR(100)
, NumeroConector DECIMAL(20,0)
, IdTipoFacturacion DECIMAL(20,0)
, TipoComprobante VARCHAR(100)
, ValidoHasta VARCHAR(100)
, Comprobante VARCHAR(100)
, Telefono VARCHAR(100)
, IdCentroSalud DECIMAL(20,0)
, CentroSalud VARCHAR(1000)
, Sala VARCHAR(100)
, IdMedico DECIMAL(20,0)
, Medico VARCHAR(100)
, Direccion VARCHAR(8000)
, IdSexo DECIMAL(20,0)
, Sexo VARCHAR(100)
, Email VARCHAR(100)
, ComentarioPaciente VARCHAR(8000)
, FechaFacturacion0 DATE
, FechaFacturacion VARCHAR(100)
, IdUsuarioCrea DECIMAL(20,0)
, Creadopor VARCHAR(100)
, IdProducto DECIMAL(20,0)
, TipoProducto VARCHAR(100)
, ProDucto VARCHAR(100)
, Cantidad DECIMAL(20,0)
, Precio DECIMAL(20,2)
, DescuentoAplicado DECIMAL(20,2)
, Total DECIMAL(20,2)
, CantidadArticulos DECIMAL(20,0)
, TotalDescuento DECIMAL(20,2)
, Subtotal DECIMAL(20,2)
, Impuesto DECIMAL(20,2)
, TotalGeneral DECIMAL(20,2)
, IdTipoPago DECIMAL(20,0)
, TipoPago VARCHAR(100)
, MontoPagado DECIMAL(20,2)
)

IF(@Accion='INSERT')
	
	BEGIN
		
		INSERT INTO [Reporte].[HistorialFacturacionCotizacion]
		(
			  IdUsuario
            , NumeroFactura
            , NombrePaciente
            , IdTipoIdentificacion
            , TipoIdentificacion
            , NumeroIdentificacion
            , IdEstatusFacturacion
            , Estatus
            , CodigoFacturacion
            , NumeroConector
            , IdTipoFacturacion
            , TipoComprobante
            , ValidoHasta
            , Comprobante
            , Telefono
            , IdCentroSalud
            , CentroSalud
            , Sala
            , IdMedico
            , Medico
            , Direccion
            , IdSexo
            , Sexo
            , Email
            , ComentarioPaciente
            , FechaFacturacion0
            , FechaFacturacion
            , IdUsuarioCrea
            , Creadopor
            , IdProducto
            , TipoProducto
            , ProDucto
            , Cantidad
            , Precio
            , DescuentoAplicado
            , Total
            , CantidadArticulos
            , TotalDescuento
            , Subtotal
            , Impuesto
            , TotalGeneral
            , IdTipoPago
            , TipoPago
            , MontoPagado
			)
	
	
		      OUTPUT
		  inserted.IdUsuario
        , inserted.NumeroFactura
        , inserted.NombrePaciente
        , inserted.IdTipoIdentificacion
        , inserted.TipoIdentificacion
        , inserted.NumeroIdentificacion
        , inserted.IdEstatusFacturacion
        , inserted.Estatus
        , inserted.CodigoFacturacion
        , inserted.NumeroConector
        , inserted.IdTipoFacturacion
        , inserted.TipoComprobante
        , inserted.ValidoHasta
        , inserted.Comprobante
        , inserted.Telefono
        , inserted.IdCentroSalud
        , inserted.CentroSalud
        , inserted.Sala
        , inserted.IdMedico
        , inserted.Medico
        , inserted.Direccion
        , inserted.IdSexo
        , inserted.Sexo
        , inserted.Email
        , inserted.ComentarioPaciente
        , inserted.FechaFacturacion0
        , inserted.FechaFacturacion
        , inserted.IdUsuarioCrea
        , inserted.Creadopor
        , inserted.IdProducto
        , inserted.TipoProducto
        , inserted.ProDucto
        , inserted.Cantidad
        , inserted.Precio
        , inserted.DescuentoAplicado
        , inserted.Total
        , inserted.CantidadArticulos
        , inserted.TotalDescuento
        , inserted.Subtotal
        , inserted.Impuesto
        , inserted.TotalGeneral
        , inserted.IdTipoPago
        , inserted.TipoPago
        , inserted.MontoPagado
			
			 INTO @ITEMS
			  
			  VALUES
			  (
			  @IdUsuario
            , @NumeroFactura
            , @NombrePaciente
            , @IdTipoIdentificacion
            , @TipoIdentificacion
            , @NumeroIdentificacion
            , @IdEstatusFacturacion
            , @Estatus
            , @CodigoFacturacion
            , @NumeroConector
            , @IdTipoFacturacion
            , @TipoComprobante
            , @ValidoHasta
            , @Comprobante
            , @Telefono
            , @IdCentroSalud
            , @CentroSalud
            , @Sala
            , @IdMedico
            , @Medico
            , @Direccion
            , @IdSexo
            , @Sexo
            , @Email
            , @ComentarioPaciente
            , @FechaFacturacion0
            , @FechaFacturacion
            , @IdUsuarioCrea
            , @Creadopor
            , @IdProducto
            , @TipoProducto
            , @ProDucto
            , @Cantidad
            , @Precio
            , @DescuentoAplicado
            , @Total
            , @CantidadArticulos
            , @TotalDescuento
            , @Subtotal
            , @Impuesto
            , @TotalGeneral
            , @IdTipoPago
            , @TipoPago
            , @MontoPagado
			  )
END

IF(@Accion='DELETE')
	
	BEGIN
		
		DELETE [Reporte].[HistorialFacturacionCotizacion]
			
			 OUTPUT
		  deleted.IdUsuario
        , deleted.NumeroFactura
        , deleted.NombrePaciente
        , deleted.IdTipoIdentificacion
        , deleted.TipoIdentificacion
        , deleted.NumeroIdentificacion
        , deleted.IdEstatusFacturacion
        , deleted.Estatus
        , deleted.CodigoFacturacion
        , deleted.NumeroConector
        , deleted.IdTipoFacturacion
        , deleted.TipoComprobante
        , deleted.ValidoHasta
        , deleted.Comprobante
        , deleted.Telefono
        , deleted.IdCentroSalud
        , deleted.CentroSalud
        , deleted.Sala
        , deleted.IdMedico
        , deleted.Medico
        , deleted.Direccion
        , deleted.IdSexo
        , deleted.Sexo
        , deleted.Email
        , deleted.ComentarioPaciente
        , deleted.FechaFacturacion0
        , deleted.FechaFacturacion
        , deleted.IdUsuarioCrea
        , deleted.Creadopor
        , deleted.IdProducto
        , deleted.TipoProducto
        , deleted.ProDucto
        , deleted.Cantidad
        , deleted.Precio
        , deleted.DescuentoAplicado
        , deleted.Total
        , deleted.CantidadArticulos
        , deleted.TotalDescuento
        , deleted.Subtotal
        , deleted.Impuesto
        , deleted.TotalGeneral
        , deleted.IdTipoPago
        , deleted.TipoPago
        , deleted.MontoPagado
			
			 INTO @ITEMS
				
				WHERE IdUsuario = @IdUsuario
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Reporte].[SP_MANTENIMIENTO_RUTA_REPORTES]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Reporte].[SP_MANTENIMIENTO_RUTA_REPORTES]
  @IdReporte DECIMAL(20,0)
, @DescripcionReporte VARCHAR(8000)
, @RutaReporte VARCHAR(8000)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdReporte DECIMAL(20,0)
, DescripcionReporte VARCHAR(8000)
, RutaReporte VARCHAR(8000)
)

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Reporte].[RutaReporte] SET 
			
			  DescripcionReporte=@DescripcionReporte
			, RutaReporte=@RutaReporte
				
				OUTPUT
					
					  inserted.IdReporte
					, inserted.DescripcionReporte
					, inserted.RutaReporte
						
						INTO @ITEMS
							
							WHERE IdReporte = @IdReporte
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Reporte].[SP_SACAR_HISTORIAL_Facturacion_Cotizacion]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Reporte].[SP_SACAR_HISTORIAL_Facturacion_Cotizacion]
@IdUsuario DECIMAL(20,0) = NULL

AS

SELECT
  HFC.IdUsuario
, HFC.NumeroFactura
, HFC.NombrePaciente
, HFC.IdTipoIdentificacion
, HFC.TipoIdentificacion
, HFC.NumeroIdentificacion
, HFC.IdEstatusFacturacion
, HFC.Estatus
, HFC.CodigoFacturacion
, HFC.NumeroConector
, HFC.IdTipoFacturacion
, HFC.TipoComprobante
, HFC.ValidoHasta
, HFC.Comprobante
, HFC.Telefono
, HFC.IdCentroSalud
, HFC.CentroSalud
, HFC.Sala
, HFC.IdMedico
, HFC.Medico
, HFC.Direccion
, HFC.IdSexo
, HFC.Sexo
, HFC.Email
, HFC.ComentarioPaciente
, HFC.FechaFacturacion0
, HFC.FechaFacturacion
, HFC.IdUsuarioCrea
, HFC.Creadopor
, HFC.IdProducto
, HFC.TipoProducto
, HFC.ProDucto
, HFC.Cantidad
, HFC.Precio
, HFC.DescuentoAplicado
, HFC.Total
, HFC.CantidadArticulos
, HFC.TotalDescuento
, HFC.Subtotal
, HFC.Impuesto
, HFC.TotalGeneral
, HFC.IdTipoPago
, HFC.TipoPago
, HFC.MontoPagado 
, I.IdInformacionEmpresa
, I.NombreEmpresa
, I.Direccion
, I.Email
, I.Email2
, I.Fac AS Fax
, i.Telefonos
, I.RNC
, I.Facebook
, I.Instagran
, I.CodigoInformacionEmpresa
, L.IdLogoEmpresa
, L.Descripcion AS DescripcionLogo
, L.LogoEmpresa
FROM [Reporte].[HistorialFacturacionCotizacion] HFC
INNER JOIN [Configuracion].[InformacionEmpresa] I ON I.IdInformacionEmpresa = 1
INNER JOIN [Configuracion].[LogoEmpresa] L ON L.IdLogoEmpresa = 1
GO
/****** Object:  StoredProcedure [Reporte].[SP_SACAR_RUTA_REPORTE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Reporte].[SP_SACAR_RUTA_REPORTE]
@IdReporte DECIMAL(20,0) = NULL

AS

SELECT
  R.IdReporte
, UPPER(R.DescripcionReporte) AS DescripcionReporte
, R.RutaReporte
FROM [Reporte].[RutaReporte] R 

WHERE R.IdReporte = ISNULL(@IdReporte,R.IdReporte)

ORDER BY R.IdReporte ASC
GO
/****** Object:  StoredProcedure [Seguridad].[SP_BUSCA_CLAVE_SEGURIDAD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Seguridad].[SP_BUSCA_CLAVE_SEGURIDAD]
  @ClaveSeguridad VARCHAR(8000)
, @IdUsuario DECIMAL(18,0)
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  CLA.IdClaveSeguridad
, CLA.IdUsuario
, U.Persona
, P.Descripcion AS Perfil
, CLA.Clave
, CLA.Estatus AS Estatus0
, CASE CLA.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' ELSE 'ERROR' END AS Estatus
, CLA.UsuarioAdiciona
, UC.Persona AS CreadoPor
, CLA.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,CLA.FechaAdiciona,103) AS FechaAdiciona
, CLA.UsuarioModifica
, UM.Persona AS ModificadoPor
, CLA.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,CLA.FechaModifica,103) AS FechaModifica
FROM [Seguridad].[ClaveSeguridad] CLA
INNER JOIN [Seguridad].[Usuario] U ON U.IdUsuario = CLA.IdUsuario
INNER JOIN [Seguridad].[Perfil] P ON P.IdPerfil = U.IdPerfil
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = CLA.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = CLA.UsuarioModifica

WHERE CLA.Clave = ISNULL(@ClaveSeguridad,CLA.Clave)
AND CLA.IdUsuario = ISNULL(@IdUsuario,CLA.IdUsuario)

ORDER BY CLA.IdUsuario
OFFSET (@NumeroPagina - 1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Seguridad].[SP_BUSCA_USUARIOS]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Seguridad].[SP_BUSCA_USUARIOS]
  @IdUsuario DECIMAL(18,0) = NULL
, @CodigoUsuario VARCHAR(100) = NULL
, @IdPerfil DECIMAL(18,0) = NULL
, @Usuario VARCHAR(20) = NULL
, @UsuarioLogin VARCHAR(20) = NULL
, @Clave VARCHAR(8000) = NULL
, @NumeroPagina INT = NULL
, @NumeroRegistros INT = 10

AS

SELECT
  U.IdUsuario
, U.CodigoUsuario
, U.IdPerfil
, P.Descripcion AS Perfil
, U.Usuario
, U.Clave
, U.Persona
, U.Estatus AS Estatus0
, CASE U.Estatus WHEN 1 THEN 'ACTIVO' WHEN 0 THEN 'INACTIVO' END AS Estatus
, U.UsuarioAdiciona
, UC.Persona AS CreadoPor
, U.FechaAdiciona AS FechaAdiciona0
, CONVERT(NVARCHAR,U.FechaAdiciona,103) AS FechaAdiciona
, U.UsuarioModifica
, UM.Persona AS ModificadoPor
, U.FechaModifica AS FechaModifica0
, CONVERT(NVARCHAR,U.FechaModifica,103) AS FechaModifica
FROM [Seguridad].[Usuario] U
INNER JOIN [Seguridad].[Perfil] P ON P.IdPerfil = U.IdPerfil
LEFT JOIN [Seguridad].[Usuario] UC ON UC.IdUsuario = UC.UsuarioAdiciona
LEFT JOIN [Seguridad].[Usuario] UM ON UM.IdUsuario = UM.UsuarioModifica

WHERE U.IdUsuario = ISNULL(@IdUsuario,U.IdUsuario)
AND U.CodigoUsuario = ISNULL(@CodigoUsuario,U.CodigoUsuario)
AND U.IdPerfil = ISNULL(@IdPerfil,U.IdPerfil)
AND U.Usuario LIKE '%' + ISNULL(@Usuario,U.Usuario) + '%'
AND U.Usuario = ISNULL(@UsuarioLogin,U.Usuario)
AND U.Clave = ISNULL(@Clave,U.Clave)

ORDER BY U.IdUsuario
OFFSET (@NumeroPagina -1) * @NumeroRegistros ROWS
FETCH NEXT @NumeroRegistros ROWS ONLY;
GO
/****** Object:  StoredProcedure [Seguridad].[SP_BUSCAR_EJECUTAR_USUARIO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Seguridad].[SP_BUSCAR_EJECUTAR_USUARIO]
@IdUsuario DECIMAL(18,0) = NULL

AS

SELECT
  E.IdRegistro
, E.IdUsuario
, E.CantidadIntentos
FROM [Seguridad].[EjecutarUsuario] E

WHERE E.IdUsuario = ISNULL(@IdUsuario,E.IdUsuario)
GO
/****** Object:  StoredProcedure [Seguridad].[SP_MANTENIMIENTO_CLAVE_SEGURIDAD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SP_HELP 'Seguridad.ClaveSeguridad'

CREATE PROCEDURE [Seguridad].[SP_MANTENIMIENTO_CLAVE_SEGURIDAD]
  @IdClaveSeguridad DECIMAL(18,0)
, @IdUsuario DECIMAL(18,0)
, @Clave VARCHAR(8000)
, @Estatus BIT
, @IdUsuarioCrea DECIMAL(18,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdClaveSeguridad DECIMAL(18,0)
, IdUsuario DECIMAL(18,0)
, Clave VARCHAR(8000)
, Estatus BIT
, UsuarioAdiciona DECIMAL(18,0)
, FechaAdiciona  DATE
, UsuarioModifica DECIMAL(18,0)
, FechaModifica DATE
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdClaveSeguridad = ISNULL (MAX(IdClaveSeguridad),0) + 1
		FROM [Seguridad].[ClaveSeguridad]
		IF(ISNULL(@IdClaveSeguridad,0) = 0)
		SET @IdClaveSeguridad = 1
			
			INSERT INTO [Seguridad].[ClaveSeguridad]
			(
				  IdClaveSeguridad
				, IdUsuario
				, Clave
				, Estatus
				, UsuarioAdiciona
				, FechaAdiciona
				, UsuarioModifica
				, FechaModifica
			)
				
				OUTPUT	
					
					  inserted.IdClaveSeguridad
					, inserted.IdUsuario
					, inserted.Clave
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							VALUES
							(
								  @IdClaveSeguridad
								, @IdUsuario
								, @Clave
								, @Estatus
								, @IdUsuarioCrea
								, GETDATE()
								, @IdUsuarioCrea
								, GETDATE()
							)
END
IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Seguridad].[ClaveSeguridad] SET 
			
			  Clave = @Clave
			, Estatus = @Estatus
			, UsuarioModifica=@IdUsuarioCrea
			, FechaModifica=GETDATE()
				

				OUTPUT	
					
					  inserted.IdClaveSeguridad
					, inserted.IdUsuario
					, inserted.Clave
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE 
							 IdUsuario = @IdUsuario
END

IF(@Accion='DISABLE')
	
	BEGIN	
		
		UPDATE [Seguridad].[ClaveSeguridad] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdUsuarioCrea
			, FechaModifica=GETDATE()
				
				OUTPUT	
					
					  inserted.IdClaveSeguridad
					, inserted.IdUsuario
					, inserted.Clave
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE 
							 IdUsuario = @IdUsuario
END
SELECT * FROM @ITEMS
					
GO
/****** Object:  StoredProcedure [Seguridad].[SP_MANTENIMIENTO_USUARIO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Seguridad].[SP_MANTENIMIENTO_USUARIO]
  @IdUsuario DECIMAL(20,0)
, @CodigoUsuario VARCHAR(100)
, @IdPerfil DECIMAL(20,0)
, @Usuario VARCHAR(20)
, @Clave VARCHAR(8000)
, @Persona VARCHAR(1000)
, @Estatus BIT
, @IdusuarioCrea DECIMAL(20,0)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdUsuario DECIMAL(20,0)
, CodigoUsuario VARCHAR(100)
, IdPerfil DECIMAL(20,0)
, Usuario VARCHAR(20)
, Clave VARCHAR(8000)
, Persona VARCHAR(1000)
, Estatus BIT
, UsuarioAdiciona DECIMAL(20,0)
, FechaAdiciona DATETIME
, UsuarioModifica DECIMAL(20,0)
, FechaModifica DATETIME
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT 
		@IdUsuario=ISNULL(MAX(IdUsuario),0) + 1
		FROM [Seguridad].[Usuario]
		IF(ISNULL(@IdUsuario,0) = 0)
		SET @IdUsuario = 1

		UPDATE [Configuracion].[Secuencial] SET Secuencia = (SELECT MAX(Secuencia) + 1 FROM [Configuracion].[Secuencial] WHERE IdSecuencial = 2) WHERE IdSecuencial = 2
			
			INSERT INTO [Seguridad].[Usuario]
			(
				  IdUsuario
				, CodigoUsuario
				, IdPerfil
				, Usuario
				, Clave
				, Persona
				, Estatus
				, UsuarioAdiciona
				, FechaAdiciona
				, UsuarioModifica
				, FechaModifica
			)
				
				OUTPUT
					
					  inserted.IdUsuario
					, inserted.CodigoUsuario
					, inserted.IdPerfil
					, inserted.Usuario
					, inserted.Clave
					, inserted.Persona
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							VALUES
							(
								  @IdUsuario
								, (SELECT
									   CONCAT(Sigla,CAST(DATEPART(YEAR,GETDATE()) AS VARCHAR),CAST(DATEPART(MONTH,GETDATE()) AS VARCHAR), CAST(Secuencia AS VARCHAR))
									  FROM Configuracion.[Secuencial] WHERE IdSecuencial = 2)
								, @IdPerfil
								, @Usuario
								, @Clave
								, @Persona
								, @Estatus
								, @IdusuarioCrea
								, GETDATE()
								, @IdusuarioCrea
								, GETDATE()
							)
END
IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Seguridad].[Usuario] SET
			
			  IdPerfil=@IdPerfil
			, Usuario=@Usuario
			, Clave=@Clave
			, Persona=@Persona
			, Estatus=@Estatus
			, UsuarioModifica=@IdusuarioCrea
			, FechaModifica=GETDATE()
				
				OUTPUT
					
					  inserted.IdUsuario
					, inserted.CodigoUsuario
					, inserted.IdPerfil
					, inserted.Usuario
					, inserted.Clave
					, inserted.Persona
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdUsuario=@IdUsuario
							AND CodigoUsuario=@CodigoUsuario
END

IF(@Accion='DISABLE')
	
	BEGIN
		
		UPDATE [Seguridad].[Usuario] SET
			
			  Estatus = 0
			, UsuarioModifica=@IdusuarioCrea
			, FechaModifica=GETDATE()
				
				OUTPUT
					
					  inserted.IdUsuario
					, inserted.CodigoUsuario
					, inserted.IdPerfil
					, inserted.Usuario
					, inserted.Clave
					, inserted.Persona
					, inserted.Estatus
					, inserted.UsuarioAdiciona
					, inserted.FechaAdiciona
					, inserted.UsuarioModifica
					, inserted.FechaModifica
						
						INTO @ITEMS
							
							WHERE IdUsuario=@IdUsuario
							AND CodigoUsuario=@CodigoUsuario
END

SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Seguridad].[SP_MANTENIMINTO_EJECUTAR_USUARIO]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Seguridad].[SP_MANTENIMINTO_EJECUTAR_USUARIO]
  @IdRegistro DECIMAL(18,0)
, @IdUsuario DECIMAL(18,0)
, @CantidadIntentos INT
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(
  IdRegistro DECIMAL(18,0)
, IdUsuario DECIMAL(18,0)
, CantidadIntentos INT
)

IF(@Accion='INSERT')
	
	BEGIN
		
		SELECT
		@IdRegistro = ISNULL(MAX(IdRegistro),0) + 1
		FROM [Seguridad].[EjecutarUsuario]
		IF(ISNULL(@IdRegistro,0) = 0)
			SET @IdRegistro = 1
				
				INSERT INTO [Seguridad].[EjecutarUsuario]
				(
					  IdRegistro
					, IdUsuario
					, CantidadIntentos
				)
					
					OUTPUT
						
						  inserted.IdRegistro
						, inserted.IdUsuario
						, inserted.CantidadIntentos
							
							INTO @ITEMS
								
								VALUES
								(
									  @IdRegistro
									, @IdUsuario
									, @CantidadIntentos
								)
END

IF(@Accion='UPDATE')
	
	BEGIN
		
		UPDATE [Seguridad].[EjecutarUsuario] SET
			
			CantidadIntentos = @CantidadIntentos
				
				OUTPUT
					
					  inserted.IdRegistro
					, inserted.IdUsuario
					, inserted.CantidadIntentos
						
						INTO @ITEMS
							
							WHERE IdUsuario = @IdUsuario
END

IF(@Accion='DELETE')
	
	BEGIN
		
		UPDATE [Seguridad].[EjecutarUsuario] SET
			
			CantidadIntentos = 0
				
				OUTPUT
					
					  inserted.IdRegistro
					, inserted.IdUsuario
					, inserted.CantidadIntentos
						
						INTO @ITEMS
							
							WHERE IdUsuario = @IdUsuario
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Seguridad].[SP_MODIFICAR_LOGON_REPORTE]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Seguridad].[SP_MODIFICAR_LOGON_REPORTE]
  @IdLogonBd DECIMAL(20,0)
, @Usuario VARCHAR(20)
, @Clave VARCHAR(8000)
, @Accion VARCHAR(150) = 'INSERT'

AS

DECLARE @ITEMS TABLE
(  
  IdLogonBd DECIMAL(20,0)
, Usuario VARCHAR(20)
, Clave VARCHAR(8000)
)
	
	IF(@Accion='UPDATE')
		
		BEGIN
			
			UPDATE [Seguridad].[LogonBD] SET
				
				  Usuario = @Usuario
				, Clave=@Clave
					
					OUTPUT
						
						  inserted.IdLogonBd
						, inserted.Usuario
						, inserted.Clave
							
							INTO @ITEMS
								
								WHERE IdLogonBd = @IdLogonBd
END
SELECT * FROM @ITEMS
GO
/****** Object:  StoredProcedure [Seguridad].[SP_SACAR_LOGON_BD]    Script Date: 11/17/2019 3:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Seguridad].[SP_SACAR_LOGON_BD]
@IdLogonBD DECIMAL(20,0) = NULL

AS

SELECT
  L.IdLogonBd
, L.Usuario
, L.Clave
FROM [Seguridad].[LogonBD] L

WHERE L.IdLogonBd = ISNULL(@IdLogonBD,L.IdLogonBd)

ORDER BY L.IdLogonBd ASC
GO
