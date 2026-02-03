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
    public class SayHello : ControllerBase
    {
        private readonly Hello _hello;
        public SayHello(Hello hello)
        {
            _hello = hello;
        }
        [HttpGet("{name}")]
        public string Reversing(string name)
        {
            return _hello.Greet(name);
        }
    }
}