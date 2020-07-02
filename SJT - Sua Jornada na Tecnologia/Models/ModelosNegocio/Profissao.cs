using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models
{
    public class Profissao
    {
        public int ProfissaoId { get; set; }

        public string Nome { get; set; }

        //Criando uma interface de lista para conectar com Resposta,
        //deixando claro a comunicação entre as classes
        public ICollection<Resposta> Resposta { get; set; }

    }
}
