namespace ProjetoSOLID._5___DIP.Não_Aplicado
{
    public class ProdutoPostgreSQLRepositorio : IRepositorio<Produto>
    {
        public Produto ObterId(int id)
        {
            return new Produto(id, "vestuario", 10.0);
        }
    }
}
