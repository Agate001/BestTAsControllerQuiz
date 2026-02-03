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
    public class ReverseIt : ControllerBase
    {
        private readonly Reversing _reversing;
        public ReverseIt(Reversing reversing)
        {
            _reversing = reversing;
        }
        [HttpGet("{input}")]
        public string Reversing(string input)
        {
            return _reversing.ReverseString(input);
        } 
    }
}