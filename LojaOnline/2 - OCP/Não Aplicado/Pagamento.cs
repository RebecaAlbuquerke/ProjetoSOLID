using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.OCP.Não_Aplicado
{
    public class Pagamento
    {
        enum TipoDePagamento
        {
            CartãoDeCrédito,
            CartãoDeDébito,
            Boleto,
            Dinheiro
        }

        public double ValorDoPagamento { get; set; }

        public double ValorDaCompra  { get; set; }

        public void ReceberPagamento( double valorDoPagamento, double valorDaCompra)
        {
            ValorDoPagamento = valorDoPagamento;
            ValorDaCompra = valorDaCompra;
            var tipoDePagamento = new TipoDePagamento();
            
            if (tipoDePagamento == TipoDePagamento.CartãoDeCrédito)
            {
                valorDoPagamento = valorDaCompra * 1.1;
            }

            if (tipoDePagamento == TipoDePagamento.CartãoDeDébito)
            {
                valorDoPagamento = valorDaCompra * 1.05;
            }

            if (tipoDePagamento == TipoDePagamento.Boleto)
            {
                valorDoPagamento = valorDaCompra;
            }

            if (tipoDePagamento == TipoDePagamento.Dinheiro)
            {
                valorDoPagamento = valorDaCompra * 0.95;
            }
        }
    }
}
