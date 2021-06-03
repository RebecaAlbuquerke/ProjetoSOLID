using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    public class EstoqueDosProdutos : IEstoqueDosProdutos
    {
        public int Estoque { get; set; }

        public bool Disponivel { get; set; }

        public void AdicionarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void DisponibilidadeProduto(int estoque, bool disponivel)
        {
            Estoque = estoque;
            Disponivel = disponivel;

            if (estoque <= 0)
            {
                Disponivel = true;
            }

            else
            {
                Disponivel = false;
            }
        }
    }
}
