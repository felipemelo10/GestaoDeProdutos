using GestaoProdutos.Models;

namespace GestaoProdutos.Repository
{
    public interface IProdutoRepository
    {

        Task<IList<Produto>> BuscarTodos();
        Task Adicionar(Produto produto);
    }
}
