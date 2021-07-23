using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._4___ISP.Aplicado
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public double Preco { get; set; }

        public Produto(int id, string nome, string categoria, double preco)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }
    }
}
