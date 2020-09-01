using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySQL_Empleat.Models;

namespace MySQL_Empleat.Controllers
{
    public class EmpleatController : Controller
    {
        public IActionResult Index()
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(MySQL_Empleat.Models.EmpleatContext)) as EmpleatContext;

            return View(context.GetAllEmpleats());
        }
    }
}