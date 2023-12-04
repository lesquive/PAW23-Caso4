using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static AutoFixRepairAPI.Pages.CrearClienteModel;
using static frontEnd.Pages.IndexModel;

namespace AutoFixRepairAPI.Pages
{
    public class CrearSolicitudModel : PageModel
    {
        public class SolicitudReparacion
        {
            public int ClienteId { get; set; }

            public int TipoReparacionId { get; set; }

            public int? IdMecanicoAsignado { get; set; }

            // Propiedades relacionadas al automóvil
            public string ModeloAutomovil { get; set; }
            public string MarcaAutomovil { get; set; }
            public int AnioAutomovil { get; set; }
            public string PlacaAutomovil { get; set; }
        }

        [BindProperty]
        public SolicitudReparacion solicitudReparacion { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var jsonSolicitud = JsonSerializer.Serialize(solicitudReparacion);

            using var httpClient = new HttpClient();

            var apiUrl = "https://localhost:7131/api/SolicitudReparacion";

            var content = new StringContent(jsonSolicitud, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
