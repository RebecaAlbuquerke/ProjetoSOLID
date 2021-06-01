using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Aplicado
{
    public abstract class CalçaSkinny : Calça
    {
        public override Tecidos Tecido
        {
            set { Tecido = Tecidos.jeans; }
        }

        public override int Numeração { get; set; }
    }
}
