using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projektarbete_azure.Controllers
{
    public class SalwaController : Controller
    {
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
