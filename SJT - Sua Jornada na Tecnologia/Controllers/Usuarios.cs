using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SJT___Sua_Jornada_na_Tecnologia.Controllers
{
    public class Usuarios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
