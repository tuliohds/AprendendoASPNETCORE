using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models
{
    public class Pergunta 
    {
        public int PerguntaId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Resposta> Resposta { get; set; }

        public ICollection<Jornada> Jornada { get; set; }
    }
}
