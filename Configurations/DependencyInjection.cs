using GestaoProdutos.Data;
using GestaoProdutos.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoProdutos.Configurations
{
    public static class DependencyInjection
    {
        public static WebApplicationBuilder ResolveDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ProdutoContext>(op => op.UseInMemoryDatabase("teste"));

            builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

            return builder;
        }
    }
}
