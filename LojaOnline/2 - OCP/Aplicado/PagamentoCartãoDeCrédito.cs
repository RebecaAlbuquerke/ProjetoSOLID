using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoSOLID._2___OCP.Aplicado.TiposDePagamentos;

namespace ProjetoSOLID.OCP.Aplicado
{
    public class PagamentoCartãoDeCrédito : Pagamento
    {
        private TipoDePagamento _tipoDePagamento = TipoDePagamento.CartãoDeCrédito;

        public TipoDePagamento TipoDePagamento
        {
            get { return _tipoDePagamento; }
            set { _tipoDePagamento = value; }
        }

        public override double ValorDoPagamento { get; set; }

        public int SenhaDoCartão { get; set; }

        public double CalcularValorDoPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento * 1.1;

            return ValorDoPagamento;
        }

    }
}
