﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Não_Aplicado
{
    public class Pedido
    {
        public int ReceberPedido(Produto produto, int quantidade)
        {
            var estoqueAtualizado = produto.Estoque - quantidade;
            return estoqueAtualizado;
        }
    }
}
