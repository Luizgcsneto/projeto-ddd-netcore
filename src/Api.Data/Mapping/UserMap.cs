using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User"); //colocar o nome da tabela

            builder.HasKey(u => u.Id); // definir a chave primária

            builder.HasIndex(u => u.Email)
                   .IsUnique();

            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(u => u.Email)
                    .HasMaxLength(100);
        }
    }
}
