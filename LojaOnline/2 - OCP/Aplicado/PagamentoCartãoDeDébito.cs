using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Aplicado
{
    public class PagamentoCartãoDeDébito : Pagamento
    {
        public override double ValorDoPagamento { get; set; }

        public int SenhaDoCartão { get; set; }

        public double CalcularValorDoPagamento(double valorDoPagamento)
        {
            ValorDoPagamento= valorDoPagamento;
            valorDoPagamento = valorDoPagamento * 1.05;

            return valorDoPagamento;
        }
    }
}
