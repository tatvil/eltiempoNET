using ElTiempoWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElTiempoWeb.Controllers
{
    public class RosaController : Controller
    {
        private readonly RosaApiService _api;

        public RosaController(RosaApiService api)
        {
            _api = api;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string ciudad, string desde)
        {
            var datos = await _api.ObtenerDatos(ciudad, desde);
            return View(datos);
        }
    }
}

