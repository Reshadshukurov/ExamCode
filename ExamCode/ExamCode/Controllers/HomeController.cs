using ExamCode.DAL;
using Microsoft.AspNetCore.Mvc;


namespace ExamCode.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {

            return View();
        }

    }
}
