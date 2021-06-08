using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Não_Aplicado
{
    public class Pagamento
    {
        public enum TipoDePagamento
        {
            CartãoDeCrédito,
            CartãoDeDébito,
            Boleto,
            Dinheiro
        }

        public double ValorDoPagamento { get; set; }

        public double ValorDaCompra { get; set; }

        public void ReceberPagamento(double valorDaCompra, TipoDePagamento tipoDePagamento)
        {
            ValorDaCompra = valorDaCompra;

            if (tipoDePagamento == TipoDePagamento.CartãoDeCrédito)
            {
                ValorDoPagamento = valorDaCompra * 1.1;
            }

            if (tipoDePagamento == TipoDePagamento.CartãoDeDébito)
            {
                ValorDoPagamento = valorDaCompra * 1.05;
            }

            if (tipoDePagamento == TipoDePagamento.Boleto)
            {
                ValorDoPagamento = valorDaCompra;
            }

            if (tipoDePagamento == TipoDePagamento.Dinheiro)
            {
                ValorDoPagamento = valorDaCompra * 0.95;
            }
        }
    }
}
