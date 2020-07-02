using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SJT___Sua_Jornada_na_Tecnologia.Models;
using SJT___Sua_Jornada_na_Tecnologia.Models.RegrasNegocios;
using SJT___Sua_Jornada_na_Tecnologia.Models.ViewModels;

namespace SJT___Sua_Jornada_na_Tecnologia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SjtRN sjtRN;

        public HomeController(ILogger<HomeController> logger, SjtRN sjtRN)
        {
            _logger = logger;
            this.sjtRN = sjtRN;
        }

        public IActionResult Index()
        {
            IEnumerable<Pergunta> perguntas = sjtRN.ListarPerguntas().ToList();


            ViewModel viewModel = new ViewModel()
            {
                Perguntas = perguntas.Select(item => new PerguntasViewModel()
                {
                    PerguntaId = item.PerguntaId,
                    Descricao = item.Descricao,
                    Respostas = sjtRN.ListarRespostas(item.PerguntaId).Select(resposta => new RespostasViewModel()
                    {
                        RespostaId = resposta.RespostaId,
                        Descricao = resposta.Descricao
                    })
                })
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
