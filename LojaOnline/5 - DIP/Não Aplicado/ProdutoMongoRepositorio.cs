using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Não_Aplicado
{
    public class ProdutoMongoRepositorio : IRepositorio<Produto>
    {
        public Produto ObterId(int id)
        {
            return new Produto(id, "vestuario", 10.0);
        }
    }
}
