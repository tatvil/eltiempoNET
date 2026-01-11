using Microsoft.AspNetCore.Mvc;

namespace ElTiempoWeb.Controllers
{
    public class CiudadesController : Controller
    {
        [HttpGet]
        public IActionResult Ciudades()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetDatosPorMes(int mes)
        {
            // Aquí irán los datos reales o simulados
            var datos = new Dictionary<string, object>
            {
                ["madrid"] = new { temp_max = 30, temp_media = 20, temp_min = 10, precipitacion = 15, viento = 12, humedad = 60 },
                ["ampolla"] = new { temp_max = 28, temp_media = 18, temp_min = 8, precipitacion = 20, viento = 10, humedad = 65 },
                ["alfaz"] = new { temp_max = 32, temp_media = 22, temp_min = 12, precipitacion = 10, viento = 14, humedad = 55 }
            };

            return Json(datos);
        }
    }
}

