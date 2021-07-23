using Xunit;
using FluentAssertions;
using ProjetoSOLID._4___ISP.Aplicado;
using System;

namespace Tests._4___ISP
{
    public class CadastroPedidosAplicadoTests
    {
        [Fact]
        public void CadastroProdutosDeveLancarExcecaoQuandoTiverDadoInvalido()
        {
            //Arrange
            var sut = new CadastroPedidos(123, null, 112.0);

            //Act

            //Assert
            Assert.Throws<Exception>(() => sut.ValidarDados());
        }

        [Fact]
        public void CadastroProdutosDeveLancarExcecaoQuandoValorDoPagamentoForMenorQueOValorDoPedido()
        {
            //Arrange
            var produto = new Produto(default, "Laranja", "Fruta", 1.2);
            var sut = new CadastroPedidos(123, produto, 112.0);

            //Act

            //Assert
            Assert.Throws<Exception>(() => sut.ValidarPagamento(110.0));
        }
    }
}
