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
        public int Estoque { get; set; }

        public Status StatusDoProduto { get; set; }

        public void DisponibilidadeProduto(int estoque)
        {
            Estoque = estoque;

            if (estoque <= 0)
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
