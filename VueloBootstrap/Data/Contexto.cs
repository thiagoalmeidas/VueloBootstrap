using System;
using Microsoft.EntityFrameworkCore;
using VueloBootstrap.Models;


namespace VueloBootstrap.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Origem> Origens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* Aqui eu uso Sitema Mac, nao tive como usar o SqlServer para testar, e por mais que eu tenha me esforcado
            para utilizar o Mysql com suas bibliotecas EntityFramework eu nao consegui*/ 
            optionsBuilder.UseSqlServer("Server=localhost;port=3306;User ID=root;Password=admin123;Database=agenciaviagens");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Email).HasMaxLength(100).IsRequired();
                table.Property(prop => prop.Telefone).HasColumnType("char(15)").IsRequired();
                table.Property(prop => prop.Endereco).HasMaxLength(200).IsRequired();
            });

            modelBuilder.Entity<Origem>(table =>
            {
                table.ToTable("Origens");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.pais_origem).HasMaxLength(20).IsRequired();
                table.Property(prop => prop.cidade_origem).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.preco_origem).IsRequired();
            });

            modelBuilder.Entity<Destino>(table =>
            {
                table.ToTable("Destinos");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.pais_destino).HasMaxLength(20).IsRequired();
                table.Property(prop => prop.cidade_destino).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.preco_destino).IsRequired();
            });

            /* teriam outras tabaleas de relacionamento, como nao encontrei nada explicativo
            no moodle , tnao eu nao o  fiz.*/ 
        }
    }
}

// após tudo isso teria que adicionar o migrations no terminal *porém deu erro.
// logo após dar um update na database *sem o migrations náo foi possivel.

