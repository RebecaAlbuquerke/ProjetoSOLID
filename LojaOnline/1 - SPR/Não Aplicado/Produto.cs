using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.SPR.Não_Aplicado
{
    public class Produto
    {
        public int Id { get; set; }

        public int Estoque { get; set; }

        public string Categoria { get; set; }

        public double Preço { get; set; }

        public enum Status
        {
            Disponivel,
            Indisponivel
        }

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
