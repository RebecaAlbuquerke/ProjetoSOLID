using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoSOLID._2___OCP.Aplicado.TiposDePagamentos;

namespace ProjetoSOLID.OCP.Aplicado
{
    public class PagamentoDinheiro : Pagamento
    {
        private TipoDePagamento _tipoDePagamento = TipoDePagamento.Dinheiro;

        public TipoDePagamento TipoDePagamento
        {
            get { return _tipoDePagamento; }
            set { _tipoDePagamento = value; }
        }

        public override double ValorDoPagamento { get; set; }

        public double Troco { get; set; }

        public double CalcularValorDoPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento * 0.95;

            return  ValorDoPagamento;
        }
    }
}
