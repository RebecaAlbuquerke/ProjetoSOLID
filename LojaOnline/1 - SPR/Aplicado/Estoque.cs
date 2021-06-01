using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.SPR.Aplicado
{
    public class Estoque
    {
        public static int TotalDeProdutos { get; private set; }

        private int estoque;

        public int GetEstoque()
        {
            return estoque;
        }

        public void SetEstoque(int value)
        {
            estoque = value;
        }
    }
}
