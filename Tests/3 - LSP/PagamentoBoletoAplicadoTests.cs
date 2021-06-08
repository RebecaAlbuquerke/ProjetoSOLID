using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using ProjetoSOLID._3___LSP.Aplicado;

namespace Tests
{
    public class PagamentoBoletoAplicadoTests
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
        public void ValorDoPagamentoDeveSer475QuandoBoletoDinheiro_50()
        {
            var sut = new PagamentoDinheiro();
            sut.ReceberPagamento(50);
            sut.ValorDoPagamento.Should().Be(47.5);
        }
    }
}
