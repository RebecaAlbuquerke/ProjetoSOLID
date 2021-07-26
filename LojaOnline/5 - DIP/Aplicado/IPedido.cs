using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    interface IPedido
    {
        int ReceberPedido(Produto produto, int quantidade);
    }
}
