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
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id,Nom,Cognom,Carrec,Sou")] Empleat emp)
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(MySQL_Empleat.Models.EmpleatContext)) as EmpleatContext;
            
            return View(context.UpdateEmpleat(emp));

        }

       
        public IActionResult Delete(int id, string nom, string cognom, string carrec, int sou)
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(MySQL_Empleat.Models.EmpleatContext)) as EmpleatContext;
            //context.DeleteEmpleat(id);
            return View(context.DeleteEmpleat(id, nom, cognom, carrec, sou));
        }

        public ActionResult Create(int id, string nom, string cognom, string carrec, int sou)
        {
            Empleat emp = new Empleat();
            emp.Id = id;
            emp.Nom = nom;
            emp.Cognom = cognom;
            emp.Carrec = carrec;
            emp.Sou = sou;
            return View(emp);
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Nom,Cognom,Carrec,Sou")] Empleat emp)
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(MySQL_Empleat.Models.EmpleatContext)) as EmpleatContext;

            return View(context.InsertEmpleat(emp));

        }
    }
}