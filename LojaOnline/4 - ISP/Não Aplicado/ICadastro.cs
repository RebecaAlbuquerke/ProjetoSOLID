using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._4___ISP.Não_Aplicado
{
    public interface ICadastro
    {
        void ValidarDados();

        void ValidarPagamento(double valorDoPagamento);
    }
}
