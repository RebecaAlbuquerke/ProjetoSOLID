using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSOLID._4___ISP.Não_Aplicado;

namespace ProjetoSOLID._4___ISP.Não_Aplicado
{
    public class CadastroProdutos : ICadastro
    {
        public Produto Produto { get; set; }

        public CadastroProdutos(Produto produto)
        {
            Produto = produto;
        }
  
        public void ValidarDados()
        {
            if (Produto.Id == null && Produto.Id == 0 || Produto.Nome == null || Produto.Categoria == null || Produto.Preco == null && Produto.Preco == 0.0)
            {
                throw new Exception("Dados Invalidos");
            }
        }

        public void ValidarPagamento(double valorDoPagamento)
        {
            //NÃO FAZ SENTIDO
        }
    }
}
