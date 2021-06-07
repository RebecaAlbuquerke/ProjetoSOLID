using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Aplicado
{
    public interface IFormaDePagamento
    {
        double ValorDoPagamento { get; }
    }

    public class PagamentoBoleto : IFormaDePagamento
    {
        public double ValorDoPagamento => ValorDoPagamento * 1;
    }

    public abstract class PagamentoDinheiro : IFormaDePagamento
    {
        public double ValorDoPagamento => ValorDoPagamento * 0.95;
    }
}
