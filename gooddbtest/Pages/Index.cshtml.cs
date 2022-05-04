using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;
//Hecho por Jose Miguel Beltran Cinco A00227714

namespace gooddbtest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [Required(ErrorMessage = "Complete el dato")]
        [BindProperty]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Complete el dato")]
        [BindProperty]
        public string Mes { get; set; }

        public void OnGet()
        {

            ViewData["Mensaje"] = "Conoce tu heroe ";
        }

        public void OnPost()
        {
            string primeraParte, segundaParte;
            char letraNombre =  Nombre.ToLower()[0];
            int index = (int)letraNombre % 32;
            string mesIngresado = Mes.ToLower();
            switch (index)
            {
                case 1:
                    primeraParte = "Captain";
                    break;
                case 2:
                    primeraParte = "Wonder";
                    break;
                case 3:
                    primeraParte = "Super";
                    break;
                case 4:
                    primeraParte = "Phantom";
                    break;
                case 5:
                    primeraParte = "Dark";
                    break;
                case 6:
                    primeraParte = "Incredible";
                    break;
                case 7:
                    primeraParte = "Professor";
                    break;
                case 8:
                    primeraParte = "Iron";
                    break;
                case 9:
                    primeraParte = "Hawk";
                    break;
                case 10:
                    primeraParte = "Archer";
                    break;
                case 11:
                    primeraParte = "Steel";
                    break;
                case 12:
                    primeraParte = "Bolt";
                    break;
                case 13:
                    primeraParte = "Atomic";
                    break;
                case 14:
                    primeraParte = "Torch";
                    break;
                case 15:
                    primeraParte = "Space";
                    break;
                case 16:
                    primeraParte = "Mega";
                    break;
                case 17:
                    primeraParte = "Turbo";
                    break;
                case 18:
                    primeraParte = "Fantastic";
                    break;
                case 19:
                    primeraParte = "Invisible";
                    break;
                case 20:
                    primeraParte = "Night";
                    break;
                case 21:
                    primeraParte = "Silver";
                    break;
                case 22:
                    primeraParte = "Aqua";
                    break;
                case 23:
                    primeraParte = "Amazing";
                    break;
                case 24:
                    primeraParte = "Giant";
                    break;
                case 25:
                    primeraParte = "Rock";
                    break;
                case 26:
                    primeraParte = "Power";
                    break;
                default: primeraParte = "error";
                    break;
            }

            segundaParte = "error";
            if (mesIngresado == "enero")
            {
                segundaParte = "Shield";
            }
            else if (mesIngresado == "febrero")
            {
                segundaParte = "Arrow";
            }
            else if (mesIngresado == "marzo")
            {
                segundaParte = "Justice";
            }
            else if (mesIngresado == "abril")
            {
                segundaParte = "Thunder";
            }
            else if (mesIngresado == "mayo")
            {
                segundaParte = "Rider";
            }
            else if (mesIngresado == "junio")
            {
                segundaParte = "Falcon";
            }
            else if (mesIngresado == "julio")
            {
                segundaParte = "Ninja";
            }
            else if (mesIngresado == "agosto")
            {
                segundaParte = "Spider";
            }
            else if (mesIngresado == "septiembre")
            {
                segundaParte = "Beast";
            }
            else if (mesIngresado == "octubre")
            {
                segundaParte = "Blade";
            }
            else if (mesIngresado == "noviembre")
            {
                segundaParte = "Hulk";
            }
            else if (mesIngresado == "diciembre")
            {
                segundaParte = "Doom";
            }
            ViewData["Mensaje"] = "Tu Nombre de heroe es: " + primeraParte +" " +segundaParte;
        }
    }
}