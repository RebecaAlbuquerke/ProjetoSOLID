using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoSOLID._5___DIP.Não_Aplicado.StatusDoProduto;

namespace ProjetoSOLID._5___DIP.Não_Aplicado
{
    public class EstoqueDosProdutos
    {
        public List<Produto> ListaDeProdutos { get; set; }
        public ProdutoMongoRepositorio Repositorio { get; set; }

        public EstoqueDosProdutos()
        {
            ListaDeProdutos = new List<Produto>();
            Repositorio = new ProdutoMongoRepositorio();
        }

        public void AdicionarProduto(int id)
        {
            var produto = Repositorio.ObterId(id);
            ListaDeProdutos.Add(produto);
        }
    }
}
