using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Aplicado
{
    public interface IFormaDePagamento
    {
        double ValorDoPagamento { get; set; }
    }

    public class PagamentoBoleto : IFormaDePagamento
    {
        protected double _ValorDoPagamento;

        public double ValorDoPagamento
        {
            get { return _ValorDoPagamento; }
            set => _ValorDoPagamento = value;
        }

        public void ReceberPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento;
        }
    }

    public class PagamentoDinheiro : IFormaDePagamento
    {
        protected double _ValorDoPagamento;

        public double ValorDoPagamento
        {
            get { return _ValorDoPagamento; }
            set => _ValorDoPagamento = value;
        }

        public void ReceberPagamento(double valorDoPagamento)
        {
            ValorDoPagamento = valorDoPagamento * 0.95;
        }
    }
}
