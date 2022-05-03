using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace gooddbtest.Pages.Shared
{
    public class DatosPersonalesModel : PageModel
    {
        public void OnGet(string Mensaje, int Mes)
        {
            ViewData["MensajeLejano"] = "Llegaste al fin: " + Mensaje + " Solo te tomo " + Mes + " Años";
        }
    }
}
