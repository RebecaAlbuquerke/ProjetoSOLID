using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    public class Produto
    {
        public int Id { get; set; }

        public string Categoria { get; set; }

        public double Preço { get; set; }

        public Produto(int id, string categoria, double preço)
        {
            Id = id;
            Categoria = categoria;
            Preço = preço;
        }
    }
}
