using ERPGranjita.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace ERPGranjita.Client.Pages.Ingresos
{
    public partial class Ventas : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; } = default!;

        private List<Venta>? ventas;
        private Venta nuevaVenta = new Venta { Fecha = DateTime.Today };
        private bool isSaving = false;
        private string mensaje = "";
        private string errorMensaje = "";

        protected override async Task OnInitializedAsync()
        {
            await CargarVentas();
        }

        private async Task GuardarVenta()
        {
            isSaving = true;
            mensaje = "";
            errorMensaje = "";
            try
            {
                var response = await Http.PostAsJsonAsync("api/ventas", nuevaVenta);
                if (response.IsSuccessStatusCode)
                {
                    mensaje = "Venta guardada correctamente";
                    await CargarVentas();
                    nuevaVenta = new Venta { Fecha = DateTime.Today };
                }
                else
                {
                    errorMensaje = "Error al guardar la venta.";
                }
            }
            catch (Exception ex)
            {
                errorMensaje = "Error al conectar con la API: " + ex.Message;
            }
            isSaving = false;
        }

        private async Task CargarVentas()
        {
            try
            {
                ventas = await Http.GetFromJsonAsync<List<Venta>>("api/ventas");
            }
            catch
            {
                ventas = new List<Venta>();
                errorMensaje = "Error al cargar ventas desde la API.";
            }
        }
    }
}