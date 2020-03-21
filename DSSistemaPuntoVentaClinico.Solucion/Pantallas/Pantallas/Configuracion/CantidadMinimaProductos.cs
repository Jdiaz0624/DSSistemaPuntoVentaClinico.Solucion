using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class CantidadMinimaProductos : Form
    {
        public CantidadMinimaProductos()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MODIFICAR LA CANTIDAD MINIMA
        private void ModificarCantidadMinima() {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ECantidadMinima Modificar = new Logica.Entidades.EntidadInventario.ECantidadMinima();

            Modificar.IdCantidadMinima = 1;
            Modificar.CantidadMinima = Convert.ToInt32(txtcantidad.Text);

            var MAn = ObjDataInventario.Value.MantenimientoCantidadMinima(Modificar, "UPDATE");
        }
        #endregion
        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarData = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarData)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region SACAR CANTIDAD MINIMA
        private int SacarCantidadMinima(int IdCantidadMinima) {
            int CantidadBD = 0;
            var SacarCantidad = ObjDataInventario.Value.BuscaCantidadMinima(IdCantidadMinima);
            foreach (var n in SacarCantidad)
            {
                CantidadBD = Convert.ToInt32(n.CantidadMinima);
            }
            txtcantidad.Text = CantidadBD.ToString();
            return CantidadBD;
        }
        #endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtcantidad.Text.Trim()))
                {
                    MessageBox.Show("Favor de ingresar una cantidad", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int CantidadIngresada = Convert.ToInt32(txtcantidad.Text);

                    if (CantidadIngresada >= 0 && CantidadIngresada <= 100)
                    {
                        ModificarCantidadMinima();
                        MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("El rango de numero ingresado no es valido, favor de verificar que este entre 0 y 100", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el cambio, Codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CantidadMinimaProductos_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
            SacarCantidadMinima(1);
            lbTitulo.Text = "Modificar Cantidad Minima de Productos";
            lbTitulo.ForeColor = Color.White;
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void CantidadMinimaProductos_FormClosing(object sender, FormClosingEventArgs e)
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
