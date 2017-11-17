using Exam.Entities;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Repositories
{
    public class ExamRepository
    {
        ExamContext ExamContext;

        public ExamRepository(ExamContext examContext)
        {
            ExamContext = examContext;
        }

        public List<Car> ListAll()
        {
            return ExamContext.Licence_plates.ToList();
        }
 
        public List<Car> SearchByPlate(string plate)
        {
            var searchedCars = from car in ExamContext.Licence_plates
                          where car.Plate.Contains(plate)
                          select car;
            return searchedCars.ToList();
        }

        public List<Car> SearchByBrand(string brand)
        {
            var searchedCars = from car in ExamContext.Licence_plates
                               where car.Car_Brand == brand
                               select car;
            return searchedCars.ToList();
        }

        public List<Car> ListSpecialPlatedCars(string input)
        {
            var searchedCars = from car in ExamContext.Licence_plates
                               where car.Plate.StartsWith(input)
                               select car;
            return searchedCars.ToList();
        }
    }
}
