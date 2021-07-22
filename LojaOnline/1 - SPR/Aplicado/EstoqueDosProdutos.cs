using ProjetoSOLID.SPR.Aplicado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoSOLID._1___SPR.Aplicado.StatusDoProduto;

namespace ProjetoSOLID._1___SPR.Aplicado
{
    public class EstoqueDosProdutos
    {
        public Status StatusDoProduto { get; set; }

        public Produto Produto { get; set; }

        public int Estoque { get; set; }

        public EstoqueDosProdutos(Produto produto, int estoque)
        {
            Produto = produto;
            Estoque = estoque;
        }

        public void DisponibilidadeProduto()
        {
            if (Estoque <= 0)
            {
                StatusDoProduto = Status.Indisponivel;
            }

            else
            {
                StatusDoProduto = Status.Disponivel;
            }
        }

    }
}
