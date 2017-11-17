using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam.Repositories;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        ExamRepository ExamRepository;
        private string policePlate = "RB";
        private string diplomatPlate = "DT";

        public HomeController(ExamRepository examRepository)
        {
            ExamRepository = examRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult List(string Plate)
        {
            return View("list", ExamRepository.ListAll());
        }

        [HttpGet]
        [Route("search")]
        [Route("search{plate}")]
        [Route("search{police}")]
        public IActionResult SearchByPlate(string plate, int police, int diplomat)
        {
            if (police == 1)
            {
                return View("list", ExamRepository.ListSpecialPlatedCars(policePlate));
            }
            if (diplomat == 1)
            {
                return View("list", ExamRepository.ListSpecialPlatedCars(diplomatPlate));
            }
            if (plate.Length > 0)
            {
                return View("list", ExamRepository.SearchByPlate(plate));
            }
            return Json(new { errorMessage = "Please povide input" });
        }

        [HttpGet]
        [Route("search/{brand}")]
        public IActionResult SearchByBrand(string brand)
        {
            return View("list", ExamRepository.SearchByBrand(brand));
        }
    }
}
