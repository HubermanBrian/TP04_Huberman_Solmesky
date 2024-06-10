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
        CargarListas();
        return View();
    }
    public void CargarListas()
    {
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino != Excursion)
        {
            ViewBag.Diferente = "Destino difente a excursion";
            CargarListas();
            return View ("SelectPaquete");
        }
        Paquete paquete = new Paquete(ORTWorld.ListaHoteles[Hotel -1], ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursion-1]);

        if (ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], paquete))
        {
            ViewBag.Error = "Destino igual";
            CargarListas();
            return View ("SelectPaquete");
        }
        else 
        {
            return RedirectToAction("Index");
        }
    }
}
