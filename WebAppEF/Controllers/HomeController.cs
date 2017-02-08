using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.BlImp;
using Entity;

namespace WebAppEF.Controllers
{
    public class HomeController : Controller
    {
        private RolImpl rolImpl = new RolImpl();
        private UsuarioImp usuarioImp = new UsuarioImp();
        public ActionResult Index()
        {
            return View((List<Usuario>)usuarioImp.GetAll());
        }

        public ActionResult Editar(int idUsuario = 0)
        {
            ViewBag.Roles = rolImpl.GetAll();
            return View(idUsuario == 0 ? new Usuario() : usuarioImp.Find(x => x.id == idUsuario));
        }


        [HttpPost]
        public JsonResult EditarJson(Usuario usuario)
        {
            string message = "Success";
            return Json(message, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult GetUsuariosJson(Usuario usuario)
        {
            var message= rolImpl.GetAll();
            return Json(message, JsonRequestBehavior.AllowGet);
        }
    }
}