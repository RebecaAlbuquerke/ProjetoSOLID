using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using ProjetoSOLID._1___SPR.Aplicado;
using static ProjetoSOLID._1___SPR.Aplicado.StatusDoProduto;

namespace Tests.SPR
{
    public class EstoqueDosProdutosAplicadoTests
    {
        [Fact]
        public void DeveRetornarDisponivel_QuandoOEstoqueForMaiorQueZero()
        {
            var sut = new EstoqueDosProdutos();
            sut.DisponibilidadeProduto(20);
            sut.StatusDoProduto.Should().Be(Status.Disponivel);
        }

        [Fact]
        public void DeveRetornarIndisponivel_QuandoOEstoqueForMenorOuIgualAZero()
        {
            var sut = new EstoqueDosProdutos();
            sut.DisponibilidadeProduto(0);
            sut.StatusDoProduto.Should().Be(Status.Indisponivel);
        }
    }
}
