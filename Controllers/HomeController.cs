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
    public IActionResult SelectPaquete()
    {
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        Paquete paquete = new Paquete(ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
        if (ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino], paquete))
        {
            ViewBag.Error = "Destino igual";
            return RedirectToAction("SelectPaquete");
        }
        else
        {
            return RedirectToAction("Index");
        }
    }
}
