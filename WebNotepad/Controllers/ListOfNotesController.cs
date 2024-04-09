using Microsoft.AspNetCore.Mvc;

namespace WebNotepad.Controllers
{
    public class ListOfNotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
