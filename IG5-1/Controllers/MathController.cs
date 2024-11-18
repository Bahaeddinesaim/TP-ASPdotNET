using Microsoft.AspNetCore.Mvc;

namespace IG5_1.Controllers
{
    
    public class MathController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult ShowNumber(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [Route("Math/ShowSum/{num1}/{num2}")]
        public IActionResult ShowSum(int num1, int num2)
        {
            int sum = num1 + num2;
            ViewData["Num1"] = num1;
            ViewData["Num2"] = num2;
            ViewData["Sum"] = sum;
            return View();
        }
        [Route("Math/Equation/{a}/{b}/{c}")]
        public IActionResult Equation(int a, int b, int c)
        {
            double delta = b * b - 4 * a * c;
            double x1;
            double x2;
            double x;
           if (delta == 0)
            {
                x = -b / (2 * a);
                //result = $"L'équation a une solution double : x = {x}";
            }
            else if (delta > 0)

            {
                 x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                 x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                //result = $"L'équation a deux solutions : x1 = {x1}, x2 = {x2}";
            }

            ViewData["A"] = a;
            ViewData["B"] = b;
            ViewData["C"] = c;
            ViewData["Delta"] = delta;
            ViewBag.X1 = x1;
            ViewBag.X2 = x2;
            ViewBag.X = x;

            return View();
        }

       
     
        public IActionResult Suivi(double id)
        {
            double[] suivis = new double[10];
            for (int i = 0; i < 10; i++)
            {
                suivis[i] = id + i + 1;
            }

            ViewData["Id"] = id;
            ViewBag.Suivis = suivis;

            return View();
        }
    }
}
