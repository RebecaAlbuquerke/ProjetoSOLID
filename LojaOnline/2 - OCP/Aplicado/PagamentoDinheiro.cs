using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Aplicado
{
    public class PagamentoDinheiro : Pagamento
    {
        public override double ValorDoPagamento { get; set; }

        public double Troco { get; set; }

        public double CalcularValorDoPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento;
            valorDoPagamento = valorDoPagamento * 0.95;

            return valorDoPagamento;
        }
    }
}
