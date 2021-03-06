﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    public partial class SubMenuConfiguracion : Form
    {
        public SubMenuConfiguracion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuConfiguracion_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Configuración de Sistema";
            lbUsuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
            //lbUsuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
        }

        private void btnInformacionEmpresa_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion.InformacionEmpresa InformacionEmpresa = new Pantallas.Configuracion.InformacionEmpresa();
            InformacionEmpresa.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion.ConfiguracionReportes Repirtes = new Pantallas.Configuracion.ConfiguracionReportes();
            Repirtes.VariablesGlobales.IdUsuario = Convert.ToInt32(lbUsuario.Text);
            Repirtes.ShowDialog();
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion.SecuencialComprobantes Comprobantes = new Pantallas.Configuracion.SecuencialComprobantes();
            Comprobantes.VariablesGlobales.IdUsuario = Convert.ToInt32(lbUsuario.Text);
            Comprobantes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion.CantidadMinimaProductos CantidadMinima = new Pantallas.Configuracion.CantidadMinimaProductos();
            CantidadMinima.VariablesGlobales.IdUsuario = Convert.ToInt32(lbUsuario.Text);
            CantidadMinima.ShowDialog();
        }
    }
}
