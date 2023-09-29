using Microsoft.AspNetCore.Mvc;
using Trabajo2.Models;

namespace Trabajo2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(Conversion model)
        {
            if (ModelState.IsValid)
            {

                if (model.TipoConversion == TipoDeConversion.DolaraPeso)
                {
                   
                    model.Resultado = model.PesoAm * model.PesoMx;
                }
                else if (model.TipoConversion == TipoDeConversion.PesoaDolar)
                {
               
                    model.Resultado = model.PesoAm / model.PesoMx;
                }
            }

            return View(model);
        }
    }
}
