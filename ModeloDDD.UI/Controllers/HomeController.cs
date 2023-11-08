using ModeloDDD.Domain.Interfaces.Entities;
using ModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModeloDDD.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService<IUsuario> _usuarioService;

        public HomeController(IUsuarioService<IUsuario> usuarioService)
        {
            _usuarioService = usuarioService;

            var model = _usuarioService.GetById(1);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}