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
            var repositorio = new ProdutoPostgreSQLRepositorio();
            var estoqueDeProduto = new EstoqueDosProdutos(repositorio);
        }
    }
}
