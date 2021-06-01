using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Aplicado
{
    public abstract class Calça
    {
        public enum Tecidos
        {
            jeans,
            sarja,
            algodão
        }

        public abstract Tecidos Tecido { get; set; }

        public abstract int Numeração { get; set; }
    }
}
