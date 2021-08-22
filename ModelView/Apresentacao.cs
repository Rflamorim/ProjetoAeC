using System.Collections.Generic;
using ProjetoAeC_main;

namespace ProjetoAeC_main.Apresentacao
{
    public class HomeView
    {
        public string Mensagem
        {
            get{ return "Bemvindo a minha API";}
        }
        public List<string> Endpoints
        {
            get
            { 
                return new List<string>() 
             {
                "/Profissoes",
                "/candidatos",
                "/swagger"
             };
            
            }
        }
    }
}