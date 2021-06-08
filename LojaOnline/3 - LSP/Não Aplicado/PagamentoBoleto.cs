using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Não_Aplicado
{
    public class PagamentoBoleto
    {
        public virtual double ValorDoPagamento { get; set; }

        protected double _ValorDoPagamento;

        public virtual void ReceberPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento;
        }
    }

    public class PagamentoDinheiro : PagamentoBoleto
    {
        public override double ValorDoPagamento
        {
            get { return _ValorDoPagamento; }
            set => _ValorDoPagamento = value;
        }
        
        public override void ReceberPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento * 0.95;
        }
    }
}
