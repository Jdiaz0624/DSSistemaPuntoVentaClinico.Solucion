using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class MantenimientoAlmacen : Form
    {
        public MantenimientoAlmacen()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DEL USUARIO
        private void SacarDatosUsuario(decimal IdUsuario)
        {
            var SacarDatos = ObjdataSeguridad.Value.BuscaUsuario(
                VariablesGlobales.IdUsuario,
                null, null, null, null, null, 1, 1);
            foreach (var n in SacarDatos)
            {
                VariablesGlobales.IdPerfil = Convert.ToDecimal(n.IdPerfil.ToString());
                VariablesGlobales.CodigoMantenimiento = n.CodigoUsuario;
            }
        }
        #endregion
        #region SACAR LOS DATOS DE LA EMPRESA
        private void SacarDatosEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MANTENIMIENTO DE ALMACENES
        private void MANAlmacen()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EAlmacen Mantenimiento = new Logica.Entidades.EntidadInventario.EAlmacen();

            Mantenimiento.IdAlmacen = VariablesGlobales.IdMantenimiento;
            Mantenimiento.CodigoAlmacen = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.Nombre = txtNombre.Text;
            Mantenimiento.Direccion = txtDireccion.Text;
            Mantenimiento.Telefono = txtTelefonos.Text;
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaAdiciona0 = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica0 = DateTime.Now;

            var MAN = ObjDataInventario.Value.MantenimientoAlmacen(Mantenimiento, VariablesGlobales.AccionTomar);
        }
        #endregion
        #region LIMPIAR LOS CONTROLES
        private void LimpiarControles()
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.AlmacenConsulta Consulta = new AlmacenConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoAlmacen_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.White;
            txtNombre.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtTelefonos.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.White;
            btnCerrar.ForeColor = Color.White;

            SacarDatosEmpresa(1);
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            SacarDatosUsuario(VariablesGlobales.IdUsuario);
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                //SACAMOS LOS DATOS DEL ALMACEN

                var SacarDatosAlmacen = ObjDataInventario.Value.BuscaAlmacen(
                    VariablesGlobales.IdMantenimiento,
                    null, null, 1, 1);
                foreach (var n in SacarDatosAlmacen)
                {
                    VariablesGlobales.CodigoMantenimiento = n.CodigoAlmacen;
                    txtNombre.Text = n.Nombre;
                    txtDireccion.Text = n.Direccion;
                    txtTelefonos.Text = n.Direccion;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
                if (cbEstatus.Checked == true)
                {
                    cbEstatus.Visible = false;
                }
                else
                {
                    cbEstatus.Visible = true;
                }
            }
            else
            {
                VariablesGlobales.CodigoMantenimiento = "";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("El campo nombre no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MANAlmacen();
                if (VariablesGlobales.AccionTomar != "INSERT")
                {
                    MessageBox.Show("Registro Modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
                else
                {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked)
            {
                cbEstatus.ForeColor = Color.White;
            }
            else
            {
                cbEstatus.ForeColor = Color.Red;
            }
        }

        private void MantenimientoAlmacen_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
