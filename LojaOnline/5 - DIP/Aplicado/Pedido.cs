using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    public class Pedido : IPedido
    {
        public int ReceberPedido(Produto produto, int quantidade)
        {
            var estoqueAtualizado = produto.Estoque - quantidade;
            return estoqueAtualizado;
        }
    }
}
