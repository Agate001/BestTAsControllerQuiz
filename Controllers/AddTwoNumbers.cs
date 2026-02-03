using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers : ControllerBase
    {
        private readonly AddingNums _addingNums;

        public AddTwoNumbers(AddingNums addingNums)
        {
            _addingNums = addingNums;
        }

        [HttpGet("{num1}/{num2}")]
        public int AddingNums(int num1, int num2)
        {
            return _addingNums.AddTwo(num1, num2);
        }
    }
}