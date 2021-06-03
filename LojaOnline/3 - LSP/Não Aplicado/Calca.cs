using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSOLID._3___LSP.Não_Aplicado
{
    public abstract class Calca
    {
        public enum Tecidos
        {
            jeans,
            sarja,
            algodão
        }

        public abstract Tecidos Tecido { get; set; }

        private Tamanhos m_EnumVal;
        public virtual Tamanhos EnumVal
        {
            get { return m_EnumVal; }
            set { m_EnumVal = value; }
        }

        public enum Tamanhos
        {
            N36,
            N38,
            N40,
            N42,
            N44
        };

        public abstract class Blusa : Calca
        {
            public override Tecidos Tecido { get; set; }

            private new Tamanhos m_EnumVal;

            public virtual Tamanhos GetEnumVal()
            { return m_EnumVal; }
            public virtual void SetEnumVal(Tamanhos value)
            { m_EnumVal = value; }

            public new enum Tamanhos
            {
                PP,
                P,
                M,
                G,
                GG
            };
        }
    }
}
