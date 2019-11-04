using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaInventario
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDInventarioDataContext ObjData = new Data.Conexiones.ConexionLINQ.BDInventarioDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region MANTENIMIENTO DE ALMACEN
        //LISTADO DE ALMACEN
        public List<Entidades.EntidadInventario.EAlmacen> BuscaAlmacen(decimal? IdAlmacen = null, string CodigoAlmacen = null, string Nombre = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_ALMACEN(IdAlmacen, CodigoAlmacen, Nombre, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadInventario.EAlmacen
                          {
                              IdAlmacen=n.IdAlmacen,
                              CodigoAlmacen=n.CodigoAlmacen,
                              Nombre=n.Nombre,
                              Direccion=n.Direccion,
                              Telefono=n.Telefono,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE ALMACEN
        public Entidades.EntidadInventario.EAlmacen MantenimientoAlmacen(Entidades.EntidadInventario.EAlmacen Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadInventario.EAlmacen Mantenimiento = null;

            var Almacen = ObjData.SP_MANTENIMIENTO_ALMACEN(
                Item.IdAlmacen,
                Item.CodigoAlmacen,
                Item.Nombre,
                Item.Direccion,
                Item.Telefono,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Almacen != null)
            {
                Mantenimiento = (from n in Almacen
                                 select new Entidades.EntidadInventario.EAlmacen
                                 {
                                     IdAlmacen=n.IdAlmacen,
                                     CodigoAlmacen=n.CodigoAlmacen,
                                     Nombre=n.Nombre,
                                     Direccion=n.Direccion,
                                     Telefono=n.Telefono,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion //COMPLETADO
        #region MANTENIMIENTO DE TIPO DE PROVEEDOR
        //MOSTRAR EL LISTADO DE TIPO DE PROVEEDOR
        public List<Entidades.EntidadInventario.ETipoProveedor> BuscaTipoProveedor(decimal? IdTipoProveedor = null, string CodigoTipoProveedor = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_PROVEEDOR(IdTipoProveedor, CodigoTipoProveedor, Descripcion, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadInventario.ETipoProveedor
                          {
                              IdTipoProveedor=n.IdTipoProveedor,
                              CodigoTipoProveedor=n.CodigoTipoProveedor,
                              TipoProveedor=n.TipoProveedor,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaModifica0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }
        //MANTENIMIENTO DE TIPO DE PROVEEDOR
        public Entidades.EntidadInventario.ETipoProveedor MantenimientoTipoProveedor(Entidades.EntidadInventario.ETipoProveedor Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadInventario.ETipoProveedor Mantenimiento = null;

            var TipoProveedor = ObjData.SP_MANTENIMIENTO_TIPO_PROVEEDOR(
                Item.IdTipoProveedor,
                Item.CodigoTipoProveedor,
                Item.TipoProveedor,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoProveedor != null)
            {
                Mantenimiento = (from n in TipoProveedor
                                 select new Entidades.EntidadInventario.ETipoProveedor
                                 {
                                     IdTipoProveedor=n.IdTipoProveedor,
                                     CodigoTipoProveedor=n.CodigoTipoProveedor,
                                     TipoProveedor=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE PROVEEDOR
        //LISTADO DE PROVEEDORES
        public List<Entidades.EntidadInventario.EProveedor> BuscaProveedor(decimal? IdProveedor = null, string CodigoProveedor = null, decimal? IdTipoproveedor = null, string Nombre = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_PROVEEDOR(IdProveedor, CodigoProveedor, IdTipoproveedor, Nombre, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadInventario.EProveedor
                          {
                              IdProveedor=n.IdProveedor,
                              CodigoProveedor=n.CodigoProveedor,
                              TipoProveedor=n.TipoProveedor,
                              IdTipoProveedor=n.IdTipoProveedor,
                              Nombre=n.Nombre,
                              Direccion=n.Direccion,
                              Telefonos=n.Telefonos,
                              Fax=n.Fax,
                              Contacto=n.Contacto,
                              LlevaComision0=n.LlevaComision0,
                              LlevaComision=n.LlevaComision,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }
        //MANTENMIENTO DE PROVEEDORES
        public Entidades.EntidadInventario.EProveedor MantenimientoProveedor(Entidades.EntidadInventario.EProveedor Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadInventario.EProveedor Mantenimiento = null;

            var Proveedor = ObjData.SP_MANTENIMIENTO_PROVEEDOR(
                Item.IdProveedor,
                Item.CodigoProveedor,
                Item.IdTipoProveedor,
                Item.Nombre,
                Item.Direccion,
                Item.Telefonos,
                Item.Fax,
                Item.Contacto,
                Item.LlevaComision0,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Proveedor != null)
            {
                Mantenimiento = (from n in Proveedor
                                 select new Entidades.EntidadInventario.EProveedor
                                 {
                                     IdProveedor=n.IdProveedor,
                                     CodigoProveedor=n.CodigoProveedor,
                                     IdTipoProveedor=n.IdTipoProveedor,
                                     Nombre=n.Nombre,
                                     Direccion=n.Direccion,
                                     Telefonos=n.Telefonos,
                                     Fax=n.Fax,
                                     Contacto=n.Contacto,
                                     LlevaComision0=n.LlevaComision,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE TIPO DE PRODUCTO
        //LISTADO DE TIPO DE PRODUCTO
        public List<Entidades.EntidadInventario.ETipoProducto> BuscaTipoProducto(decimal? IdTipoProducto = null, string CodigoTipoProducto = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_PRODUCTO(IdTipoProducto, CodigoTipoProducto, Descripcion, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadInventario.ETipoProducto
                          {
                              IdTipoProducto=n.IdTipoProducto,
                              CodigoTipoProducto=n.CodigoTipoProducto,
                              TipoProducto=n.TipoProducto,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }
        //MANTENIMIETO DE TIPO DE PRODUCTO
        public Entidades.EntidadInventario.ETipoProducto MantenimientoTipoProducto(Entidades.EntidadInventario.ETipoProducto Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadInventario.ETipoProducto Mantenimiento = null;

            var Tipoproducto = ObjData.SP_MANTENIMIENTO_TIPO_PRODUCTO(
                Item.IdTipoProducto,
                Item.CodigoTipoProducto,
                Item.TipoProducto,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Tipoproducto != null)
            {
                Mantenimiento = (from n in Tipoproducto
                                 select new Entidades.EntidadInventario.ETipoProducto
                                 {
                                    IdTipoProducto=n.IdTipoProducto,
                                    CodigoTipoProducto=n.CodigoTipoProducto,
                                    TipoProducto=n.Descripcion,
                                    Estatus0=n.Estatus,
                                    UsuarioAdiciona=n.UsuarioAdiciona,
                                    FechaAdiciona0=n.FechaAdiciona,
                                    UsuarioModifica=n.UsuarioModifica,
                                    FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE TIPO DE EMPAQUE
        //BUSCA TIPO DE EMPAQUE
        public List<Entidades.EntidadInventario.ETipoEmpaque> BuscaTipoEmpaque(decimal? IdTipoEmpaque = null, string CodigoTipoEmpaque = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_EMPAQUE(IdTipoEmpaque, CodigoTipoEmpaque, Descripcion, NumeroPagina, Numeroregistros)
                          select new Entidades.EntidadInventario.ETipoEmpaque
                          {
                              IdTipoEmpaque=n.IdTipoEmpaque,
                              CodigoTipoEmpaque=n.CodigoTipoEmpaque,
                              TipoEmpaque=n.TipoEmpaque,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }
        //MANTENIMIENTO DE TIPO DE EMPAQUE
        public Entidades.EntidadInventario.ETipoEmpaque MantenimientoTipoEmpaque(Entidades.EntidadInventario.ETipoEmpaque Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadInventario.ETipoEmpaque Mantenimiento = null;

            var TipoEmpaque = ObjData.SP_MANTENIMIENTO_TIPO_EMPAQUE(
                Item.IdTipoEmpaque,
                Item.CodigoTipoEmpaque,
                Item.TipoEmpaque,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoEmpaque != null)
            {
                Mantenimiento = (from n in TipoEmpaque
                                 select new Entidades.EntidadInventario.ETipoEmpaque
                                 {
                                     IdTipoEmpaque=n.IdTipoEmpaque,
                                     CodigoTipoEmpaque=n.CodigoTipoEmpaque,
                                     TipoEmpaque=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE PRODUCTO
        //LISTADO DE PRODUCTOS
        public List<Entidades.EntidadInventario.EPRoducto> BuscaProducto(decimal? IdProducto = null, string CodigoProducto = null, decimal? IdAlmacen = null, decimal? IdTipoProveedor = null, decimal? IdProveedor = null, decimal? IdTipoEmpaque = null, decimal? IdTipoProducto = null, string Descripcion = null, DateTime? FechaEntradaDesde = null, DateTime? FechaEntradaHasta = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_PRODUCTO(IdProducto, CodigoProducto, IdAlmacen, IdTipoProveedor, IdProveedor, IdTipoEmpaque, IdTipoProducto, Descripcion, FechaEntradaDesde, FechaEntradaHasta, NumeroPagina, Numeroregistros)
                          select new Entidades.EntidadInventario.EPRoducto
                          {
                              IdProducto=n.IdProducto,
                              CodigoProducto=n.CodigoProducto,
                              IdAlmacen=n.IdAlmacen,
                              Almacen=n.Almacen,
                              IdTipoProveedor=n.IdTipoProveedor,
                              TipoProveedor=n.TipoProveedor,
                              IdProveedor=n.IdProveedor,
                              Proveedor=n.Proveedor,
                              IdTipoEmpaque=n.IdTipoEmpaque,
                              TipoEmpaque=n.TipoEmpaque,
                              IdTipoProducto0=n.IdTipoProducto0,
                              TipoProducto=n.TipoProducto,
                              Producto =n.Producto,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              CantidadAlmacen=n.CantidadAlmacen,
                              PrecioCompra=n.PrecioCompra,
                              PrecioVenta=n.PrecioVenta,
                              SegundoPrecio=n.SegundoPrecio,
                              TercerPrecio=n.TercerPrecio,
                              FechaEntrada0=n.FechaEntrada0,
                              FechaEntrada=n.FechaEntrada,
                              LlevaDescuento0=n.LlevaDescuento0,
                              LlevaDescuento=n.LlevaDescuento,
                              PorcientoDescuento=n.PorcientoDescuento,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaEntrada0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE PRODUCTOS
        public Entidades.EntidadInventario.EPRoducto MantenimientoProducto(Entidades.EntidadInventario.EPRoducto Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadInventario.EPRoducto Mantenimiento = null;

            var Producto = ObjData.SP_MANTENIMIENTO_PRODUCTO(
                Item.IdProducto,
                Item.CodigoProducto,
                Item.IdAlmacen,
                Item.IdTipoProveedor,
                Item.IdProveedor,
                Item.IdTipoEmpaque,
                Item.IdTipoProducto0,
                Item.Producto,
                Item.Estatus0,
                Item.CantidadAlmacen,
                Item.PrecioCompra,
                Item.PrecioVenta,
                Item.SegundoPrecio,
                Item.TercerPrecio,
                Item.LlevaDescuento0,
                Item.PorcientoDescuento,
                Item.UsuarioAdiciona,
                Accion);
            if (Producto != null)
            {
                Mantenimiento = (from n in Producto
                                 select new Entidades.EntidadInventario.EPRoducto
                                 {
                                     IdProducto =n.IdProducto,
                                     CodigoProducto = n.CodigoProducto,
                                     IdAlmacen =n.IdAlmacen,
                                     IdTipoProveedor = n.IdTipoProveedor,
                                     IdProveedor = n.IdProveedor,
                                     IdTipoEmpaque =n.IdTipoEmpaque,
                                     IdTipoProducto0=n.IdTipoProducto,
                                     Producto=n.Descripcion,
                                     Estatus0 =n.Estatus,
                                     CantidadAlmacen = n.CantidadAlmacen,
                                     PrecioCompra = n.PrecioCompra,
                                     PrecioVenta = n.PrecioVenta,
                                     SegundoPrecio =n.SegundoPrecio,
                                     TercerPrecio = n.TercerPrecio,
                                     FechaEntrada0 =n.FechaEntrada,
                                     LlevaDescuento0  = n.LlevaDescuento,
                                     PorcientoDescuento = n.PorcientoDescuento,
                                     UsuarioAdiciona =n.UsuarioAdiciona,
                                     FechaAdiciona0 = n.FechaAdiciona,
                                     UsuarioModifica = n.UsuarioModifica,
                                     FechaModifica0 = n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
            
           
            
        }
        #endregion
        #region CONTAR PRODUCTOS
        public List<Entidades.EntidadInventario.EContarProductos> Contarproductos(decimal? IdProducto = null, string CodigoProducto = null, decimal? IdAlmacen = null, decimal? IdTipoProveedor = null, decimal? IdProveedor = null, decimal? IdTipoEmpaque = null, decimal? IdTipoProducto = null, string Descripcion = null, DateTime? FechaEntradaDesde = null, DateTime? FechaEntradaHasta = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Contar = (from n in ObjData.SP_CONTAR_CANTIDAD_PRODUCTO(IdProducto, CodigoProducto, IdAlmacen, IdTipoProveedor, IdProveedor, IdTipoEmpaque, IdTipoProducto, Descripcion, FechaEntradaDesde, FechaEntradaHasta, 1, 1)
                          select new Entidades.EntidadInventario.EContarProductos
                          {
                              Cantidad = n.Cantidad
                          }).ToList();
            return Contar;
        }
#endregion
    }
}
