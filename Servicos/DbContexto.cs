using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using apresentacao.Models;



  namespace apresentacao.Servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
    public DbSet<Profissao> Profissoes { get; set; }
    public DbSet<Candidato> Candidatos { get; set; }
  }
}