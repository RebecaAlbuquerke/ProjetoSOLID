using ProjetoSOLID._5___DIP.Não_Aplicado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    public class EstoqueDosProdutos
    {
        public List<Produto> ListaDeProdutos { get; set; }
        public IRepositorio<Produto> Repositorio { get; set; }

        public EstoqueDosProdutos(IRepositorio<Produto> repositorio)
        {
            ListaDeProdutos = new List<Produto>();
            Repositorio = repositorio;
        }

        public void AdicionarProduto(int id)
        {
            var produto = Repositorio.ObterId(id);
            ListaDeProdutos.Add(produto);
        }
    }
}
