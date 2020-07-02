using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<PerguntasViewModel> Perguntas { get; set; }
        //public IEnumerable<RespostasViewModel> Respostas { get; set; }
    }

    public class PerguntasViewModel
    {
        public int PerguntaId { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<RespostasViewModel> Respostas { get; set; }
    }

    public class RespostasViewModel
    {
        public int RespostaId { get; set; }

        public string Descricao { get; set; }
    }
}
