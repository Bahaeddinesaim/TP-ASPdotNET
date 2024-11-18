using IG5_2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IG5_2.Controllers
{
    public class FormController : Controller
    {
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(FormVM form)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }
    }
}
