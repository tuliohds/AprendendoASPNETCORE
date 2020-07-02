using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models
{
    public class Jornada
    {
        public int JornadaId { get; set; }

        //CHAVE ESTRANGEIRA PERGUNTA
        public int PerguntaId { get; set; }
        public virtual Pergunta Pergunta { get; set; }

        //CHAVE ESTRANGEIRA RESPOSTA
        public int RespostaId { get; set; }
        public virtual Resposta Resposta { get; set; }

        //CHAVE ESTRANGEIRA USUARIO
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }


    }
}
