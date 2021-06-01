using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.SPR.Não_Aplicado
{
    public class Produto
    {
        public static int TotalDeProdutos { get; private set; }

        public int Id { get; set; }

        public int Estoque { get; set; }

        public string Categoria { get; set; }

        public double Preço { get; set; }

        public Produto(int id, int estoque, string categoria, double preço)
        {
            Console.WriteLine("Criando Produto");

            Id = id;
            Estoque = estoque;
            Categoria = categoria;
            Preço = preço;

            TotalDeProdutos = TotalDeProdutos + Estoque;
        }

        public void CompraDeProduto(string formaDePagamento, int quantidadeComprada)
        {
            if (formaDePagamento == "Cartão de crédito")
            {
                Preço = Preço * 1.1; //acréssimo de 10% 
            }

            if (formaDePagamento == "Cartão de débito")
            {
                Preço = Preço * 1.05; //acréssimo de 5% 
            }

            if (formaDePagamento == "Dinheiro")
            {
                Preço = Preço; //sem acréssimo
            }

            Estoque = Estoque - quantidadeComprada;
        }
    }
}
