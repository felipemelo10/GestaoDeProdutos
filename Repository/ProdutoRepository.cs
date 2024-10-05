using System.Linq;
using GestaoProdutos.Data;
using GestaoProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoProdutos.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _produtoContext;

        public ProdutoRepository(ProdutoContext produtoContext)
        {
            _produtoContext = produtoContext;
        }
        public async Task<IList<Produto>> BuscarTodos()
        {
            return await _produtoContext.Produtos.OrderBy(p => p.Valor).ToListAsync();
        }
        public async Task Adicionar(Produto produto)
        {
            await _produtoContext.Produtos.AddAsync(produto);

            await _produtoContext.SaveChangesAsync();
        }

        
    }
}
