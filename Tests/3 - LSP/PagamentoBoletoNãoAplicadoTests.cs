using ProjetoSOLID._3___LSP.N�o_Aplicado;
using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;

namespace Tests
{
    public class PagamentoBoletoN�oAplicadoTests
    {
        [Fact]
        public void ValorDoPagamentoDeveSer100QuandoBoleto_100()
        {
            var sut = new PagamentoBoleto();
            sut.ReceberPagamento(100);
            sut.ValorDoPagamento.Should().Be(100);
        }

        [Fact]
        public void ValorDoPagamentoDeveSer95QuandoDinheiro_100()
        {
            var sut = new PagamentoDinheiro();
            sut.ReceberPagamento(100);
            sut.ValorDoPagamento.Should().Be(95);
        }

        [Fact]
        public void ValorDoPagamentoDeveSer50QuandoBoletoDinheiro_50()
        {
            PagamentoBoleto sut = new PagamentoDinheiro();
            sut.ReceberPagamento(50);
            sut.ValorDoPagamento.Should().Be(50);
        }
    }
}
