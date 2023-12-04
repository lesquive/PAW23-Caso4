using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace frontEnd.Pages
{
    public class SolicitudesPendientesModel : PageModel
    {
        public class SolicitudReparacion
        {
            public int Id { get; set; }
            public int ClienteId { get; set; }
            public int TipoReparacionId { get; set; }
            public bool Completada { get; set; }
            public int? IdMecanicoAsignado { get; set; }
        }

        private readonly IHttpClientFactory _httpClientFactory;

        public SolicitudesPendientesModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public List<SolicitudReparacion> Reparaciones { get; private set; } = new List<SolicitudReparacion>();
        public string ErrorMessage { get; private set; }

        public async Task OnGetAsync()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetFromJsonAsync<List<SolicitudReparacion>>("https://localhost:7131/api/SolicitudReparacion");

                if (response != null)
                {
                    Reparaciones = response;
                }
                else
                {
                    ErrorMessage = "Error al obtener las reparaciones de AutoFix";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error: {ex.Message}";
            }
        }
    }
}
