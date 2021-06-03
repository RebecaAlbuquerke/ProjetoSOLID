using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._4___ISP.Aplicado
{
    public class CadastroPedidos : IValidadorPagamento, IValidadorDados
    {
        public void ValidarDados()
        {
            // Validar dados do pedido
        }

        public void ValidarPagamento()
        {
            // Validar pagamento do pedido
        }
    }
}
