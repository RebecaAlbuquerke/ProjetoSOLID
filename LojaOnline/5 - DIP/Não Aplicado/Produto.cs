using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Não_Aplicado
{
    public class Produto
    {
        public int Id { get; set; }

        public string Categoria { get; set; }

        public double Preço { get; set; }

        public int Estoque { get; set; }

        public Produto(int id, string categoria, double preço, int estoque)
        {
            Id = id;
            Categoria = categoria;
            Preço = preço;
            Estoque = estoque;
        }
    }
}
