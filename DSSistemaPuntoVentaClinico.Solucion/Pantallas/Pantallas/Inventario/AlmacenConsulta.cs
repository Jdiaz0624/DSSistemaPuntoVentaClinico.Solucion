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
    public partial class AlmacenConsulta : Form
    {
        public AlmacenConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DEL USUARIO
        private void SacarDatosUsuario(decimal IdUsuario)
        {
            var Sacar = ObjdataSeguridad.Value.BuscaUsuario(
                IdUsuario,
                null, null, null, null, null, 1, 1);
            foreach (var n in Sacar)
            {
                lbIdUsuario.Text = n.IdUsuario.ToString();
                lbPerfilUsuarioConectado.Text = n.IdPerfil.ToString();
            }
        }
        #endregion
        #region SACAR EL LISTADO DE ALMACENES
        private void SacarDatosAlmacenes()
        {
            string _Nombre = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaAlmacen(
                new Nullable<decimal>(),
                _Codigo,
                _Nombre,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdAlmacen"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        #endregion
        #region RESTABLECER PANTALLA
        private void Restablecer()
        {
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnRestablecer.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtClaveSeguridad.Visible = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            SacarDatosAlmacenes();
        }

#endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.MantenimientoAlmacen Mantenimiento = new MantenimientoAlmacen();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.ShowDialog();
        }

        private void AlmacenConsulta_Load(object sender, EventArgs e)
        {
            SacarDatosUsuario(VariablesGlobales.IdUsuario);
            SacarDatosAlmacenes();
            gbBuscar.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            lbTitulo.Text = "Mantenimiento de Almacen";
            lbTitulo.ForeColor = Color.White;
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccioanr este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VariablesGlobales.IdMantenimiento = Convert.ToDecimal(dtListado.CurrentRow.Cells["IdAlmacen"].Value.ToString());
                VariablesGlobales.CodigoMantenimiento = Convert.ToString(dtListado.CurrentRow.Cells["CodigoAlmacen"].Value.ToString());
                btnNuevo.Enabled = false;
                btnConsultar.Enabled = false;
                btnRestablecer.Enabled = true;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                txtClaveSeguridad.Visible = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';

                var SacarDatosAlmacenSeleccionado = ObjDataInventario.Value.BuscaAlmacen(
                    VariablesGlobales.IdMantenimiento,
                    null, null, 1, 1);
                dtListado.DataSource = SacarDatosAlmacenSeleccionado;
                OcultarColumnas();
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.MantenimientoAlmacen Mantenimiento = new MantenimientoAlmacen();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            //Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("¿No puedes dejar el campo Clave de seguridad vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS QUE LA CLAVE DE SEGURIDAD ES VALIDA
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Verificar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario,
                    1, 1);
                if (Verificar.Count() < 1)
                {
                    MessageBox.Show("La clave de Seguridad ingresada no es valida, Favor de Verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //PROCEDEMOS A DESHABILITAR

                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EAlmacen Deshabilitar = new Logica.Entidades.EntidadInventario.EAlmacen();

                    Deshabilitar.IdAlmacen = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoAlmacen = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjDataInventario.Value.MantenimientoAlmacen(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restablecer();
                }

            }
        }

        private void AlmacenConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SacarDatosAlmacenes();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                SacarDatosAlmacenes();
            }
            else
            {
                SacarDatosAlmacenes();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                SacarDatosAlmacenes();
            }
            else
            {
                SacarDatosAlmacenes();
            }
        }
    }
}
