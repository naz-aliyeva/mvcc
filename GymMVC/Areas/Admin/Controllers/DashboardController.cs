using GymMVC.Contexts;
using GymMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            List<ChooseProgram> programs = _context.ChoosePograms.ToList();
            return View(programs);
        }
    }
}
