using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using ProjetoSOLID.OCP.Não_Aplicado;
using static ProjetoSOLID.OCP.Não_Aplicado.Pagamento;

namespace Tests._2__OCP
{
    public class PagamentoNãoAplicadoTests
    {
        [Fact]
        public void DeveRetornar110_QuandoValordaCompraFor100()
        {
            var sut = new Pagamento();
            sut.ReceberPagamento(100, TipoDePagamento.CartãoDeCrédito);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(110);
        }

        [Fact]
        public void DeveRetornar105_QuandoValordaCompraFor100()
        {
            var sut = new Pagamento();
            sut.ReceberPagamento(100, TipoDePagamento.CartãoDeDébito);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(105);
        }

        [Fact]
        public void DeveRetornar100_QuandoValordaCompraFor100()
        {
            var sut = new Pagamento();
            sut.ReceberPagamento(100, TipoDePagamento.Boleto);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(100);
        }

        [Fact]
        public void DeveRetornar95_QuandoValordaCompraFor100()
        {
            var sut = new Pagamento();
            sut.ReceberPagamento(100, TipoDePagamento.Dinheiro);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(95);
        }
    }
}
