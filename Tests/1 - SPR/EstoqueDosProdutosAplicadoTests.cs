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
using ProjetoSOLID.SPR.Aplicado;

namespace Tests.SPR
{
    public class EstoqueDosProdutosAplicadoTests
    {
        [Fact]
        public void DeveRetornarDisponivel_QuandoOEstoqueForMaiorQueZero()
        {
            //Arrange
            var produto = new Produto(default, "Laranja", "Fruta", 1.2);
            var sut = new EstoqueDosProdutos(produto, 20);

            //Act
            sut.DisponibilidadeProduto();

            //Assert
            using (var assertionScope = new AssertionScope())
            {
                sut.StatusDoProduto.Should().Be(Status.Disponivel);
                sut.Estoque.Should().Be(20);
            }
        }

        [Fact]
        public void DeveRetornarIndisponivel_QuandoOEstoqueForMenorOuIgualAZero()
        {
            //Arrange
            var produto = new Produto(default, "Laranja", "Fruta", 1.2);
            var sut = new EstoqueDosProdutos(produto, 0);

            //Act
            sut.DisponibilidadeProduto();

            //Assert
            using (var assertionScope = new AssertionScope())
            {
                sut.StatusDoProduto.Should().Be(Status.Indisponivel);
                sut.Estoque.Should().Be(0);
            }
        }

    }
}
