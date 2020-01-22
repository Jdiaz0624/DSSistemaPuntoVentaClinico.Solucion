using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaListas
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDListasDataContext ObjData = new Data.Conexiones.ConexionLINQ.BDListasDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        //LISTADO DE TIPO DE PROVEEDORES
        public List<Entidades.Listas.EListaTipoProveedores> ListaTipoProveedor()
        {
            ObjData.CommandTimeout = 999999999;
            var Cargar = (from n in ObjData.SP_BUSCA_TIPO_PROVEEDORES()
                          select new Entidades.Listas.EListaTipoProveedores
                          {
                             IdTipoProveedor=n.IdTipoProveedor,
                             Descripcion=n.Descripcion
                          }).ToList();
            return Cargar;
        }

        //LISTADO DE PROVEEDORES
        public List<Entidades.Listas.EListaProveedor> ListaProveedores(decimal? IdTipoProveedor = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from n in ObjData.SP_LISTA_PROVEEDOR(IdTipoProveedor)
                          select new Entidades.Listas.EListaProveedor
                          {
                              IdProveedor=n.IdProveedor,
                              Nombre=n.Nombre
                          }).ToList();
            return Cargar;
        }

        //CARGAR LOS ALMACECES
        public List<Entidades.Listas.EListasAlmacen> ListaAlnmacenes()
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from n in ObjData.SP_LISTA_ALMACEN()
                          select new Entidades.Listas.EListasAlmacen
                          {
                              IdAlmacen=n.IdAlmacen,
                              Nombre=n.Nombre
                          }).ToList();
            return Cargar;
        }

        //CARGAR LOS TIPOS DE EMPAQUE
        public List<Entidades.Listas.EListaTipoEmpaque> ListaTipoEmpaque()
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from n in ObjData.SP_LISTA_TIPO_EMPAQUE()
                          select new Entidades.Listas.EListaTipoEmpaque
                          {
                              IdTipoEmpaque=n.IdTipoEmpaque,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Cargar;
        }

        //CARGAR LOS TIPOS DE PRODUCTOS
        public List<Entidades.Listas.EListaTipoProducto> ListaTipoProducto()
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_LISTA_TIPO_PRODUCTO()
                          select new Entidades.Listas.EListaTipoProducto
                          {
                              IdTipoProducto=n.IdTipoProducto,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Buscar;
        }

        //CARGAR LOS CENTRO DE SALUD
        public List<Entidades.Listas.ECentroSalud> ListaCentrosalud()
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from n in ObjData.SP_LISTA_CENTRO_SALUD()
                          select new Entidades.Listas.ECentroSalud
                          {
                              IdCentroSalud=n.IdCentroSalud,
                              Nombre=n.Nombre
                          }).ToList();
            return Cargar;
        }

        //CARGAR LOS COMPROBANTES FISCALES
        public List<Entidades.Listas.EListaComprobantesFiscales> ListadoComprobantes()
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from n in ObjData.SP_LISTA_COMPROBANTES_FISCALES()
                          select new Entidades.Listas.EListaComprobantesFiscales
                          {
                              IdComprobante=n.IdComprobante,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Cargar;
        }
        //CARGAR LOS SEXOS
        public List<Entidades.Listas.EListaSexo> ListaSexos()
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_CARGAR_LISTA_SEXO()
                          select new Entidades.Listas.EListaSexo
                          {
                              IdSexo=n.IdSexo,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Buscar;
        }
        //CARGAR LOS TIPOS DE IDENTIFICACION
        public List<Entidades.Listas.EListaTipoIdentificacion> ListaTipoIdentificacion()
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_CARGAR_LISTA_TIPO_IDENTIFICACION()
                          select new Entidades.Listas.EListaTipoIdentificacion
                          {
                              IdTipoIdentificacion=n.IdTipoIdentificacion,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Buscar;
        }
        //CARGAR LOS MEDICOS
        public List<Entidades.Listas.EListaMedicos> ListaMedicos(decimal? IdCentroSalud = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from N in ObjData.SP_CARGAR_LISTA_MEDICOS(IdCentroSalud)
                          select new Entidades.Listas.EListaMedicos
                          {
                              IdMedico=N.IdMedico,
                              NombreMedico=N.NombreMedico
                          }).ToList();
            return Cargar;
        }

        //CARGAR LOS TIPOS DE PAGO
        public List<Entidades.Listas.EListaTipoPago> ListaTipoPago()
        {
            ObjData.CommandTimeout = 999999999;

            var Cargar = (from n in ObjData.SP_CARGAR_LISTA_TIPO_PAGO()
                          select new Entidades.Listas.EListaTipoPago
                          {
                              IdTipoPago=n.IdTipoPago,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Cargar;
        }

        //CARGAR EL LISTADO DE LOS ESTATUS DE FACTURACION
        public List<Entidades.Listas.EListaEsatusFacturacion> ListadoEstatusFActuracion()
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_CARGAR_LISTA_ESTATUS_FACTURACION()
                          select new Entidades.Listas.EListaEsatusFacturacion
                          {
                              IdEstatusFacturacion=n.IdEstatusFacturacion,
                              Estatus=n.Estatus
                          }).ToList();
            return Buscar;
        }

        //LISTADO DE USUARIOS
        public List<Entidades.Listas.EListaUsuario> ListaUsuarios()
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_LISTA_USUARIOS()
                          select new Entidades.Listas.EListaUsuario
                          {
                              IdUsuario=n.IdUsuario,
                              Persona=n.Persona,
                              Usuario=n.Usuario
                          }).ToList();
            return Buscar;
        }

        //LISTADO DE LOS ESTATUS DE CIRUGIA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EEstatusCirugia> BuscaEstatusCirugia()
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_LISTA_ESTATUS_CIRUGIA()
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EEstatusCirugia
                           {
                               IdEstatusCirugia=n.IdEstatusCirugia,
                               Descripcion=n.Descripcion,
                               Estatus=n.Estatus
                           }).ToList();
            return Listado;
        }

        //LISTADO DE LAS HOTAS
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaHoras> BuscaHoras(decimal? IdHora = null, string Hora = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_LISTAS_HORAS(IdHora, Hora)
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaHoras
                           {
                               IdHora=n.IdHora,
                               Hora=n.Hora,
                               Estatus=n.Estatus,
                               Estatus0=n.Estatus0
                           }).ToList();
            return Listado;
        }

        //LISTADO DE ASISTENTE DE CIRUGIA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaAsistenteCirugia> BuscaAsistenteCirugia()
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_CARGAR_LISTAS_ASISTENTE_CIRUGIA()
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaAsistenteCirugia
                           {
                               IdAsistenteCirugia=n.IdAsistenteCirugia,
                               Nombre=n.Nombre
                           }).ToList();
            return Listado;
        }

        //MOSTRAR EL LISTADO DE LOS TIPOS DE VENTA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaTipoVenta> BuscaListaTipoVenta()
        {
            ObjData.CommandTimeout = 999999999;

            var BuscaTipoVenta = (from n in ObjData.SP_LISTADO_TIPO_VENTA()
                                  select new DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaTipoVenta
                                  {
                                      IdTipoVenta=n.IdTipoVenta,
                                      TipoVenta=n.TipoVenta
                                  }).ToList();
            return BuscaTipoVenta;
        }

        //MOSTRAR EL LISTADO DE LA CANTIDAD DE DIAS
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaCantidadDias> BuscaCantidadDias()
        {
            ObjData.CommandTimeout = 999999999;

            var DIas = (from n in ObjData.SP_LISTA_CANTIDAD_DIAS()
                        select new DSSistemaPuntoVentaClinico.Logica.Entidades.Listas.EListaCantidadDias
                        {
                            IdCantidadDias=n.IdCantidadDias,
                            CantidadDias=n.CantidadDias
                        }).ToList();
            return DIas;
        }
    }
}
