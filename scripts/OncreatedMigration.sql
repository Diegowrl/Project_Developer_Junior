using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestDevJunior.Models
{
    public class TestDevJuniorContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Client>().Property(e => e.razao_social).HasColumnType("VARCHAR").HasMaxLength(250);
            modelBuilder.Entity<Client>().Property(e => e.cnpj).HasColumnType("VARCHAR").HasMaxLength(250);
        }

        public TestDevJuniorContext (DbContextOptions<TestDevJuniorContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        

    }
}
