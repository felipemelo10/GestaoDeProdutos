using GestaoProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProdutos.Data.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(m => m.Nome).HasMaxLength(15).IsRequired();
            builder.Property(m => m.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(m => m.Valor).IsRequired();
            builder.Property(m => m.Disponivel).IsRequired();
        }
    }
}
