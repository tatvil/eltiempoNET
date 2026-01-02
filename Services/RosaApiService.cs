using System.Net.Http;
using System.Net.Http.Json;

namespace ElTiempoWeb.Services
{
    public class RosaApiService
    {
        private readonly HttpClient _http;

        public RosaApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<RegistroViento>> ObtenerDatos(string ciudad, string desde)
        {
            string url = $"https://eltiempo-api.azurewebsites.net/api/rosa?ciudad={ciudad}&desde={desde}";
            return await _http.GetFromJsonAsync<List<RegistroViento>>(url);
        }
    }

    public class RegistroViento
    {
        public DateTime Fecha { get; set; }
        public double VientoVelocidad { get; set; }
        public double VientoDireccion { get; set; }
        public bool EsLunaLlena { get; set; }
    }
}

