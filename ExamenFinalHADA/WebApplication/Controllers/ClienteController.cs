using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.BEAN;
using WebApplication.Models.Conection;

namespace WebApplication.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            try
            {
                List<tbCliente> listaCliente;
                using (var db = new BD_ExamenFinalEntities())
                {
                    listaCliente = db.tbCliente.ToList();
                    return View(listaCliente);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(tbCliente clie)
        {
            

            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                using (var db = new BD_ExamenFinalEntities())
                {
                    clie.Estado = "A";
                    db.tbCliente.Add(clie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                //throw;
                return View();
            }

        }
    }
}