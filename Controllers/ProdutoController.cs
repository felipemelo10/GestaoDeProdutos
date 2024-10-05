using GestaoProdutos.Models;
using GestaoProdutos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository) =>
            _produtoRepository = produtoRepository;

        public IActionResult Criar() => View();

        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoRepository.BuscarTodos();

            return View(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Produto produtoModel)
        {
            if (!ModelState.IsValid) 
            {
                return View(produtoModel);
            }

            produtoModel.Disponivel = produtoModel.Disponivel == 0 ? EProdutoDisponivel.Sim : produtoModel.Disponivel;

            await _produtoRepository.Adicionar(produtoModel);
            return RedirectToAction("Index");
        }
    }
}
