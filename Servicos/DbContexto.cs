using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using apresentacao.Models;



  namespace apresentacao.Servicos
{
    public class DbContexto : DbContext 
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Candidato>().HasIndex(u => u.Cpf).IsUnique();

        }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }

    }
}