using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Não_Aplicado
{
    public abstract class PagamentoBoleto
    {
        public abstract double ValorDoPagamento { get; set; }
    }

    public abstract class PagamentoDinheiro : PagamentoBoleto
    {
        public override double ValorDoPagamento
        {
            get { return ValorDoPagamento; }
            set { ValorDoPagamento = ValorDoPagamento * 0.95; }
        }
    }
}
