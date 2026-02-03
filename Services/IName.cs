using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Model;

namespace BestTAsControllerQuiz.Services
{
    public interface IName
    {
        Name? GetNameById(int id);
    }
}