using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Aplicado
{
    public abstract class Pagamento
    {
        public virtual double ValorDoPagamento { get; set; }

        public virtual double ReceberPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento;

            return ValorDoPagamento;
        }
    }
}
