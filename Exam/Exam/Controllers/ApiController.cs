﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam.Repositories;

namespace Exam.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        ExamRepository ExamRepository;

        public ApiController(ExamRepository examRepository)
        {
            ExamRepository = examRepository;
        }

        [HttpGet]
        [Route("search/{brand}")]
        public IActionResult SearchByBrand(string brand)
        {
            if (ExamRepository.SearchByBrand(brand).Count == 0)
            {
                return Json(new { result = "no matches found" });
            }
            else
            {
                var searchResult = new
                {
                    result = "ok",
                    data = ExamRepository.SearchByBrand(brand)
                };
                return Json(searchResult);
            }
        }
    }
}