using ProjetoSOLID._5___DIP.Aplicado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests._5___DIP
{
    public class PedidoAplicadoTests
    {
        [Fact]
        public void AtualizarEstoque()
        {
            var produto = new Produto(01, "vestuario", 10.0, 20);
            var sut = new Pedido();
            var resultado = sut.ReceberPedido(produto, 5);
            Assert.Equal(15, resultado);
        }
    }
}
