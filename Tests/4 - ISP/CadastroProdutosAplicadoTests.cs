using Xunit;
using FluentAssertions;
using ProjetoSOLID._4___ISP.Aplicado;
using System;

namespace Tests._4___ISP
{
    public class CadastroProdutosAplicadoTests
    {
        [Fact]
        public void CadastroPedidoDeveLancarExcecaoQuandoTiverDadoInvalido()
        {
            //Arrange
            var produto = new Produto(default, null, "Fruta", 1.2);
            var sut = new CadastroProdutos(produto);

            //Act

            //Assert
            Assert.Throws<Exception>(() => sut.ValidarDados());
        }
    }
}
