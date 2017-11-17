using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Repositories
{
    public class ExamRepository
    {
        ExamContext Context;

        public ExamRepository(ExamContext context)
        {
            Context = context;
        }
    }
}
