using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoSOLID._2___OCP.Aplicado.TiposDePagamentos;

namespace ProjetoSOLID.OCP.Aplicado
{
    public class PagamentoBoleto : Pagamento
    {
        private TipoDePagamento _tipoDePagamento = TipoDePagamento.Boleto;

        public TipoDePagamento TipoDePagamento
        {
            get { return _tipoDePagamento; }
            set { _tipoDePagamento = value; }
        }

        public override double ValorDoPagamento { get; set; }

        public int CódigoDoBoleto { get; set; }

        public override double ReceberPagamento(double valorDoPagamento)
        {

            ValorDoPagamento = valorDoPagamento;

            return ValorDoPagamento;
        }
    }
}
