using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class ClaveSeguridad : Form
    {
        public ClaveSeguridad()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LA INFORMAICON DE LA EMPRESA
        private void MostrarInformaicoNEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion

        #region CARGAR EL LISTADO DE USUARIOS
        private void CargarUsuarios()
        {
            var Usuario = ObjDataListas.Value.ListaUsuarios();
            txtUsuario.DataSource = Usuario;
            txtUsuario.DisplayMember = "Persona";
            txtUsuario.ValueMember = "IdUsuario";
        }
        #endregion

        #region CONSULTAR LA CLAVE DE SEGURIDAD
        private void ConsultarClave()
        {
            try {
                var ConsultarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                null,
                Convert.ToDecimal(txtUsuario.SelectedValue),
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = ConsultarClave;
                OcultarColumnas();
            }
            catch (Exception) { }
        }
        #endregion

        #region RESTABLECER LA PANTALLA
        private void Restablecerpantalla()
        {
            btnConsultar.Enabled = true;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtNumeroPagina.Visible = true;
            txtNumeroRegistros.Visible = true;
            CargarUsuarios();
            txtClave.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ConsultarClave();
            btnRestablecer.Enabled = false;
            dtListado.Enabled = true;
            cbEstatus.Visible = false;
            txtConfirmarClave.Text = string.Empty;   
        }
#endregion

        #region OCULTAR COLUMNAS DEL GRID
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdClaveSeguridad"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["Perfil"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        #endregion

        #region MANTENIMIENTO DE LA CLAVE DE SEGURIDAD3
        private void MANClaveSeguridad(string Accion)
        {
            //VERIFICAMOS LOS CAMPOS VACIOS
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()) || string.IsNullOrEmpty(txtConfirmarClave.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS QUE LA CLAVE DE SEGURIDAD INGRESADAS SEAN IGUALES
                string Clave = txtClave.Text;
                string Confirmar = txtConfirmarClave.Text;

                if (Clave != Confirmar)
                {
                    MessageBox.Show("Las claves ingresadas no concuerdan favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Text = string.Empty;
                    txtConfirmarClave.Text = string.Empty;
                }
                else
                {
                    //VERIFICAMOS QUE EL USUARIO SELECCIONADO NO TENGA UNA CLAVE ASIGNADA EN CASO DE QUE SEA UN PRODUCTO NUEVO
                    if (Accion == "INSERT")
                    {
                        var ValidarUsuario = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            null,
                            Convert.ToDecimal(txtUsuario.SelectedValue), 1, 1);
                        if (ValidarUsuario.Count() < 1)
                        {
                           
                            //GUARDAMOS
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EClaveSeguridad Mantenimiento = new Logica.Entidades.EntidadSeguridad.EClaveSeguridad();

                            Mantenimiento.IdClaveSeguridad = 0;
                            Mantenimiento.IdUsuario = Convert.ToDecimal(txtUsuario.SelectedValue);
                            Mantenimiento.Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);
                            Mantenimiento.Estatus0 = cbEstatus.Checked;
                            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                            Mantenimiento.FechaAdiciona0 = DateTime.Now;
                            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                            Mantenimiento.FechaModifica0 = DateTime.Now;

                            var MAN = ObjDataSeguridad.Value.MantenimientoClaveSeguridad(Mantenimiento, Accion);
                            MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Restablecerpantalla();
                        }
                        else
                        {
                            MessageBox.Show("El usuairo seleccionado ya tiene una clave de seguridad asignada, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //REALIZAMOS EL MANTENIMIENTO
                        //GUARDAMOS
                        DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EClaveSeguridad Mantenimiento = new Logica.Entidades.EntidadSeguridad.EClaveSeguridad();

                        Mantenimiento.IdClaveSeguridad = 0;
                        Mantenimiento.IdUsuario = Convert.ToDecimal(txtUsuario.SelectedValue);
                        Mantenimiento.Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);
                        Mantenimiento.Estatus0 = cbEstatus.Checked;
                        Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                        Mantenimiento.FechaAdiciona0 = DateTime.Now;
                        Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                        Mantenimiento.FechaModifica0 = DateTime.Now;

                        var MAN = ObjDataSeguridad.Value.MantenimientoClaveSeguridad(Mantenimiento, Accion);
                        MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restablecerpantalla();
                    }
                    
                }
            }
        }
#endregion

        private void ClaveSeguridad_Load(object sender, EventArgs e)
        {
            MostrarInformaicoNEmpresa(1);
            gbMantenimiento.ForeColor = Color.White;
            gbOpciones.ForeColor = Color.White;
            gbListado.ForeColor = Color.White;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtUsuario.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            txtClaveSeguridad.PasswordChar = '•';
            txtClave.PasswordChar = '•';
            txtConfirmarClave.PasswordChar = '•';
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            CargarUsuarios();
            ConsultarClave();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClaveSeguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
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

        private void txtUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarClave();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarClave();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdUsuario"].Value.ToString());

            var Buscar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                null,
                VariablesGlobales.IdMantenimiento, 1, 1);
            dtListado.DataSource = Buscar;
            OcultarColumnas();
            foreach (var n in Buscar)
            {
                txtUsuario.Text = n.Persona;
                txtClave.Text = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                txtConfirmarClave.Text = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
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
            btnConsultar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            lbClaveSeguridad.Visible = true;
            txtClaveSeguridad.Visible = true;
            txtNumeroPagina.Visible = false;
            txtNumeroRegistros.Visible = false;
            btnRestablecer.Enabled = true;
            dtListado.Enabled = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Restablecerpantalla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MANClaveSeguridad("INSERT");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS SI EL CAMPO CAMPO CLAVE DE SEGURIDAD ESTA VACIO
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                string ClaveDesencriptada = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    ClaveDesencriptada, VariablesGlobales.IdUsuario, 1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, o no pertenece al usuario conectado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                }
                else
                {
                    //VALIDAMOS QUE LA CLAVE DE SEGURIDAD ESTE ACTIVA
                    bool EstatusClave = false;

                    foreach (var n in ValidarClaveSeguridad)
                    {
                        EstatusClave = Convert.ToBoolean(n.Estatus0);
                    }
                    if (EstatusClave == false)
                    {
                        MessageBox.Show("Esta clave de seguridad no se puede utilizar por que esta deshabilitada actualmente, favor de cominicarse con un administrador para activarla nuevamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //REALIZAMOS EL MANTENIMIENTO
                        MANClaveSeguridad("UPDATE");
                    }
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS SI EL CAMPO CAMPO CLAVE DE SEGURIDAD ESTA VACIO
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                string ClaveDesencriptada = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    ClaveDesencriptada, VariablesGlobales.IdUsuario, 1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, o no pertenece al usuario conectado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                }
                else
                {
                    //VALIDAMOS QUE LA CLAVE DE SEGURIDAD ESTE ACTIVA
                    bool EstatusClave = false;

                    foreach (var n in ValidarClaveSeguridad)
                    {
                        EstatusClave = Convert.ToBoolean(n.Estatus0);
                    }
                    if (EstatusClave == false)
                    {
                        MessageBox.Show("Esta clave de seguridad no se puede utilizar por que esta deshabilitada actualmente, favor de cominicarse con un administrador para activarla nuevamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //REALIZAMOS EL MANTENIMIENTO
                        MANClaveSeguridad("DISABLE");
                    }
                }
            }
        }
    }
}
