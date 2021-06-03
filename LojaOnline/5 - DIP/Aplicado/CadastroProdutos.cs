using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    class CadastroProdutos
    {
        public void AdicionarProduto(Produto produto)
        {
            var estoque = new EstoqueDosProdutos();
            estoque.AdicionarProduto(produto);
        }
    }
}
