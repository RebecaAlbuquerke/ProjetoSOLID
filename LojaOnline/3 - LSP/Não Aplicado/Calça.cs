using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID.LSP.Não_Aplicado
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

        public abstract class CalçaSkinny : Calça
        {
            public override Tecidos Tecido
            {
                set { Tecido = Tecidos.jeans; }
            }
        }
    }
}
