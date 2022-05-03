using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;


namespace gooddbtest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Nombre { get; set; }
        public string Mes { get; set; }

        public void OnGet()
        {

            ViewData["Mensaje"] = "Tu Nombre de Heroe es: ";
            //Nombre = "Josemiguel";
        }

        public void OnPost()
        {

            ViewData["Mensaje"] = "Tu Nombre de heroe es: " + Nombre;
        }
    }
}