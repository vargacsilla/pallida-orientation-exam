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
        public IActionResult Search(string Plate)
        {
            return View("list", ExamRepository.SearchPlates(Plate));
        }
    }
}
