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
                
        public ActionResult Edit(int id, string nom, string cognom, string carrec, int sou)
        {
            Empleat emp = new Empleat();
            emp.Id = id;
            emp.Nom = nom;
            emp.Cognom = cognom;
            emp.Carrec = carrec;
            emp.Sou = sou;

            return Edit(emp);
        }

        [HttpPost]
        public ActionResult Edit(Empleat emp)
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(MySQL_Empleat.Models.EmpleatContext)) as EmpleatContext;

            return View(context.UpdateEmpleat(emp));

        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(MySQL_Empleat.Models.EmpleatContext)) as EmpleatContext;

            return View(context.DeleteEmpleat(id));
        }
    }
}