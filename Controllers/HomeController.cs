using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Huberman_Solmesky.Models;

namespace TP04_Huberman_Solmesky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.Paquetes = ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete(){
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        return View();
    }
    public IActionResult GuardarPaquete (string Destino, string Hotel, string Aereo, string Excursion)
    {
        Paquete paquete = new Paquete(Hotel,Aereo,Excursion);
        if(ORTWorld.IngresarPaquete(Destino, paquete))
        {
            ViewBag.Error = "Destino igual";
            return RedirectToAction("SelectPaquete");
        }
        else
        {
            return RedirectToAction("index");
        }
    }
}
