using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumberFun.Models;

namespace NumberFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(string number) //Parse the number input string into an int
        {
            int n;

            if (number != null)
            {
                int.TryParse(number, out n);
                NumberAnalysis analysis = new NumberAnalysis(n);
                return View(analysis);
            }
            else
                return Error();


        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult NumberInfo(string number) //Pass the number into the Number Analysis Model
        {
            int num;
            if (int.TryParse(number, out num))
            {
                NumberAnalysis numberProperties = new NumberAnalysis(num);

                return View(numberProperties);
            }
            else
            {
                return Error();
            }

        }

    }
}
