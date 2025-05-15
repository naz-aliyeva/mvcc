using GymMVC.Contexts;
using GymMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymMVC.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            List<ChooseProgram> choosePrograms = _context.ChoosePograms.ToList();
            return View(choosePrograms);
        }
    }
}
