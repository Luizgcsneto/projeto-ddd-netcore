using Api.Data.Mapping;
using data.Mapping;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PessoaEntity> Pessoas { get; set; }
        public DbSet<ContactEntity> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<PessoaEntity>(new PessoaMap().Configure);
            modelBuilder.Entity<ContactEntity>(new ContactMap().Configure);
        }
    }
}
