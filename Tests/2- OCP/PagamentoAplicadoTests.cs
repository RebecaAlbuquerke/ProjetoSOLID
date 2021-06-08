using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using ProjetoSOLID.OCP.Aplicado;
using static ProjetoSOLID._2___OCP.Aplicado.TiposDePagamentos;

namespace Tests._2__OCP
{
    public class PagamentoAplicadoTests
    {
        [Fact]
        public void DeveRetornar110_QuandoValordaCompraFor100()
        {
            var sut = new PagamentoCartãoDeCrédito();
            sut.ReceberPagamento(100);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(110);
        }

        [Fact]
        public void DeveRetornar105_QuandoValordaCompraFor100()
        {
            var sut = new PagamentoCartãoDeDébito();
            sut.ReceberPagamento(100);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(105);
        }        
        
        [Fact]
        public void DeveRetornar100_QuandoValordaCompraFor100()
        {
            var sut = new PagamentoBoleto();
            sut.ReceberPagamento(100);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(100);
        }

        [Fact]
        public void DeveRetornar95_QuandoValordaCompraFor100()
        {
            var sut = new PagamentoDinheiro();
            sut.ReceberPagamento(100);
            Math.Round(sut.ValorDoPagamento, 2).Should().Be(95);
        }
    }
}
