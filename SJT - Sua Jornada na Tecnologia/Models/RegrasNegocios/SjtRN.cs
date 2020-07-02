using SJT___Sua_Jornada_na_Tecnologia.Models.DBAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models.RegrasNegocios
{
    public class SjtRN
    {
        private readonly DBAObject dBAccess;

        public SjtRN(DBAObject dBAccess)
        {
            this.dBAccess = dBAccess;
        }

        public IEnumerable<Pergunta> ListarPerguntas()
        {
            return dBAccess.ListarPerguntas();
        }

        public IEnumerable<Resposta> ListarRespostas()
        {
            return dBAccess.ListarRespostas();
        }

        public IEnumerable<Resposta> ListarRespostas(int perguntaId)
        {
            return dBAccess.ListarRespostas(perguntaId);
        }
    }
}
