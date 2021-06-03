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

        public Produto(int id, int estoque, string categoria, double preço)
        {
            Id = id;
            Estoque = estoque;
            Categoria = categoria;
            Preço = preço;
        }
    }
}
