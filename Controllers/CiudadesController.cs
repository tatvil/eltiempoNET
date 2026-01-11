using Microsoft.AspNetCore.Mvc;
using ElTiempoWeb.Data;
using System.Linq;

public class CiudadesController : Controller
{
    private readonly AppDbContext _context;

    public CiudadesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Ciudades()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GetDatosPorMes(int mes)
    {
        var datos = _context.Estadisticas
            .Where(e => e.Mes == mes)
            .ToList();

        var resultado = datos
            .GroupBy(e => e.Ciudad.ToLower())
            .ToDictionary(g => g.Key, g => new {
                temp_max = g.First().TempMax,
                temp_media = g.First().TempMedia,
                temp_min = g.First().TempMin,
                precipitacion = g.First().Precipitacion,
                viento = g.First().Viento,
                humedad = g.First().Humedad
            });

        return Json(resultado);
    }
}


