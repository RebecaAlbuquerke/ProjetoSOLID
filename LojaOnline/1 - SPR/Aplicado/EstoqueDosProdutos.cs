using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.SPR.Aplicado
{
    public class EstoqueDosProdutos
    {
        public int Estoque { get; set; }

        public bool Disponivel { get; set; }

        public void DisponibilidadeProduto (int estoque, bool disponivel)
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
