using FluentAssertions;
using ProjetoSOLID._5___DIP.Aplicado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests._5___DIP
{
    public class EstoqueDosProdutosAplicadoTests
    {
        [Fact]
        public void AdicionarProduto()
        {
            var produto = new Produto(01, "vestuario", 10.0, 20);
            var sut = new EstoqueDosProdutos();
            sut.AdicionarProduto(produto, produto.Id, produto.Categoria, produto.Preço, produto.Estoque);
            sut.ListaDeProdutos.Should().Contain(produto);
        }
    }
}
