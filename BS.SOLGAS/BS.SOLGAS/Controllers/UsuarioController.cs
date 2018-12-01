using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BS.SOLGAS.Logica;

namespace BS.SOLGAS.Controllers
{
    public class UsuarioController : Controller
    {
        LNUsuario lnUsuario = new LNUsuario();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
    }
}