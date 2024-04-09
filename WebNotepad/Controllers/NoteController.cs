using Microsoft.AspNetCore.Mvc;

namespace WebNotepad.Controllers
{
    public class NoteController : Controller
    {
        [HttpGet]
        [Route("/note")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
