using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._4___ISP.Não_Aplicado
{
    public class CadastroPedidos : ICadastro
    {
        public int Id { get; set; }

        public Produto Produto { get; set; }

        public double ValorDoPedido { get; set; }

        public CadastroPedidos(int id, Produto produto, double valorDoPedido)
        {
            Id = id;
            Produto = produto;
            ValorDoPedido = valorDoPedido;
        }
        public void ValidarDados()
        {
            if (Id == null && Id == 0 || Produto == null || ValorDoPedido == null && ValorDoPedido == 0.0)
            {
                throw new Exception("Dados Invalidos");
            }
        }

        public void ValidarPagamento(double valorDoPagamento)
        {
            if (valorDoPagamento > ValorDoPedido)
            {
                throw new Exception("Pagemnto Invalido");
            }
        }
    }
}
