using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Aplicado
{
    public abstract class Pagamento
    {
        public abstract double ValorDoPagamento { get; set; }
    }
}
