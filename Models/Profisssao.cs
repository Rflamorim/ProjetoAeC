using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using apresentacao.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apresentacao.Models

{


[Table("profissoes")]
  public class Profissao
  {
    
    [Column("profissao_id")]
    public int Id { get;set; }

    [Column("vaga", TypeName = "varchar")]
    [MaxLength(50)]
    [Required]
    public string Vaga { get;set; }

  
    
  }

}
