using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AT3_UC05.Models;
using MVC.models;

namespace AT3_UC05.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Servicos()
    {
      return View();
    }
    public IActionResult PreAgendamento()
    {
      return View();
    }
    [HttpPost]
    public IActionResult PreAgendamento(ItemAgendamento Ag)
    {
      Dados.AgendamentodoAtual.AddAgendamento(Ag);
      return RedirectToAction("SeuAgendamento");
    }
    public IActionResult SeuAgendamento()
    {
      List<ItemAgendamento> SeuAgendamento = Dados.AgendamentodoAtual.InfosDoAgendamento();
      return View(SeuAgendamento);

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
