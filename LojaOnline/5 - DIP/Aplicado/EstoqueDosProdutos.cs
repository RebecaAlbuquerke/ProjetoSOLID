using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoSOLID._5___DIP.Aplicado.StatusDoProduto;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    public class EstoqueDosProdutos : IEstoqueDosProdutos
    {
        public Status StatusDoProduto { get; set; }

        public Produto Produto { get; set; }

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void AdicionarProduto(Produto produto, int id, string categoria, double preço, int estoque)
        {
            produto.Id = id;
            produto.Categoria = categoria;
            produto.Preço = preço;
            produto.Estoque = estoque;
            ListaDeProdutos.Add(new Produto(id, categoria, preço, estoque) { });
        }
    }
}
