using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._5___DIP.Aplicado
{
    public interface IRepositorio<T>
    {
        T ObterId(int id);
    }
}
