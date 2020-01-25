using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad
{
    public class EGuardarCuentasPorPagar
    {

        public System.Nullable<decimal> IdCuentaPorPagar { get; set; }

        public System.Nullable<decimal> IdPaciente { get; set; }

        public System.Nullable<decimal> NumeroConector { get; set; }

        public System.Nullable<decimal> BalanceInicial { get; set; }

        public System.Nullable<decimal> BalanceActual { get; set; }

        public System.Nullable<int> CantidadPagos { get; set; }
    }
}
