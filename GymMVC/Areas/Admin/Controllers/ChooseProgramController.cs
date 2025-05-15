using GymMVC.Models;
using GymMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChooseProgramController : Controller
    {
        private readonly ChooseProgramService _service;
        public ChooseProgramController()
        {
            _service = new ChooseProgramService();
        }


        #region Create 

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(ChooseProgram program)
        {
            _service.CreateChooseProgram(program);
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Read
        [HttpGet]
        public IActionResult Index()
        {
            List<ChooseProgram> program = _service.GetAllChooseProgram();
            return View(program);
        }
        public IActionResult Info(int id)
        {
            ChooseProgram program = _service.GetChooseProgramById(id);
            return View(program);
        }
        #endregion


        #region Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            ChooseProgram products = _service.GetChooseProgramById(id);
            return View(products);
        }
        [HttpPost]
        public IActionResult Update(int id, FeaturedProducts featured)
        {

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ChooseProgram program = _service.GetChooseProgramById(id);
            return View(program);
            //_service.DeleteFeaturedCar(id); 
            //return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {

            _service.DeleteChooseProgram(id);
            return RedirectToAction(nameof(Index));
        }

        #endregion

    }
}
