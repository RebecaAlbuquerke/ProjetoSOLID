using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Aplicado
{
    public class PagamentoBoleto : Pagamento
    {
        public override double ValorDoPagamento { get; set; }

        public int CódigoDoBoleto { get; set; }

        public double CalcularValorDoPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento;

            return valorDoPagamento;
        }
    }
}
