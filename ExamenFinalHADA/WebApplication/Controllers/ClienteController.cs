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
    }
}