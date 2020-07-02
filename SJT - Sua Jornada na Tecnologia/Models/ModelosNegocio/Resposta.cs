using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models
{
    public class Resposta
    {
        public int RespostaId { get; set; }

        public string Descricao { get; set; }

        //CHAVE ESTRANGEIRA PERGUNTA
        public int PerguntaId { get; set; }
        //Relacionar com uma tabela estrangeira e utilizar a propriedade virtual para nem sempre buscar no BD
        public virtual Pergunta Pergunta { get; set; }

        //CHAVE ESTRANGEIRA PROFISSÃO
        public int ProfissaoId { get; set; }
        public virtual Profissao Profissao { get; set; }

        public ICollection<Jornada> Jornada { get; set; }
    }
}
