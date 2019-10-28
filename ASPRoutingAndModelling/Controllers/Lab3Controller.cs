using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPRoutingAndModelling.Controllers
{
    public class Lab3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}