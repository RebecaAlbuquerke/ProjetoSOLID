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

        public virtual string[] Tamanho { get; } = new[] { "36", "38", "40", "42", "44" };

        public abstract class Blusa : Calça
        {
            public override Tecidos Tecido { get; set; }

            public override string[] Tamanho { get; } = new[] { "P", "PP", "M", "G", "GG" };
        }
    }
}
