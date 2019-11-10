using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja
{
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region Sacar los datos de la caja
        private void SacarDatosCaja(decimal IdCaja)
        {
            var SacarDatosCaja = ObjDataCaja.Value.BuscaCaja(IdCaja, null);
            if (SacarDatosCaja.Count() < 1)
            {
                MessageBox.Show("El codigo de caja no es valido, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool Estatus = false;
                foreach (var n in SacarDatosCaja)
                {
                    lbNombreCaja.Text = n.Descripcion;
                    lbMonto.Text = n.MontoActual.ToString();
                    lbEstatus.Text = n.Estatus;
                    Estatus = Convert.ToBoolean(n.Estatus0);
                    if (Estatus == true)
                    {
                        lbEstatus.ForeColor = Color.White;
                    }
                    else
                    {
                        lbEstatus.ForeColor = Color.Red;
                    }
                }
            }
        }
        #endregion
        #region MANTENIMIENTO DE CAJA
        private void MANCaja(string CodigoCaja, string Accion)
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.ECaja Mantenimiento = new Logica.Entidades.EntidadesCaja.ECaja();

            Mantenimiento.IdCaja = Convert.ToDecimal(txtCodigoCaja.Text);
            Mantenimiento.CodigoCaja = CodigoCaja;
            Mantenimiento.Descripcion = lbNombreCaja.Text;
            Mantenimiento.MontoActual = Convert.ToDecimal(lbMonto.Text);


            var MAN = ObjDataCaja.Value.MantenimientoCaja(Mantenimiento, Accion);
        }
        #endregion
        #region SACAR E INGRESAR EFECTIVO A LA CAJA
        private void MovimientoCaja(string Concepto)
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EHistorialCaja Historial = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

            Historial.IdistorialCaja = 0;
            Historial.IdCaja = 1;
            Historial.Monto = Convert.ToDecimal(txtMonto.Text);
            Historial.Concepto = Concepto;
            Historial.Fecha0 = DateTime.Now;
            Historial.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.NumeroReferencia = 0;
            Historial.IdTipoPago = 1;

            var MAN = ObjDataCaja.Value.MantenimientoHistorialCaja(Historial, "INSERT");
            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
        }
        private void AfectarCaja(string Accion)
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.ECaja Caja = new Logica.Entidades.EntidadesCaja.ECaja();

            Caja.IdCaja = 1;
            Caja.MontoActual = Convert.ToDecimal(txtMonto.Text);

            var MAn = ObjDataCaja.Value.MantenimientoCaja(Caja, Accion);
        }
        #endregion
        #region SACAR LOS DATOS DE LA EMPRESA
        private void SacarDatosEmpresa(decimal idInformacionEmpresa)
        {
            var SacarInformacionEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(1);
            foreach (var n in SacarInformacionEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
#endregion
        private void Caja_Load(object sender, EventArgs e)
        {
            SacarDatosEmpresa(1);
            gbDatosCaja.ForeColor = Color.Black;
            txtCodigoCaja.Text = "1";
            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
            rbIngresar.Checked = true;
            gbDatosCaja.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            txtCodigoCaja.ForeColor = Color.Black;
            txtConcepto.ForeColor = Color.Black;
            txtMonto.ForeColor = Color.Black;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Caja";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void txtCodigoCaja_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Estatus = false;
            string CodigoCaja = "";
            if (string.IsNullOrEmpty(txtCodigoCaja.Text.Trim()))
            {

                txtCodigoCaja.Text = "1";
                var Buscar = ObjDataCaja.Value.BuscaCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                if (Buscar.Count() < 1)
                {
                    txtCodigoCaja.Text = "1";
                    var SegundaBusqueda = ObjDataCaja.Value.BuscaCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                    foreach (var n2 in SegundaBusqueda)
                    {
                        Estatus = Convert.ToBoolean(n2.Estatus0);
                        CodigoCaja = n2.CodigoCaja;
                        if (Estatus == true)
                        {
                            MANCaja(CodigoCaja, "CLOSE");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                        else
                        {
                            MANCaja(CodigoCaja, "OPEN");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                    }
                }
                else
                {
                    foreach (var n in Buscar)
                    {
                        Estatus = Convert.ToBoolean(n.Estatus0);
                        CodigoCaja = n.CodigoCaja;
                        if (Estatus == true)
                        {
                            MANCaja(CodigoCaja, "CLOSE");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                        else
                        {
                            MANCaja(CodigoCaja, "OPEN");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                    }
                }
            }
            else
            {
                var Buscar = ObjDataCaja.Value.BuscaCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                if (Buscar.Count() < 1)
                {
                    txtCodigoCaja.Text = "1";
                    var BuscarAlternativa = ObjDataCaja.Value.BuscaCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                    foreach (var n in BuscarAlternativa)
                    {
                        Estatus = Convert.ToBoolean(n.Estatus0);
                        CodigoCaja = n.CodigoCaja;
                        if (Estatus == true)
                        {
                            MANCaja(CodigoCaja, "CLOSE");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                        else
                        {
                            MANCaja(CodigoCaja, "OPEN");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                    }
                }
                else
                {
                    var BuscarFinal = ObjDataCaja.Value.BuscaCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                    foreach (var n in BuscarFinal)
                    {
                        Estatus = Convert.ToBoolean(n.Estatus0);
                        CodigoCaja = n.CodigoCaja;
                        if (Estatus == true)
                        {
                            MANCaja(CodigoCaja, "CLOSE");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                        else
                        {
                            MANCaja(CodigoCaja, "OPEN");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        }
                    }
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try {
                if (rbIngresar.Checked)
                {
                    //INGRESAMOS EFECTIVO
                    if (string.IsNullOrEmpty(txtMonto.Text.Trim()))
                    {
                        MessageBox.Show("Favor de ingresar la cantidad a ingresar a la caja", VariablesGlobales.NombrePacienteHis, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtConcepto.Text.Trim()))
                        {
                            txtConcepto.Text = "INGRESO DE EFETIVO";
                        }
                        MovimientoCaja(txtConcepto.Text);
                        AfectarCaja("ADD");
                        SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                        txtMonto.Text = string.Empty;
                        txtConcepto.Text = string.Empty;
                    }

                }
                else if (rbSacar.Checked)
                {
                    //SACAMOS EFECTIVO
                    if (string.IsNullOrEmpty(txtMonto.Text.Trim()))
                    {
                        MessageBox.Show("Favor de ingresar la cantidad a retirar de la caja", VariablesGlobales.NombrePacienteHis, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //COMPARAMOS LA CANTIDAD EN CAJA CONTRA LA CANTIDAD QUE SE VA A RETIRAR
                        decimal MontoCaja = Convert.ToDecimal(lbMonto.Text);
                        decimal MontoRetiro = Convert.ToDecimal(txtMonto.Text);

                        if (MontoRetiro > MontoCaja)
                        {
                            MessageBox.Show("El monto que desea retirar de la caja supera el monto actual, favor de verificar e intentarlo nuevamente", VariablesGlobales.NombrePacienteHis, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtConcepto.Text.Trim()))
                            {
                                txtConcepto.Text = "RETIRO DE EFETIVO";
                            }
                            decimal Monto = Convert.ToDecimal(txtMonto.Text);
                            txtMonto.Text = string.Empty;
                            txtMonto.Text = (Monto * -1).ToString();
                            MovimientoCaja(txtConcepto.Text);
                            AfectarCaja("LESS");
                            SacarDatosCaja(Convert.ToDecimal(txtCodigoCaja.Text));
                            txtMonto.Text = string.Empty;
                            txtConcepto.Text = string.Empty;
                        }

                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar este proceso", VariablesGlobales.NombrePacienteHis, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
