using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaEntity>
    {
        
        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            builder.ToTable("Pessoa"); 

            builder.HasKey(u => u.Id); 


            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(u => u.Age);
                
        }
    }
}
